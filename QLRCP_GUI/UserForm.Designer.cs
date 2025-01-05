using System.Drawing;
using System.Windows.Forms;

namespace QLRCP_GUI
{
    partial class UserForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close_log = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_buyticket = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_close_log);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 29);
            this.panel2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(295, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = " ve xem phim";
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
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(10, 345);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(157, 35);
            this.btn_logout.TabIndex = 34;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // btn_buyticket
            // 
            this.btn_buyticket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_buyticket.FlatAppearance.BorderSize = 0;
            this.btn_buyticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buyticket.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_buyticket.ForeColor = System.Drawing.Color.White;
            this.btn_buyticket.Location = new System.Drawing.Point(261, 81);
            this.btn_buyticket.Name = "btn_buyticket";
            this.btn_buyticket.Size = new System.Drawing.Size(157, 35);
            this.btn_buyticket.TabIndex = 35;
            this.btn_buyticket.Text = "Mua ve";
            this.btn_buyticket.UseVisualStyleBackColor = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btn_buyticket);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.panel2);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button btn_close_log;
        private Button btn_logout;
        private Button btn_buyticket;
    }
}