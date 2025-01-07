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
    public partial class dashBroadFrm : Form
    {
        private readonly TicketService ticketServices;
        private readonly MovieService movieServices;
        public dashBroadFrm()
        {
            InitializeComponent();
            movieServices = new MovieService(new MovieRepository(new MovieContextDB())); // Initialize movieServices
            ticketServices = new TicketService(new TicketRepository(new MovieContextDB()), new MovieRepository(new MovieContextDB()));
            LoadMovies();
            ShowTotalRevenue();
        }
        private void LoadMovies()
        {
            try
            {
                var movies = movieServices.GetAllMovies();
                dataGridView1.DataSource = movies;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách phim: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void ShowTotalRevenue()
        {
            try
            {
                decimal totalRevenue = ticketServices.GetTotalRevenue_1();
                label7.Text = $": {totalRevenue:C}";
               // MessageBox.Show($"Tổng doanh thu: {totalRevenue:C}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tính tổng doanh thu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dashBroadFrm_Load(object sender, EventArgs e)
        {

        }

        private void btn_backListStaff_Click(object sender, EventArgs e)
        {
            AdminForm adForm = new AdminForm();
            adForm.Show();
            this.Hide();
        }
    }
}
