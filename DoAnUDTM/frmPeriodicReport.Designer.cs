using System.Drawing;
using System.Windows.Forms;

namespace DoAnUDTM
{
    partial class frmPeriodicReport
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
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            comboBox3 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(690, 440);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 18;
            label4.Text = "VNĐ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(503, 440);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 16;
            label3.Text = "Doanh Thu";
            // 
            // button2
            // 
            button2.Location = new Point(388, 436);
            button2.Name = "button2";
            button2.Size = new Size(80, 23);
            button2.TabIndex = 15;
            button2.Text = "Thống Kê";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(311, 153);
            dataGridView1.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(374, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 460);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Doanh Thu";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(6, 243);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(323, 173);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh Sách Doanh Thu";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Location = new Point(6, 64);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(323, 173);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Hóa Đơn";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(8, 16);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(311, 145);
            dataGridView2.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(195, 27);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(87, 23);
            comboBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 31);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 5;
            label2.Text = "Năm";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(56, 26);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(84, 23);
            comboBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 31);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Tháng";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(117, 27);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 2;
            button1.Text = "Vẽ";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(75, 23);
            comboBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(570, 434);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 23);
            textBox2.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 460);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống Kê";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 80);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 369);
            textBox1.TabIndex = 0;
            // 
            // frmPeriodicReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 471);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(textBox2);
            Controls.Add(groupBox1);
            Name = "frmPeriodicReport";
            Text = "frmPeriodicReport";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Button button2;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private DataGridView dataGridView2;
        private ComboBox comboBox3;
        private Label label2;
        private ComboBox comboBox2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}