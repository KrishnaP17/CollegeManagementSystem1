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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Fees_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (txtStudentID.Text != "")
            {



                //create SQL connection with server 
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True";

                //create command object to enter sql commands here and connect it to the server connection
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                //enter command to GET first name, last name, school name, and duration based on the student id entered
                cmd.CommandText = "Select fName, lName, schoolName, duration from NewAdmission where studentID = " + txtStudentID.Text + " ";

                //we need to store this data in some container
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();

                //Now fill the Data (DA) into the data set (DS)
                DA.Fill(DS);   //lets say the table gets filled like: krishna patel UNCC 2022-2026
                               //                                                      [0],   [1],  [2],   [3]




                //command to DISPLAY the first name, last name, school name, and duration to their relavent fields in fees interface 


                //WE NEED TO MAKE SURE THE STUDENT ID ENTERED IS IN THE DATABASE
                if (DS.Tables[0].Rows.Count != 0)
                {

                    //we want the first name which is stored in as first column and first row in DS
                    fNameLabel.Text = DS.Tables[0].Rows[0][0].ToString();

                    //we want the last name which is stored in as 2nd column and first row in DS
                    lNamelabel.Text = DS.Tables[0].Rows[0][1].ToString();

                    //we want the school name which is stored in as 3rd column and first row in DS
                    sNamelabel.Text = DS.Tables[0].Rows[0][2].ToString();

                    //we want the last name which is stored in as 4th column and first row in DS
                    durationLabel.Text = DS.Tables[0].Rows[0][3].ToString();
                }
                else
                {
                    fNameLabel.Text = "_________________";
                    lNamelabel.Text = "_________________";
                    sNamelabel.Text = "_________________";
                    durationLabel.Text = "_________________";
                }

            }
            else
            {
                //clear the text boxes when the user backspaces the ID they gaev

                fNameLabel.Text = "_________________";
                lNamelabel.Text = "_________________";
                sNamelabel.Text = "_________________";
                durationLabel.Text = "_________________";
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            //we want to make sure first that if the student id has already been entered before, meaning if the fees are already paid for that student, they don't need to submit it again. 
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            //if the user enters non-esistent student ID
            cmd.CommandText = "select studentID from NewAdmission where studentID = " + txtStudentID.Text + " ";
            //we need to store this data in some container
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();

            //Now fill the Data (DA) into the data set (DS)
            DA.Fill(DS);
            if (DS.Tables[0].Rows.Count == 0)
            {
                // If the student ID is not found in the NewAdmission table, show an error message
                MessageBox.Show("Please enter a valid student ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentID.Text = "";
                return;
            }



            //fetch the fees table where the student ID is equivalent to the one user entered
            cmd.CommandText = "select * from fees where studentID = " + txtStudentID.Text + " ";

            //we need to store this data in some container
            SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
            DataSet DS1 = new DataSet();

            //Now fill the Data (DA) into the data set (DS)
            DA1.Fill(DS1);


            //we are fetching the data that isn't into the fees table
            if (DS1.Tables[0].Rows.Count == 0)
            {
                //create SQL connection with server 
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source = KRISHNA\\SQLEXPRESS; database = college; integrated security = True";

                //create command object to enter sql commands here and connect it to the server connection
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;

                //insert the student's ID and the fees amount to the fees table
                cmd1.CommandText = "insert into fees (studentID, fees) values (" + txtStudentID.Text + " , " + textFees.Text + ")";

                //we need to store this data in some container
                SqlDataAdapter DA2 = new SqlDataAdapter(cmd1);
                DataSet DS2 = new DataSet();

                //Now fill the Data (DA) into the data set (DS)
                DA2.Fill(DS2);

                if (MessageBox.Show("Fees Submission Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    //clear the textboxes when the submission is successful (basically reset the form)
                    txtStudentID.Text = "";
                    fNameLabel.Text = "_________________";
                    lNamelabel.Text = "_________________";
                    sNamelabel.Text = "_________________";
                    durationLabel.Text = "_________________";
                    textFees.Text = "";
                }
            }
            else
            {

                MessageBox.Show("Fees already submitted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentID.Text = "";
                fNameLabel.Text = "_________________";
                lNamelabel.Text = "_________________";
                sNamelabel.Text = "_________________";
                durationLabel.Text = "_________________";
                textFees.Text = "";
            }



        }

        private void textFees_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
