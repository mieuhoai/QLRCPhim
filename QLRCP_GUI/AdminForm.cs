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
    public partial class AdminForm : Form
    {
        private readonly UserService userService;
        private readonly MovieService movieService;
        private readonly TicketService ticketService;
        public AdminForm()
        {
            InitializeComponent();
            userService = new UserService(new UserRepository(new MovieContextDB()));
            movieService = new MovieService(new MovieRepository(new MovieContextDB()));
            ticketService = new TicketService(new TicketRepository(new MovieContextDB()), new MovieRepository(new MovieContextDB()));


        }

        private void btn_managemovie_Click(object sender, EventArgs e)
        {
            addMovieForm admform = new addMovieForm(movieService);
            admform.Show();
            this.Hide();
        }

        private void btn_dashbroad_Click(object sender, EventArgs e)
        {
            dashBroadFrm dbform = new dashBroadFrm();
            dbform.Show();
            this.Hide();
        }

        private void btn_mangestaff_Click(object sender, EventArgs e)
        {
            addStaff staffrm = new addStaff(userService);
            staffrm.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("ban co chac chan muon dang xuat khong", "xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Login loginform = new Login();
                loginform.Show();
                this.Hide();
            }
        }
    }
}