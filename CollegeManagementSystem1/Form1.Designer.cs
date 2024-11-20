namespace CollegeManagementSystem1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            loginPanel = new Panel();
            label7 = new Label();
            BtnLogin = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            admissionToolStripMenuItem = new ToolStripMenuItem();
            newAdmissionToolStripMenuItem = new ToolStripMenuItem();
            feeToolStripMenuItem = new ToolStripMenuItem();
            updateFeeToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            searchStudentToolStripMenuItem = new ToolStripMenuItem();
            updateStudentInfoToolStripMenuItem = new ToolStripMenuItem();
            removeStudentToolStripMenuItem = new ToolStripMenuItem();
            teacherToolStripMenuItem = new ToolStripMenuItem();
            addTeacherToolStripMenuItem = new ToolStripMenuItem();
            searchTeacherToolStripMenuItem = new ToolStripMenuItem();
            updateTeacherInfoToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(118, 443);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1228, 77);
            label1.TabIndex = 0;
            label1.Text = "COLLEGE MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 159);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 26);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 127);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 26);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.Olive;
            label4.Location = new Point(118, 330);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(693, 77);
            label4.TabIndex = 3;
            label4.Text = "WELCOME TO THE";
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(label7);
            loginPanel.Controls.Add(BtnLogin);
            loginPanel.Controls.Add(textBox2);
            loginPanel.Controls.Add(textBox1);
            loginPanel.Controls.Add(label6);
            loginPanel.Controls.Add(label5);
            loginPanel.Controls.Add(pictureBox1);
            loginPanel.ForeColor = Color.Olive;
            loginPanel.Location = new Point(118, 611);
            loginPanel.Margin = new Padding(4, 3, 4, 3);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(911, 419);
            loginPanel.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Olive;
            label7.Location = new Point(371, 48);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(147, 38);
            label7.TabIndex = 11;
            label7.Text = "SIGN IN";
            label7.Click += label7_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            BtnLogin.Location = new Point(325, 329);
            BtnLogin.Margin = new Padding(4, 3, 4, 3);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(252, 55);
            BtnLogin.TabIndex = 9;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 15F);
            textBox2.Location = new Point(458, 246);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(320, 42);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 15F);
            textBox1.Location = new Point(458, 159);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 42);
            textBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label6.ForeColor = Color.Olive;
            label6.Location = new Point(195, 252);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(147, 35);
            label6.TabIndex = 6;
            label6.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label5.ForeColor = Color.Olive;
            label5.Location = new Point(195, 166);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 35);
            label5.TabIndex = 5;
            label5.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-42, -30);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGoldenrodYellow;
            menuStrip1.ImageScalingSize = new Size(44, 44);
            menuStrip1.Items.AddRange(new ToolStripItem[] { admissionToolStripMenuItem, feeToolStripMenuItem, studentToolStripMenuItem, teacherToolStripMenuItem, aboutUsToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4);
            menuStrip1.Size = new Size(1728, 98);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // admissionToolStripMenuItem
            // 
            admissionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newAdmissionToolStripMenuItem });
            admissionToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            admissionToolStripMenuItem.ForeColor = Color.Olive;
            admissionToolStripMenuItem.Image = (Image)resources.GetObject("admissionToolStripMenuItem.Image");
            admissionToolStripMenuItem.ImageTransparentColor = Color.White;
            admissionToolStripMenuItem.Name = "admissionToolStripMenuItem";
            admissionToolStripMenuItem.Padding = new Padding(4);
            admissionToolStripMenuItem.Size = new Size(136, 90);
            admissionToolStripMenuItem.Text = "Admission ";
            admissionToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // newAdmissionToolStripMenuItem
            // 
            newAdmissionToolStripMenuItem.BackColor = Color.LightGoldenrodYellow;
            newAdmissionToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newAdmissionToolStripMenuItem.ForeColor = Color.Olive;
            newAdmissionToolStripMenuItem.Name = "newAdmissionToolStripMenuItem";
            newAdmissionToolStripMenuItem.Size = new Size(270, 34);
            newAdmissionToolStripMenuItem.Text = "New Admission";
            newAdmissionToolStripMenuItem.Click += newAdmissionToolStripMenuItem_Click;
            // 
            // feeToolStripMenuItem
            // 
            feeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateFeeToolStripMenuItem });
            feeToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            feeToolStripMenuItem.ForeColor = Color.Olive;
            feeToolStripMenuItem.Image = (Image)resources.GetObject("feeToolStripMenuItem.Image");
            feeToolStripMenuItem.ImageTransparentColor = Color.White;
            feeToolStripMenuItem.Name = "feeToolStripMenuItem";
            feeToolStripMenuItem.Padding = new Padding(8);
            feeToolStripMenuItem.Size = new Size(69, 90);
            feeToolStripMenuItem.Text = "Fee";
            feeToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // updateFeeToolStripMenuItem
            // 
            updateFeeToolStripMenuItem.BackColor = Color.LightGoldenrodYellow;
            updateFeeToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateFeeToolStripMenuItem.ForeColor = Color.Olive;
            updateFeeToolStripMenuItem.Name = "updateFeeToolStripMenuItem";
            updateFeeToolStripMenuItem.Size = new Size(231, 34);
            updateFeeToolStripMenuItem.Text = "Update Fee";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.BackColor = Color.LightGoldenrodYellow;
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchStudentToolStripMenuItem, updateStudentInfoToolStripMenuItem, removeStudentToolStripMenuItem });
            studentToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            studentToolStripMenuItem.ForeColor = Color.Olive;
            studentToolStripMenuItem.Image = (Image)resources.GetObject("studentToolStripMenuItem.Image");
            studentToolStripMenuItem.ImageTransparentColor = Color.White;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Padding = new Padding(8);
            studentToolStripMenuItem.Size = new Size(111, 90);
            studentToolStripMenuItem.Text = "Student";
            studentToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // searchStudentToolStripMenuItem
            // 
            searchStudentToolStripMenuItem.BackColor = Color.LightGoldenrodYellow;
            searchStudentToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            searchStudentToolStripMenuItem.ForeColor = Color.Olive;
            searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            searchStudentToolStripMenuItem.Size = new Size(320, 34);
            searchStudentToolStripMenuItem.Text = "Search Student";
            // 
            // updateStudentInfoToolStripMenuItem
            // 
            updateStudentInfoToolStripMenuItem.BackColor = Color.LightGoldenrodYellow;
            updateStudentInfoToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            updateStudentInfoToolStripMenuItem.ForeColor = Color.Olive;
            updateStudentInfoToolStripMenuItem.Name = "updateStudentInfoToolStripMenuItem";
            updateStudentInfoToolStripMenuItem.Size = new Size(320, 34);
            updateStudentInfoToolStripMenuItem.Text = "Update Student Info";
            updateStudentInfoToolStripMenuItem.Click += updateStudentInfoToolStripMenuItem_Click;
            // 
            // removeStudentToolStripMenuItem
            // 
            removeStudentToolStripMenuItem.BackColor = Color.LightGoldenrodYellow;
            removeStudentToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            removeStudentToolStripMenuItem.ForeColor = Color.Olive;
            removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            removeStudentToolStripMenuItem.Size = new Size(320, 34);
            removeStudentToolStripMenuItem.Text = "Remove Student";
            // 
            // teacherToolStripMenuItem
            // 
            teacherToolStripMenuItem.BackColor = Color.LightGoldenrodYellow;
            teacherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTeacherToolStripMenuItem, searchTeacherToolStripMenuItem, updateTeacherInfoToolStripMenuItem });
            teacherToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            teacherToolStripMenuItem.ForeColor = Color.Olive;
            teacherToolStripMenuItem.Image = (Image)resources.GetObject("teacherToolStripMenuItem.Image");
            teacherToolStripMenuItem.ImageTransparentColor = Color.White;
            teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            teacherToolStripMenuItem.Padding = new Padding(8);
            teacherToolStripMenuItem.Size = new Size(114, 90);
            teacherToolStripMenuItem.Text = "Teacher";
            teacherToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // addTeacherToolStripMenuItem
            // 
            addTeacherToolStripMenuItem.BackColor = Color.LightGoldenrodYellow;
            addTeacherToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            addTeacherToolStripMenuItem.ForeColor = Color.Olive;
            addTeacherToolStripMenuItem.Name = "addTeacherToolStripMenuItem";
            addTeacherToolStripMenuItem.Size = new Size(323, 34);
            addTeacherToolStripMenuItem.Text = "Add Teacher";
            // 
            // searchTeacherToolStripMenuItem
            // 
            searchTeacherToolStripMenuItem.BackColor = Color.LightGoldenrodYellow;
            searchTeacherToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            searchTeacherToolStripMenuItem.ForeColor = Color.Olive;
            searchTeacherToolStripMenuItem.Name = "searchTeacherToolStripMenuItem";
            searchTeacherToolStripMenuItem.Size = new Size(323, 34);
            searchTeacherToolStripMenuItem.Text = "Search Teacher";
            // 
            // updateTeacherInfoToolStripMenuItem
            // 
            updateTeacherInfoToolStripMenuItem.BackColor = Color.LightGoldenrodYellow;
            updateTeacherInfoToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            updateTeacherInfoToolStripMenuItem.ForeColor = Color.Olive;
            updateTeacherInfoToolStripMenuItem.Name = "updateTeacherInfoToolStripMenuItem";
            updateTeacherInfoToolStripMenuItem.Size = new Size(323, 34);
            updateTeacherInfoToolStripMenuItem.Text = "Update Teacher Info";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            aboutUsToolStripMenuItem.ForeColor = Color.Olive;
            aboutUsToolStripMenuItem.Image = (Image)resources.GetObject("aboutUsToolStripMenuItem.Image");
            aboutUsToolStripMenuItem.ImageTransparentColor = Color.White;
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Padding = new Padding(8);
            aboutUsToolStripMenuItem.Size = new Size(127, 90);
            aboutUsToolStripMenuItem.Text = "About Us";
            aboutUsToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            logoutToolStripMenuItem.ForeColor = Color.Olive;
            logoutToolStripMenuItem.Image = (Image)resources.GetObject("logoutToolStripMenuItem.Image");
            logoutToolStripMenuItem.ImageTransparentColor = Color.White;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Padding = new Padding(8);
            logoutToolStripMenuItem.Size = new Size(111, 90);
            logoutToolStripMenuItem.Text = "Logout ";
            logoutToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            logoutToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1728, 1109);
            Controls.Add(loginPanel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel loginPanel;
        private Button BtnLogin;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem admissionToolStripMenuItem;
        private ToolStripMenuItem newAdmissionToolStripMenuItem;
        private ToolStripMenuItem feeToolStripMenuItem;
        private ToolStripMenuItem updateFeeToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem searchStudentToolStripMenuItem;
        private ToolStripMenuItem updateStudentInfoToolStripMenuItem;
        private ToolStripMenuItem teacherToolStripMenuItem;
        private ToolStripMenuItem removeStudentToolStripMenuItem;
        private ToolStripMenuItem addTeacherToolStripMenuItem;
        private ToolStripMenuItem searchTeacherToolStripMenuItem;
        private ToolStripMenuItem updateTeacherInfoToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}
