using System.Drawing;
using System.Windows.Forms;

namespace QLRCP_GUI
{
    partial class addMovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_hidepanel1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_hidepanel2 = new System.Windows.Forms.Button();
            this.addmovie_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_deletemovie = new System.Windows.Forms.Button();
            this.btn_upmovie = new System.Windows.Forms.Button();
            this.btn_addmovie = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.addmovie_genre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addmovie_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addmovie_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addmovie_id = new System.Windows.Forms.TextBox();
            this.addmovie_capacity = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_hidepanel1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 422);
            this.panel1.TabIndex = 4;
            // 
            // btn_hidepanel1
            // 
            this.btn_hidepanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_hidepanel1.FlatAppearance.BorderSize = 0;
            this.btn_hidepanel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hidepanel1.ForeColor = System.Drawing.Color.White;
            this.btn_hidepanel1.Location = new System.Drawing.Point(129, 23);
            this.btn_hidepanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hidepanel1.Name = "btn_hidepanel1";
            this.btn_hidepanel1.Size = new System.Drawing.Size(83, 23);
            this.btn_hidepanel1.TabIndex = 47;
            this.btn_hidepanel1.Text = "Thêm phim";
            this.btn_hidepanel1.UseVisualStyleBackColor = false;
            this.btn_hidepanel1.Click += new System.EventHandler(this.btn_hidepanel1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(756, 371);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "List movie";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(66, 23);
            this.btn_back.TabIndex = 42;
            this.btn_back.Text = "<--";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btn_hidepanel2);
            this.panel2.Controls.Add(this.addmovie_status);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_deletemovie);
            this.panel2.Controls.Add(this.btn_upmovie);
            this.panel2.Controls.Add(this.btn_addmovie);
            this.panel2.Controls.Add(this.btn_import);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addmovie_genre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addmovie_price);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addmovie_name);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.addmovie_id);
            this.panel2.Controls.Add(this.addmovie_capacity);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 422);
            this.panel2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label7.Location = new System.Drawing.Point(55, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "So Luong";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(346, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(346, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_hidepanel2
            // 
            this.btn_hidepanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_hidepanel2.FlatAppearance.BorderSize = 0;
            this.btn_hidepanel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hidepanel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btn_hidepanel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_hidepanel2.Location = new System.Drawing.Point(13, 28);
            this.btn_hidepanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hidepanel2.Name = "btn_hidepanel2";
            this.btn_hidepanel2.Size = new System.Drawing.Size(122, 24);
            this.btn_hidepanel2.TabIndex = 47;
            this.btn_hidepanel2.Text = "Danh sách phim";
            this.btn_hidepanel2.UseVisualStyleBackColor = false;
            this.btn_hidepanel2.Click += new System.EventHandler(this.btn_hidepanel2_Click);
            // 
            // addmovie_status
            // 
            this.addmovie_status.FormattingEnabled = true;
            this.addmovie_status.Items.AddRange(new object[] {
            "Chon",
            "Co san",
            "Khong co san ",
            "da xoa"});
            this.addmovie_status.Location = new System.Drawing.Point(153, 203);
            this.addmovie_status.Name = "addmovie_status";
            this.addmovie_status.Size = new System.Drawing.Size(101, 21);
            this.addmovie_status.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label6.Location = new System.Drawing.Point(55, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Trang Thai";
            // 
            // btn_deletemovie
            // 
            this.btn_deletemovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_deletemovie.FlatAppearance.BorderSize = 0;
            this.btn_deletemovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletemovie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletemovie.ForeColor = System.Drawing.Color.White;
            this.btn_deletemovie.Location = new System.Drawing.Point(192, 72);
            this.btn_deletemovie.Name = "btn_deletemovie";
            this.btn_deletemovie.Size = new System.Drawing.Size(66, 23);
            this.btn_deletemovie.TabIndex = 43;
            this.btn_deletemovie.Text = "delete";
            this.btn_deletemovie.UseVisualStyleBackColor = false;
            this.btn_deletemovie.Click += new System.EventHandler(this.btn_deletemovie_Click);
            // 
            // btn_upmovie
            // 
            this.btn_upmovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_upmovie.FlatAppearance.BorderSize = 0;
            this.btn_upmovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upmovie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upmovie.ForeColor = System.Drawing.Color.White;
            this.btn_upmovie.Location = new System.Drawing.Point(100, 72);
            this.btn_upmovie.Name = "btn_upmovie";
            this.btn_upmovie.Size = new System.Drawing.Size(66, 23);
            this.btn_upmovie.TabIndex = 42;
            this.btn_upmovie.Text = "update";
            this.btn_upmovie.UseVisualStyleBackColor = false;
            this.btn_upmovie.Click += new System.EventHandler(this.btn_upmovie_Click);
            // 
            // btn_addmovie
            // 
            this.btn_addmovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_addmovie.FlatAppearance.BorderSize = 0;
            this.btn_addmovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addmovie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addmovie.ForeColor = System.Drawing.Color.White;
            this.btn_addmovie.Location = new System.Drawing.Point(13, 72);
            this.btn_addmovie.Name = "btn_addmovie";
            this.btn_addmovie.Size = new System.Drawing.Size(66, 23);
            this.btn_addmovie.TabIndex = 41;
            this.btn_addmovie.Text = "add";
            this.btn_addmovie.UseVisualStyleBackColor = false;
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_import.FlatAppearance.BorderSize = 0;
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.ForeColor = System.Drawing.Color.White;
            this.btn_import.Location = new System.Drawing.Point(346, 275);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(66, 23);
            this.btn_import.TabIndex = 40;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(346, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 178);
            this.panel3.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label5.Location = new System.Drawing.Point(55, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "The Loai";
            // 
            // addmovie_genre
            // 
            this.addmovie_genre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmovie_genre.Location = new System.Drawing.Point(153, 293);
            this.addmovie_genre.Multiline = true;
            this.addmovie_genre.Name = "addmovie_genre";
            this.addmovie_genre.Size = new System.Drawing.Size(101, 18);
            this.addmovie_genre.TabIndex = 37;
            this.addmovie_genre.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(55, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Gia";
            // 
            // addmovie_price
            // 
            this.addmovie_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmovie_price.Location = new System.Drawing.Point(153, 246);
            this.addmovie_price.Multiline = true;
            this.addmovie_price.Name = "addmovie_price";
            this.addmovie_price.Size = new System.Drawing.Size(101, 18);
            this.addmovie_price.TabIndex = 35;
            this.addmovie_price.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(55, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Movie Name";
            // 
            // addmovie_name
            // 
            this.addmovie_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmovie_name.Location = new System.Drawing.Point(153, 163);
            this.addmovie_name.Multiline = true;
            this.addmovie_name.Name = "addmovie_name";
            this.addmovie_name.Size = new System.Drawing.Size(101, 18);
            this.addmovie_name.TabIndex = 33;
            this.addmovie_name.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(55, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Movie ID";
            // 
            // addmovie_id
            // 
            this.addmovie_id.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmovie_id.Location = new System.Drawing.Point(153, 127);
            this.addmovie_id.Multiline = true;
            this.addmovie_id.Name = "addmovie_id";
            this.addmovie_id.Size = new System.Drawing.Size(101, 18);
            this.addmovie_id.TabIndex = 31;
            this.addmovie_id.Tag = "";
            // 
            // addmovie_capacity
            // 
            this.addmovie_capacity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmovie_capacity.Location = new System.Drawing.Point(153, 331);
            this.addmovie_capacity.Multiline = true;
            this.addmovie_capacity.Name = "addmovie_capacity";
            this.addmovie_capacity.Size = new System.Drawing.Size(101, 18);
            this.addmovie_capacity.TabIndex = 49;
            this.addmovie_capacity.Tag = "";
            // 
            // addMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Controls.Add(this.panel2);
            this.Name = "addMovieForm";
            this.Text = "addMovieForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel2;
        private ComboBox addmovie_status;
        private Label label6;
        private Button btn_deletemovie;
        private Button btn_upmovie;
        private Button btn_addmovie;
        private Button btn_import;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox addmovie_genre;
        private Label label4;
        private TextBox addmovie_price;
        private Label label3;
        private TextBox addmovie_name;
        private Label label2;
        private TextBox addmovie_id;
        private Button btn_back;
        private PictureBox pictureBox2;
        private Button btn_hidepanel1;
        private Button btn_hidepanel2;
        private TextBox addmovie_capacity;
        private Label label7;
    }
}