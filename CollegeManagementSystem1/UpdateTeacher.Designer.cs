namespace CollegeManagementSystem1
{
    partial class UpdateTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTeacher));
            label11 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            UTPanel2 = new Panel();
            currSubjects = new Label();
            label7 = new Label();
            panel2 = new Panel();
            alert4 = new Label();
            tsubjectList = new CheckedListBox();
            label13 = new Label();
            updateBtn = new Button();
            otherOptionTxt = new TextBox();
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
            pictureBox2 = new PictureBox();
            txtTeacherID = new TextBox();
            enterStudetID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            UTPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Calligraphy", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Olive;
            label11.Location = new Point(159, 24);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(856, 67);
            label11.TabIndex = 23;
            label11.Text = "Update Teacher Information";
            label11.Click += label11_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(UTPanel2);
            panel1.Controls.Add(btnSaveUS);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtTeacherID);
            panel1.Controls.Add(enterStudetID);
            panel1.Location = new Point(46, 144);
            panel1.MaximumSize = new Size(1038, 713);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 713);
            panel1.TabIndex = 34;
            // 
            // UTPanel2
            // 
            UTPanel2.BackColor = Color.Khaki;
            UTPanel2.Controls.Add(currSubjects);
            UTPanel2.Controls.Add(label7);
            UTPanel2.Controls.Add(panel2);
            UTPanel2.Controls.Add(label12);
            UTPanel2.Controls.Add(CurAddy);
            UTPanel2.Controls.Add(CurSchool);
            UTPanel2.Controls.Add(CurEmail);
            UTPanel2.Controls.Add(CurPhone);
            UTPanel2.Controls.Add(label10);
            UTPanel2.Controls.Add(label5);
            UTPanel2.Controls.Add(label4);
            UTPanel2.Controls.Add(label3);
            UTPanel2.Controls.Add(label2);
            UTPanel2.Controls.Add(label1);
            UTPanel2.Location = new Point(3, 2);
            UTPanel2.MaximumSize = new Size(1038, 708);
            UTPanel2.Name = "UTPanel2";
            UTPanel2.Size = new Size(1038, 708);
            UTPanel2.TabIndex = 35;
            // 
            // currSubjects
            // 
            currSubjects.AutoSize = true;
            currSubjects.Font = new Font("Times New Roman", 12F);
            currSubjects.Location = new Point(273, 568);
            currSubjects.Name = "currSubjects";
            currSubjects.Size = new Size(252, 27);
            currSubjects.TabIndex = 32;
            currSubjects.Text = "____________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Olive;
            label7.Location = new Point(21, 568);
            label7.Name = "label7";
            label7.Size = new Size(188, 26);
            label7.TabIndex = 31;
            label7.Text = "Current Subjects";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGoldenrod;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(alert4);
            panel2.Controls.Add(tsubjectList);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(otherOptionTxt);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(543, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(474, 455);
            panel2.TabIndex = 30;
            // 
            // alert4
            // 
            alert4.AutoSize = true;
            alert4.BackColor = Color.PaleGoldenrod;
            alert4.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            alert4.ForeColor = Color.Olive;
            alert4.Location = new Point(12, 201);
            alert4.Name = "alert4";
            alert4.Size = new Size(449, 25);
            alert4.TabIndex = 33;
            alert4.Text = "Please select all of the courses teacher will teach.";
            // 
            // tsubjectList
            // 
            tsubjectList.FormattingEnabled = true;
            tsubjectList.Items.AddRange(new object[] { "ITSC 1212", "ITSC 1213", "ITSC 1600", "ITSC 2175", "ITSC 2214", "ITSC 2181", "ITSC 3146", "ITSC 3155", "MATH 1241", "MATH 1242", "MATH 2164", "MATH 2122", "ITIS 3135", "ITIS 3310", "ITIs 3200", "ITIS 4221", "ITCS 3160", "ITCS 3112" });
            tsubjectList.Location = new Point(133, 238);
            tsubjectList.Name = "tsubjectList";
            tsubjectList.Size = new Size(220, 116);
            tsubjectList.TabIndex = 46;
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
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.LemonChiffon;
            updateBtn.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.Olive;
            updateBtn.Location = new Point(167, 383);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(141, 50);
            updateBtn.TabIndex = 24;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // otherOptionTxt
            // 
            otherOptionTxt.Font = new Font("Times New Roman", 9F);
            otherOptionTxt.Location = new Point(99, 264);
            otherOptionTxt.Name = "otherOptionTxt";
            otherOptionTxt.Size = new Size(278, 28);
            otherOptionTxt.TabIndex = 29;
            otherOptionTxt.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Phone Number", "Email", "School Name", "Address", "Subjects" });
            comboBox1.Location = new Point(99, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 33);
            comboBox1.TabIndex = 27;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F);
            label12.Location = new Point(283, 47);
            label12.Name = "label12";
            label12.Size = new Size(0, 27);
            label12.TabIndex = 26;
            // 
            // CurAddy
            // 
            CurAddy.AutoSize = true;
            CurAddy.Font = new Font("Times New Roman", 12F);
            CurAddy.Location = new Point(273, 415);
            CurAddy.Name = "CurAddy";
            CurAddy.Size = new Size(252, 27);
            CurAddy.TabIndex = 14;
            CurAddy.Text = "____________________";
            // 
            // CurSchool
            // 
            CurSchool.AutoSize = true;
            CurSchool.Font = new Font("Times New Roman", 12F);
            CurSchool.Location = new Point(273, 281);
            CurSchool.Name = "CurSchool";
            CurSchool.Size = new Size(252, 27);
            CurSchool.TabIndex = 13;
            CurSchool.Text = "____________________";
            // 
            // CurEmail
            // 
            CurEmail.AutoSize = true;
            CurEmail.Font = new Font("Times New Roman", 12F);
            CurEmail.Location = new Point(273, 156);
            CurEmail.Name = "CurEmail";
            CurEmail.Size = new Size(252, 27);
            CurEmail.TabIndex = 12;
            CurEmail.Text = "____________________";
            // 
            // CurPhone
            // 
            CurPhone.AutoSize = true;
            CurPhone.Font = new Font("Times New Roman", 12F);
            CurPhone.Location = new Point(273, 37);
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
            label5.Location = new Point(21, 416);
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
            label4.Location = new Point(21, 281);
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
            label3.Location = new Point(21, 157);
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
            label2.Location = new Point(21, 37);
            label2.Name = "label2";
            label2.Size = new Size(213, 26);
            label2.TabIndex = 2;
            label2.Text = "Current Phone No. ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(38, 171);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 26);
            label1.TabIndex = 1;
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
            btnSaveUS.Click += btnSaveUS_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(313, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(404, 355);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // txtTeacherID
            // 
            txtTeacherID.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTeacherID.Location = new Point(615, 437);
            txtTeacherID.Name = "txtTeacherID";
            txtTeacherID.Size = new Size(214, 48);
            txtTeacherID.TabIndex = 14;
            // 
            // enterStudetID
            // 
            enterStudetID.AutoSize = true;
            enterStudetID.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterStudetID.ForeColor = Color.Olive;
            enterStudetID.Location = new Point(178, 444);
            enterStudetID.Margin = new Padding(5, 0, 5, 0);
            enterStudetID.Name = "enterStudetID";
            enterStudetID.Size = new Size(388, 41);
            enterStudetID.TabIndex = 1;
            enterStudetID.Text = "ENTER TEACHER ID:";
            // 
            // UpdateTeacher
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1130, 950);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            MaximumSize = new Size(1152, 1006);
            Name = "UpdateTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateTeacher";
            Load += UpdateTeacher_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            UTPanel2.ResumeLayout(false);
            UTPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnSaveUS;
        private PictureBox pictureBox2;
        private TextBox txtTeacherID;
        private Label enterStudetID;
        private Panel UTPanel2;
        private Label currSubjects;
        private Label label7;
        private Panel panel2;
        private Label label13;
        private Button updateBtn;
        private TextBox otherOptionTxt;
        private ComboBox comboBox1;
        private Label label12;
        private Label CurAddy;
        private Label CurSchool;
        private Label CurEmail;
        private Label CurPhone;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckedListBox tsubjectList;
        private Label alert4;
    }
}