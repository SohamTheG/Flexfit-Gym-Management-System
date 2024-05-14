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
    public partial class ForgotPasswordForm : Form
    {
        OracleConnection connection;
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        void connect_to_db()
        {
            string oradb = "Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True";
            connection = new OracleConnection(oradb);
            connection.Open();
        }

        void new_password_update()
        {
            try
            {
                connect_to_db();

                // Get the email, new password, and confirmed password from the textboxes
                string email = textBox_email_id_forgpasspg.Text;
                string newPassword = textBox_password_forgpasspg.Text;
                string confirmNewPassword = textBox_confirm_pass.Text;

                // Check if any field is empty
                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the new password matches the confirmed password
                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the email exists in the database
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT COUNT(*) FROM USER_DETAILS WHERE EMAILID = :email";
                cmd.Parameters.Add(":email", OracleType.VarChar).Value = email;

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("Invalid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Don't proceed further if email is not found
                }

                // Update the password
                cmd.CommandText = "UPDATE USER_DETAILS SET PASSWORD = :newPassword WHERE EMAILID = :email";
                cmd.Parameters.Clear(); // Clear previous parameters
                cmd.Parameters.Add(":email", OracleType.VarChar).Value = email;
                cmd.Parameters.Add(":newPassword", OracleType.VarChar).Value = newPassword;
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Close the form only if the password update is successful
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void Email_id_lbl_forgpasspg_Click(object sender, EventArgs e)
        {

        }

        private void textBox_email_id_forgpasspg_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_password_lbl_forgpasspg_Click(object sender, EventArgs e)
        {

        }

        private void textBox_password_forgpasspg_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmpasslbl_forgpasspg_Click(object sender, EventArgs e)
        {

        }

        private void textBox_confirm_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_new_password_btn_Click(object sender, EventArgs e)
        {
            
            if (textBox_email_id_forgpasspg.Text.Length == 0 || textBox_password_forgpasspg.Text.Length == 0 || textBox_confirm_pass.Text.Length == 0)
            {
                MessageBox.Show("Please Fill Reqired Details !", "Error");
            }
            else if (textBox_password_forgpasspg.Text != textBox_confirm_pass.Text)
            {
                MessageBox.Show("Password Do Not Match !", "Error");
            }
            else if(textBox_password_forgpasspg.Text.Length < 8)
            {
                MessageBox.Show("Minimum Length of password is 8 charachters !", "Error");
            }
            else
            {
                new_password_update();
            }
        }
    }
}
