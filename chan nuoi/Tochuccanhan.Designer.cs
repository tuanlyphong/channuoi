namespace chan_nuoi
{
    partial class Tochuccanhan
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(385, 317);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(412, 121);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(385, 317);
            dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 41);
            label1.TabIndex = 2;
            label1.Text = "TỔ CHỨC CÁ NHÂN";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(57, 12);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 22;
            button1.Text = "Thêm tổ chức";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(582, 12);
            button2.Name = "button2";
            button2.Size = new Size(172, 35);
            button2.TabIndex = 23;
            button2.Text = "Thêm cá nhân";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(115, 86);
            button3.Name = "button3";
            button3.Size = new Size(107, 34);
            button3.TabIndex = 27;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Location = new Point(12, 86);
            button4.Name = "button4";
            button4.Size = new Size(107, 34);
            button4.TabIndex = 26;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 24;
            label2.Text = "ID tổ chức:";
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(516, 86);
            button5.Name = "button5";
            button5.Size = new Size(107, 34);
            button5.TabIndex = 31;
            button5.Text = "Xóa";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.Location = new Point(413, 86);
            button6.Name = "button6";
            button6.Size = new Size(107, 34);
            button6.TabIndex = 30;
            button6.Text = "Tìm kiếm";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(493, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(413, 60);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 28;
            label3.Text = "ID cá nhân:";
            // 
            // button7
            // 
            button7.BackColor = Color.YellowGreen;
            button7.Location = new Point(681, 81);
            button7.Name = "button7";
            button7.Size = new Size(107, 34);
            button7.TabIndex = 32;
            button7.Text = "Cập nhật";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Tochuccanhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 173, 178);
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Tochuccanhan";
            Text = "Tổ chức và cá nhân";
            Load += Tochuccanhan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label2;
        private Button button5;
        private Button button6;
        private TextBox textBox2;
        private Label label3;
        private Button button7;
    }
}