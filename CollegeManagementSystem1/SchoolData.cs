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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CollegeManagementSystem1
{
    public partial class SchoolData : Form
    {
        public SchoolData()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SchoolData_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                // Check if school exists
                cmd.CommandText = "SELECT COUNT(*) FROM NewAdmission WHERE schoolName = @SchoolName";
                cmd.Parameters.AddWithValue("@SchoolName", textBox1.Text);
                int count = (int)cmd.ExecuteScalar();

                if (count == 0)
                {
                    dataGridView1.Visible = false;
                    label3.Visible = true;
                    label3.Text = "Sorry, no data was found/matched for entered school.";
                }
                else
                {
                    label3.Visible = false;
                    dataGridView1.Visible = true;

                    cmd.Parameters.Clear();
                    cmd.CommandText = @"
            SELECT 
                NewAdmission.schoolName as School_Name, 
                NewAdmission.fName as Student_First_Name, 
                NewAdmission.lName as Student_Last_Name, 
                subjects.value as Subjects, 
                CONCAT(NewTeacher.tfName, ' ', NewTeacher.tlName) as Teacher_Name 
            FROM NewAdmission 
            CROSS APPLY STRING_SPLIT(NewAdmission.subjects, ',') as subjects 
            JOIN     NewTeacher 
                ON NewTeacher.tSubject = subjects.value 
                AND NewTeacher.tSchoolName = NewAdmission.schoolName 
            WHERE NewAdmission.schoolName = @SchoolName";
                    cmd.Parameters.AddWithValue("@SchoolName", textBox1.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

    }
}
//CROSS APPLY STRING_SPLIT(NewAdmission.subjects, ',') as subjects 