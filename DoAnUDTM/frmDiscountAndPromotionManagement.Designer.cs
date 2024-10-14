using System.Drawing;
using System.Windows.Forms;

namespace DoAnUDTM
{
    partial class frmDiscountAndPromotionManagement
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
            groupBox2 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(6, 419);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(603, 68);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tác Vụ";
            // 
            // button4
            // 
            button4.Location = new Point(480, 22);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 14;
            button4.Text = "Hủy";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(331, 22);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 15;
            button5.Text = "Sửa";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(59, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(195, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 145);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Khuyến Mãi";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(381, 26);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(167, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(381, 66);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 23);
            textBox4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 69);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "Điều Kiện";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 30);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Số Lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 103);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Giá Tri";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 69);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 4;
            label2.Text = "Tên Khuyến Mãi";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 30);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Mã Khuyến Mãi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(6, 156);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(603, 257);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Khuyễn Mãi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(585, 222);
            dataGridView1.TabIndex = 0;
            // 
            // frmDiscountAndPromotionManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 503);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "frmDiscountAndPromotionManagement";
            Text = "frmDiscountAndPromotionManagement";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button button4;
        private Button button5;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private TextBox textBox4;
    }
}