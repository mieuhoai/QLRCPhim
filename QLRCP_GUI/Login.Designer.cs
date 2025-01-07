namespace QLRCP_GUI
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reglink1 = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.log_showpass = new System.Windows.Forms.CheckBox();
            this.log_passwd = new System.Windows.Forms.TextBox();
            this.log_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.log_rememberpass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.log_rememberpass);
            this.panel1.Controls.Add(this.btn_reglink1);
            this.panel1.Controls.Add(this.btn_log);
            this.panel1.Controls.Add(this.log_showpass);
            this.panel1.Controls.Add(this.log_passwd);
            this.panel1.Controls.Add(this.log_username);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(430, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 359);
            this.panel1.TabIndex = 0;
            // 
            // btn_reglink1
            // 
            this.btn_reglink1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_reglink1.FlatAppearance.BorderSize = 0;
            this.btn_reglink1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reglink1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_reglink1.ForeColor = System.Drawing.Color.White;
            this.btn_reglink1.Location = new System.Drawing.Point(152, 290);
            this.btn_reglink1.Name = "btn_reglink1";
            this.btn_reglink1.Size = new System.Drawing.Size(146, 51);
            this.btn_reglink1.TabIndex = 9;
            this.btn_reglink1.Text = "Register here!";
            this.btn_reglink1.UseVisualStyleBackColor = false;
            this.btn_reglink1.Click += new System.EventHandler(this.btn_reglink1_Click);
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_log.FlatAppearance.BorderSize = 0;
            this.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_log.ForeColor = System.Drawing.Color.White;
            this.btn_log.Location = new System.Drawing.Point(7, 235);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(291, 49);
            this.btn_log.TabIndex = 8;
            this.btn_log.Text = "LOGIN";
            this.btn_log.UseVisualStyleBackColor = false;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // log_showpass
            // 
            this.log_showpass.AutoSize = true;
            this.log_showpass.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.log_showpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.log_showpass.Location = new System.Drawing.Point(7, 193);
            this.log_showpass.Name = "log_showpass";
            this.log_showpass.Size = new System.Drawing.Size(133, 24);
            this.log_showpass.TabIndex = 7;
            this.log_showpass.Text = "Show password";
            this.log_showpass.UseVisualStyleBackColor = true;
            this.log_showpass.CheckedChanged += new System.EventHandler(this.log_showpass_CheckedChanged);
            // 
            // log_passwd
            // 
            this.log_passwd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.log_passwd.Location = new System.Drawing.Point(7, 157);
            this.log_passwd.Multiline = true;
            this.log_passwd.Name = "log_passwd";
            this.log_passwd.PasswordChar = '*';
            this.log_passwd.Size = new System.Drawing.Size(291, 30);
            this.log_passwd.TabIndex = 6;
            // 
            // log_username
            // 
            this.log_username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_username.Location = new System.Drawing.Point(7, 85);
            this.log_username.Multiline = true;
            this.log_username.Name = "log_username";
            this.log_username.Size = new System.Drawing.Size(291, 30);
            this.log_username.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label5.Location = new System.Drawing.Point(12, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Create an account?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(3, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(136, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // log_rememberpass
            // 
            this.log_rememberpass.AutoSize = true;
            this.log_rememberpass.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.log_rememberpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.log_rememberpass.Location = new System.Drawing.Point(141, 193);
            this.log_rememberpass.Name = "log_rememberpass";
            this.log_rememberpass.Size = new System.Drawing.Size(170, 24);
            this.log_rememberpass.TabIndex = 10;
            this.log_rememberpass.Text = "Remember Password";
            this.log_rememberpass.UseVisualStyleBackColor = true;
            this.log_rememberpass.CheckedChanged += new System.EventHandler(this.log_rememberpass_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.CheckBox log_showpass;
        private System.Windows.Forms.TextBox log_passwd;
        private System.Windows.Forms.TextBox log_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reglink1;
        private System.Windows.Forms.CheckBox log_rememberpass;
    }
}