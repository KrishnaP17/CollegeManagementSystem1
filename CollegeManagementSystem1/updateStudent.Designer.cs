﻿namespace CollegeManagementSystem1
{
    partial class updateStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateStudent));
            label11 = new Label();
            panel1 = new Panel();
            USPanel2 = new Panel();
            panel2 = new Panel();
            label13 = new Label();
            updateBtn = new Button();
            comboBox1 = new ComboBox();
            label12 = new Label();
            CurAddy = new Label();
            CurSchool = new Label();
            CurEmail = new Label();
            CurPhone = new Label();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSaveUS = new Button();
            pictureBox1 = new PictureBox();
            txtStudentID = new TextBox();
            enterStudetID = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            USPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Calligraphy", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Olive;
            label11.Location = new Point(146, 20);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(850, 67);
            label11.TabIndex = 22;
            label11.Text = "Update Student Information";
            label11.Click += label11_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(USPanel2);
            panel1.Controls.Add(btnSaveUS);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtStudentID);
            panel1.Controls.Add(enterStudetID);
            panel1.Location = new Point(43, 135);
            panel1.MaximumSize = new Size(1038, 713);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 713);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint;
            // 
            // USPanel2
            // 
            USPanel2.BackColor = Color.Khaki;
            USPanel2.Controls.Add(panel2);
            USPanel2.Controls.Add(label12);
            USPanel2.Controls.Add(CurAddy);
            USPanel2.Controls.Add(CurSchool);
            USPanel2.Controls.Add(CurEmail);
            USPanel2.Controls.Add(CurPhone);
            USPanel2.Controls.Add(label10);
            USPanel2.Controls.Add(label5);
            USPanel2.Controls.Add(label4);
            USPanel2.Controls.Add(label3);
            USPanel2.Controls.Add(label2);
            USPanel2.Controls.Add(label1);
            USPanel2.Location = new Point(0, 2);
            USPanel2.MaximumSize = new Size(1038, 708);
            USPanel2.Name = "USPanel2";
            USPanel2.Size = new Size(1038, 708);
            USPanel2.TabIndex = 24;
            USPanel2.Paint += USPanel2_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGoldenrod;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(543, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(474, 455);
            panel2.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Olive;
            label13.Location = new Point(8, 40);
            label13.Name = "label13";
            label13.Size = new Size(453, 32);
            label13.TabIndex = 28;
            label13.Text = "CHOOSE INFO TO BE CHANGED";
            label13.Click += label13_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.LemonChiffon;
            updateBtn.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.Olive;
            updateBtn.Location = new Point(167, 366);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(141, 50);
            updateBtn.TabIndex = 24;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Phone Number", "Email", "School Name", "Address" });
            comboBox1.Location = new Point(99, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 33);
            comboBox1.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F);
            label12.Location = new Point(281, 117);
            label12.Name = "label12";
            label12.Size = new Size(0, 27);
            label12.TabIndex = 26;
            // 
            // CurAddy
            // 
            CurAddy.AutoSize = true;
            CurAddy.Font = new Font("Times New Roman", 12F);
            CurAddy.Location = new Point(271, 524);
            CurAddy.Name = "CurAddy";
            CurAddy.Size = new Size(252, 27);
            CurAddy.TabIndex = 14;
            CurAddy.Text = "____________________";
            // 
            // CurSchool
            // 
            CurSchool.AutoSize = true;
            CurSchool.Font = new Font("Times New Roman", 12F);
            CurSchool.Location = new Point(271, 378);
            CurSchool.Name = "CurSchool";
            CurSchool.Size = new Size(252, 27);
            CurSchool.TabIndex = 13;
            CurSchool.Text = "____________________";
            // 
            // CurEmail
            // 
            CurEmail.AutoSize = true;
            CurEmail.Font = new Font("Times New Roman", 12F);
            CurEmail.Location = new Point(271, 250);
            CurEmail.Name = "CurEmail";
            CurEmail.Size = new Size(252, 27);
            CurEmail.TabIndex = 12;
            CurEmail.Text = "____________________";
            // 
            // CurPhone
            // 
            CurPhone.AutoSize = true;
            CurPhone.Font = new Font("Times New Roman", 12F);
            CurPhone.Location = new Point(271, 121);
            CurPhone.Name = "CurPhone";
            CurPhone.Size = new Size(252, 27);
            CurPhone.TabIndex = 11;
            CurPhone.Text = "____________________";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.ForeColor = Color.Olive;
            label10.Location = new Point(-55, 376);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 26);
            label10.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Olive;
            label5.Location = new Point(19, 506);
            label5.Name = "label5";
            label5.Size = new Size(184, 26);
            label5.TabIndex = 5;
            label5.Text = "Current Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Olive;
            label4.Location = new Point(19, 369);
            label4.Name = "label4";
            label4.Size = new Size(235, 26);
            label4.TabIndex = 4;
            label4.Text = "Current School Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Olive;
            label3.Location = new Point(19, 241);
            label3.Name = "label3";
            label3.Size = new Size(163, 26);
            label3.TabIndex = 3;
            label3.Text = "Current Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(19, 107);
            label2.Name = "label2";
            label2.Size = new Size(213, 26);
            label2.TabIndex = 2;
            label2.Text = "Current Phone No. ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(36, 241);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 26);
            label1.TabIndex = 1;
            label1.Click += label1_Click_1;
            // 
            // btnSaveUS
            // 
            btnSaveUS.BackColor = Color.PaleGoldenrod;
            btnSaveUS.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveUS.ForeColor = Color.Olive;
            btnSaveUS.Location = new Point(444, 586);
            btnSaveUS.Name = "btnSaveUS";
            btnSaveUS.Size = new Size(160, 62);
            btnSaveUS.TabIndex = 16;
            btnSaveUS.Text = "Save";
            btnSaveUS.UseVisualStyleBackColor = false;
            btnSaveUS.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(406, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(615, 437);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(214, 48);
            txtStudentID.TabIndex = 14;
            txtStudentID.TextChanged += txtFirstName_TextChanged;
            // 
            // enterStudetID
            // 
            enterStudetID.AutoSize = true;
            enterStudetID.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterStudetID.ForeColor = Color.Olive;
            enterStudetID.Location = new Point(178, 444);
            enterStudetID.Margin = new Padding(5, 0, 5, 0);
            enterStudetID.Name = "enterStudetID";
            enterStudetID.Size = new Size(381, 41);
            enterStudetID.TabIndex = 1;
            enterStudetID.Text = "ENTER STUDENT ID:";
            enterStudetID.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 248);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 31);
            textBox1.TabIndex = 29;
            // 
            // updateStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1130, 950);
            Controls.Add(pictureBox2);
            Controls.Add(label11);
            Controls.Add(panel1);
            MaximumSize = new Size(1152, 1006);
            Name = "updateStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "updateStudent";
            Load += updateStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            USPanel2.ResumeLayout(false);
            USPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Panel panel1;
        private Label enterStudetID;
        private TextBox txtStudentID;
        private PictureBox pictureBox1;
        private Button btnSaveUS;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label10;
        private Label CurPhone;
        private Label CurEmail;
        private Label CurSchool;
        private Label CurAddy;
        private Button updateBtn;
        private Label label12;
        private ComboBox comboBox1;
        private Label label13;
        private Panel USPanel2;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox textBox1;
    }
}