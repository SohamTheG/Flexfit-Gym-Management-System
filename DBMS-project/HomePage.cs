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
    public partial class HomePage : Form
    {
        LoginPage f1;
        public HomePage(LoginPage parentForm)
        {
            InitializeComponent();
            f1 = parentForm;
          
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void optionsbtn_homepg_Click(object sender, EventArgs e)
        {
           optionspanel_homepg.Visible = true;
           optionspanel_homepg.BringToFront();
        }

        private void just_img_homepg_Click(object sender, EventArgs e)
        {

        }

        private void My_prof_btn_homepg_Click(object sender, EventArgs e)
        {
            ProfilePage form1 = new ProfilePage(this, f1);
            form1.Show();
        }

        private void BookSessionBtn_homepg_Click(object sender, EventArgs e)
        {
            SessionBookingForm form1 = new SessionBookingForm(f1);
            form1.Show();
        }

        private void About_us_section_btn_Click(object sender, EventArgs e)
        {
            AboutUsForm form1 = new AboutUsForm();
            form1.Show();
        }

        private void back_btn_dashboard_homepg_Click(object sender, EventArgs e)
        {
            optionspanel_homepg.Visible = false;
        }

        private void main_img_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buy_zumba_sub_btn_homepg_Click(object sender, EventArgs e)
        {
            ZumbaSubBookingForm form1 =new ZumbaSubBookingForm(f1);
            form1.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GymSubBookingForm form1 =new GymSubBookingForm(f1);   form1.Show();
        }

        private void buy_boxing_sub_homepg_btn_Click(object sender, EventArgs e)
        {
            BoxingSubBookingForm form1 =new BoxingSubBookingForm(f1); form1.Show();

        }
    }
}
