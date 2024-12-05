namespace CollegeManagementSystem1
{
    partial class SearchTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTeacher));
            dataGridView1 = new DataGridView();
            textBox1T = new TextBox();
            label1 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 441);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1241, 434);
            dataGridView1.TabIndex = 32;
            // 
            // textBox1T
            // 
            textBox1T.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1T.Location = new Point(777, 262);
            textBox1T.Name = "textBox1T";
            textBox1T.Size = new Size(224, 49);
            textBox1T.TabIndex = 31;
            textBox1T.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(542, 270);
            label1.Name = "label1";
            label1.Size = new Size(200, 41);
            label1.TabIndex = 30;
            label1.Text = "Teacher ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Calligraphy", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Olive;
            label11.Location = new Point(476, 37);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(500, 72);
            label11.TabIndex = 29;
            label11.Text = "Search Teacher";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 404);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // SearchTeacher
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1312, 896);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1T);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlDarkDark;
            MaximumSize = new Size(1334, 952);
            Name = "SearchTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchTeacher";
            Load += SearchTeacher_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1T;
        private Label label1;
        private Label label11;
        private PictureBox pictureBox1;
    }
}