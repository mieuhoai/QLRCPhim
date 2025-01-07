namespace QLRCP_GUI
{
    partial class registerFrm
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
            this.reg_cpasswd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.reg_showpass = new System.Windows.Forms.CheckBox();
            this.reg_passwd = new System.Windows.Forms.TextBox();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reg_cpasswd
            // 
            this.reg_cpasswd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.reg_cpasswd.Location = new System.Drawing.Point(15, 210);
            this.reg_cpasswd.Multiline = true;
            this.reg_cpasswd.Name = "reg_cpasswd";
            this.reg_cpasswd.PasswordChar = '*';
            this.reg_cpasswd.Size = new System.Drawing.Size(291, 30);
            this.reg_cpasswd.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label9.Location = new System.Drawing.Point(11, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Confirm password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(160, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Login here!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_reg.FlatAppearance.BorderSize = 0;
            this.btn_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_reg.ForeColor = System.Drawing.Color.White;
            this.btn_reg.Location = new System.Drawing.Point(15, 276);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(291, 49);
            this.btn_reg.TabIndex = 8;
            this.btn_reg.Text = "REGISTER";
            this.btn_reg.UseVisualStyleBackColor = false;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // reg_showpass
            // 
            this.reg_showpass.AutoSize = true;
            this.reg_showpass.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.reg_showpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.reg_showpass.Location = new System.Drawing.Point(15, 246);
            this.reg_showpass.Name = "reg_showpass";
            this.reg_showpass.Size = new System.Drawing.Size(133, 24);
            this.reg_showpass.TabIndex = 7;
            this.reg_showpass.Text = "Show password";
            this.reg_showpass.UseVisualStyleBackColor = true;
            this.reg_showpass.CheckedChanged += new System.EventHandler(this.reg_showpass_CheckedChanged);
            // 
            // reg_passwd
            // 
            this.reg_passwd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.reg_passwd.Location = new System.Drawing.Point(15, 143);
            this.reg_passwd.Multiline = true;
            this.reg_passwd.Name = "reg_passwd";
            this.reg_passwd.PasswordChar = '*';
            this.reg_passwd.Size = new System.Drawing.Size(291, 30);
            this.reg_passwd.TabIndex = 6;
            // 
            // reg_username
            // 
            this.reg_username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.reg_username.Location = new System.Drawing.Point(15, 71);
            this.reg_username.Multiline = true;
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(291, 30);
            this.reg_username.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label6.Location = new System.Drawing.Point(11, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label7.Location = new System.Drawing.Point(11, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "UserName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label8.Location = new System.Drawing.Point(112, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Register";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.reg_cpasswd);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_reg);
            this.panel2.Controls.Add(this.reg_showpass);
            this.panel2.Controls.Add(this.reg_passwd);
            this.panel2.Controls.Add(this.reg_username);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(430, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 394);
            this.panel2.TabIndex = 3;
            // 
            // registerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Controls.Add(this.panel2);
            this.Name = "registerFrm";
            this.Text = "registerFrm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox reg_cpasswd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.CheckBox reg_showpass;
        private System.Windows.Forms.TextBox reg_passwd;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
    }
}