using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;


namespace DBMS_project
{
    public partial class RegistrationPgForm : Form
    {
        OracleConnection connection;
        Form loginpg;
        public RegistrationPgForm(Form loginpg)
        {
            InitializeComponent();
            this.loginpg = loginpg;
        }

        void connect_to_db()
        {
            string oradb = "Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True";
            connection = new OracleConnection(oradb);
            connection.Open();
        }

        void insert_user_profile()
        {
            try
            {
                // Connect to the database
                connect_to_db();

                // Create a new OracleCommand
                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = connection;

                // Define the SQL insert statement
                string sql = "INSERT INTO USER_DETAILS (emailID, first_name, middle_name, last_name, phone, address, user_DOB, user_gender, password) VALUES (:email, :first_name, :middle_name, :last_name, :phone_number, :address, :date_of_birth, :gender, :password)";

                // Prepare the OracleCommand with the SQL statement
                cmd1.CommandText = sql;

                // Add parameters to the command
                cmd1.Parameters.Add(":email", OracleType.VarChar).Value = textBox_email_regpg.Text;
                cmd1.Parameters.Add(":password", OracleType.VarChar).Value = textBox_password_regpg.Text;
                cmd1.Parameters.Add(":phone_number", OracleType.VarChar).Value = textBoxPhoneNoregpg.Text;

                // Determine gender
                string gender = "";
                if (radioButton_male_regpg.Checked)
                {
                    gender = "Male";
                }
                else if (radioButton_female_regpg.Checked)
                {
                    gender = "Female";
                }
                else if (radioButton_other_regpg.Checked)
                {
                    gender = "Other";
                }
                cmd1.Parameters.Add(":gender", OracleType.VarChar).Value = gender;

                cmd1.Parameters.Add(":first_name", OracleType.VarChar).Value = textBox1.Text;
                cmd1.Parameters.Add(":middle_name", OracleType.VarChar).Value = textBoxmidname_regpg.Text;
                cmd1.Parameters.Add(":last_name", OracleType.VarChar).Value = textBox_lastname_regpg.Text;
                cmd1.Parameters.Add(":address", OracleType.VarChar).Value = richTextBox_address_regpg.Text;

                
                // Convert DateTime to OracleDate for date_of_birth
                OracleParameter dateOfBirthParam = new OracleParameter(":date_of_birth", OracleType.DateTime);
                dateOfBirthParam.Value = monthCalendar1.SelectionStart;
                cmd1.Parameters.Add(dateOfBirthParam);


                // Execute the command
                cmd1.ExecuteNonQuery();

                // Close the connection
                connection.Close();

                MessageBox.Show("User profile registered successfully.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
        void insert_user()
        {
            try
            {
                // Connect to the database
                connect_to_db();

                // Create a new OracleCommand
                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = connection;

                // Define the SQL insert statement
                string sql = "INSERT INTO USER_DETAILS (emailID, first_name, middle_name, last_name, phone, address, user_DOB,user_age, user_gender, password ) VALUES (:email, :first_name, :middle_name, :last_name, :phone_number, :address, :date_of_birth,:age, :gender, :password )";

                // Prepare the OracleCommand with the SQL statement
                cmd1.CommandText = sql;

                // Add parameters to the command
                cmd1.Parameters.Add(":email", OracleType.VarChar).Value = textBox_email_regpg.Text;
                cmd1.Parameters.Add(":first_name", OracleType.VarChar).Value = textBox1.Text;
                cmd1.Parameters.Add(":middle_name", OracleType.VarChar).Value = textBoxmidname_regpg.Text;
                cmd1.Parameters.Add(":last_name", OracleType.VarChar).Value = textBox_lastname_regpg.Text;
                cmd1.Parameters.Add(":phone_number", OracleType.VarChar).Value = textBoxPhoneNoregpg.Text;
                cmd1.Parameters.Add(":address", OracleType.VarChar).Value = richTextBox_address_regpg.Text;
                cmd1.Parameters.Add(":date_of_birth", OracleType.DateTime).Value = monthCalendar1.SelectionStart;

                // Determine gender
                string gender = "";
                if (radioButton_male_regpg.Checked)
                {
                    gender = "Male";
                }
                else if (radioButton_female_regpg.Checked)
                {
                    gender = "Female";
                }
                else if (radioButton_other_regpg.Checked)
                {
                    gender = "Other";
                }
                cmd1.Parameters.Add(":gender", OracleType.VarChar).Value = gender;

                cmd1.Parameters.Add(":password", OracleType.VarChar).Value = textBox_password_regpg.Text;

                // Calculate age
                int age = calculateAge(monthCalendar1.SelectionStart);
                cmd1.Parameters.Add(":age", OracleType.Number).Value = age;

                // Execute the command
                cmd1.ExecuteNonQuery();

                // Close the connection
                connection.Close();

                MessageBox.Show("User profile registered successfully.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }



        int calculateAge(DateTime dob)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - dob.Year;
            if (now.Month < dob.Month || (now.Month == dob.Month && now.Day < dob.Day))
            {
                age--;
            }
            return age;
        }



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void email_id_lbl_regpg_Click(object sender, EventArgs e)
        {

        }

        private void textBox_email_regpg_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_regpg_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_lbl_regpg_Click(object sender, EventArgs e)
        {

        }

        private void confirm_pass_lbl_regpg_Click(object sender, EventArgs e)
        {

        }

        private void textBoxconf_pass_regpg_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            int age = DateTime.Now.Year - selectedDate.Year;

            
            if (DateTime.Now < selectedDate.AddYears(age))
            {
                age--;
            }

            label_agecalc_regpg.Text = age.ToString();
        }
        private void labelage_regpg_Click(object sender, EventArgs e)
        {

        }

        private void label_agecalc_regpg_Click(object sender, EventArgs e)
        {

        }

        private void label_phone_regpg_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhoneNoregpg_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelgenderregpg_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_male_regpg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_female_regpg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_other_regpg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_fname_regpg_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_miname_regpg_Click(object sender, EventArgs e)
        {

        }

        private void textBoxmidname_regpg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_laname_regpg_Click(object sender, EventArgs e)
        {

        }

        private void textBox_lastname_regpg_TextChanged(object sender, EventArgs e)
        {

        }

        private void labeladress_regpg_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_address_regpg_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_btn_regpg_Click(object sender, EventArgs e)
        {
            // Check if email contains valid domains
            if (textBox_email_regpg.Text.Contains("@gmail.com") ||
                textBox_email_regpg.Text.Contains("@yahoo.com") ||
                textBox_email_regpg.Text.Contains("@hotmail.com"))
            {
                // Check password length
                if (textBox_password_regpg.Text.Length > 7 && textBox_password_regpg.Text.Length < 15)
                {
                    // Check if passwords match
                    if (textBox_password_regpg.Text == textBoxconf_pass_regpg.Text)
                    {
                        // Check if gender is selected
                        if (radioButton_male_regpg.Checked || radioButton_female_regpg.Checked || radioButton_other_regpg.Checked)
                        {
                            // Check if all textboxes are filled
                            if (!string.IsNullOrWhiteSpace(textBox_email_regpg.Text) &&
                                !string.IsNullOrWhiteSpace(textBox_password_regpg.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxconf_pass_regpg.Text) &&
                                !string.IsNullOrWhiteSpace(textBoxPhoneNoregpg.Text) &&
                                !string.IsNullOrWhiteSpace(textBox1.Text) &&
                                !string.IsNullOrWhiteSpace(textBox_lastname_regpg.Text) &&
                                !string.IsNullOrWhiteSpace(richTextBox_address_regpg.Text)
                                )
                            {
                                if((textBoxPhoneNoregpg.Text.Length == 10))
                                {
                                    insert_user();
                                    
                                    LoginPage pg1 = new LoginPage();
                                    loginpg.Show();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Invaild Phone Number.", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please fill in all the fields.", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a gender.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Password size must be between 8 to 15 characters.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid email ID type.", "Error");
            }
        }

        private void RegistrationPgForm_Load(object sender, EventArgs e)
        {

        }
    }
}
