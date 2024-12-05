using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollegeManagementSystem1
{
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewAdmission.studentID as Student_ID, NewAdmission.fName as First_Name, NewAdmission.lName as Last_Name, NewAdmission.mobile as Phone_Number, NewAdmission.email as Email, NewAdmission.schoolName as School_Name, NewAdmission.subjects as Subjects, NewAdmission.gender as Gender, NewAdmission.dob as Date_of_Birth, NewAdmission.duration as Duration, NewAdmission.addres as Address from NewAdmission";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

            if (textBox1.Text != "")
            {
                cmd.CommandText = "select studentID from NewAdmission where studentID = " + textBox1.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Please enter a valid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (ds.Tables[0].Rows.Count != 0)
                {
                    cmd.CommandText = " SELECT NewAdmission.studentID AS Student_ID, NewAdmission.fName AS First_Name, NewAdmission.lName AS Last_Name, NewAdmission.mobile AS Phone_Number, NewAdmission.email AS Email, NewAdmission.schoolName AS School_Name, NewAdmission.subjects as Subjects, NewAdmission.gender AS Gender, NewAdmission.dob AS Date_of_Birth, NewAdmission.duration AS Duration, NewAdmission.addres AS Address, CASE WHEN fees.fees IS NULL THEN 'Fees not paid yet' ELSE CAST(fees.fees AS VARCHAR) END AS Fees_Paid FROM NewAdmission LEFT JOIN fees ON NewAdmission.studentID = fees.studentID WHERE NewAdmission.studentID = " + textBox1.Text + "";
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    dataGridView1.DataSource = ds1.Tables[0];
                }
            }
            else
            {
                cmd.CommandText = "select NewAdmission.studentID as Student_ID, NewAdmission.fName as First_Name, NewAdmission.lName as Last_Name, NewAdmission.mobile as Phone_Number, NewAdmission.email as Email, NewAdmission.schoolName as School_Name, NewAdmission.subjects as Subjects, NewAdmission.gender as Gender, NewAdmission.dob as Date_of_Birth, NewAdmission.duration as Duration, NewAdmission.addres as Address from NewAdmission";
                SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);

                dataGridView1.DataSource = ds2.Tables[0];
            }

            

        }
    }
}
