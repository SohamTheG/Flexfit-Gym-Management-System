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
    public partial class ZumbaSubBookingForm : Form
    {
        int pricePerMonth = 2000;
        LoginPage loginP;

        public ZumbaSubBookingForm(LoginPage x)
        {
            InitializeComponent();
            this.loginP = x;

        }
        private static string GenerateSubscriptionID()
        {
            Random rand = new Random();
            string randomPart = rand.Next(1000, 10000).ToString();
            string subscriptionID = "Z" + randomPart;
            return subscriptionID;
        }
        private void get_instructor_info(int selectedIndex)
        {
            try
            {
                // Connect to the database
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    connection.Open();

                    // Create SQL command to select the instructor at the given index
                    string sql = "SELECT instructorID, Instructor_name, instructor_age, instructor_gender FROM INSTRUCTOR_DETAILS WHERE instructorID = (SELECT MIN(instructorID) FROM (SELECT instructorID FROM INSTRUCTOR_DETAILS ORDER BY instructorID OFFSET :SelectedIndex ROWS FETCH NEXT 1 ROWS ONLY))";

                    // Create OracleCommand
                    using (OracleCommand cmd = new OracleCommand(sql, connection))
                    {
                        // Add parameter for the selected index
                        cmd.Parameters.Add(":SelectedIndex", OracleType.Number).Value = selectedIndex;

                        // Execute the command
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if there's a result
                            if (reader.Read())
                            {
                                // Retrieve instructor details from the current row
                                string instructorID = reader.GetString(0);
                                string name = reader.GetString(1);
                                int age = reader.GetInt32(2);
                                string gender = reader.GetString(3);

                                // Display the instructor details in the label
                                changing_info_lbl_ZumbaSub.Text = $"Name: {name}\nAge: {age}\nGender: {gender}";
                            }
                            else
                            {
                                // No instructor found at the selected index
                                changing_info_lbl_ZumbaSub.Text = "No instructor found.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                changing_info_lbl_ZumbaSub.Text = "An error occurred: " + ex.Message;
            }
        }

        private int get_no_of_instructors()
        {
            int count = 0;
            try
            {
                // Connect to the database
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    connection.Open();

                    // Create SQL command to count the number of instructors
                    string sql = "SELECT COUNT(*) FROM INSTRUCTOR_DETAILS";

                    // Create OracleCommand
                    using (OracleCommand cmd = new OracleCommand(sql, connection))
                    {
                        // Execute the command and retrieve the count
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return count;
        }
        private void InsertSubscriptionDetails(string emailID, string subscriptionID, DateTime startDate, int duration, int price, DateTime enddate)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    connection.Open();

                    string sql = "INSERT INTO ZUMBA_SUBSCRIPTION_DETAILS (emailID, z_subscriptionID, z_start_date, z_duration, z_price, z_end_date) " +
                                 "VALUES (:emailID, :subscriptionID, :startDate, :duration, :price, :enddate)";

                    using (OracleCommand cmd = new OracleCommand(sql, connection))
                    {
                        cmd.Parameters.Add(":emailID", OracleType.VarChar).Value = emailID;
                        cmd.Parameters.Add(":subscriptionID", OracleType.VarChar).Value = subscriptionID;
                        cmd.Parameters.Add(":startDate", OracleType.DateTime).Value = startDate;
                        cmd.Parameters.Add(":duration", OracleType.Int32).Value = duration;
                        cmd.Parameters.Add(":price", OracleType.Int32).Value = price;
                        cmd.Parameters.Add(":enddate", OracleType.DateTime).Value = enddate;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Subscription details inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert subscription details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void Back_bt_ZumbaSub_Click(object sender, EventArgs e)
        {
            this.Close();
           
            
        }

        private void Facilities_info_grpboxZumbaSub_Enter(object sender, EventArgs e)
        {

        }

        private void efg_Click(object sender, EventArgs e)
        {

        }

        private void groupbox_sele_ZumbaSub_Enter(object sender, EventArgs e)
        {

        }

        private void Sel_date_ZumbaSub_lbl_Click(object sender, EventArgs e)
        {

        }

        private void sel_date_ZumbaSub_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Sel_duration_lbl_ZumbaSub_Click(object sender, EventArgs e)
        {

        }

        private void ZumbaSubDurationTrackbr_Scroll(object sender, EventArgs e)
        {
            int months = ZumbaSubDurationTrackbr.Value+1;
            int totalPrice = months * pricePerMonth;
            ZumbaSub_price.Text = totalPrice.ToString() + " Rs.";
            no_of_months_lbl_ZumbaSub.Text = months + " Months";
        }

        private void no_of_months_lbl_ZumbaSub_Click(object sender, EventArgs e)
        {

        }

        private void treeViewInstructors_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void instructorinfo_grpbox_Enter(object sender, EventArgs e)
        {

        }

        private void price_lbl_ZumbaSub_Click(object sender, EventArgs e)
        {

        }

        private void ZumbaSub_price_Click(object sender, EventArgs e)
        {

        }

        private void purchase_btn_ZumbaSub_Click(object sender, EventArgs e)
        {
            {
                string emid = loginP.email_user;
                string subid = GenerateSubscriptionID();
                DateTime sdate = sel_date_ZumbaSub.SelectionStart;
                int dur = ZumbaSubDurationTrackbr.Value + 1;
                int pr = dur * pricePerMonth;
                DateTime endda = sdate.AddMonths(dur);

                InsertSubscriptionDetails(emid, subid, sdate, dur, pr, endda);
            }
            PaymentForm xform = new PaymentForm(ZumbaSub_price.Text);
            xform.Show();
        }

        private void sel_slot_lbl_ZumbaSub_Click(object sender, EventArgs e)
        {

        }

        private void zumba_time_slots_ZumbaSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = zumba_time_slots_ZumbaSub.SelectedIndex;

            if (get_no_of_instructors() < 6)
            {
                if (selectedIndex >= get_no_of_instructors())
                    selectedIndex = ((selectedIndex + 1)%get_no_of_instructors())-1;
            }

            changing_info_lbl_ZumbaSub.Visible = true;

            // Call the function to fetch instructor info
            get_instructor_info(selectedIndex);
        }

        private void changing_info_lbl_ZumbaSub_Click(object sender, EventArgs e)
        {

        }

        private void efg_ahhh_Click(object sender, EventArgs e)
        {

        }
    }
}
