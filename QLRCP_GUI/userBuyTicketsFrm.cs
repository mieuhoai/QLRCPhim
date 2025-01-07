using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLRCP_BUS.Services;
using QLRCP_DAL.Models;
using QLRCP_DAL.Repos;

namespace QLRCP_GUI
{
    public partial class userBuyTicketsFrm : Form
    {
        private readonly UserService userServices;
        private readonly TicketService ticketServices;
        public userBuyTicketsFrm()
        {
            InitializeComponent();
            var context = new MovieContextDB(); // Create an instance of MovieContextDB
            var ticketRepository = new TicketRepository(context); // Pass the context to the repository
            var movieRepository = new MovieRepository(context);
            ticketServices = new TicketService(ticketRepository, movieRepository); // Ensure ticketServices is initialized
            LoadUserFilm();
        }

        private void LoadUserFilm()
        {
            try
            {
                // Lấy userId từ UserSession
                var userId = UserSession.CurrentUserId;

                // Lấy danh sách vé đã mua của người dùng từ ticketServices
                var userFilm = ticketServices.GetUserMovieTickets(userId);

                // Hiển thị dữ liệu lên DataGridView
                dataGridView1.DataSource = userFilm;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show($"Lỗi khi tải danh sách vé: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_backListStaff_Click(object sender, EventArgs e)
        {
            UserForm usrForm = new UserForm();
            usrForm.Show();
            this.Hide();
        }
    }
}
