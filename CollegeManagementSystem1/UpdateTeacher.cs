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
    public partial class UpdateTeacher : Form
    {
        public UpdateTeacher()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void USPanel2_Paint(object sender, PaintEventArgs e)
        {
            //otherOptionTxt.Visible = true;
            //tsubjectList.Visible = false;
            //if (comboBox1.SelectedIndex == 4)
            //{
            //otherOptionTxt.Visible = false;

            //    tsubjectList.Visible = true;

            //}
        }

        private void btnSaveUS_Click(object sender, EventArgs e)
        {
            if (txtTeacherID.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select teacherID from NewTeacher where teacherID = @teacherID";
                cmd.Parameters.AddWithValue("@teacherID", txtTeacherID.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);



                if (DS.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Please enter a valid teacher ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    panel1.Controls.Clear();

                    UTPanel2.Visible = true;

                    if (!panel1.Controls.Contains(UTPanel2))
                    {
                        panel1.Controls.Add(UTPanel2);
                    }

                    cmd.CommandText = "select tMobile, tEmail, tSchoolName, tAddress, tSubject from NewTeacher where teacherID = " + txtTeacherID.Text + "";

                    SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                    DataSet DS1 = new DataSet();

                    DA1.Fill(DS1);

                    CurPhone.Text = DS1.Tables[0].Rows[0][0].ToString();
                    CurEmail.Text = DS1.Tables[0].Rows[0][1].ToString();
                    CurSchool.Text = DS1.Tables[0].Rows[0][2].ToString();
                    CurAddy.Text = DS1.Tables[0].Rows[0][3].ToString();
                    currSubjects.Text = DS1.Tables[0].Rows[0][4].ToString();



                }
            }
        }

        private void UpdateTeacher_Load(object sender, EventArgs e)
        {
            UTPanel2.Visible = false;

            otherOptionTxt.Visible = false;
            tsubjectList.Visible = false;
            alert4.Visible = false;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
           
             if (comboBox1.SelectedIndex == 0)
            {
                cmd.CommandText = "Update NewTeacher set [tMobile] = " + otherOptionTxt.Text + " where teacherID = " + txtTeacherID.Text + " ";
                MessageBox.Show("Teacher information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                CurPhone.Text = otherOptionTxt.Text;

                comboBox1.ResetText();
                otherOptionTxt.Clear();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                cmd.CommandText = "Update NewTeacher set [tEmail] = '" + otherOptionTxt.Text + "' where teacherID = " + txtTeacherID.Text + " ";
                MessageBox.Show("Teacher information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                CurEmail.Text = otherOptionTxt.Text;

                comboBox1.ResetText();
                otherOptionTxt.Clear();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                cmd.CommandText = "Update NewTeacher set [tSchoolName] = '" + otherOptionTxt.Text + "' where teacherID = " + txtTeacherID.Text + "";
                MessageBox.Show("Teacher information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                CurSchool.Text = otherOptionTxt.Text;

                comboBox1.ResetText();
                otherOptionTxt.Clear();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                cmd.CommandText = "Update NewTeacher set [tAddress] = '" + otherOptionTxt.Text + "' where teacherID = " + txtTeacherID.Text + "";
                MessageBox.Show("Teacher information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                CurAddy.Text = otherOptionTxt.Text;

                comboBox1.ResetText();
                otherOptionTxt.Clear();

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                List<string> selectedSubjects = new List<string>();
                foreach (var item in tsubjectList.CheckedItems)
                {
                    selectedSubjects.Add(item.ToString());
                }
                String subjects = String.Join(", ", selectedSubjects);

                cmd.CommandText = "update NewTeacher set [tSubject] = " + subjects + " ";
                MessageBox.Show("Teacher information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                currSubjects.Text = subjects;
            }
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 4)
            {
                otherOptionTxt.Visible = false; // Hide the TextBox
                tsubjectList.Visible = true;    // Show the ComboBox for subjects
                alert4.Visible = true;
            }
            else
            {
                otherOptionTxt.Visible = true;  // Show the TextBox for other options
                tsubjectList.Visible = false;   // Hide the ComboBox
            }
        }

    }
}
