using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLRCP_BUS.Services;
using QLRCP_DAL.Models;
using QLRCP_DAL.Repos;
namespace QLRCP_GUI
{
    public partial class buyTicketForm_2 : Form
    {

        private readonly MovieService movieServices;
        private readonly TicketService ticketServices;
        private readonly List<int> selectedSeats = new List<int>();
        private decimal totalPrice = 0;     // Tổng tiền
        private readonly string movieId;   // ID phim (truyền từ form trước)
        buy_tickets ticket = new buy_tickets();
        public buyTicketForm_2(string movieId, TicketService ticketService,MovieService movieService)
        {
            InitializeComponent();
            this.ticketServices = ticketService;
            this.movieServices = movieService;
            this.movieId = movieId;
            LoadComboBoxData();
            cb_food.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            cb_drink.SelectedIndexChanged += (s, e) => UpdateTotalPrice();
            
        }
        private void LoadComboBoxData()
        {
            // Load dữ liệu đồ ăn và nước uống
            cb_food.Items.Clear();
            cb_food.Items.AddRange(new object[] { "Bắp rang", "Hotdog", "Pizza" });

            cb_drink.Items.Clear();
            cb_drink.Items.AddRange(new object[] { "Coca-Cola", "Pepsi", "7Up" });
        }
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null) // Kiểm tra nút không null
            {
                string seatText = btn.Text;
                string seatNumberStr = new string(seatText.Where(char.IsDigit).ToArray());

                if (int.TryParse(seatNumberStr, out int seatNumber))
                {
                    if (selectedSeats.Contains(seatNumber))
                    {
                        // Nếu ghế đã chọn, gỡ bỏ khỏi danh sách và cập nhật giao diện
                        selectedSeats.Remove(seatNumber);
                        btn.BackColor = DefaultBackColor; // Trả lại màu mặc định
                    }
                    else
                    {
                        // Nếu ghế chưa chọn, thêm vào danh sách và cập nhật giao diện
                        selectedSeats.Add(seatNumber);
                        btn.BackColor = Color.LightBlue; // Đổi màu để đánh dấu đã chọn
                    }

                    // Cập nhật tổng tiền sau khi chọn ghế
                    UpdateTotalPrice();
                }
                else
                {
                    MessageBox.Show("Số ghế không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateTotalPrice()
        {
            decimal foodPrice = 0, drinkPrice = 0, seatPrice = 0, moviePrice = 0;

            var movie = movieServices.GetMovieById(movieId);
            if (movie != null)
            {
                moviePrice = movie.price;
            }
            else
            {
                MessageBox.Show("Không tìm thấy bộ phim với mã này.");
                return;
            }

            // Giá đồ ăn
            switch (cb_food.SelectedItem)
            {
                case "Bắp rang": foodPrice = 30000; break;
                case "Hotdog": foodPrice = 50000; break;
                case "Pizza": foodPrice = 100000; break;
            }

            // Giá nước uống
            switch (cb_drink.SelectedItem)
            {
                case "Coca-Cola": drinkPrice = 20000; break;
                case "Pepsi": drinkPrice = 25000; break;
                case "7Up": drinkPrice = 15000; break;
            }

            // Giá ghế dựa trên số ghế đã chọn
            foreach (var seatNumber in selectedSeats)
            {
                if (seatNumber >= 1 && seatNumber <= 16)
                    seatPrice += 50000;
                else if (seatNumber >= 17 && seatNumber <= 32)
                    seatPrice += 70000;
                else if (seatNumber >= 33 && seatNumber <= 50)
                    seatPrice += 90000;
            }

            // Tổng tiền = giá phim + giá ghế + giá đồ ăn + giá nước uống
            totalPrice = moviePrice + seatPrice + foodPrice + drinkPrice;
            ticket.totalPrice = (int)totalPrice; // Cập nhật tổng tiền vé
            txtThanhTien.Text = $"{totalPrice:C}";
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(movieId) || selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phim và ít nhất một ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = UserSession.CurrentUserId; // Lấy ID người dùng (giả định)

            try
            {
                foreach (var seatNumber in selectedSeats)
                {
                    var ticket = new buy_tickets
                    {
                        movie_id = movieId,
                        seat_number = seatNumber,
                        totalPrice = (int)(totalPrice / selectedSeats.Count), // Chia đều tổng tiền cho mỗi ghế
                        purchase_date = DateTime.Now
                    };

                    ticketServices.AddBuyTicket_1(ticket, userId); // Thêm từng vé vào cơ sở dữ liệu
                }

                MessageBox.Show("Mua vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSelections();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mua vé: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearSelections();
        }
        private void ClearSelections()
        {
            selectedSeats.Clear();
            foreach (Control control in button_Group.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = DefaultBackColor; // Trả lại màu mặc định
                }
            }
            cb_food.SelectedIndex = -1;
            cb_drink.SelectedIndex = -1;
            txtThanhTien.Text = "0";
        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            string receipt = $"Phim: {movieId}\n" +
                     $"Ghế: {string.Join(", ", selectedSeats.Select(seat => $"G{seat}"))}\n" +
                     $"Tổng tiền: {totalPrice:C}\n" +
                     $"Ngày mua: {DateTime.Now:dd/MM/yyyy}";
            MessageBox.Show(receipt, "Biên Lai", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buyTicketForm_2_Load(object sender, EventArgs e)
        {
            foreach (Control control in button_Group.Controls)
            {
                if (control is Button button) // Kiểm tra nếu Control là Button
                {
                    button.Click += SeatButton_Click; // Gắn sự kiện Click
                }
            }
        }

        private void btn_backListStaff_Click(object sender, EventArgs e)
        {
            UserForm usrForm = new UserForm();
            usrForm.Show();
            this.Hide();
        }
    }
}
