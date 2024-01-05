namespace chan_nuoi
{
    partial class Themthongke
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
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(16, 249);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 43;
            label3.Text = "Ngày thống kê:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 115);
            label4.Name = "label4";
            label4.Size = new Size(305, 41);
            label4.TabIndex = 42;
            label4.Text = "THÊM THỐNG KÊ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 213);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 41;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(20, 216);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 39;
            label2.Text = "ID hộ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(20, 185);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 38;
            label1.Text = "ID thống kê:";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(123, 348);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 37;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(123, 246);
            dateTimePicker1.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 30);
            dateTimePicker1.TabIndex = 44;
            dateTimePicker1.Value = new DateTime(2023, 12, 31, 16, 6, 17, 0);
            // 
            // textBox3
            // 
            textBox3.Location = new Point(123, 282);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(20, 285);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 45;
            label5.Text = "Số lượng bò:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(123, 315);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 27);
            textBox4.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(20, 318);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 47;
            label6.Text = "Số lượng dê:";
            // 
            // Themthongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 173, 178);
            ClientSize = new Size(320, 459);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Themthongke";
            Text = "Thêm thống kê";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
    }
}