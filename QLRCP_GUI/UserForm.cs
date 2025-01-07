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
    public partial class UserForm : Form
    {
        private readonly UserService userService;
        private readonly MovieService movieService;
        private readonly TicketService ticketService;
        public UserForm()
        {
            InitializeComponent();
            userService = new UserService(new UserRepository(new MovieContextDB()));
            movieService = new MovieService(new MovieRepository(new MovieContextDB()));
            ticketService = new TicketService(new TicketRepository(new MovieContextDB()), new MovieRepository(new MovieContextDB()));


        }
        private void btn_buyticket_Click(object sender, EventArgs e)
        {
       
            buyTicketForm btkfrm = new buyTicketForm(ticketService, movieService);
            btkfrm.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            userBuyTicketsFrm ubtsform = new userBuyTicketsFrm();
            ubtsform.Show();
            this.Hide();
        }
    }
}
