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

            if (username == "krishnaCMS" && password == "krishnaCMS")
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
    }
}
