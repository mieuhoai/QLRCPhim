using System.Drawing;
using System.Windows.Forms;

namespace QLRCP_GUI
{
    partial class AdminForm
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
            this.btn_mangestaff = new System.Windows.Forms.Button();
            this.btn_dashbroad = new System.Windows.Forms.Button();
            this.btn_managemovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mangestaff
            // 
            this.btn_mangestaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_mangestaff.FlatAppearance.BorderSize = 0;
            this.btn_mangestaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mangestaff.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_mangestaff.ForeColor = System.Drawing.Color.White;
            this.btn_mangestaff.Location = new System.Drawing.Point(267, 176);
            this.btn_mangestaff.Name = "btn_mangestaff";
            this.btn_mangestaff.Size = new System.Drawing.Size(157, 35);
            this.btn_mangestaff.TabIndex = 2;
            this.btn_mangestaff.Text = "Them Nhan Vien";
            this.btn_mangestaff.UseVisualStyleBackColor = false;
            this.btn_mangestaff.Click += new System.EventHandler(this.btn_mangestaff_Click);
            // 
            // btn_dashbroad
            // 
            this.btn_dashbroad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_dashbroad.FlatAppearance.BorderSize = 0;
            this.btn_dashbroad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashbroad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_dashbroad.ForeColor = System.Drawing.Color.White;
            this.btn_dashbroad.Location = new System.Drawing.Point(267, 115);
            this.btn_dashbroad.Name = "btn_dashbroad";
            this.btn_dashbroad.Size = new System.Drawing.Size(157, 35);
            this.btn_dashbroad.TabIndex = 1;
            this.btn_dashbroad.Text = "Bang Dieu Khien";
            this.btn_dashbroad.UseVisualStyleBackColor = false;
            this.btn_dashbroad.Click += new System.EventHandler(this.btn_dashbroad_Click);
            // 
            // btn_managemovie
            // 
            this.btn_managemovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_managemovie.FlatAppearance.BorderSize = 0;
            this.btn_managemovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_managemovie.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_managemovie.ForeColor = System.Drawing.Color.White;
            this.btn_managemovie.Location = new System.Drawing.Point(267, 55);
            this.btn_managemovie.Name = "btn_managemovie";
            this.btn_managemovie.Size = new System.Drawing.Size(157, 35);
            this.btn_managemovie.TabIndex = 3;
            this.btn_managemovie.Text = "Quản lý phim";
            this.btn_managemovie.UseVisualStyleBackColor = false;
            this.btn_managemovie.Click += new System.EventHandler(this.btn_managemovie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(243, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "he thong quan ly ve xem phim";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 32);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_logout);
            this.panel3.Controls.Add(this.btn_managemovie);
            this.panel3.Controls.Add(this.btn_dashbroad);
            this.panel3.Controls.Add(this.btn_mangestaff);
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 363);
            this.panel3.TabIndex = 33;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(0, 325);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(163, 35);
            this.btn_logout.TabIndex = 35;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 390);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_dashbroad;
        private Button button3;
        private Button btn_managemovie;
        private Button btn_mangestaff;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_logout;
    }
}