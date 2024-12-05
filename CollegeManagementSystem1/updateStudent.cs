using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtStudentID.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select studentID from NewAdmission where studentID = @studentID";
                cmd.Parameters.AddWithValue("@studentID", txtStudentID.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);




                if (DS.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Please enter a valid student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    panel1.Controls.Clear();

                    USPanel2.Visible = true;

                   // newAddy.Visible = false;


                    if (!panel1.Controls.Contains(USPanel2))
                    {
                        panel1.Controls.Add(USPanel2);
                    }

                    cmd.CommandText = "select mobile, email, schoolName, addres from NewAdmission where studentID = " + txtStudentID.Text + "";

                    SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                    DataSet DS1 = new DataSet();

                    DA1.Fill(DS1);

                    CurPhone.Text = DS1.Tables[0].Rows[0][0].ToString();
                    CurEmail.Text = DS1.Tables[0].Rows[0][1].ToString();
                    CurSchool.Text = DS1.Tables[0].Rows[0][2].ToString();
                    CurAddy.Text = DS1.Tables[0].Rows[0][3].ToString();


                }

            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if(comboBox1.SelectedIndex == 0)
            {
                cmd.CommandText = "Update NewAdmission set [mobile] = " + textBox1.Text + " where studentID = " + txtStudentID.Text + " ";
                MessageBox.Show("Student information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                CurPhone.Text = textBox1.Text;

                comboBox1.ResetText();
                textBox1.Clear();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                cmd.CommandText = "Update NewAdmission set [email] = '" + textBox1.Text + "' where studentID = " + txtStudentID.Text + " ";
                MessageBox.Show("Student information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                CurEmail.Text = textBox1.Text;

                comboBox1.ResetText();
                textBox1.Clear();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                cmd.CommandText = "Update NewAdmission set [schoolName] = '" + textBox1.Text + "' where studentID = " + txtStudentID.Text + "";
                MessageBox.Show("Student information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                CurSchool.Text = textBox1.Text;

                comboBox1.ResetText();
                textBox1.Clear();
            }
            else if (comboBox1.SelectedIndex == 3) 
            {

                cmd.CommandText = "Update NewAdmission set [addres] = '" + textBox1.Text + "' where studentID = " + txtStudentID.Text + "";
                MessageBox.Show("Student information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                CurAddy.Text = textBox1.Text;

                comboBox1.ResetText();
                textBox1.Clear();

            }


            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

        }

        private void USPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
