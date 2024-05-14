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
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Establish connection to the database
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create SQL query
                    string sql = @"
                        SELECT g_date, num_sessions_scheduled
                        FROM (
                            SELECT g_date, COUNT(*) AS num_sessions_scheduled
                            FROM GYM_SESSION_DETAILS
                            GROUP BY g_date
                        ) session_counts
                        WHERE num_sessions_scheduled = (
                            SELECT MAX(num_sessions_scheduled)
                            FROM (
                                SELECT COUNT(*) AS num_sessions_scheduled
                                FROM GYM_SESSION_DETAILS
                                GROUP BY g_date
                            ) max_counts
                        )";

                    // Create OracleDataAdapter
                    OracleDataAdapter adapter = new OracleDataAdapter(sql, connection);

                    // Create DataSet
                    DataSet dataSet = new DataSet();

                    // Fill the DataSet with data from OracleDataAdapter
                    adapter.Fill(dataSet);

                    // Set the DataTable as the DataSource for the DataGridView
                    dataGridNO_gym_sess.DataSource = dataSet.Tables[0];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Fetch and display the total revenue generated from Zumba sessions
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
                        // Define the SQL query to get the total revenue generated from Zumba subscriptions
                        string zumbaRevenueQuery = "SELECT SUM(z_price) AS total_zumba_revenue FROM ZUMBA_SUBSCRIPTION_DETAILS";

                        // Prepare the OracleCommand with the SQL statement
                        cmd.CommandText = zumbaRevenueQuery;

                        // Execute the command and retrieve the scalar result
                        object result = cmd.ExecuteScalar();

                        // Check if the result is not null
                        if (result != null && result != DBNull.Value)
                        {
                            // Convert the result to decimal and display it in the label
                            label_rev.Text = $"Total Zumba Revenue: {Convert.ToDecimal(result)}";
                        }
                        else
                        {
                            // If the result is null, display an appropriate message
                            label_rev.Text = "No revenue data available";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                        // Define the SQL query to get the counts of male and female users
                        string genderCountsQuery = @"
                SELECT 
                    SUM(CASE WHEN user_gender = 'Male' THEN 1 ELSE 0 END) AS male_count,
                    SUM(CASE WHEN user_gender = 'Female' THEN 1 ELSE 0 END) AS female_count
                FROM 
                    USER_DETAILS";

                        // Prepare the OracleCommand with the SQL statement
                        cmd.CommandText = genderCountsQuery;

                        // Execute the command and retrieve the data reader
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Create a DataTable to hold the data
                            DataTable dt = new DataTable();

                            // Load the data from the reader into the DataTable
                            dt.Load(reader);

                            // Set the DataTable as the DataSource for the dataGridViewMalevsFemale
                            dataGridViewMalevsFemale.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                // Establish connection to the database
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create SQL query to select all data from INSTRUCTOR_DETAILS table
                    string instructorQuery = "SELECT * FROM INSTRUCTOR_DETAILS";

                    // Create OracleDataAdapter
                    OracleDataAdapter adapter = new OracleDataAdapter(instructorQuery, connection);

                    // Create DataSet
                    DataSet dataSet = new DataSet();

                    // Fill the DataSet with data from OracleDataAdapter
                    adapter.Fill(dataSet);

                    // Set the DataTable as the DataSource for the dataGridViewInstructors
                    dataGridViewInstructors.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                // Establish connection to the database
                using (OracleConnection connection = new OracleConnection("Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create SQL query to select all data from TRAINER table
                    string trainerQuery = "SELECT * FROM TRAINER";

                    // Create OracleDataAdapter
                    OracleDataAdapter adapter = new OracleDataAdapter(trainerQuery, connection);

                    // Create DataSet
                    DataSet dataSet = new DataSet();

                    // Fill the DataSet with data from OracleDataAdapter
                    adapter.Fill(dataSet);

                    // Set the DataTable as the DataSource for the dataGridTrainers
                    dataGridTrainers.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dataGridNO_gym_sess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_rev_Click(object sender, EventArgs e)
        {

        }

        private void male_n_fe_lbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMalevsFemale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelx_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewInstructors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridTrainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labely_Click(object sender, EventArgs e)
        {

        }
    }
}
