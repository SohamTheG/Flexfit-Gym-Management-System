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
    public partial class bookedsessionForm : Form
    {
        LoginPage loginPage;
        public bookedsessionForm(LoginPage x)
        {
            InitializeComponent();
            loginPage = x;
        }

        private void Mysess_lbl_mysesspg_Click(object sender, EventArgs e)
        {

        }

        private void Ok_btn_mysesspg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowAllSessions(string emailID)
        {
            try
            {
                string connectionString = "Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True"; 

                // Create the SQL query with nested subqueries to fetch session details from all tables
                string query = @"
                    SELECT emailID, subscriptionID, startTime, endTime, sessionDate, instructorID, sessionType
                    FROM (
                        SELECT emailID, z_subscriptionID AS subscriptionID, z_start_time AS startTime, 
                               z_end_time AS endTime, z_date AS sessionDate, instructorid AS instructorID,
                               'Zumba' AS sessionType
                        FROM ZUMBA_TIMESLOT_DETAILS
                        UNION ALL
                        SELECT emailID, b_subscriptionID AS subscriptionID, b_start_time AS startTime, 
                               b_end_time AS endTime, b_date AS sessionDate, instructorid AS instructorID,
                               'Boxing' AS sessionType
                        FROM BOXING_TIMESLOT_DETAILS
                        UNION ALL
                        SELECT emailID, g_subscriptionID AS subscriptionID, g_start_time AS startTime, 
                               g_end_time AS endTime, g_date AS sessionDate, NULL AS instructorID,
                               'Gym' AS sessionType
                        FROM GYM_SESSION_DETAILS
                    )
                    WHERE emailID = :emailID"; 

                // Create OracleDataAdapter to execute the query and fill the DataTable
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleDataAdapter adapter = new OracleDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.Add(":emailID", OracleType.VarChar).Value = emailID;
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bookedsessionForm_Load(object sender, EventArgs e)
        {
            ShowAllSessions(loginPage.email_user);
        }

    }
}
