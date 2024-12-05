namespace CollegeManagementSystem1
{
    partial class RemoveStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveStudent));
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 442);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1241, 434);
            dataGridView1.TabIndex = 37;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(792, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 49);
            textBox1.TabIndex = 36;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(553, 189);
            label1.Name = "label1";
            label1.Size = new Size(197, 41);
            label1.TabIndex = 35;
            label1.Text = "Student ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Calligraphy", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(192, 0, 0);
            label11.Location = new Point(484, 38);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(532, 72);
            label11.TabIndex = 34;
            label11.Text = "Remove Student";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 383);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGoldenrod;
            button1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Firebrick;
            button1.Location = new Point(676, 289);
            button1.Name = "button1";
            button1.Size = new Size(215, 46);
            button1.TabIndex = 38;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RemoveStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1312, 896);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            MaximumSize = new Size(1334, 952);
            Name = "RemoveStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RemoveStudent";
            Load += RemoveStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label11;
        private PictureBox pictureBox1;
        private Button button1;
    }
}