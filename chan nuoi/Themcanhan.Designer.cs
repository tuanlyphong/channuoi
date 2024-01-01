namespace chan_nuoi
{
    partial class Themcanhan
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 150);
            label4.Name = "label4";
            label4.Size = new Size(283, 41);
            label4.TabIndex = 34;
            label4.Text = "THÊM CÁ NHÂN";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(19, 242);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 31;
            label2.Text = "Tên cá nhân:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(19, 211);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 30;
            label1.Text = "ID cá nhân:";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(122, 305);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 29;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 272);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(19, 275);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 35;
            label3.Text = "ID tổ chức:";
            // 
            // Themcanhan
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
            Name = "Themcanhan";
            Text = "Themcanhan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
    }
}