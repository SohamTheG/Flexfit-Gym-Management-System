using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_project
{
    public partial class AdminPage : Form
    {
        LoginPage lpage;
        OracleConnection connection;
        public AdminPage(LoginPage lpage)
        {
            InitializeComponent();
            this.lpage = lpage;
            ConnectToDb();
        }
        void ConnectToDb()
        {
            string connectionString = "Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True";
            connection = new OracleConnection(connectionString);
            connection.Open();
        }

        void InsertInstructorInfo(string instructorID, string instructorName, int instructorAge, string instructorGender)
        {
            try
            {
                // Create a new OracleCommand
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;

                // Define the SQL insert statement
                string sql = "INSERT INTO INSTRUCTOR_DETAILS (instructorID, Instructor_name, instructor_age, instructor_gender) " +
                             "VALUES (:instructorID, :instructorName, :instructorAge, :instructorGender)";

                // Prepare the OracleCommand with the SQL statement
                cmd.CommandText = sql;

                // Add parameters to the command
                cmd.Parameters.Add(":instructorID", OracleType.VarChar).Value = instructorID;
                cmd.Parameters.Add(":instructorName", OracleType.VarChar).Value = instructorName;
                cmd.Parameters.Add(":instructorAge", OracleType.Int32).Value = instructorAge;
                cmd.Parameters.Add(":instructorGender", OracleType.VarChar).Value = instructorGender;

                // Execute the command to insert the data
                cmd.ExecuteNonQuery();

                MessageBox.Show("Instructor information inserted successfully.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
        private void InsertTrainerInfo(string trainerID, string trainerName, int trainerAge, string trainerGender)
        {
            try
            {
                // Create a new OracleCommand
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;

                // Define the SQL insert statement
                string sql = "INSERT INTO TRAINER (trainerID, trainer_name, trainer_age, trainer_gender) " +
                             "VALUES (:trainerID, :trainerName, :trainerAge, :trainerGender)";

                // Prepare the OracleCommand with the SQL statement
                cmd.CommandText = sql;

                // Add parameters to the command
                cmd.Parameters.Add(":trainerID", OracleType.VarChar).Value = trainerID;
                cmd.Parameters.Add(":trainerName", OracleType.VarChar).Value = trainerName;
                cmd.Parameters.Add(":trainerAge", OracleType.Int32).Value = trainerAge;
                cmd.Parameters.Add(":trainerGender", OracleType.VarChar).Value = trainerGender;

                // Execute the command to insert the data
                cmd.ExecuteNonQuery();

                MessageBox.Show("Trainer information inserted successfully.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
        


        private void Logoutbtn_admin_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage form1 = new LoginPage();
            form1.Show();
        }

        private void groupBox_trainer_Enter(object sender, EventArgs e)
        {

        }

        private void trainer_name_lbl_admin_Click(object sender, EventArgs e)
        {

        }

        private void textBox_trainer_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void trainer_age_lbl_admin_Click(object sender, EventArgs e)
        {

        }

        private void textBox_trainer_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void trainer_sex_admin_lbl_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_male_trainer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_triner_female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Inserttrainer_admin_btn_Click(object sender, EventArgs e)
        {
            string trainerID = textBox1_trainerid.Text; // You need to provide this value
            string trainerName = textBox_trainer_name.Text;
            int trainerAge = int.Parse(textBox_trainer_age.Text);
            string trainerGender = radioButton_male_trainer.Checked ? "Male" : "Female";


            // Add trainer information
            InsertTrainerInfo(trainerID, trainerName, trainerAge, trainerGender);
        }

        private void instructor_name_lbl_admin_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_instructor_info_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_instructor_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void instuctor_age_admin_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox_instructor_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructor_sex_lbl_admin_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_Male_Instructor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Female_instructor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Insert_inst_admin_btn_Click(object sender, EventArgs e)
        {
            string instructorID = textBox_instr_id_adminpg.Text; // You need to provide this value
            string instructorName = textBox_instructor_name.Text;
            int instructorAge = Convert.ToInt32(textBox_instructor_age.Text);
            string instructorGender = radioButton_Male_Instructor.Checked ? "Male" : "Female"; // Assuming you have radio buttons for gender selection

            // Insert the instructor information
            InsertInstructorInfo(instructorID, instructorName, instructorAge, instructorGender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_instr_id_adminpg_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_trainerid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_trainer_id_Click(object sender, EventArgs e)
        {

        }

        private void stats_btn_Click(object sender, EventArgs e)
        {
            StatsForm x = new StatsForm();
            x.Show();
        }
    }
    }

