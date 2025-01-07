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
    public partial class registerFrm : Form
    {
        private readonly UserService userService;
        public registerFrm()
        {
            InitializeComponent();
            userService = new UserService(new UserRepository(new MovieContextDB()));
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            string username = reg_username.Text.Trim();
            string password = reg_passwd.Text.Trim();
            string confirmPassword = reg_cpasswd.Text.Trim();
            string hashedPassword = PasswordHelper.HashPassword(password);
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Vui long dien vao o trong", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length <= 5)
            {
                MessageBox.Show("Mật khẩu phải dài hơn 5 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newUser = new user
            {
                username = username,
                password = hashedPassword,
                role = "Admin", // Default role is "user"
                status = "Active",
                date_reg = DateTime.Now
            };

            if (userService.AddUser(newUser))
            {
                MessageBox.Show("Dang Ky Thanh Cong.", "Thanh Cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Tên người dùng đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reg_showpass_CheckedChanged(object sender, EventArgs e)
        {
               reg_passwd.PasswordChar = reg_showpass.Checked ? '\0' : '*';
            reg_cpasswd.PasswordChar = reg_showpass.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
