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
        private int selectedSeatNumber = 0; // Ghế được chọn
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
                // Lấy số ghế từ Text của nút (giả sử ghế là dạng "G10", "G11", ...)
                string seatText = btn.Text;
                string seatNumberStr = new string(seatText.Where(char.IsDigit).ToArray());

                if (int.TryParse(seatNumberStr, out int seatNumber))
                {
                    selectedSeatNumber = seatNumber;

                    // Hiển thị thông báo cho người dùng
                    MessageBox.Show($"Bạn đã chọn ghế: {btn.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (selectedSeatNumber >= 1 && selectedSeatNumber <= 16)
                seatPrice = 50000;
            else if (selectedSeatNumber >= 17 && selectedSeatNumber <= 32)
                seatPrice = 70000;
            else if (selectedSeatNumber >= 33 && selectedSeatNumber <= 50)
                seatPrice = 90000;

            // Tổng tiền = giá ghế + giá đồ ăn + giá nước uống
            totalPrice = moviePrice + seatPrice + foodPrice + drinkPrice;
            ticket.totalPrice = (int)totalPrice; // Update the correct property
            txtThanhTien.Text = $"{totalPrice:C}";
            
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(movieId) || selectedSeatNumber == 0)
            {
                MessageBox.Show("Vui lòng chọn phim và ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ticket = new buy_tickets
            {
                movie_id = movieId,
                seat_number = selectedSeatNumber,
                totalPrice = (int)totalPrice,
                purchase_date = DateTime.Now

            };

            // Giả sử bạn có một phương thức để lấy user_id (ví dụ từ session hoặc đối tượng đăng nhập)
            int userId = UserSession.CurrentUserId;  // Hoặc từ đối tượng đăng nhập khác

            try
            {
                ticketServices.AddBuyTicket_1(ticket, userId); // Gọi hàm thêm vé với user_id
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
            selectedSeatNumber = 0;
            cb_food.SelectedIndex = -1;
            cb_drink.SelectedIndex = -1;
            txtThanhTien.Text = "0";
        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            string receipt = $"Phim: {movieId}\n" +
                     $"Ghế: G{selectedSeatNumber}\n" +
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
