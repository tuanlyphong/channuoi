namespace chan_nuoi
{
    partial class Themtochuc
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
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 150);
            label4.Name = "label4";
            label4.Size = new Size(282, 41);
            label4.TabIndex = 28;
            label4.Text = "THÊM TỔ CHỨC";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(22, 248);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 23;
            label2.Text = "Tên tổ chức:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(22, 215);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 22;
            label1.Text = "ID tổ chức:";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(125, 274);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 21;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Themtochuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 173, 178);
            ClientSize = new Size(320, 459);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Themtochuc";
            Text = "Thêm tổ chức";
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
    }
}