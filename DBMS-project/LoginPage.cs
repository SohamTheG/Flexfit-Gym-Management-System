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
    public partial class LoginPage : Form
    {
        OracleConnection connection;
        
        public string password_user;
        public string first_name_user;
        public string last_name_user;
        public string email_user;
        public string middle_name_user;
        public string phonenumber_user;
        public string address_user;
        public string DOB_user;
        public int age;
        public string user_gender;
        public LoginPage()
        {
            InitializeComponent();
        }

        void connect_to_db()
        {
            string oradb = "Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True";
            connection = new OracleConnection(oradb);
            connection.Open();
        }
        void save_info(string email)
        {
            try
            {
                // Connect to the database
                
                connect_to_db();

                // Create a new OracleCommand
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;

                // Define the SQL select statement to fetch user information based on email
                string sql = "SELECT * FROM USER_DETAILS WHERE emailID = :email";

                // Prepare the OracleCommand with the SQL statement
                cmd.CommandText = sql;

                // Add parameter to the command
                cmd.Parameters.Add(":email", OracleType.VarChar).Value = email;

                // Execute the command to fetch the user information
                OracleDataReader reader = cmd.ExecuteReader();

                // Check if there is any data
                if (reader.Read())
                {
                    // Retrieve user information from the database and assign them to public variables
                    
                    password_user = reader["password"].ToString();
                    first_name_user = reader["first_name"].ToString();
                    last_name_user = reader["last_name"].ToString();
                    email_user = reader["emailID"].ToString();
                    middle_name_user = reader["middle_name"].ToString();
                    phonenumber_user = reader["phone"].ToString();
                    address_user = reader["address"].ToString();
                    DOB_user = reader["user_DOB"].ToString(); // Assuming user_DOB is a date column in the database
                    age = calculateAge(DateTime.Parse(DOB_user));
                    user_gender = reader["user_gender"].ToString();
                }
                else
                {
                    MessageBox.Show("No user found with the provided email.", "Error");
                }

                // Close the reader and the connection
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching user information: " + ex.Message, "Error");
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
        void fetch_info_users()
        {
            try
            {
                // Connect to the database
                connect_to_db();

                // Create a new OracleCommand
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;

                // Define the SQL select statement for user login
                string sql = "SELECT COUNT(*) FROM USER_DETAILS WHERE emailID = :email AND password = :password";

                // Prepare the OracleCommand with the SQL statement
                cmd.CommandText = sql;

                // Add parameters to the command
                cmd.Parameters.Add(":email", OracleType.VarChar).Value = textBox_email_id_loginpg.Text;
                cmd.Parameters.Add(":password", OracleType.VarChar).Value = textBox_password_loginpg.Text;

                // Execute the command to fetch the count of matching records
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Close the connection
                connection.Close();

                // Check if count is greater than 0, indicating a match was found
                if (count > 0)
                {
                    MessageBox.Show("User login successful.", "Success");
                    // Call save_info function after successful login
                    
                    save_info(textBox_email_id_loginpg.Text);

                    // Navigate to the home page
                    HomePage page1 = new HomePage(this);
                    page1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
        void fetch_info_admin()
        {
            try
            {
                // Connect to the database
                connect_to_db();

                // Create a new OracleCommand
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;

                // Define the SQL select statement for admin login
                string sql = "SELECT COUNT(*) FROM REGISTRATION WHERE admin_username = :username AND admin_password = :password";

                // Prepare the OracleCommand with the SQL statement
                cmd.CommandText = sql;

                // Add parameters to the command
                cmd.Parameters.Add(":username", OracleType.VarChar).Value = textBox_email_id_loginpg.Text;
                cmd.Parameters.Add(":password", OracleType.VarChar).Value = textBox_password_loginpg.Text;

                // Execute the command to fetch the count of matching records
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Close the connection
                connection.Close();

                // Check if count is greater than 0, indicating a match was found
                if (count > 0)
                {
                    MessageBox.Show("Admin login successful.", "Success");

                    
                    AdminPage adminPage = new AdminPage(this);
                    adminPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid admin username or password.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }


        private void Email_id_lbl_loginpg_Click(object sender, EventArgs e)
        {

        }

        private void textBox_email_id_loginpg_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_lbl_login_pg_Click(object sender, EventArgs e)
        {

        }

        private void textBox_password_loginpg_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_loginpg_Click(object sender, EventArgs e)
        {
            if (textBox_email_id_loginpg.Text.Length != 0 && textBox_password_loginpg.Text.Length != 0)
            {
                
                if(textBox_email_id_loginpg.Text == "admin@gmail.com" && textBox_password_loginpg.Text == "admin")
                {
                    fetch_info_admin();
                }
                else if (true)
                {
                    fetch_info_users();
                    //here we check for backend
                    
                }
            }
            else
            {
                MessageBox.Show("Missing Input Fields", "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Register_loginpg_Click(object sender, EventArgs e)
        {
            RegistrationPgForm form1 = new RegistrationPgForm(this);
            form1.Show();
        }

        private void forgot_pass_lblb_loginpg_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm form1 = new ForgotPasswordForm();
            form1.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
