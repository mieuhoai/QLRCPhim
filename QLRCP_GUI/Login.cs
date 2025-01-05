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
    public partial class Login : Form
    {
        private readonly UserService userService;

        public Login()
        {
            InitializeComponent();
            userService = new UserService(new UserRepository(new MovieContextDB()));
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            string username = log_username.Text.Trim();
            string password = log_passwd.Text.Trim();

            if (userService.ValidateLogin(username, password))
            {
                var user = userService.GetAllUsers().Find(u => u.username == username);

                if (user != null)
                {
                    if (user.role == "Admin")
                    {
                        AdminForm adForm = new AdminForm();
                        adForm.Show();
                    }
                    else
                    {
                        UserForm usrForm = new UserForm();
                        usrForm.Show();
                    }

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reglink1_Click(object sender, EventArgs e)
        {
            registerFrm registerForm = new registerFrm();
            registerForm.Show();
            this.Hide();
        }

        private void log_showpass_CheckedChanged(object sender, EventArgs e)
        {
            log_passwd.PasswordChar = log_showpass.Checked ? '\0' : '*';
        }
    }
}
