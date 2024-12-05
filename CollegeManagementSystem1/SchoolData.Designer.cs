namespace CollegeManagementSystem1
{
    partial class SchoolData
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 180);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter School Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 242);
            label2.Name = "label2";
            label2.Size = new Size(263, 25);
            label2.TabIndex = 1;
            label2.Text = "Ex: UNCC, NC State, UNCG, etc...";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(551, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 359);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(685, 304);
            dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(683, 275);
            label3.Name = "label3";
            label3.Size = new Size(443, 25);
            label3.TabIndex = 4;
            label3.Text = "Sorry, no data was found/matched for entered school ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 39);
            label4.Name = "label4";
            label4.Size = new Size(758, 25);
            label4.TabIndex = 5;
            label4.Text = "Shows students, their subjects, and teachers who teacher those subjects for the school entered";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(783, 178);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SchoolData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1138, 718);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(1160, 774);
            Name = "SchoolData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolData";
            Load += SchoolData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}