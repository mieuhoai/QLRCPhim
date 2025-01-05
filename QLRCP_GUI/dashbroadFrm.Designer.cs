using System.Drawing;
using System.Windows.Forms;

namespace Demo_RCP_GUI
{
    partial class dashBroadFrm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label7 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(125, 14);
            label7.Name = "label7";
            label7.Size = new Size(26, 17);
            label7.TabIndex = 4;
            label7.Text = "0$";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(133, 19, 33);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(540, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(175, 100);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 70);
            label3.Name = "label3";
            label3.Size = new Size(111, 17);
            label3.TabIndex = 3;
            label3.Text = "Tong thu nhap";
            // 
            // pictureBox3
            // 
         //   pictureBox3.Image = QLRCP_GUI.Properties.Resources.profits1; // This line causes CS0117 error
            pictureBox3.Location = new Point(31, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(116, 14);
            label5.Name = "label5";
            label5.Size = new Size(17, 17);
            label5.TabIndex = 2;
            label5.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(133, 19, 33);
            label4.Location = new Point(12, 10);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 2;
            label4.Text = "Phim moi";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(133, 19, 33);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(288, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(175, 100);
            panel4.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(144, 14);
            label6.Name = "label6";
            label6.Size = new Size(26, 17);
            label6.TabIndex = 4;
            label6.Text = "0$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 70);
            label2.Name = "label2";
            label2.Size = new Size(140, 17);
            label2.TabIndex = 3;
            label2.Text = "Thu nhap hom nay";
            // 
            // pictureBox2
            // 
         //   pictureBox2.Image = QLRCP_GUI.Properties.Resources.money1;
            pictureBox2.Location = new Point(21, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(133, 19, 33);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(741, 176);
            dataGridView1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(18, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 219);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
       //     pictureBox1.Image = QLRCP_GUI.Properties.Resources.video_player1;
            pictureBox1.Location = new Point(37, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(133, 19, 33);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(46, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 100);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 70);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 1;
            label1.Text = "Phim co san";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(18, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 136);
            panel1.TabIndex = 4;
            // 
            // dashBroadFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "dashBroadFrm";
            Text = "dashBroadFrm";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private Panel panel5;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label4;
        private Panel panel4;
        private Label label6;
        private Label label2;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label1;
        private Panel panel1;
    }
}