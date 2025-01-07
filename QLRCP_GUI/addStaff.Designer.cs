using System.Drawing;
using System.Windows.Forms;

namespace QLRCP_GUI
{
    partial class addStaff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_backListStaff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_passwd_addstaff = new System.Windows.Forms.TextBox();
            this.txt_usrname_addstaff = new System.Windows.Forms.TextBox();
            this.cb_status_addstaff = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_deletestaff = new System.Windows.Forms.Button();
            this.btn_upstaff = new System.Windows.Forms.Button();
            this.btn_addstaff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_backListStaff);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 29);
            this.panel1.TabIndex = 0;
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
            this.btn_backListStaff.TabIndex = 43;
            this.btn_backListStaff.Text = "<--";
            this.btn_backListStaff.UseVisualStyleBackColor = false;
            this.btn_backListStaff.Click += new System.EventHandler(this.btn_backListStaff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(293, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Quan Ly Nhan Vien";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(13, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(426, 340);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "List staff";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label5.Location = new System.Drawing.Point(16, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label6.Location = new System.Drawing.Point(16, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trang Thai";
            // 
            // txt_passwd_addstaff
            // 
            this.txt_passwd_addstaff.Location = new System.Drawing.Point(29, 95);
            this.txt_passwd_addstaff.Name = "txt_passwd_addstaff";
            this.txt_passwd_addstaff.Size = new System.Drawing.Size(222, 22);
            this.txt_passwd_addstaff.TabIndex = 10;
            // 
            // txt_usrname_addstaff
            // 
            this.txt_usrname_addstaff.Location = new System.Drawing.Point(29, 44);
            this.txt_usrname_addstaff.Name = "txt_usrname_addstaff";
            this.txt_usrname_addstaff.Size = new System.Drawing.Size(222, 22);
            this.txt_usrname_addstaff.TabIndex = 11;
            // 
            // cb_status_addstaff
            // 
            this.cb_status_addstaff.FormattingEnabled = true;
            this.cb_status_addstaff.Items.AddRange(new object[] {
            "active",
            "inactive",
            "Deleted"});
            this.cb_status_addstaff.Location = new System.Drawing.Point(29, 148);
            this.cb_status_addstaff.Name = "cb_status_addstaff";
            this.cb_status_addstaff.Size = new System.Drawing.Size(104, 24);
            this.cb_status_addstaff.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_deletestaff);
            this.groupBox1.Controls.Add(this.btn_upstaff);
            this.groupBox1.Controls.Add(this.btn_addstaff);
            this.groupBox1.Controls.Add(this.cb_status_addstaff);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_passwd_addstaff);
            this.groupBox1.Controls.Add(this.txt_usrname_addstaff);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.groupBox1.Location = new System.Drawing.Point(445, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 340);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin Nhan Vien";
            // 
            // btn_deletestaff
            // 
            this.btn_deletestaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_deletestaff.FlatAppearance.BorderSize = 0;
            this.btn_deletestaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletestaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletestaff.ForeColor = System.Drawing.Color.White;
            this.btn_deletestaff.Location = new System.Drawing.Point(199, 211);
            this.btn_deletestaff.Name = "btn_deletestaff";
            this.btn_deletestaff.Size = new System.Drawing.Size(66, 23);
            this.btn_deletestaff.TabIndex = 44;
            this.btn_deletestaff.Text = "delete";
            this.btn_deletestaff.UseVisualStyleBackColor = false;
            this.btn_deletestaff.Click += new System.EventHandler(this.btn_deletestaff_Click);
            // 
            // btn_upstaff
            // 
            this.btn_upstaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_upstaff.FlatAppearance.BorderSize = 0;
            this.btn_upstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upstaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upstaff.ForeColor = System.Drawing.Color.White;
            this.btn_upstaff.Location = new System.Drawing.Point(111, 211);
            this.btn_upstaff.Name = "btn_upstaff";
            this.btn_upstaff.Size = new System.Drawing.Size(66, 23);
            this.btn_upstaff.TabIndex = 43;
            this.btn_upstaff.Text = "update";
            this.btn_upstaff.UseVisualStyleBackColor = false;
            this.btn_upstaff.Click += new System.EventHandler(this.btn_upstaff_Click);
            // 
            // btn_addstaff
            // 
            this.btn_addstaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_addstaff.FlatAppearance.BorderSize = 0;
            this.btn_addstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addstaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addstaff.ForeColor = System.Drawing.Color.White;
            this.btn_addstaff.Location = new System.Drawing.Point(16, 211);
            this.btn_addstaff.Name = "btn_addstaff";
            this.btn_addstaff.Size = new System.Drawing.Size(66, 23);
            this.btn_addstaff.TabIndex = 42;
            this.btn_addstaff.Text = "add";
            this.btn_addstaff.UseVisualStyleBackColor = false;
            this.btn_addstaff.Click += new System.EventHandler(this.btn_addstaff_Click);
            // 
            // addStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Name = "addStaff";
            this.Text = "addStaff";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label3;
        private Button btn_backListStaff;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_passwd_addstaff;
        private TextBox txt_usrname_addstaff;
        private ComboBox cb_status_addstaff;
        private GroupBox groupBox1;
        private Button btn_addstaff;
        private Button btn_upstaff;
        private Button btn_deletestaff;
    }
}