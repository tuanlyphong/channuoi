namespace chan_nuoi
{
    partial class Cosochannuoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cosochannuoi));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(375, 26);
            label1.Name = "label1";
            label1.Size = new Size(342, 41);
            label1.TabIndex = 1;
            label1.Text = "CƠ SỞ CHĂN NUÔI";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Salmon;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(70, 70);
            button1.Name = "button1";
            button1.Size = new Size(178, 96);
            button1.TabIndex = 7;
            button1.Text = "Tổ chức,cá nhân";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(70, 172);
            button2.Name = "button2";
            button2.Size = new Size(178, 96);
            button2.TabIndex = 8;
            button2.Text = "Cơ sở chế biến";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(70, 274);
            button3.Name = "button3";
            button3.Size = new Size(178, 96);
            button3.TabIndex = 9;
            button3.Text = "Vùng an toàn dịch bệnh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Cosochannuoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 173, 178);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Cosochannuoi";
            Text = "Cơ sở chăn nuôi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}