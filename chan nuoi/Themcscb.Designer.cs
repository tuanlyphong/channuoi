namespace chan_nuoi
{
    partial class Themcscb
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
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 129);
            label4.Name = "label4";
            label4.Size = new Size(295, 41);
            label4.TabIndex = 28;
            label4.Text = "THÊM CƠ SỞ CB";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(127, 258);
            dateTimePicker1.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 30);
            dateTimePicker1.TabIndex = 27;
            dateTimePicker1.Value = new DateTime(2023, 12, 31, 16, 6, 17, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(8, 258);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 26;
            label3.Text = "Ngày thành lập:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(24, 225);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 23;
            label2.Text = "Chủ cơ sở:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(24, 192);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 22;
            label1.Text = "Tên cơ sở:";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(127, 294);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 21;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Themcscb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 173, 178);
            ClientSize = new Size(320, 459);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Themcscb";
            Text = "Thêm cơ sở chế biến";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}