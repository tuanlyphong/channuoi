namespace chan_nuoi
{
    partial class Tochuccochungnhan
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
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(115, 86);
            button3.Name = "button3";
            button3.Size = new Size(107, 34);
            button3.TabIndex = 32;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Location = new Point(12, 86);
            button4.Name = "button4";
            button4.Size = new Size(107, 34);
            button4.TabIndex = 31;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 29;
            label2.Text = "ID tổ chức:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 312);
            dataGridView1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 9);
            label1.Name = "label1";
            label1.Size = new Size(537, 41);
            label1.TabIndex = 33;
            label1.Text = "TỔ CHỨC ĐƯỢC CHỨNG NHẬN";
            // 
            // Tochuccochungnhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 173, 178);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Tochuccochungnhan";
            Text = "Tổ chức có chứng nhận";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}