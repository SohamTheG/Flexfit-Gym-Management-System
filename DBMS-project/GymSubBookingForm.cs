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
    public partial class GymSubBookingForm : Form
    {
        OracleConnection OracleConnection;
        string connectionString = "Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True";
        LoginPage x;
        int prizegymsub_1M = 2000;
        int prizetrainer_1M = 5000;
        int total_bill_integer;
        int no_of_months_sub;
        int no_of_months_trainer;
        int flag=0;
        public GymSubBookingForm(LoginPage x)
        {
            InitializeComponent();
            this.x = x;
            
        }

        int InsertSubscriptionDetails(string emailID, string subscriptionID, DateTime startDate, int duration, DateTime endDate, int price)
        {
            try
            {
                // Create a new OracleConnection
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();
                    

                    // Create a new OracleCommand
                    using (OracleCommand cmd = connection.CreateCommand())
                    {
                        // Define the SQL insert statement
                        string sql = "INSERT INTO GYM_SUBSCRIPTION_DETAILS (emailID, g_subscriptionID, g_start_date, g_duration, g_end_date, g_price) " +
                                     "VALUES (:emailID, :subscriptionID, :startDate, :duration, :endDate, :price)";

                        // Prepare the OracleCommand with the SQL statement
                        cmd.CommandText = sql;

                        // Add parameters to the command
                        cmd.Parameters.Add(":emailID", OracleType.VarChar).Value = emailID;
                        cmd.Parameters.Add(":subscriptionID", OracleType.VarChar).Value = subscriptionID;
                        cmd.Parameters.Add(":startDate", OracleType.DateTime).Value = startDate;
                        cmd.Parameters.Add(":duration", OracleType.Number).Value = duration;
                        cmd.Parameters.Add(":endDate", OracleType.DateTime).Value = endDate;
                        cmd.Parameters.Add(":price", OracleType.Number).Value = price;
                        
                        // Execute the command to insert the data
                        int rowsAffected = cmd.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            connection.Close();
                            
                            return 1;
                        }
                        else
                        {
                            connection.Close();
                            MessageBox.Show("Failed to insert subscription details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;

            }
        }

        string GetTrainerIDFromDatabase(string trainerName, string trainerGender, int trainerAge)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand cmd = connection.CreateCommand())
                    {
                        // Define the SQL select statement to retrieve trainerID based on name, gender, and age
                        string sql = "SELECT trainerID FROM TRAINER WHERE trainer_name = :trainerName AND trainer_gender = :trainerGender AND trainer_age = :trainerAge";
                        cmd.CommandText = sql;

                        // Add parameters to the command
                        cmd.Parameters.Add(":trainerName", OracleType.VarChar).Value = trainerName;
                        cmd.Parameters.Add(":trainerGender", OracleType.VarChar).Value = trainerGender;
                        cmd.Parameters.Add(":trainerAge", OracleType.Number).Value = trainerAge;

                        // Execute the command to fetch the trainerID
                        object result = cmd.ExecuteScalar();

                        // Check if the result is not null and return the trainerID
                        if (result != null)
                        {
                            connection.Close();
                            return result.ToString();
                        }
                        else
                        {
                            // Trainer not found in the database
                            connection.Close();
                            return null;
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        int add_trainer_has_tbl(string subscriptionID)
        {
            try
            {
                bool trainerFound = false;

                // Iterate through the panel's controls to find the selected radio button
                foreach (Control control in panel1.Controls)
                {
                    if (control is RadioButton radioButton && radioButton.Checked)
                    {
                        trainerFound = true;
                        // Extract trainer details from the selected radio button's text
                        string[] trainerDetails = radioButton.Text.Trim().Split(',');
                        string trainerName = trainerDetails[0].Trim();
                        string trainerGender = trainerDetails[1].Trim();
                        int trainerAge = int.Parse(trainerDetails[2].Trim());

                        if (no_of_months_trainer > no_of_months_sub)
                        {
                            MessageBox.Show("Trainer duration cannot exceed subscription duration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }

                        // Here, you need to obtain the trainerID. 
                        // It could be retrieved from your database based on the trainer's name, gender, and age.
                        string trainerID = GetTrainerIDFromDatabase(trainerName, trainerGender, trainerAge);

                        // If trainerID is null, it means the trainer doesn't exist in the database.
                        if (trainerID == null)
                        {

                            MessageBox.Show("Trainer not found in the database. Please select a valid trainer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }

                        // Insert the subscription-trainer mapping into the GYM_SUBSCRIPTION_HAS_TRAINER table
                        using (OracleConnection connection = new OracleConnection(connectionString))
                        {
                            connection.Open();
                            using (OracleCommand cmd = connection.CreateCommand())
                            {
                                string sql = "INSERT INTO GYM_SUBSCRIPTION_HAS_TRAINER (g_subscriptionID, trainerID) " +
                                             "VALUES (:subscriptionID, :trainerID)";
                                cmd.CommandText = sql;
                                cmd.Parameters.Add(":subscriptionID", OracleType.VarChar).Value = subscriptionID;
                                cmd.Parameters.Add(":trainerID", OracleType.VarChar).Value = trainerID;
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    connection.Close();
                                    MessageBox.Show("Trainer assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return 1;
                                }
                                else
                                {
                                    connection.Close();
                                    MessageBox.Show("Failed to assign trainer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return 0;
                                }
                            }
                        }
                    }
                }

                // If no radio button is selected
                if (!trainerFound)
                {
                    MessageBox.Show("Please select a trainer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }


        void update_price()
        {
            if (trainer_or_no_rdiobtn.Checked == false)
            {
                cal_no_of_months_trainer();
                calc_no_of_months_sub();
                trainer_price.Text = "0 Rs."; 
                total_bill_integer = prizegymsub_1M * no_of_months_sub;
                Gym_price.Text = total_bill_integer + " Rs.";
                total_bill.Text = total_bill_integer + " Rs.";
            }
            else 
            {
                cal_no_of_months_trainer();
                calc_no_of_months_sub();
                trainer_price.Text = no_of_months_trainer * prizetrainer_1M + " Rs.";
                Gym_price.Text = no_of_months_sub * prizegymsub_1M + " Rs.";
                total_bill_integer = no_of_months_sub * prizegymsub_1M + no_of_months_trainer * prizetrainer_1M;
                total_bill.Text = total_bill_integer + " Rs.";
            }
        }


        void calc_no_of_months_sub()
        {
            if(GymSubDurationTrackbr.Value == 0)
            {
                no_of_months_lbl_gymbook.Text = "1 Month";
                no_of_months_sub = 1;
            }
            else
            {
                no_of_months_lbl_gymbook.Text = GymSubDurationTrackbr.Value * 3 + " Months";
                no_of_months_sub = GymSubDurationTrackbr.Value * 3;
            }
            
        }
        void cal_no_of_months_trainer()
        {
            if (gymtrainerDurationTrackbr.Value == 0)
            {
                trainer_duration_lbl.Text = "1 Month";
                no_of_months_trainer = 1;
            }
            else
            {
                trainer_duration_lbl.Text = gymtrainerDurationTrackbr.Value * 3 + " Months";
                no_of_months_trainer = gymtrainerDurationTrackbr.Value * 3;
            }
        }

        private void trainer_or_no_rdiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if(trainer_or_no_rdiobtn.Checked == true)
            {
                Gym_trainers_sel_grpbox.Visible = true;
                update_price();
            }
            if(trainer_or_no_rdiobtn.Checked == false)
            {
                Gym_trainers_sel_grpbox.Visible = false;
                update_price();
            }
        }

        void add_gym_trainer_control(string trainer_gen,string trainer_nm,int trainer_ag) //use this to add new gym trainers
        {
            try
            { 
                RadioButton newRadioButton = new RadioButton();

                newRadioButton.Text = "        " + trainer_nm + " ," +trainer_gen + " ," + trainer_ag.ToString();
                newRadioButton.ForeColor = Color.Black;
                newRadioButton.Checked = GymTrainerradbtn1.Checked;
                newRadioButton.Font = GymTrainerradbtn1.Font;
                newRadioButton.BackColor = Color.White;
                newRadioButton.Size = GymTrainerradbtn1.Size;
                newRadioButton.Enabled = GymTrainerradbtn1.Enabled;
                newRadioButton.Image = GymTrainerradbtn1.Image;
                newRadioButton.ImageAlign = GymTrainerradbtn1.ImageAlign;
                newRadioButton.TextImageRelation = GymTrainerradbtn1.TextImageRelation;



                int spacing = 10; 
                int newY = panel1.Controls.Count > 0 ? panel1.Controls[panel1.Controls.Count - 1].Bottom + spacing : 0;
                newRadioButton.Location = new Point(GymTrainerradbtn1.Location.X, newY);
                
                newRadioButton.Appearance = GymTrainerradbtn1.Appearance;

                panel1.Controls.Add(newRadioButton);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static string GenerateSubscriptionID()
        {
            // Generate a random part
            Random rand = new Random();
            string randomPart = rand.Next(1000, 10000).ToString(); // Random 4-digit number

            // Combine parts to create the subscription ID
            string subscriptionID = "G" + randomPart;
            return subscriptionID;
        }


        private void Gym_trainers_sel_grpbox_Enter(object sender, EventArgs e)
        {

        }

        private void Facilities_info_grpbox_GymBook_Enter(object sender, EventArgs e)
        {

        }

        private void abc_Click(object sender, EventArgs e)
        {

        }

        private void groupbox_sele_gym_book_Enter(object sender, EventArgs e)
        {

        }

        private void Sel_date_gym_book_lbl_Click(object sender, EventArgs e)
        {

        }

        private void sel_date_gymbook_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Sel_duration_lbl_Gym_book_Click(object sender, EventArgs e)
        {

        }

        private void GymSubDurationTrackbr_Scroll(object sender, EventArgs e)
        {
            calc_no_of_months_sub();
            update_price();
        }

        private void no_of_months_lbl_gymbook_Click(object sender, EventArgs e)
        {
            
        }

        private void GymTrainerradbtn1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GymTrainerradbtn2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GymTrainerradbtn3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GymTrainerradbtn4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Current_price_lb_gymbook_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailID = x.email_user; // You need to provide this value
            string subscriptionID = GenerateSubscriptionID(); // You need to provide this value
            DateTime startDate = sel_date_gymbook.SelectionStart; // You need to provide this value
            int duration = Convert.ToInt32(no_of_months_sub); // Assuming you have a trackbar for duration selection
            DateTime endDate = startDate.AddMonths(duration); // Calculate end date based on start date and duration
            int price = Convert.ToInt32(total_bill_integer); // Assuming you calculate the total price somewhere

            if (no_of_months_trainer > no_of_months_sub)
            {
                MessageBox.Show("Trainer duration cannot exceed subscription duration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { flag = InsertSubscriptionDetails(emailID, subscriptionID, startDate, duration, endDate, price); }

            

            if (flag == 1)
            {
                // Subscription details inserted successfully

                if (trainer_or_no_rdiobtn.Checked)
                {
                    // Check if any trainer radio button is checked
                    bool trainerSelected = panel1.Controls.OfType<RadioButton>().Any(r => r.Checked);
                    if (!trainerSelected)
                    {
                        MessageBox.Show("Please select a trainer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        // Add trainer details
                        flag = add_trainer_has_tbl(subscriptionID);
                    }
                }

                if (flag == 1)
                {
                    // Operation successful, proceed to payment
                    PaymentForm form1 = new PaymentForm(total_bill.Text);
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Failed to complete the operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to insert subscription details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void trainer_price_Click(object sender, EventArgs e)
        {
            
        }

        private void Trainer_price_lbl_gymbook_Click(object sender, EventArgs e)
        {

        }

        private void GymSubBookingForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Create a new OracleConnection
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new OracleCommand
                    using (OracleCommand cmd = connection.CreateCommand())
                    {
                        // Define the SQL select statement
                        string sql = "SELECT trainer_name, trainer_age , trainer_gender FROM TRAINER";

                        // Prepare the OracleCommand with the SQL statement
                        cmd.CommandText = sql;

                        // Execute the command to fetch the data
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if there are rows returned
                            if (reader.HasRows)
                            {
                                // Iterate over the rows
                                while (reader.Read())
                                {
                                    // Get the trainer details
                                    string trainerGend = reader.GetString(2);
                                    string trainerName = reader.GetString(0);
                                    int trainerAge = reader.GetInt32(1);


                                    // Add a radio button for each trainer
                                    add_gym_trainer_control(trainerGend, trainerName,trainerAge);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception to console or a log file
                Console.WriteLine("Error in GymSubBookingForm_Load: " + ex.ToString());
                MessageBox.Show("An error occurred while loading trainers. Please check the log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sel_dur_t_lbl_gymbook_Click(object sender, EventArgs e)
        {

        }

        private void gymtrainerDurationTrackbr_Scroll(object sender, EventArgs e)
        {
            cal_no_of_months_trainer();
            update_price();
        }

        private void trainer_duration_lbl_Click(object sender, EventArgs e)
        {

        }

        private void plus_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Gym_price_Click(object sender, EventArgs e)
        {

        }

        private void yes_or_no_main_lbl_Click(object sender, EventArgs e)
        {

        }

        private void no_trainer_lbl_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Back_bt_gymbook_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void samplegrpbox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void hmm_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
