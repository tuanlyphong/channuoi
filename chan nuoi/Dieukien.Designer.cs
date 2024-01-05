namespace chan_nuoi
{
    partial class Dieukien
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
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(52, 154);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 42;
            label3.Text = "Nhiệt độ:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(52, 121);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 39;
            label2.Text = "Tên điều kiện:";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(155, 250);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 23;
            button1.Text = "Thêm điều kiện";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(387, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(401, 331);
            dataGridView1.TabIndex = 44;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 27);
            textBox4.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(52, 187);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 45;
            label4.Text = "Độ ẩm:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 217);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 27);
            textBox5.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(52, 220);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 47;
            label5.Text = "Lượng mưa:";
            // 
            // Dieukien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 173, 178);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Dieukien";
            Text = "Điều kiện chăn nuôi";
            Load += Dieukien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
    }
}