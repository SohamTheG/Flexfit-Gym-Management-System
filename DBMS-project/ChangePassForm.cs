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
    public partial class ChangePassForm : Form
    {
        OracleConnection connection;
        public ChangePassForm()
        {
            InitializeComponent();
        }
        void connect_to_db()
        {
            string oradb = "Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True";
            connection = new OracleConnection(oradb);
            connection.Open();
        }
        void updatepassword()
        {
            
                
                connect_to_db();

                // Get the email and passwords from the textboxes
                string email = email_tb_chps.Text;
                string newPassword = new_pass_tb_chps.Text;
                string confirmNewPassword = conf_new_pass_tb_chps.Text;

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



        private void current_pass_lbl_chps_Click(object sender, EventArgs e)
        {

        }

        private void curr_pass_tb_chps_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_pass_chps_lbl_Click(object sender, EventArgs e)
        {

        }

        private void new_pass_tb_chps_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_new_pass_chps_Click(object sender, EventArgs e)
        {

        }

        private void conf_new_pass_tb_chps_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ok_btn_chps_Click(object sender, EventArgs e)
        {
            updatepassword();
        }
    }
}
