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
    public partial class MySubsriptions : Form
    {
        OracleConnection conn;
        LoginPage loginPage;
        public MySubsriptions(LoginPage lpage)
        {
            InitializeComponent();
            this.loginPage = lpage;
            connect_to_db();
            OracleCommand comm1 = new OracleCommand();
            comm1.Connection = conn;
            comm1.CommandText = "SELECT g_subscriptionID, g_start_date, g_end_date, g_price, g_duration FROM GYM_SUBSCRIPTION_DETAILS WHERE emailID = :emailid";
            comm1.Parameters.Add(":emailid", OracleType.VarChar).Value = loginPage.email_user;
            comm1.CommandType = CommandType.Text;

            // Create OracleDataAdapter with the command
            OracleDataAdapter dataAdapter = new OracleDataAdapter(comm1);

            // Create a DataSet to hold the retrieved data
            DataTable ds = new DataTable();

            // Fill the DataSet with data retrieved by the adapter
            dataAdapter.Fill(ds);

            // Set the DataGridView's DataSource to the DataSet's table
            dataGridView_subs.DataSource = ds;
            dataGridView_subs.RowHeadersVisible = true;

            OracleCommand comm2 = new OracleCommand();
            comm2.Connection = conn;
            comm2.CommandText = "SELECT z_subscriptionID, z_start_date, z_end_date, z_price, z_duration FROM ZUMBA_SUBSCRIPTION_DETAILS WHERE emailID = :emailid";
            comm2.Parameters.Add(":emailid", OracleType.VarChar).Value = loginPage.email_user;
            comm2.CommandType = CommandType.Text;

            // Create OracleDataAdapter with the command
            OracleDataAdapter dataAdapter2 = new OracleDataAdapter(comm2);

            // Create a DataSet to hold the retrieved data
            DataTable ds2 = new DataTable();

            // Fill the DataSet with data retrieved by the adapter
            dataAdapter2.Fill(ds2);

            // Set the DataGridView's DataSource to the DataSet's table
            dataGridzumba.DataSource = ds2;
            dataGridzumba.RowHeadersVisible = true;

            OracleCommand comm3 = new OracleCommand();
            comm3.Connection = conn;
            comm3.CommandText = "SELECT b_subscriptionID, b_start_date, b_end_date, b_price, b_duration FROM BOXING_SUBSCRIPTION_DETAILS WHERE emailID = :emailid";
            comm3.Parameters.Add(":emailid", OracleType.VarChar).Value = loginPage.email_user;
            comm3.CommandType = CommandType.Text;

            // Create OracleDataAdapter with the command
            OracleDataAdapter dataAdapter3 = new OracleDataAdapter(comm3);

            // Create a DataSet to hold the retrieved data
            DataTable ds3 = new DataTable();

            // Fill the DataSet with data retrieved by the adapter
            dataAdapter3.Fill(ds3);

            // Set the DataGridView's DataSource to the DataSet's table
            dataGridboxing.DataSource = ds3;
            dataGridboxing.RowHeadersVisible = true;

            // Close the connection
            conn.Close();
        }
        void connect_to_db()
        {
            string oradb = "Data Source=SohamXlaptop;Persist Security Info=True;User ID=system;Password=student;Unicode=True";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void Mysubs_lbl_mysubpg_Click(object sender, EventArgs e)
        {

        }

        private void Ok_btn_mysubspg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MySubsriptions_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_subs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
