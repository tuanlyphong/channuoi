namespace chan_nuoi
{
    partial class Themgietmo
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
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(19, 259);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 43;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 134);
            label4.Name = "label4";
            label4.Size = new Size(196, 41);
            label4.TabIndex = 42;
            label4.Text = "CƠ SỞ GM";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 41;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(19, 226);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 39;
            label2.Text = "Tên chủ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(19, 195);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 38;
            label1.Text = "Tên cơ sở:";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(122, 289);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 37;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Themgietmo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 173, 178);
            ClientSize = new Size(320, 459);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Themgietmo";
            Text = "Thêm cơ sở giết mổ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}