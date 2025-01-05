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
using System.Xml;
using QLRCP_BUS.Services;

namespace QLRCP_GUI
{
    public partial class addStaff : Form
    {
        private readonly UserService userServices;
        public addStaff (UserService userService)
        {
            InitializeComponent();
            userServices = userService;
            LoadUsers();
        }
        private void LoadUsers()
        {
            var users = userServices.GetAllUsers();
            DataGridView dgvUsers = new DataGridView
            {
                DataSource = users,
                Dock = DockStyle.Fill
            };
            this.Controls.Add(dgvUsers);
        }
        private void DisplayAddStaff()
        {
            var tickets = userServices.GetStaffUsers();
            //dataGridView1.DataSource = tickets.ToList();
        }
    }
}
