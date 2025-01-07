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
        

        private void btn_hidepanel2_Click(object sender, EventArgs e)
        {
            
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
                string movieId = addmovie_id.Text.Trim();
                string movieName = addmovie_name.Text.Trim();
                string genre = addmovie_genre.Text.Trim();
                decimal price = decimal.Parse(addmovie_price.Text.Trim());
                int capacity = int.Parse(addmovie_capacity.Text.Trim());
                string status = addmovie_status.SelectedItem != null ? addmovie_status.SelectedItem.ToString() : "Không xác định";
                string imagePath = currentImagePath;

                // Get the movie by ID
                var movie = movieServices.GetMovieById(movieId);
             
                if (movie != null)
                {
                    // Update the movie details
                    movie.movie_name = movieName;
                    movie.genre = genre;
                    movie.price = price;
                    movie.capacity = capacity;
                    movie.status = status;
                    movie.movie_image = imagePath; // Uncomment if using image path

                    // Call the service to update the movie
                    movieServices.UpdateMovie1(movie);

                    MessageBox.Show("Cập nhật phim thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMovies(); // Reload the movie list
                    ClearFields(); // Clear the form fields
                }
                else
                {
                    MessageBox.Show("Phim không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    var movie = movieServices.GetMovieById(addmovie_id.Text.Trim());
                    if (movie != null)
                    {
                        movieServices.DeleteMovie(movie.id);
                        LoadMovies();
                        ClearFields();
                        MessageBox.Show("Xóa phim thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
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
            
        }

        private void btn_addmovie_Click(object sender, EventArgs e)
        {
            string movieId = addmovie_id.Text.Trim();
            string movieName = addmovie_name.Text.Trim();
            string genre = addmovie_genre.Text.Trim();
            decimal price = decimal.Parse(addmovie_price.Text.Trim()); ;
            int capacity = int.Parse(addmovie_capacity.Text.Trim());
            string status = addmovie_status.SelectedItem != null ? addmovie_status.SelectedItem.ToString() : "Không xác định";
            string imagePath = currentImagePath;

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
                
                movieServices.AddMovie(newMovie, imagePath);
                MessageBox.Show("Thêm phim thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMovies();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm phim: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addmovie_id.Text = row.Cells[1].Value.ToString();
                addmovie_name.Text = row.Cells[2].Value.ToString();
                addmovie_genre.Text = row.Cells[3].Value.ToString();
                addmovie_price.Text = row.Cells[4].Value.ToString();
                addmovie_capacity.Text = row.Cells[5].Value.ToString();
                addmovie_status.Text = row.Cells[7]?.Value?.ToString() ?? string.Empty;

                string imagePath = row.Cells[6].Value.ToString();
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
                }
                else
                {
                    // Handle the case where the file does not exist
                    pictureBox1.Image = null; // or set a default image
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
