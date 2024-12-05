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
    public partial class RemoveStudent : Form
    {
        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewAdmission.studentID as Student_ID, NewAdmission.fName as First_Name, NewAdmission.lName as Last_Name, NewAdmission.mobile as Phone_Number, NewAdmission.email as Email, NewAdmission.schoolName as School_Name, NewAdmission.gender as Gender, NewAdmission.dob as Date_of_Birth, NewAdmission.duration as Duration, NewAdmission.addres as Address from NewAdmission";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select studentID from NewAdmission where studentID = " + textBox1.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Please enter a valid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                if (MessageBox.Show("This will DELETE student from database. Do you want to proceed?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    cmd.CommandText = "delete from NewAdmission where studentID = " + textBox1.Text + "";
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    MessageBox.Show("Student deletion successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();

                    cmd.CommandText = "select NewAdmission.studentID as Student_ID, NewAdmission.fName as First_Name, NewAdmission.lName as Last_Name, NewAdmission.mobile as Phone_Number, NewAdmission.email as Email, NewAdmission.schoolName as School_Name, NewAdmission.gender as Gender, NewAdmission.dob as Date_of_Birth, NewAdmission.duration as Duration, NewAdmission.addres as Address from NewAdmission";
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);

                    dataGridView1.DataSource = ds2.Tables[0];
                }
                else
                {
                    cmd.CommandText = "select NewAdmission.studentID as Student_ID, NewAdmission.fName as First_Name, NewAdmission.lName as Last_Name, NewAdmission.mobile as Phone_Number, NewAdmission.email as Email, NewAdmission.schoolName as School_Name, NewAdmission.gender as Gender, NewAdmission.dob as Date_of_Birth, NewAdmission.duration as Duration, NewAdmission.addres as Address from NewAdmission";
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    dataGridView1.DataSource = ds1.Tables[0];
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
