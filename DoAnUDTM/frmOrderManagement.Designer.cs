using System.Drawing;
using System.Windows.Forms;

namespace DoAnUDTM
{
    partial class frmOrderManagement
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(681, 178);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Chung";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(125, 290);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(70, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 15;
            label1.Text = "Mã Hóa Đơn";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(70, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 23);
            textBox2.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 58);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 17;
            label2.Text = "Ngày Bán";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(70, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 23);
            textBox3.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 90);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 19;
            label3.Text = "Mã Nhân Viên";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(70, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(141, 23);
            textBox4.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 122);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 21;
            label4.Text = "Tên Nhân Viên";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(362, 112);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(141, 23);
            textBox5.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 120);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 29;
            label5.Text = "Số Điện Thoại";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(362, 80);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(141, 23);
            textBox6.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(311, 88);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 27;
            label6.Text = "Địa Chỉ";
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(362, 48);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(141, 23);
            textBox7.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(311, 56);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 25;
            label7.Text = "Tên Khách Hàng";
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(362, 18);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(141, 23);
            textBox8.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(311, 24);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 23;
            label8.Text = "Mã Khách Hàng";
            // 
            // frmOrderManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmOrderManagement";
            Text = "frmOrderManagement";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}