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
    public partial class updateStudent : Form
    {
        public updateStudent()
        {
            InitializeComponent();
        }

        private void updateStudent_Load(object sender, EventArgs e)
        {
            USPanel2.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String studentID = txtStudentID.Text;


            string connectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; Integrated Security = True";

            //@StudentID is just a placeholder like: "Select count(*) from NewAdmission where studentID = "1234";
            string query = "SELECT COUNT(*) FROM NewAdmission WHERE StudentID = @StudentID";


            /*ensures that once the code inside the using block completes, the connection will
              automatically close and release any resources, even if an error occurs.
              This helps manage resources efficiently. */
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                //AddWithValue basically replaces @StudentID with the actual StudentID
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                con.Open();

                /* .ExecuteScalar() is a method that executes the SQL command and returns the value of the first column in the
                 first row of the result set. It’s commonly used when you’re only expecting a 
                single value, such as a count or an aggregate result */

                //it executes the query: "select count(*) from NewAdmission where ..." and the query matches the studentID with the database
                int studentExists = (int)cmd.ExecuteScalar();

                if (studentExists > 0)
                {
                    //execute the function that takes place which updates the info

                    panel1.Controls.Clear();

                    USPanel2.Visible = true;

                    if (!panel1.Controls.Contains(USPanel2))
                    {
                        panel1.Controls.Add(USPanel2);
                    }

                   

                }

                else if (String.IsNullOrEmpty(studentID))
                {
                    MessageBox.Show("Please enter a valid Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Student ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
