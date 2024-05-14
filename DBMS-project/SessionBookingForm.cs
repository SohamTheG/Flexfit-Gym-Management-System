using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_project
{
    public partial class SessionBookingForm : Form
    {
        LoginPage loginPage;
        int maxOccupancy = 1;
        public SessionBookingForm(LoginPage x)
        {
            InitializeComponent();
            loginPage = x;
            if(From_am_pm.Text == "AM")
            {
                numericUpDown1.Minimum = 6;
                numericUpDown1.Maximum = 11;
            }else
            {
                numericUpDown1.Minimum = 2;
                numericUpDown1.Maximum = 9;

                
            }

            
            
        }
        private string get_zumba_subid(string emailID)
        {
            string subscriptionID = "";
            try
            {
                // Establish connection to the database
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new OracleCommand
                    using (OracleCommand cmd = connection.CreateCommand())
                    {
                        // Define the SQL query to retrieve the Zumba subscription ID
                        string sql = "SELECT z_subscriptionID FROM ZUMBA_SUBSCRIPTION_DETAILS WHERE emailID = :emailID";

                        // Prepare the OracleCommand with the SQL statement
                        cmd.CommandText = sql;

                        // Add parameter to the command
                        cmd.Parameters.Add(":emailID", OracleType.VarChar).Value = emailID;

                        // Execute the command to fetch the subscription ID
                        object result = cmd.ExecuteScalar();
                        // Check if result is not null and convert it to string
                        if (result != null)
                        {
                            subscriptionID = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exception occurred
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return subscriptionID;
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
        private string get_gym_subid(string emailID)
        {
            string subscriptionID = "";
            try
            {
                // Establish connection to the database
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new OracleCommand
                    using (OracleCommand cmd = connection.CreateCommand())
                    {
                        // Define the SQL query to retrieve the subscription ID
                        string sql = "SELECT g_subscriptionID FROM GYM_SUBSCRIPTION_DETAILS WHERE emailID = :emailID";

                        // Prepare the OracleCommand with the SQL statement
                        cmd.CommandText = sql;

                        // Add parameter to the command
                        cmd.Parameters.Add(":emailID", OracleType.VarChar).Value = emailID;

                        // Execute the command to fetch the subscription ID
                        object result = cmd.ExecuteScalar();
                        // Check if result is not null and convert it to string
                        if (result != null)
                        {
                            subscriptionID = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exception occurred
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return subscriptionID;
        }
        private int InsertZumbaSessionDetails(string emailID, string subscriptionID, string startTime, string endTime, DateTime date, string instid)
        {
            try
            {
                // Establish connection to the database
                using (OracleConnection connection = new OracleConnection("Data Source = SohamXlaptop; Persist Security Info = True; User ID = system; Password = student; Unicode = True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new OracleCommand
                    using (OracleCommand cmd = connection.CreateCommand())
                    {
                        // Define the SQL insert statement
                        string sql = "INSERT INTO ZUMBA_TIMESLOT_DETAILS (emailID, z_subscriptionID, z_start_time, z_date, z_end_time,instructorid) " +
                                     "VALUES (:emailID, :subscriptionID, :startTime, :Sessdate, :endTime, :instid)";

                        // Prepare the OracleCommand with the SQL statement
                        cmd.CommandText = sql;

                        // Add parameters to the command
                        cmd.Parameters.Add(":emailID", OracleType.VarChar).Value = emailID;
                        cmd.Parameters.Add(":subscriptionID", OracleType.VarChar).Value = subscriptionID;
                        cmd.Parameters.Add(":startTime", OracleType.VarChar).Value = startTime;
                        cmd.Parameters.Add(":endTime", OracleType.VarChar).Value = endTime;
                        cmd.Parameters.Add(":Sessdate", OracleType.DateTime).Value = date;
                        cmd.Parameters.Add(":instid", OracleType.VarChar).Value = instid;

                        // Execute the command to insert the data
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Session details inserted successfully
                            return 1;
                        }
                        else
                        {
                            // Insertion failed
                            MessageBox.Show("Failed to insert Zumba session details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exception occurred
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private string get_instructorid(int selectedIndex)
        {
            string instid = "";
            try
            {
                // Connect to the database
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    connection.Open();

                    // Create SQL command to select the instructor at the given index
                    string sql = "SELECT instructorID FROM INSTRUCTOR_DETAILS WHERE instructorID = (SELECT MIN(instructorID) FROM (SELECT instructorID FROM INSTRUCTOR_DETAILS ORDER BY instructorID OFFSET :SelectedIndex ROWS FETCH NEXT 1 ROWS ONLY))";

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
                                instid = reader.GetString(0);
                                reader.Close();
                                return instid;

                                // Display the instructor details in the label

                            }
                            else
                            {
                                MessageBox.Show("No instructor found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return instid;
        }

        private bool CheckMaxOccupancyBoxing(string startTime, DateTime date, int maxOccupancy)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    connection.Open();

                    using (OracleCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "check_max_occupancy_boxing"; // Use the name of the PL/SQL function for boxing

                        // Add input parameters
                        cmd.Parameters.Add("p_start_time", OracleType.VarChar).Value = startTime;
                        cmd.Parameters.Add("p_date", OracleType.DateTime).Value = date;
                        cmd.Parameters.Add("p_max_occupancy", OracleType.Int32).Value = maxOccupancy;

                        // Add output parameter
                        cmd.Parameters.Add("result", OracleType.Int32).Direction = ParameterDirection.ReturnValue;

                        // Execute the command
                        cmd.ExecuteNonQuery();

                        // Get the result from the output parameter
                        int result = Convert.ToInt32(cmd.Parameters["result"].Value);

                        // Convert result to boolean
                        return result == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string get_box_subid(string emailID)
        {
            string subscriptionID = "";
            try
            {
                // Establish connection to the database
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new OracleCommand
                    using (OracleCommand cmd = connection.CreateCommand())
                    {
                        // Define the SQL query to retrieve the boxing subscription ID
                        string sql = "SELECT b_subscriptionID FROM BOXING_SUBSCRIPTION_DETAILS WHERE emailID = :emailID";

                        // Prepare the OracleCommand with the SQL statement
                        cmd.CommandText = sql;

                        // Add parameter to the command
                        cmd.Parameters.Add(":emailID", OracleType.VarChar).Value = emailID;

                        // Execute the command to fetch the subscription ID
                        object result = cmd.ExecuteScalar();

                        // Check if result is not null and convert it to string
                        if (result != null)
                        {
                            subscriptionID = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exception occurred
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return subscriptionID;
        }

        private bool CheckMaxOccupancy(string startTime, DateTime date, int maxOccupancy)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    connection.Open();

                    using (OracleCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "check_max_occupancy";

                        // Add input parameters
                        cmd.Parameters.Add("p_start_time", OracleType.VarChar).Value = startTime;
                        cmd.Parameters.Add("p_date", OracleType.DateTime).Value = date;
                        cmd.Parameters.Add("p_max_occupancy", OracleType.Int32).Value = maxOccupancy;

                        // Add output parameter
                        cmd.Parameters.Add("result", OracleType.Int32).Direction = ParameterDirection.ReturnValue;

                        // Execute the command
                        cmd.ExecuteNonQuery();

                        // Get the result from the output parameter
                        int result = Convert.ToInt32(cmd.Parameters["result"].Value);

                        // Convert result to boolean
                        return result == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private int InsertBoxingSessionDetails(string emailID, string subscriptionID, string startTime, string endTime, DateTime date, string instid)
        {
            try
            {
                // Establish connection to the database
                using (OracleConnection connection = new OracleConnection("Data Source = SohamXlaptop; Persist Security Info = True; User ID = system; Password = student; Unicode = True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new OracleCommand
                    using (OracleCommand cmd = connection.CreateCommand())
                    {
                        // Define the SQL insert statement
                        string sql = "INSERT INTO BOXING_TIMESLOT_DETAILS (emailID, b_subscriptionID, b_start_time, b_end_time, b_date, instructorid) " +
                                     "VALUES (:emailID, :subscriptionID, :startTime, :endTime, :Sessdate, :instid)";

                        // Prepare the OracleCommand with the SQL statement
                        cmd.CommandText = sql;

                        // Add parameters to the command
                        cmd.Parameters.Add(":emailID", OracleType.VarChar).Value = emailID;
                        cmd.Parameters.Add(":subscriptionID", OracleType.VarChar).Value = subscriptionID;
                        cmd.Parameters.Add(":startTime", OracleType.VarChar).Value = startTime;
                        cmd.Parameters.Add(":endTime", OracleType.VarChar).Value = endTime;
                        cmd.Parameters.Add(":Sessdate", OracleType.DateTime).Value = date;
                        cmd.Parameters.Add(":instid", OracleType.VarChar).Value = instid;

                        // Execute the command to insert the data
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Session details inserted successfully
                            return 1;
                        }
                        else
                        {
                            // Insertion failed
                            MessageBox.Show("Failed to insert boxing session details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Exception occurred
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }


        private int InsertGymSessionDetails(string emailID, string subscriptionID, string startTime, string endTime, DateTime date, int duration)
            {
                try
                {
                    // Establish connection to the database
                    using (OracleConnection connection = new OracleConnection("Data Source = SohamXlaptop; Persist Security Info = True; User ID = system; Password = student; Unicode = True"))
                    {
                        // Open the connection
                        connection.Open();

                        // Create a new OracleCommand
                        using (OracleCommand cmd = connection.CreateCommand())
                        {
                            // Define the SQL insert statement
                            string sql = "INSERT INTO GYM_SESSION_DETAILS (emailID, g_subscriptionID, g_start_time, g_end_time, g_date, g_no_of_hours) " +
                                         "VALUES (:emailID, :subscriptionID, :startTime, :endTime, :Sessdate, :duration)";

                            // Prepare the OracleCommand with the SQL statement
                            cmd.CommandText = sql;

                            // Add parameters to the command
                            cmd.Parameters.Add(":emailID", OracleType.VarChar).Value = emailID;
                            cmd.Parameters.Add(":subscriptionID", OracleType.VarChar).Value = subscriptionID;
                            cmd.Parameters.Add(":startTime", OracleType.VarChar).Value = startTime;
                            cmd.Parameters.Add(":endTime", OracleType.VarChar).Value = endTime;
                            cmd.Parameters.Add(":Sessdate", OracleType.DateTime).Value = date;
                            cmd.Parameters.Add(":duration", OracleType.Number).Value = duration;

                            // Execute the command to insert the data
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Session details inserted successfully
                                return 1;
                            }
                            else
                            {
                                // Insertion failed
                                MessageBox.Show("Failed to insert session details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return 0;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Exception occurred
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }

            // Other methods and event handlers
        


    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Duration_grpbox_Enter(object sender, EventArgs e)
        {

        }

        private void Sel_start_time_grpbox_Enter(object sender, EventArgs e)
        {

        }

        private void sel_timeslot_grpbox_Enter(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void BookSessionHeading_Click(object sender, EventArgs e)
        {

        }

        private void done_btn_bookSess_Click(object sender, EventArgs e)
        {

            if (Gym_radiobtn.Checked)
            {
                try
                {
                    string emailID = loginPage.email_user; // Replace with actual email ID
                    string subscriptionID = get_gym_subid(emailID); // Replace with actual subscription ID
                    string startTime = numericUpDown1.Value + From_am_pm.Text; // Replace with actual start time
                    string endTime = (numericUpDown1.Value + trackBar1.Value+1).ToString() + From_am_pm.Text; // Replace with actual end time
                    DateTime date = monthCalendar1.SelectionRange.Start; // Replace with actual date
                    int duration = trackBar1.Value+1; // Replace with actual duration in hours
                    if((numericUpDown1.Value + trackBar1.Value)>=10 && From_am_pm.Text == "PM")
                    {
                        MessageBox.Show("End time cannot exceed 10 pm");
                        return;
                    }
                    // Insert session details into the database
                    bool isMaxOccupancyReached = CheckMaxOccupancy(startTime, date, maxOccupancy);

                    if (isMaxOccupancyReached)
                    {
                        MessageBox.Show("Maximum occupancy reached for the selected timeslot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop further execution
                    }
                    int result = InsertGymSessionDetails(emailID, subscriptionID, startTime, endTime, date, duration);

                    if (result == 1)
                    {
                        MessageBox.Show("Session details inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else if (Zumba_Session_Radio.Checked)
            {
                try
                {
                    string emailID = loginPage.email_user; // Replace with actual email ID
                    string subscriptionID = get_zumba_subid(emailID); // Replace with actual subscription ID
                    string timeRange = zumba_time_slots.Text;
                    string[] times = timeRange.Split('-');

                    string startTime = times[0].Trim(); // Start time
                    string endTime = times[1].Trim(); // End time
                    int selectedIndex = zumba_time_slots.SelectedIndex;

                    DateTime date = monthCalendar1.SelectionRange.Start; // Replace with actual date
                    if (get_no_of_instructors() < 6)
                    {
                        if (selectedIndex >= get_no_of_instructors())
                            selectedIndex = ((selectedIndex + 1) % get_no_of_instructors()) - 1;
                    }
                    string instd = get_instructorid(selectedIndex);
                    bool isMaxOccupancyReached = CheckMaxOccupancy(startTime, date, maxOccupancy);

                    if (isMaxOccupancyReached)
                    {
                        MessageBox.Show("Maximum occupancy reached for the selected timeslot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop further execution
                    }
                    int result = InsertZumbaSessionDetails(emailID, subscriptionID, startTime, endTime, date, instd);
                    if (result == 1)
                    {
                        MessageBox.Show("Session details inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }else if (Boxing_Session_rdiobtn.Checked)
            {
                try
                {
                    string emailID = loginPage.email_user; // Replace with actual email ID
                    string subscriptionID = get_box_subid(emailID); // Replace with actual subscription ID
                    string timeRange = zumba_time_slots.Text;
                    string[] times = timeRange.Split('-');

                    string startTime = times[0].Trim(); // Start time
                    string endTime = times[1].Trim(); // End time
                    int selectedIndex = zumba_time_slots.SelectedIndex;

                    DateTime date = monthCalendar1.SelectionRange.Start; // Replace with actual date
                    if (get_no_of_instructors() < 6)
                    {
                        if (selectedIndex >= get_no_of_instructors())
                            selectedIndex = ((selectedIndex + 1) % get_no_of_instructors()) - 1;
                    }
                    string instd = get_instructorid(selectedIndex);
                    bool isMaxOccupancyReached = CheckMaxOccupancyBoxing(startTime, date, maxOccupancy);

                    if (isMaxOccupancyReached)
                    {
                        MessageBox.Show("Maximum occupancy reached for the selected timeslot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop further execution
                    }
                    int result = InsertBoxingSessionDetails(emailID, subscriptionID, startTime, endTime, date, instd);
                    if (result == 1)
                    {
                        MessageBox.Show("Session details inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please select a type of session");
            }

        }

        private void back_btnSessForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gym_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if(Gym_radiobtn.Checked == true)
            {
                Sel_start_time_grpbox.Visible = true;
                monthCalendar1.Visible = true;
                Sel_start_time_grpbox.BringToFront();
                BookSessionHeading.Text = "Selecting Gym Session....";
            }
        }

        private void Boxing_Session_CheckedChanged(object sender, EventArgs e)
        {
            if (Zumba_Session_Radio.Checked == true)
            {
                sel_timeslot_grpbox.Visible = true;
                monthCalendar1.Visible = true;
                sel_timeslot_grpbox.BringToFront();
                BookSessionHeading.Text = "Selecting Zumba Session...";
            }
        }

        private void Boxing_Session_rdiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Boxing_Session_rdiobtn.Checked == true)
            {
                sel_timeslot_grpbox.Visible = true;
                monthCalendar1.Visible = true;
                sel_timeslot_grpbox.BringToFront();
                BookSessionHeading.Text = "Selecting Boxing Session....";
            }
        }

        private void BookSessionMain_Enter(object sender, EventArgs e)
        {

        }

        private void SessionBtn_GrpBox_Enter(object sender, EventArgs e)
        {

        }

        private void No_of_hrs_lbl_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            switch(trackBar1.Value)
            {
                case 0:
                    No_of_hrs_lbl.Text = "1 hour";
                    break;
                case 1:
                    No_of_hrs_lbl.Text = "2 hours";
                    break;
                case 2:
                    No_of_hrs_lbl.Text = "3 hours";
                    break;
                case 3:
                    No_of_hrs_lbl.Text = "4 hours";
                    break;
                case 4:
                    No_of_hrs_lbl.Text = "5 hours";
                    break;
                case 5:
                    No_of_hrs_lbl.Text = "6 hours";
                    break;
            }
        }

        private void Session_starts_lbl_Click(object sender, EventArgs e)
        {

        }

        private void From_am_pm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (From_am_pm.Text == "AM")
            {
                numericUpDown1.Minimum = 6;
                numericUpDown1.Maximum = 11;
            }
            else
            {
                numericUpDown1.Minimum = 2;
                numericUpDown1.Maximum = 9;
            }
        }

        private void sel_slot_lbl_Click(object sender, EventArgs e)
        {

        }

        private void zumba_time_slots_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SessionBookingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
