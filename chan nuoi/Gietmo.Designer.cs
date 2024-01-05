namespace chan_nuoi
{
    partial class Gietmo
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
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(417, 55);
            button2.Name = "button2";
            button2.Size = new Size(107, 34);
            button2.TabIndex = 18;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(304, 55);
            button1.Name = "button1";
            button1.Size = new Size(107, 34);
            button1.TabIndex = 17;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 15;
            label2.Text = "Tên cơ sở:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 345);
            dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 11);
            label1.Name = "label1";
            label1.Size = new Size(290, 41);
            label1.TabIndex = 13;
            label1.Text = "CƠ SỞ GIẾT MỔ";
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(681, 55);
            button3.Name = "button3";
            button3.Size = new Size(107, 34);
            button3.TabIndex = 20;
            button3.Text = "Thêm";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Gietmo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 173, 178);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Gietmo";
            Text = "CƠ SỞ GIẾT MỔ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button3;
    }
}