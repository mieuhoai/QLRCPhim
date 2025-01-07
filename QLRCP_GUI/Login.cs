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
            string hashedPassword = PasswordHelper.HashPassword(password);

            if (userService.ValidateLogin(username, hashedPassword))
            {
                var user = userService.GetAllUsers().Find(u => u.username == username);

                if (user != null)
                {
                    // Kiểm tra xem người dùng có chọn "Ghi nhớ đăng nhập" không
                    if (log_rememberpass.Checked)
                    {
                        Properties.Settings.Default.Username = username;
                        Properties.Settings.Default.Password = PasswordHelper.EncryptPassword(password); // Mã hóa mật khẩu
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.Username = string.Empty;
                        Properties.Settings.Default.Password = string.Empty;
                        Properties.Settings.Default.Save();
                    }

                    // Xử lý đăng nhập thành công (AdminForm hoặc UserForm)
                    if (user.role == "Admin")
                    {
                        AdminForm adForm = new AdminForm();
                        adForm.Show();
                    }
                    else if (user.role == "Staff")
                    {
                        AdminForm adForm = new AdminForm();
                        adForm.Show();
                    }
                    else
                    {
                        UserForm usrForm = new UserForm();
                        usrForm.Show();

                        // Khi người dùng đăng nhập
                        UserSession.CurrentUserId = user.id; // userId là giá trị lấy từ quá trình đăng nhập
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
        public bool ValidateLogin(string username, string password)
        {
            var user = userService.GetAllUsers().FirstOrDefault(u => u.username == username);
            if (user == null)
                return false;

            // Kiểm tra mật khẩu đã nhập có khớp với mật khẩu đã mã hóa trong cơ sở dữ liệu
            return PasswordHelper.VerifyPassword(password, user.password);
        }

        private void log_rememberpass_CheckedChanged(object sender, EventArgs e)
        {
            if (!log_rememberpass.Checked)
            {
                Properties.Settings.Default.Username = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.Save();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Tự động điền thông tin đăng nhập
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username) &&
                !string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                log_username.Text = Properties.Settings.Default.Username;
                log_passwd.Text = PasswordHelper.DecryptPassword(Properties.Settings.Default.Password); // Giải mã mật khẩu
                log_rememberpass.Checked = true;
            }
        }
    }
}
