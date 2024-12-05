using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementSystem1
{
    public partial class NewTeacher : Form
    {
        public NewTeacher()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tfName = TxtfName.Text;
            String tlName = TxtlName.Text;
            String tGender = "";
            bool male = radioButton1.Checked;
            bool female = radioButton2.Checked;
            if (male)
            {
                tGender = radioButton1.Text;
            }
            else if (female)
            {
                tGender = radioButton2.Text;
            }
            else
            {
                tGender = radioButton3.Text;
            }
            List<string> selectedSubjects = new List<String>();
            foreach (var item in tsubjectList.CheckedItems)
            {
                selectedSubjects.Add(item.ToString());
            }
            String subjects = String.Join(", ", selectedSubjects);
            Int64 tMobile = Int64.Parse(TxtMobile.Text);
            String tDOB = TxtDOB.Text;
            String tEmail = TxtEmail.Text;
            String tSchoolName = TxtSchoolName.Text;
            String tAddress = TxtAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewTeacher (tfName, tlName, tGender, tSubject, tMobile, tDOB, tEmail, tSchoolName, tAddress) values ( '" + tfName + "', '" + tlName + "', '" + tGender + "', '" + subjects + "', '" + tMobile + "', '" + tDOB + "', '" + tEmail + "', '" + tSchoolName + "', '" + tAddress + "')";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            con.Close();

            MessageBox.Show("Data Saved Successfully. Remember the Teacher ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtfName.Clear();
            TxtlName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            foreach (int i in tsubjectList.CheckedIndices)
            {
                tsubjectList.SetItemChecked(i, false);
            }
            TxtMobile.Clear();
            TxtDOB.ResetText();
            TxtEmail.Clear();
            TxtSchoolName.Clear();
            TxtAddress.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtfName.Clear();
            TxtlName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            foreach (int i in tsubjectList.CheckedIndices)
            {
                tsubjectList.SetItemChecked(i, false);
            }
            TxtMobile.Clear();
            TxtDOB.ResetText();
            TxtEmail.Clear();
            TxtSchoolName.Clear();
            TxtAddress.Clear();
        }

        private void NewTeacher_Load(object sender, EventArgs e)
        {
            //generate teacher ID starting from one

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; Integrated Security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select max(teacherID) from NewTeacher";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            Int64 abc = Convert.ToInt64(ds.Tables[0].Rows[0][0]);
            teacherID.Text = (abc + 1).ToString();


        }
    }
}
