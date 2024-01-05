namespace chan_nuoi
{
    partial class Giaychungnhan
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
            dataGridView1 = new DataGridView();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(367, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(401, 331);
            dataGridView1.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(32, 161);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 54;
            label3.Text = "Ngày cấp:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 53;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(32, 128);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 51;
            label2.Text = "ID tổ chức:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(15, 97);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 50;
            label1.Text = "Mã chứng nhận:";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(135, 191);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 49;
            button1.Text = "Thêm chứng nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(135, 158);
            dateTimePicker1.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 30);
            dateTimePicker1.TabIndex = 57;
            dateTimePicker1.Value = new DateTime(2023, 12, 31, 16, 6, 17, 0);
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.Location = new Point(596, 12);
            button2.Name = "button2";
            button2.Size = new Size(172, 35);
            button2.TabIndex = 58;
            button2.Text = "Tổ chức có chứng nhận";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Giaychungnhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 173, 178);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Giaychungnhan";
            Text = "Giấy chứng nhận";
            Load += Giaychungnhan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}