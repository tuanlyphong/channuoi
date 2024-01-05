namespace chan_nuoi
{
    partial class Honhole
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 9);
            label1.Name = "label1";
            label1.Size = new Size(319, 41);
            label1.TabIndex = 3;
            label1.Text = "Kết quả thống kê ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(372, 297);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(390, 141);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(398, 297);
            dataGridView2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 23;
            button1.Text = "Thêm hộ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(602, 12);
            button2.Name = "button2";
            button2.Size = new Size(172, 35);
            button2.TabIndex = 24;
            button2.Text = "Thêm thống kê";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(492, 100);
            button5.Name = "button5";
            button5.Size = new Size(107, 34);
            button5.TabIndex = 39;
            button5.Text = "Xóa";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.Location = new Point(389, 100);
            button6.Name = "button6";
            button6.Size = new Size(107, 34);
            button6.TabIndex = 38;
            button6.Text = "Tìm kiếm";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(483, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(388, 74);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 36;
            label3.Text = "ID thống kê:";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(114, 100);
            button3.Name = "button3";
            button3.Size = new Size(107, 34);
            button3.TabIndex = 35;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Location = new Point(11, 100);
            button4.Name = "button4";
            button4.Size = new Size(107, 34);
            button4.TabIndex = 34;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(11, 74);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 32;
            label2.Text = "ID hộ:";
            // 
            // button7
            // 
            button7.BackColor = Color.YellowGreen;
            button7.Location = new Point(668, 65);
            button7.Name = "button7";
            button7.Size = new Size(106, 33);
            button7.TabIndex = 59;
            button7.Text = "Cập nhật";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Honhole
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
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Honhole";
            Text = "Thống kê các hộ chăn nuôi nhỏ lẻ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button6;
        private TextBox textBox2;
        private Label label3;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label2;
        private Button button7;
    }
}