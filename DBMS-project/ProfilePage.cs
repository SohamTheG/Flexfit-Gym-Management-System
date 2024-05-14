using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_project
{
    public partial class ProfilePage : Form
    {
        private HomePage homePage; // Add a reference to HomePage
        private LoginPage xyz;

        public ProfilePage(HomePage homePage,LoginPage xyz)
        {
            InitializeComponent();
            this.homePage = homePage; // Store the reference to HomePage
            this.xyz = xyz;
            name_here_profpg.Text = xyz.first_name_user+" " + xyz.middle_name_user + " " + xyz.last_name_user;
            phoneno_here_profpage.Text = xyz.phonenumber_user;
            address_here_profpg.Text=xyz.address_user;
            gender_here_profpg.Text = xyz.user_gender;
            age_here_profpg.Text = xyz.age.ToString();
            dob_here_profpg.Text = xyz.DOB_user.Remove(11);
            email_here_profpg.Text =(xyz.email_user);
        }

        private void back_btn_profilepg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void name_profpg_lbl_Click(object sender, EventArgs e)
        {

        }

        private void name_here_profpg_Click(object sender, EventArgs e)
        {

        }

        private void Age_profpg_lbl_Click(object sender, EventArgs e)
        {

        }

        private void age_here_profpg_Click(object sender, EventArgs e)
        {

        }

        private void Phone_no_profpg_lbl_Click(object sender, EventArgs e)
        {

        }

        private void phoneno_here_profpage_Click(object sender, EventArgs e)
        {

        }

        private void address_lbl_profpg_Click(object sender, EventArgs e)
        {

        }

        private void address_here_profpg_Click(object sender, EventArgs e)
        {

        }

        private void profile_activites_grpbox_Enter(object sender, EventArgs e)
        {

        }

        private void payment_hist_btn_profpg_Click(object sender, EventArgs e)
        {
            payment_history payment_Hist = new payment_history();
            payment_Hist.Show();
        }

        private void my_curr_sess_btn_profpg_Click(object sender, EventArgs e)
        {
            bookedsessionForm bs = new bookedsessionForm(xyz);
            bs.Show();
        }

        private void Change_passwrd_btn_profpg_Click(object sender, EventArgs e)
        {
            ChangePassForm xfrm = new ChangePassForm();
            xfrm.Show();
        }

        private void show_sub_btn_profpg_Click(object sender, EventArgs e)
        {
            MySubsriptions mySubsriptions = new MySubsriptions(xyz);
            mySubsriptions.Show();
        }

        private void gender_here_profpg_Click(object sender, EventArgs e)
        {

        }

        private void Gender_profpg_lbl_Click(object sender, EventArgs e)
        {

        }

        private void email_here_profpg_Click(object sender, EventArgs e)
        {

        }

        private void email_profpg_lbl_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_profpg_Click(object sender, EventArgs e)
        {
            
            
                // Close both the current profile page and home page forms
                this.Close();
                homePage.Close();

                // Show the login page form
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
            
        }

        private void DOB_lbl_profpg_Click(object sender, EventArgs e)
        {

        }

        private void dob_here_profpg_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {

        }
    }
}
