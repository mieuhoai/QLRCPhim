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
using System.IO;
using QLRCP_DAL.Models;
using QLRCP_DAL.Repos;

namespace QLRCP_GUI
{
    public partial class addMovieForm : Form
    {
        private readonly MovieService movieServices;
        private string currentImagePath;
        public addMovieForm(MovieService movieService)
        {
            InitializeComponent();
            movieServices = movieService;
            LoadMovies();
           
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
        private void ClearFields()
        {
            addmovie_id.Text = "";
            addmovie_name.Text = "";
            addmovie_genre.Text = "";
            addmovie_price.Text = "";
            addmovie_capacity.Text = "";
            addmovie_status.SelectedIndex = 0;
            pictureBox1.Image = null;
            currentImagePath = null;
        }
        private void btn_addmovie_Click(object sender, EventArgs e)
        {
            string movieId = .Text.Trim();
            string movieName = txtMovieName.Text.Trim();
            string genre = txtGenre.Text.Trim();
            decimal price;
            int capacity;
            string status = cboStatus.SelectedItem != null ? cboStatus.SelectedItem.ToString() : "Không xác định";
            string imagePath = txtImagePath.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(movieId) || string.IsNullOrWhiteSpace(movieName) ||
                string.IsNullOrWhiteSpace(genre) || string.IsNullOrWhiteSpace(status) ||
                !decimal.TryParse(txtPrice.Text.Trim(), out price) ||
                !int.TryParse(txtCapacity.Text.Trim(), out capacity))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác các thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newMovie = new movies
            {
                movie_id = movieId,
                movie_name = movieName,
                genre = genre,
                price = price,
                capacity = capacity,
                status = status,
                movie_image = imagePath,
                created_at = DateTime.Now
            };

            // Gọi hàm thêm phim
            try
            {
                movieService.AddMovie(newMovie, imagePath);
                MessageBox.Show("Thêm phim thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm phim: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_hidepanel2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            LoadMovies();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminForm adForm = new AdminForm();
            adForm.Show();
            this.Hide();
        }

        private void btn_upmovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(addmovie_id.Text))
                {
                    MessageBox.Show("Vui lòng chọn phim cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var movieDto = new movies
                {
                    movie_id = addmovie_id.Text.Trim(),
                    movie_name = addmovie_name.Text.Trim(),
                    genre = addmovie_genre.Text.Trim(),
                    price = Convert.ToDecimal(addmovie_price.Text.Trim()),
                    capacity = Convert.ToInt32(addmovie_capacity.Text.Trim()),
                    status = addmovie_status.Text.Trim(),
                    update_date = DateTime.Now
                };

                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation) && pictureBox1.ImageLocation != currentImagePath)
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ds_movie", addmovie_id.Text.Trim() + ".jpg");
                    File.Copy(pictureBox1.ImageLocation, path, true);
                    movieDto.movie_image = path;
                }

              //  movieServices.UpdateMovie(movieDto);
                LoadMovies();
                ClearFields();
                MessageBox.Show("Cập nhật phim thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật phim: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deletemovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(addmovie_id.Text))
                {
                    MessageBox.Show("Vui lòng chọn phim cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa phim này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                 //   var movie = movieServices.GetMovieById(addmovie_id.Text.Trim());
                //    if (movie != null)
               //     {
                  //      movieServices.DeleteMovie(movie.id);
                        LoadMovies();
                        ClearFields();
                        MessageBox.Show("Xóa phim thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
             //   }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa phim: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    openFileDialog.Title = "Chọn hình ảnh phim";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        currentImagePath = openFileDialog.FileName;
                        pictureBox1.Image = Image.FromFile(currentImagePath);
                        pictureBox1.ImageLocation = currentImagePath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nhập hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_hidepanel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            ClearFields();
        }
    }
}
