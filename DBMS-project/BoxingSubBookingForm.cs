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
    public partial class BoxingSubBookingForm : Form
    {
        int pricePerMonth_box = 2000;
        LoginPage loginP;
        public BoxingSubBookingForm(LoginPage x)
        {
            InitializeComponent();
            this.loginP = x;
        }

        private void Back_bt_BoxSub_Click(object sender, EventArgs e)
        {
            this.Close();
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
                                changing_info_lbl_BoxSub.Text = $"Name: {name}\nAge: {age}\nGender: {gender}";
                            }
                            else
                            {
                                // No instructor found at the selected index
                                changing_info_lbl_BoxSub.Text = "No instructor found.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                changing_info_lbl_BoxSub.Text = "An error occurred: " + ex.Message;
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
        private void InsertSubscriptionDetails(string emailID, string subscriptionID, DateTime startDate, int duration, int price , DateTime enddate)
        {
            try
            {
                // Connect to the database
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    connection.Open();

                    // Create SQL command to insert data
                    string sql = "INSERT INTO BOXING_SUBSCRIPTION_DETAILS (emailID, b_subscriptionID, b_start_date, b_duration, b_price, b_end_date) " +
                                 "VALUES (:emailID, :subscriptionID, :startDate, :duration, :price, :enddate)";

                    // Create OracleCommand
                    using (OracleCommand cmd = new OracleCommand(sql, connection))
                    {
                        // Add parameters
                        cmd.Parameters.Add(":emailID", OracleType.VarChar).Value = emailID;
                        cmd.Parameters.Add(":subscriptionID", OracleType.VarChar).Value = subscriptionID;
                        cmd.Parameters.Add(":startDate", OracleType.DateTime).Value = startDate;
                        cmd.Parameters.Add(":duration", OracleType.Int32).Value = duration;
                        cmd.Parameters.Add(":price", OracleType.Int32).Value = price;
                        cmd.Parameters.Add(":enddate", OracleType.DateTime).Value = enddate;

                        // Execute the command
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
        static string GenerateSubscriptionID()
        {
            // Generate a random part
            Random rand = new Random();
            string randomPart = rand.Next(1000, 10000).ToString(); // Random 4-digit number

            // Combine parts to create the subscription ID
            string subscriptionID = "B" + randomPart;
            return subscriptionID;
        }

        private void Facilities_info_grpboxBoxSub_Enter(object sender, EventArgs e)
        {

        }

        private void efg_BoxSub_Click(object sender, EventArgs e)
        {

        }

        private void groupbox_sele_BoxSub_Enter(object sender, EventArgs e)
        {

        }

        private void Sel_date_BoxSub_lbl_Click(object sender, EventArgs e)
        {

        }

        private void sel_date_BoxSub_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Sel_duration_lbl_BoxSub_Click(object sender, EventArgs e)
        {

        }

        private void BoxSubDurationTrackbr_Scroll(object sender, EventArgs e)
        {
            int months = BoxSubDurationTrackbr.Value + 1;
            int totalPrice = months * pricePerMonth_box;
            BoxSub_price.Text = totalPrice.ToString() + " Rs.";
            no_of_months_lbl_BoxSub.Text = months + " Months";
        }

        private void no_of_months_lbl_BoxSub_Click(object sender, EventArgs e)
        {

        }

        private void instructorinfo_grpbox_BoxSub_Enter(object sender, EventArgs e)
        {

        }

        private void sel_slot_lbl_BoxSub_Click(object sender, EventArgs e)
        {

        }

        private void zumba_time_slots_BoxSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected index from the ComboBox
            int selectedIndex = zumba_time_slots_BoxSub.SelectedIndex;

            if (get_no_of_instructors() < 6)
            {
                if (selectedIndex >= get_no_of_instructors())
                    selectedIndex = ((selectedIndex + 1) % get_no_of_instructors()) - 1;
            }
            changing_info_lbl_BoxSub.Visible = true;

            // Call the function to fetch instructor info
            get_instructor_info(selectedIndex);
        }

        private void changing_info_lbl_BoxSub_Click(object sender, EventArgs e)
        {

        }

        private void price_lbl_BoxSub_Click(object sender, EventArgs e)
        {

        }

        private void BoxSub_price_Click(object sender, EventArgs e)
        {

        }

        private void purchase_btn_BoxSub_Click(object sender, EventArgs e)
        {
            {
                string emid = loginP.email_user;
                string subid = GenerateSubscriptionID(); // Generate a subscription ID
                DateTime sdate = sel_date_BoxSub.SelectionStart; // Start date is the current date
                int dur = BoxSubDurationTrackbr.Value + 1; // Duration is based on the value of the trackbar
                int pr = dur * pricePerMonth_box; // Price is calculated based on the duration
                DateTime endda = sdate.AddMonths(dur); // Calculate the end date based on start date and duration

                // Call InsertSubscriptionDetails method with the parameters
                InsertSubscriptionDetails(emid, subid, sdate, dur, pr, endda);
            }
            PaymentForm xform = new PaymentForm(BoxSub_price.Text);
            xform.Show();
        }

        private void BoxingSubBookingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
