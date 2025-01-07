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
using QLRCP_DAL.Models;

namespace QLRCP_GUI
{
    public partial class addStaff : Form
    {
        private readonly UserService userServices;
        public addStaff(UserService userService)
        {
            InitializeComponent();
            userServices = userService;
            LoadStaffs();
        }
        private void LoadStaffs()
        {
            try
            {
                var staffs = userServices.GetAllUsers(); // Lấy danh sách nhân viên từ UserService
                dataGridView2.DataSource = staffs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txt_usrname_addstaff.Text = "";
            txt_passwd_addstaff.Text = "";
            cb_status_addstaff.SelectedIndex = -1;
        }
        private int id = 0;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                id=(int)row.Cells[0].Value;
                txt_usrname_addstaff.Text = row.Cells[1].Value.ToString();
                txt_passwd_addstaff.Text = row.Cells[2].Value.ToString();
                cb_status_addstaff.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btn_addstaff_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_usrname_addstaff.Text.Trim();
                string password = txt_passwd_addstaff.Text.Trim();
                string status = cb_status_addstaff.SelectedItem?.ToString() ?? string.Empty;


                // Kiểm tra xem các trường có rỗng hay không
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newStaff = new user
                {
                    username = username,
                    password = password,
                    role = "Staff",
                    status = status,
                    date_reg = DateTime.Now
                };

                // Gọi phương thức AddUser từ UserService để thêm nhân viên
                bool success = userServices.AddUser(newStaff);

                if (success)
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStaffs(); // Tải lại danh sách nhân viên
                    ClearFields(); // Xóa các trường nhập liệu
                }
                else
                {
                    MessageBox.Show("Tên người dùng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị chi tiết lỗi khi xảy ra sự cố
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}\n{ex.InnerException?.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_upstaff_Click(object sender, EventArgs e)
        {
           
                var selectedUser = id;
              

                string username = txt_usrname_addstaff.Text;
                string password = txt_passwd_addstaff.Text;
                string status = cb_status_addstaff.SelectedItem.ToString();

                var userToUpdate = new user
                {
                    id = selectedUser,
                    username = username,
                    password = password,
                    status = status
                };

                bool success = userServices.UpdateUser(userToUpdate);

                if (success)
                {
                    MessageBox.Show("Cập nhật người dùng thành công!");
                    // Update the DataGridView data if needed
                    LoadStaffs(); // Tải lại danh sách nhân viên
                    ClearFields(); // Xóa các trường nhập liệu
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người dùng để cập nhật.");
                }
            }


        private void btn_deletestaff_Click(object sender, EventArgs e)
        {

            var selectedUser = id;
           // int userId = selectedUser.id;  // Lấy ID người dùng đã chọn

            bool success = userServices.DeleteUser(selectedUser);

            if (success)
            {
                MessageBox.Show("Xóa người dùng thành công!");
                // Cập nhật lại dữ liệu trong DataGridView nếu cần
                LoadStaffs(); // Tải lại danh sách nhân viên
                ClearFields(); // Xóa các trường nhập liệu
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng để xóa.");
            }
        }
    

        private void label3_Click(object sender, EventArgs e)
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
