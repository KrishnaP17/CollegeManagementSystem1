namespace CollegeManagementSystem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void admissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void studentSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            if (username == "." && password == ".")
            {
                menuStrip1.Visible = true;
                loginPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Admissions na = new New_Admissions();
            na.Show();
        }

        private void updateStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateStudent us = new updateStudent();
            us.Show();
        }

        private void updateFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fs = new Fees();
            fs.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTeacher nt = new NewTeacher();
            nt.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //school:   Students that go to that school     Subject they are taking     Teacher that go to that school AND teach the subject they chose
            SchoolData sd = new SchoolData();
            sd.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent searchStudent = new SearchStudent();
            searchStudent.Show();
        }

        private void updateTeacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTeacher ut = new UpdateTeacher();
            ut.Show();
        }

        private void searchTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher st = new SearchTeacher();
            st.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();
        }

        private void removeTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveTeacher rt = new RemoveTeacher();
            rt.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
