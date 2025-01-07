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
  
    public partial class buyTicketForm : Form
    {
        private readonly TicketService ticketServices;
        private readonly MovieService movieServices;
        
        public buyTicketForm(TicketService ticketService, MovieService movieService)
        {
            InitializeComponent();
            this.ticketServices = ticketService;
            this.movieServices = movieService;

            LoadMovies();
        }
        private void LoadMovies()
        {
            var movies = movieServices.GetAllMovies(); // Lấy danh sách phim
            dataGridView3.DataSource = movies;
            dataGridView3   .Columns["movie_id"].HeaderText = "Mã Phim";
        }
        private void btn_selectMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(buyTicket_movieID.Text))
            {
                MessageBox.Show("Vui lòng chọn phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin chi tiết về phim từ dịch vụ
            var selectedMovie = movieServices.GetMovieById(buyTicket_movieID.Text);
            if (selectedMovie == null)
            {
                MessageBox.Show("Không tìm thấy thông tin phim!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedMovie.status != "Co san")
            {
                MessageBox.Show("Phim đã hết vé!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (buyTicket_movieID.Text == selectedMovie.movie_id)
            {
                buyTicketForm_2 btk2frm = new buyTicketForm_2(selectedMovie.movie_id, ticketServices,movieServices);
                btk2frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Phim đã hết vé!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Mở form buyticketfrm_2 và truyền thông tin phim
        }


        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

                buyTicket_movieID.Text = row.Cells[1].Value.ToString();
                buyTicket_movieName.Text = row.Cells[2].Value.ToString();
                buyTicket_movieGenre.Text = row.Cells[3].Value.ToString();
                buyTicket_moviePrice.Text = row.Cells[4].Value.ToString();
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
