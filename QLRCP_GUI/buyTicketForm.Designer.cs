using System.Drawing;
using System.Windows.Forms;

namespace QLRCP_GUI
{
    partial class buyTicketForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_backListStaff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close_log = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delmovie = new System.Windows.Forms.Button();
            this.btn_selectMovie = new System.Windows.Forms.Button();
            this.buyTicket_moviePrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buyTicket_movieGenre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buyTicket_movieName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buyTicket_movieID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_backListStaff);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_close_log);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 29);
            this.panel2.TabIndex = 34;
            // 
            // btn_backListStaff
            // 
            this.btn_backListStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_backListStaff.FlatAppearance.BorderSize = 0;
            this.btn_backListStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backListStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backListStaff.ForeColor = System.Drawing.Color.White;
            this.btn_backListStaff.Location = new System.Drawing.Point(3, 3);
            this.btn_backListStaff.Name = "btn_backListStaff";
            this.btn_backListStaff.Size = new System.Drawing.Size(66, 23);
            this.btn_backListStaff.TabIndex = 44;
            this.btn_backListStaff.Text = "<--";
            this.btn_backListStaff.UseVisualStyleBackColor = false;
            this.btn_backListStaff.Click += new System.EventHandler(this.btn_backListStaff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(272, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = " mua ve xem phim";
            // 
            // btn_close_log
            // 
            this.btn_close_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_close_log.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close_log.FlatAppearance.BorderSize = 0;
            this.btn_close_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close_log.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close_log.ForeColor = System.Drawing.Color.White;
            this.btn_close_log.Location = new System.Drawing.Point(661, 0);
            this.btn_close_log.Name = "btn_close_log";
            this.btn_close_log.Size = new System.Drawing.Size(25, 29);
            this.btn_close_log.TabIndex = 30;
            this.btn_close_log.Text = "X";
            this.btn_close_log.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(8, 51);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(668, 150);
            this.dataGridView3.TabIndex = 35;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "List movie";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_delmovie);
            this.panel1.Controls.Add(this.btn_selectMovie);
            this.panel1.Controls.Add(this.buyTicket_moviePrice);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buyTicket_movieGenre);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buyTicket_movieName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buyTicket_movieID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(8, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 173);
            this.panel1.TabIndex = 37;
            // 
            // btn_delmovie
            // 
            this.btn_delmovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_delmovie.FlatAppearance.BorderSize = 0;
            this.btn_delmovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delmovie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delmovie.ForeColor = System.Drawing.Color.White;
            this.btn_delmovie.Location = new System.Drawing.Point(568, 133);
            this.btn_delmovie.Name = "btn_delmovie";
            this.btn_delmovie.Size = new System.Drawing.Size(86, 30);
            this.btn_delmovie.TabIndex = 44;
            this.btn_delmovie.Text = "Bo Chon";
            this.btn_delmovie.UseVisualStyleBackColor = false;
            // 
            // btn_selectMovie
            // 
            this.btn_selectMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_selectMovie.FlatAppearance.BorderSize = 0;
            this.btn_selectMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectMovie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectMovie.ForeColor = System.Drawing.Color.White;
            this.btn_selectMovie.Location = new System.Drawing.Point(477, 133);
            this.btn_selectMovie.Name = "btn_selectMovie";
            this.btn_selectMovie.Size = new System.Drawing.Size(86, 30);
            this.btn_selectMovie.TabIndex = 43;
            this.btn_selectMovie.Text = "Chon ";
            this.btn_selectMovie.UseVisualStyleBackColor = false;
            this.btn_selectMovie.Click += new System.EventHandler(this.btn_selectMovie_Click);
            // 
            // buyTicket_moviePrice
            // 
            this.buyTicket_moviePrice.AutoSize = true;
            this.buyTicket_moviePrice.BackColor = System.Drawing.Color.White;
            this.buyTicket_moviePrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_moviePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_moviePrice.Location = new System.Drawing.Point(244, 149);
            this.buyTicket_moviePrice.Name = "buyTicket_moviePrice";
            this.buyTicket_moviePrice.Size = new System.Drawing.Size(40, 17);
            this.buyTicket_moviePrice.TabIndex = 42;
            this.buyTicket_moviePrice.Text = "____";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label9.Location = new System.Drawing.Point(209, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Gia:";
            // 
            // buyTicket_movieGenre
            // 
            this.buyTicket_movieGenre.AutoSize = true;
            this.buyTicket_movieGenre.BackColor = System.Drawing.Color.White;
            this.buyTicket_movieGenre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_movieGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_movieGenre.Location = new System.Drawing.Point(290, 114);
            this.buyTicket_movieGenre.Name = "buyTicket_movieGenre";
            this.buyTicket_movieGenre.Size = new System.Drawing.Size(40, 17);
            this.buyTicket_movieGenre.TabIndex = 40;
            this.buyTicket_movieGenre.Text = "____";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label7.Location = new System.Drawing.Point(209, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "The Loai:";
            // 
            // buyTicket_movieName
            // 
            this.buyTicket_movieName.AutoSize = true;
            this.buyTicket_movieName.BackColor = System.Drawing.Color.White;
            this.buyTicket_movieName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_movieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_movieName.Location = new System.Drawing.Point(316, 77);
            this.buyTicket_movieName.Name = "buyTicket_movieName";
            this.buyTicket_movieName.Size = new System.Drawing.Size(40, 17);
            this.buyTicket_movieName.TabIndex = 36;
            this.buyTicket_movieName.Text = "____";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label5.Location = new System.Drawing.Point(209, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Movie Name:";
            // 
            // buyTicket_movieID
            // 
            this.buyTicket_movieID.AutoSize = true;
            this.buyTicket_movieID.BackColor = System.Drawing.Color.White;
            this.buyTicket_movieID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicket_movieID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.buyTicket_movieID.Location = new System.Drawing.Point(290, 35);
            this.buyTicket_movieID.Name = "buyTicket_movieID";
            this.buyTicket_movieID.Size = new System.Drawing.Size(40, 17);
            this.buyTicket_movieID.TabIndex = 34;
            this.buyTicket_movieID.Text = "____";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(209, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Movie ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(20, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 153);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel2);
            this.Name = "buyTicketForm";
            this.Text = "buyTicketForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button btn_close_log;
        private Button btn_backListStaff;
        private DataGridView dataGridView3;
        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label buyTicket_movieID;
        private Label label3;
        private Label buyTicket_movieName;
        private Label label5;
        private Label buyTicket_movieGenre;
        private Label label7;
        private Label buyTicket_moviePrice;
        private Label label9;
        private Button btn_delmovie;
        private Button btn_selectMovie;
    }
}