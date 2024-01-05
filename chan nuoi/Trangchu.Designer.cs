namespace chan_nuoi
{
    partial class Trangchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trangchu));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 26);
            label1.Name = "label1";
            label1.Size = new Size(381, 41);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ CHĂN NUÔI";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Salmon;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(272, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(60, 274);
            button3.Name = "button3";
            button3.Size = new Size(178, 96);
            button3.TabIndex = 4;
            button3.Text = "Khác";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(60, 172);
            button4.Name = "button4";
            button4.Size = new Size(178, 96);
            button4.TabIndex = 5;
            button4.Text = "Cơ sở chăn nuôi";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(60, 70);
            button1.Name = "button1";
            button1.Size = new Size(178, 96);
            button1.TabIndex = 6;
            button1.Text = "Sản phẩm xử lý chất thải chăn nuôi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Trangchu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 173, 178);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Trangchu";
            Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private Button button1;
    }
}