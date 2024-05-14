using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_project
{
    public partial class PaymentForm : Form
    {
        
        public PaymentForm(string bill_amt)
        {
            InitializeComponent();
            payment_amt_pay.Text = bill_amt; 

        }

        private void account_no_lbl_pay_Click(object sender, EventArgs e)
        {

        }

        private void acctno_textBox_pay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pin_pay_lbl_Click(object sender, EventArgs e)
        {

        }

        private void pin_textBox_pay_TextChanged(object sender, EventArgs e)
        {

        }

        private void amount_lbl_pay_Click(object sender, EventArgs e)
        {

        }

        private void payment_amt_pay_Click(object sender, EventArgs e)
        {
            
        }

        private void submit_btn_pay_Click(object sender, EventArgs e)
        {
            if(acctno_textBox_pay.Text.Length == 0 || pin_textBox_pay.Text.Length == 0)
            {
                MessageBox.Show("Invalid Field Inputs", "Error");
            }
            else
            {
                MessageBox.Show("purchased successfully!");
                this.Close();
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
