namespace CollegeManagementSystem1
{
    partial class Fees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fees));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            txtStudentID = new TextBox();
            textFees = new TextBox();
            fNameLabel = new Label();
            lNamelabel = new Label();
            sNamelabel = new Label();
            durationLabel = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(277, 410);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 24;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(277, 487);
            label2.Name = "label2";
            label2.Size = new Size(147, 32);
            label2.TabIndex = 25;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Olive;
            label3.Location = new Point(277, 568);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 26;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label4.ForeColor = Color.Olive;
            label4.Location = new Point(277, 653);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
            label4.TabIndex = 27;
            label4.Text = "School Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label5.ForeColor = Color.Olive;
            label5.Location = new Point(277, 736);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 28;
            label5.Text = "Duration";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label6.ForeColor = Color.Olive;
            label6.Location = new Point(277, 822);
            label6.Name = "label6";
            label6.Size = new Size(56, 32);
            label6.TabIndex = 29;
            label6.Text = "Fee";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGoldenrod;
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Olive;
            button1.Location = new Point(470, 932);
            button1.Name = "button1";
            button1.Size = new Size(188, 41);
            button1.TabIndex = 30;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Times New Roman", 12F);
            txtStudentID.Location = new Point(569, 413);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(207, 35);
            txtStudentID.TabIndex = 31;
            txtStudentID.TextChanged += textBox1_TextChanged;
            // 
            // textFees
            // 
            textFees.Font = new Font("Times New Roman", 12F);
            textFees.Location = new Point(569, 822);
            textFees.Name = "textFees";
            textFees.Size = new Size(207, 35);
            textFees.TabIndex = 32;
            textFees.TextChanged += textFees_TextChanged;
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fNameLabel.ForeColor = Color.Black;
            fNameLabel.Location = new Point(569, 492);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new Size(216, 27);
            fNameLabel.TabIndex = 33;
            fNameLabel.Text = "_________________";
            // 
            // lNamelabel
            // 
            lNamelabel.AutoSize = true;
            lNamelabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNamelabel.ForeColor = Color.Black;
            lNamelabel.Location = new Point(569, 573);
            lNamelabel.Name = "lNamelabel";
            lNamelabel.Size = new Size(216, 27);
            lNamelabel.TabIndex = 34;
            lNamelabel.Text = "_________________";
            // 
            // sNamelabel
            // 
            sNamelabel.AutoSize = true;
            sNamelabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sNamelabel.ForeColor = Color.Black;
            sNamelabel.Location = new Point(569, 658);
            sNamelabel.Name = "sNamelabel";
            sNamelabel.Size = new Size(216, 27);
            sNamelabel.TabIndex = 35;
            sNamelabel.Text = "_________________";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            durationLabel.ForeColor = Color.Black;
            durationLabel.Location = new Point(569, 741);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(216, 27);
            durationLabel.TabIndex = 36;
            durationLabel.Text = "_________________";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(352, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(373, 362);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // Fees
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1088, 1053);
            Controls.Add(pictureBox3);
            Controls.Add(durationLabel);
            Controls.Add(sNamelabel);
            Controls.Add(lNamelabel);
            Controls.Add(fNameLabel);
            Controls.Add(textFees);
            Controls.Add(txtStudentID);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            MaximumSize = new Size(1110, 1109);
            Name = "Fees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fees";
            Load += Fees_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox txtStudentID;
        private TextBox textFees;
        private Label fNameLabel;
        private Label lNamelabel;
        private Label sNamelabel;
        private Label durationLabel;
        private PictureBox pictureBox3;
    }
}