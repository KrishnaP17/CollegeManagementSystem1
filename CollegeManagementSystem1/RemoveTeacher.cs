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
    public partial class RemoveTeacher : Form
    {
        public RemoveTeacher()
        {
            InitializeComponent();
        }

        private void RemoveTeacher_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewTeacher.teacherID as Teacher_ID, NewTeacher.tfName as First_Name, NewTeacher.tlName as Last_Name, NewTeacher.tGender as Gender, NewTeacher.tSubject as Subjects_Teaching, NewTeacher.tMobile as Phone_Number, NewTeacher.tDOb as Date_Of_Birth, NewTeacher.tEmail as Email, NewTeacher.tSchoolName as School_Name, NewTeacher.tAddress as Address from NewTeacher";
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

            cmd.CommandText = "select teacherID from NewTeacher where teacherID = " + textBox1.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Please enter a valid teacher ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                if (MessageBox.Show("This will DELETE teacher from database. Do you want to proceed?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    cmd.CommandText = "delete from NewTeacher where teacherID = " + textBox1.Text + "";
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    MessageBox.Show("Teacher deletion successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();

                    cmd.CommandText = "select NewTeacher.teacherID as Teacher_ID, NewTeacher.tfName as First_Name, NewTeacher.tlName as Last_Name, NewTeacher.tGender as Gender, NewTeacher.tSubject as Subjects_Teaching, NewTeacher.tMobile as Phone_Number, NewTeacher.tDOb as Date_Of_Birth, NewTeacher.tEmail as Email, NewTeacher.tSchoolName as School_Name, NewTeacher.tAddress as Address from NewTeacher";
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);

                    dataGridView1.DataSource = ds2.Tables[0];
                }
                else
                {
                    cmd.CommandText = "select NewTeacher.teacherID as Teacher_ID, NewTeacher.tfName as First_Name, NewTeacher.tlName as Last_Name, NewTeacher.tGender as Gender, NewTeacher.tSubject as Subjects_Teaching, NewTeacher.tMobile as Phone_Number, NewTeacher.tDOb as Date_Of_Birth, NewTeacher.tEmail as Email, NewTeacher.tSchoolName as School_Name, NewTeacher.tAddress as Address from NewTeacher";
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);

                    dataGridView1.DataSource = ds2.Tables[0];
                }
            }

        }
    }
}
