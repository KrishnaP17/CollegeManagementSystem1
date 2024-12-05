using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Reflection;
using System.Xml.Linq;

namespace CollegeManagementSystem1
{
    public partial class New_Admissions : Form
    {
        public New_Admissions()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fName = txtFirstName.Text;
            String lName = txtLastName.Text;
            Int64 mobile = Int64.Parse(txtPhoneNo.Text);
            String email = txtEmail.Text;
            String schoolName = txtSchoolName.Text;

            //gender is radio btn so:
            String gender = "";
            bool female = btnFemale.Checked;
            bool male = btnMale.Checked;
            if (female)
            {
                gender = btnFemale.Text;
            }
            else if (male)
            {
                gender = btnMale.Text;
            }
            else
            {
                gender = btnOther.Text;
            }

            String dob = dateTimePickerDOB.Text;
            String duration = comboBoxDuration.Text;
            String address = richTxtAddress.Text;

            List<string> selectedSubjects = new List<string>();
            foreach(var item in subjectList.CheckedItems)
            {
                selectedSubjects.Add(item.ToString());

            }
            String subjects = String.Join(", ", selectedSubjects);


            //create database connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; Integrated Security = True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewAdmission (fName, lName, mobile, email, schoolName, gender, dob, duration, addres, subjects) values ('" + fName + "', '" + lName + "', " + mobile + ", '" + email + "', '" + schoolName + "', '" + gender + "', '" + dob + "', '" + duration + "', '" + address + "', '"+ subjects+"')";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            con.Close();

            MessageBox.Show("Data Saved Successfully. Remember the Student ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNo.Clear();
            txtEmail.Clear();
            txtSchoolName.Clear();
            btnFemale.Checked = false;
            btnMale.Checked = false;
            btnOther.Checked = false;
            comboBoxDuration.ResetText();
            richTxtAddress.Clear();
            foreach (int i in subjectList.CheckedIndices)
            {
                subjectList.SetItemChecked(i, false);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNo.Clear();
            txtEmail.Clear();
            txtSchoolName.Clear();
            btnFemale.Checked = false;
            btnMale.Checked = false;
            btnOther.Checked = false;
            comboBoxDuration.ResetText();
            richTxtAddress.Clear();
            foreach(int i in subjectList.CheckedIndices)
            {
                subjectList.SetItemChecked(i, false);
            }

        }

        private void New_Admissions_Load(object sender, EventArgs e)
        {
            //create Database connnection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //want to generate a student ID
            cmd.CommandText = "select max(studentID) from NewAdmission";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            /*To show student ID on the screen, 
              you have to convert the table's first row and that row's first column (where the studentID os located) to a string
              then set that value to the studentID's textbox text
              and increment that value for the next student
            */
            Int64 abc = Convert.ToInt64(ds.Tables[0].Rows[0][0]);
            studentID.Text = (abc+1).ToString(); 
        }
    }
}
