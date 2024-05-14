namespace DBMS_project
{
    partial class GymSubBookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymSubBookingForm));
            this.Back_bt_gymbook = new System.Windows.Forms.Button();
            this.sel_date_gymbook = new System.Windows.Forms.MonthCalendar();
            this.GymSubDurationTrackbr = new System.Windows.Forms.TrackBar();
            this.trainer_or_no_rdiobtn = new System.Windows.Forms.RadioButton();
            this.Sel_date_gym_book_lbl = new System.Windows.Forms.Label();
            this.Sel_duration_lbl_Gym_book = new System.Windows.Forms.Label();
            this.no_of_months_lbl_gymbook = new System.Windows.Forms.Label();
            this.Current_price_lb_gymbook = new System.Windows.Forms.Label();
            this.total_bill = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupbox_sele_gym_book = new System.Windows.Forms.GroupBox();
            this.no_trainer_lbl = new System.Windows.Forms.RadioButton();
            this.yes_or_no_main_lbl = new System.Windows.Forms.Label();
            this.Facilities_info_grpbox_GymBook = new System.Windows.Forms.GroupBox();
            this.Gym_trainers_sel_grpbox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GymTrainerradbtn1 = new System.Windows.Forms.RadioButton();
            this.trainer_duration_lbl = new System.Windows.Forms.Label();
            this.gymtrainerDurationTrackbr = new System.Windows.Forms.TrackBar();
            this.sel_dur_t_lbl_gymbook = new System.Windows.Forms.Label();
            this.Trainer_price_lbl_gymbook = new System.Windows.Forms.Label();
            this.trainer_price = new System.Windows.Forms.Label();
            this.Gym_price = new System.Windows.Forms.Label();
            this.plus_lbl = new System.Windows.Forms.Label();
            this.hmm_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GymSubDurationTrackbr)).BeginInit();
            this.groupbox_sele_gym_book.SuspendLayout();
            this.Facilities_info_grpbox_GymBook.SuspendLayout();
            this.Gym_trainers_sel_grpbox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gymtrainerDurationTrackbr)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_bt_gymbook
            // 
            this.Back_bt_gymbook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back_bt_gymbook.Location = new System.Drawing.Point(12, 12);
            this.Back_bt_gymbook.Name = "Back_bt_gymbook";
            this.Back_bt_gymbook.Size = new System.Drawing.Size(80, 26);
            this.Back_bt_gymbook.TabIndex = 0;
            this.Back_bt_gymbook.Text = "Back";
            this.Back_bt_gymbook.UseVisualStyleBackColor = false;
            this.Back_bt_gymbook.Click += new System.EventHandler(this.Back_bt_gymbook_Click);
            // 
            // sel_date_gymbook
            // 
            this.sel_date_gymbook.Location = new System.Drawing.Point(21, 43);
            this.sel_date_gymbook.Name = "sel_date_gymbook";
            this.sel_date_gymbook.TabIndex = 1;
            this.sel_date_gymbook.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.sel_date_gymbook_DateChanged);
            // 
            // GymSubDurationTrackbr
            // 
            this.GymSubDurationTrackbr.Location = new System.Drawing.Point(21, 233);
            this.GymSubDurationTrackbr.Maximum = 4;
            this.GymSubDurationTrackbr.Name = "GymSubDurationTrackbr";
            this.GymSubDurationTrackbr.Size = new System.Drawing.Size(240, 45);
            this.GymSubDurationTrackbr.TabIndex = 2;
            this.GymSubDurationTrackbr.Scroll += new System.EventHandler(this.GymSubDurationTrackbr_Scroll);
            // 
            // trainer_or_no_rdiobtn
            // 
            this.trainer_or_no_rdiobtn.AutoSize = true;
            this.trainer_or_no_rdiobtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trainer_or_no_rdiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainer_or_no_rdiobtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trainer_or_no_rdiobtn.Location = new System.Drawing.Point(198, 306);
            this.trainer_or_no_rdiobtn.Name = "trainer_or_no_rdiobtn";
            this.trainer_or_no_rdiobtn.Size = new System.Drawing.Size(50, 20);
            this.trainer_or_no_rdiobtn.TabIndex = 3;
            this.trainer_or_no_rdiobtn.TabStop = true;
            this.trainer_or_no_rdiobtn.Text = "yes";
            this.trainer_or_no_rdiobtn.UseVisualStyleBackColor = false;
            this.trainer_or_no_rdiobtn.CheckedChanged += new System.EventHandler(this.trainer_or_no_rdiobtn_CheckedChanged);
            // 
            // Sel_date_gym_book_lbl
            // 
            this.Sel_date_gym_book_lbl.AutoSize = true;
            this.Sel_date_gym_book_lbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sel_date_gym_book_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sel_date_gym_book_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sel_date_gym_book_lbl.Location = new System.Drawing.Point(18, 18);
            this.Sel_date_gym_book_lbl.Name = "Sel_date_gym_book_lbl";
            this.Sel_date_gym_book_lbl.Size = new System.Drawing.Size(92, 16);
            this.Sel_date_gym_book_lbl.TabIndex = 4;
            this.Sel_date_gym_book_lbl.Text = "Select Date:";
            this.Sel_date_gym_book_lbl.Click += new System.EventHandler(this.Sel_date_gym_book_lbl_Click);
            // 
            // Sel_duration_lbl_Gym_book
            // 
            this.Sel_duration_lbl_Gym_book.AutoSize = true;
            this.Sel_duration_lbl_Gym_book.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sel_duration_lbl_Gym_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sel_duration_lbl_Gym_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sel_duration_lbl_Gym_book.Location = new System.Drawing.Point(18, 214);
            this.Sel_duration_lbl_Gym_book.Name = "Sel_duration_lbl_Gym_book";
            this.Sel_duration_lbl_Gym_book.Size = new System.Drawing.Size(117, 16);
            this.Sel_duration_lbl_Gym_book.TabIndex = 5;
            this.Sel_duration_lbl_Gym_book.Text = "Select Duration:";
            this.Sel_duration_lbl_Gym_book.Click += new System.EventHandler(this.Sel_duration_lbl_Gym_book_Click);
            // 
            // no_of_months_lbl_gymbook
            // 
            this.no_of_months_lbl_gymbook.AutoSize = true;
            this.no_of_months_lbl_gymbook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no_of_months_lbl_gymbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_months_lbl_gymbook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.no_of_months_lbl_gymbook.Location = new System.Drawing.Point(114, 281);
            this.no_of_months_lbl_gymbook.Name = "no_of_months_lbl_gymbook";
            this.no_of_months_lbl_gymbook.Size = new System.Drawing.Size(60, 16);
            this.no_of_months_lbl_gymbook.TabIndex = 6;
            this.no_of_months_lbl_gymbook.Text = "1 Month";
            this.no_of_months_lbl_gymbook.Click += new System.EventHandler(this.no_of_months_lbl_gymbook_Click);
            // 
            // Current_price_lb_gymbook
            // 
            this.Current_price_lb_gymbook.AutoSize = true;
            this.Current_price_lb_gymbook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Current_price_lb_gymbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_price_lb_gymbook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Current_price_lb_gymbook.Location = new System.Drawing.Point(332, 416);
            this.Current_price_lb_gymbook.Name = "Current_price_lb_gymbook";
            this.Current_price_lb_gymbook.Size = new System.Drawing.Size(172, 16);
            this.Current_price_lb_gymbook.TabIndex = 7;
            this.Current_price_lb_gymbook.Text = "Gym Subscription Price:";
            this.Current_price_lb_gymbook.Click += new System.EventHandler(this.Current_price_lb_gymbook_Click);
            // 
            // total_bill
            // 
            this.total_bill.AutoSize = true;
            this.total_bill.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.total_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_bill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.total_bill.Location = new System.Drawing.Point(609, 416);
            this.total_bill.Name = "total_bill";
            this.total_bill.Size = new System.Drawing.Size(66, 16);
            this.total_bill.TabIndex = 8;
            this.total_bill.Text = "2000 Rs.";
            this.total_bill.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(681, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupbox_sele_gym_book
            // 
            this.groupbox_sele_gym_book.Controls.Add(this.no_trainer_lbl);
            this.groupbox_sele_gym_book.Controls.Add(this.yes_or_no_main_lbl);
            this.groupbox_sele_gym_book.Controls.Add(this.no_of_months_lbl_gymbook);
            this.groupbox_sele_gym_book.Controls.Add(this.Sel_duration_lbl_Gym_book);
            this.groupbox_sele_gym_book.Controls.Add(this.Sel_date_gym_book_lbl);
            this.groupbox_sele_gym_book.Controls.Add(this.trainer_or_no_rdiobtn);
            this.groupbox_sele_gym_book.Controls.Add(this.GymSubDurationTrackbr);
            this.groupbox_sele_gym_book.Controls.Add(this.sel_date_gymbook);
            this.groupbox_sele_gym_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_sele_gym_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupbox_sele_gym_book.Location = new System.Drawing.Point(245, 44);
            this.groupbox_sele_gym_book.Name = "groupbox_sele_gym_book";
            this.groupbox_sele_gym_book.Size = new System.Drawing.Size(272, 354);
            this.groupbox_sele_gym_book.TabIndex = 11;
            this.groupbox_sele_gym_book.TabStop = false;
            this.groupbox_sele_gym_book.Text = "Provide Details Here";
            this.groupbox_sele_gym_book.Enter += new System.EventHandler(this.groupbox_sele_gym_book_Enter);
            // 
            // no_trainer_lbl
            // 
            this.no_trainer_lbl.AutoSize = true;
            this.no_trainer_lbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.no_trainer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_trainer_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.no_trainer_lbl.Location = new System.Drawing.Point(198, 327);
            this.no_trainer_lbl.Name = "no_trainer_lbl";
            this.no_trainer_lbl.Size = new System.Drawing.Size(42, 20);
            this.no_trainer_lbl.TabIndex = 18;
            this.no_trainer_lbl.TabStop = true;
            this.no_trainer_lbl.Text = "no";
            this.no_trainer_lbl.UseVisualStyleBackColor = false;
            this.no_trainer_lbl.CheckedChanged += new System.EventHandler(this.no_trainer_lbl_CheckedChanged);
            // 
            // yes_or_no_main_lbl
            // 
            this.yes_or_no_main_lbl.AutoSize = true;
            this.yes_or_no_main_lbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yes_or_no_main_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_or_no_main_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yes_or_no_main_lbl.Location = new System.Drawing.Point(6, 310);
            this.yes_or_no_main_lbl.Name = "yes_or_no_main_lbl";
            this.yes_or_no_main_lbl.Size = new System.Drawing.Size(164, 16);
            this.yes_or_no_main_lbl.TabIndex = 17;
            this.yes_or_no_main_lbl.Text = "Do you want a trainer ?";
            this.yes_or_no_main_lbl.Click += new System.EventHandler(this.yes_or_no_main_lbl_Click);
            // 
            // Facilities_info_grpbox_GymBook
            // 
            this.Facilities_info_grpbox_GymBook.Controls.Add(this.hmm_lbl);
            this.Facilities_info_grpbox_GymBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facilities_info_grpbox_GymBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Facilities_info_grpbox_GymBook.Location = new System.Drawing.Point(12, 44);
            this.Facilities_info_grpbox_GymBook.Name = "Facilities_info_grpbox_GymBook";
            this.Facilities_info_grpbox_GymBook.Size = new System.Drawing.Size(227, 353);
            this.Facilities_info_grpbox_GymBook.TabIndex = 12;
            this.Facilities_info_grpbox_GymBook.TabStop = false;
            this.Facilities_info_grpbox_GymBook.Text = "Facilities";
            this.Facilities_info_grpbox_GymBook.Enter += new System.EventHandler(this.Facilities_info_grpbox_GymBook_Enter);
            // 
            // Gym_trainers_sel_grpbox
            // 
            this.Gym_trainers_sel_grpbox.Controls.Add(this.panel1);
            this.Gym_trainers_sel_grpbox.Controls.Add(this.trainer_duration_lbl);
            this.Gym_trainers_sel_grpbox.Controls.Add(this.gymtrainerDurationTrackbr);
            this.Gym_trainers_sel_grpbox.Controls.Add(this.sel_dur_t_lbl_gymbook);
            this.Gym_trainers_sel_grpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gym_trainers_sel_grpbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gym_trainers_sel_grpbox.Location = new System.Drawing.Point(523, 44);
            this.Gym_trainers_sel_grpbox.Name = "Gym_trainers_sel_grpbox";
            this.Gym_trainers_sel_grpbox.Size = new System.Drawing.Size(253, 354);
            this.Gym_trainers_sel_grpbox.TabIndex = 13;
            this.Gym_trainers_sel_grpbox.TabStop = false;
            this.Gym_trainers_sel_grpbox.Text = "Select Your Gym Trainer";
            this.Gym_trainers_sel_grpbox.Visible = false;
            this.Gym_trainers_sel_grpbox.Enter += new System.EventHandler(this.Gym_trainers_sel_grpbox_Enter);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GymTrainerradbtn1);
            this.panel1.Location = new System.Drawing.Point(23, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 210);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Our Trainers :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // GymTrainerradbtn1
            // 
            this.GymTrainerradbtn1.Appearance = System.Windows.Forms.Appearance.Button;
            this.GymTrainerradbtn1.AutoSize = true;
            this.GymTrainerradbtn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GymTrainerradbtn1.Image = ((System.Drawing.Image)(resources.GetObject("GymTrainerradbtn1.Image")));
            this.GymTrainerradbtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GymTrainerradbtn1.Location = new System.Drawing.Point(19, 9);
            this.GymTrainerradbtn1.MinimumSize = new System.Drawing.Size(100, 50);
            this.GymTrainerradbtn1.Name = "GymTrainerradbtn1";
            this.GymTrainerradbtn1.Size = new System.Drawing.Size(174, 50);
            this.GymTrainerradbtn1.TabIndex = 0;
            this.GymTrainerradbtn1.Text = "        Stacy Wisconsin, 28, F";
            this.GymTrainerradbtn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GymTrainerradbtn1.UseVisualStyleBackColor = true;
            this.GymTrainerradbtn1.Visible = false;
            this.GymTrainerradbtn1.CheckedChanged += new System.EventHandler(this.GymTrainerradbtn1_CheckedChanged);
            // 
            // trainer_duration_lbl
            // 
            this.trainer_duration_lbl.AutoSize = true;
            this.trainer_duration_lbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trainer_duration_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainer_duration_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trainer_duration_lbl.Location = new System.Drawing.Point(92, 329);
            this.trainer_duration_lbl.Name = "trainer_duration_lbl";
            this.trainer_duration_lbl.Size = new System.Drawing.Size(60, 16);
            this.trainer_duration_lbl.TabIndex = 9;
            this.trainer_duration_lbl.Text = "1 Month";
            this.trainer_duration_lbl.Click += new System.EventHandler(this.trainer_duration_lbl_Click);
            // 
            // gymtrainerDurationTrackbr
            // 
            this.gymtrainerDurationTrackbr.Location = new System.Drawing.Point(6, 281);
            this.gymtrainerDurationTrackbr.Maximum = 4;
            this.gymtrainerDurationTrackbr.Name = "gymtrainerDurationTrackbr";
            this.gymtrainerDurationTrackbr.Size = new System.Drawing.Size(240, 45);
            this.gymtrainerDurationTrackbr.TabIndex = 7;
            this.gymtrainerDurationTrackbr.Scroll += new System.EventHandler(this.gymtrainerDurationTrackbr_Scroll);
            // 
            // sel_dur_t_lbl_gymbook
            // 
            this.sel_dur_t_lbl_gymbook.AutoSize = true;
            this.sel_dur_t_lbl_gymbook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sel_dur_t_lbl_gymbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_dur_t_lbl_gymbook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sel_dur_t_lbl_gymbook.Location = new System.Drawing.Point(4, 262);
            this.sel_dur_t_lbl_gymbook.Name = "sel_dur_t_lbl_gymbook";
            this.sel_dur_t_lbl_gymbook.Size = new System.Drawing.Size(117, 16);
            this.sel_dur_t_lbl_gymbook.TabIndex = 8;
            this.sel_dur_t_lbl_gymbook.Text = "Select Duration:";
            this.sel_dur_t_lbl_gymbook.Click += new System.EventHandler(this.sel_dur_t_lbl_gymbook_Click);
            // 
            // Trainer_price_lbl_gymbook
            // 
            this.Trainer_price_lbl_gymbook.AutoSize = true;
            this.Trainer_price_lbl_gymbook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Trainer_price_lbl_gymbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trainer_price_lbl_gymbook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Trainer_price_lbl_gymbook.Location = new System.Drawing.Point(122, 416);
            this.Trainer_price_lbl_gymbook.Name = "Trainer_price_lbl_gymbook";
            this.Trainer_price_lbl_gymbook.Size = new System.Drawing.Size(101, 16);
            this.Trainer_price_lbl_gymbook.TabIndex = 14;
            this.Trainer_price_lbl_gymbook.Text = "Trainer Price:";
            this.Trainer_price_lbl_gymbook.Click += new System.EventHandler(this.Trainer_price_lbl_gymbook_Click);
            // 
            // trainer_price
            // 
            this.trainer_price.AutoSize = true;
            this.trainer_price.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trainer_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainer_price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trainer_price.Location = new System.Drawing.Point(229, 416);
            this.trainer_price.Name = "trainer_price";
            this.trainer_price.Size = new System.Drawing.Size(42, 16);
            this.trainer_price.TabIndex = 14;
            this.trainer_price.Text = "0 Rs.";
            this.trainer_price.Click += new System.EventHandler(this.trainer_price_Click);
            // 
            // Gym_price
            // 
            this.Gym_price.AutoSize = true;
            this.Gym_price.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gym_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gym_price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gym_price.Location = new System.Drawing.Point(510, 416);
            this.Gym_price.Name = "Gym_price";
            this.Gym_price.Size = new System.Drawing.Size(66, 16);
            this.Gym_price.TabIndex = 15;
            this.Gym_price.Text = "2000 Rs.";
            this.Gym_price.Click += new System.EventHandler(this.Gym_price_Click);
            // 
            // plus_lbl
            // 
            this.plus_lbl.AutoSize = true;
            this.plus_lbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plus_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plus_lbl.Location = new System.Drawing.Point(300, 416);
            this.plus_lbl.Name = "plus_lbl";
            this.plus_lbl.Size = new System.Drawing.Size(15, 16);
            this.plus_lbl.TabIndex = 16;
            this.plus_lbl.Text = "+";
            this.plus_lbl.Click += new System.EventHandler(this.plus_lbl_Click);
            // 
            // hmm_lbl
            // 
            this.hmm_lbl.AutoSize = true;
            this.hmm_lbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hmm_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmm_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hmm_lbl.Location = new System.Drawing.Point(19, 32);
            this.hmm_lbl.MaximumSize = new System.Drawing.Size(200, 800);
            this.hmm_lbl.Name = "hmm_lbl";
            this.hmm_lbl.Size = new System.Drawing.Size(188, 288);
            this.hmm_lbl.TabIndex = 11;
            this.hmm_lbl.Text = resources.GetString("hmm_lbl.Text");
            this.hmm_lbl.Click += new System.EventHandler(this.hmm_lbl_Click);
            // 
            // GymSubBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.plus_lbl);
            this.Controls.Add(this.Gym_price);
            this.Controls.Add(this.trainer_price);
            this.Controls.Add(this.Gym_trainers_sel_grpbox);
            this.Controls.Add(this.Trainer_price_lbl_gymbook);
            this.Controls.Add(this.Facilities_info_grpbox_GymBook);
            this.Controls.Add(this.groupbox_sele_gym_book);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.total_bill);
            this.Controls.Add(this.Current_price_lb_gymbook);
            this.Controls.Add(this.Back_bt_gymbook);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "GymSubBookingForm";
            this.Text = "GymSubBookingForm";
            this.Load += new System.EventHandler(this.GymSubBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GymSubDurationTrackbr)).EndInit();
            this.groupbox_sele_gym_book.ResumeLayout(false);
            this.groupbox_sele_gym_book.PerformLayout();
            this.Facilities_info_grpbox_GymBook.ResumeLayout(false);
            this.Facilities_info_grpbox_GymBook.PerformLayout();
            this.Gym_trainers_sel_grpbox.ResumeLayout(false);
            this.Gym_trainers_sel_grpbox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gymtrainerDurationTrackbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_bt_gymbook;
        private System.Windows.Forms.MonthCalendar sel_date_gymbook;
        private System.Windows.Forms.TrackBar GymSubDurationTrackbr;
        private System.Windows.Forms.RadioButton trainer_or_no_rdiobtn;
        private System.Windows.Forms.Label Sel_date_gym_book_lbl;
        private System.Windows.Forms.Label Sel_duration_lbl_Gym_book;
        private System.Windows.Forms.Label no_of_months_lbl_gymbook;
        private System.Windows.Forms.Label Current_price_lb_gymbook;
        private System.Windows.Forms.Label total_bill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupbox_sele_gym_book;
        private System.Windows.Forms.GroupBox Facilities_info_grpbox_GymBook;
        private System.Windows.Forms.GroupBox Gym_trainers_sel_grpbox;
        private System.Windows.Forms.Label trainer_price;
        private System.Windows.Forms.Label Trainer_price_lbl_gymbook;
        private System.Windows.Forms.Label trainer_duration_lbl;
        private System.Windows.Forms.TrackBar gymtrainerDurationTrackbr;
        private System.Windows.Forms.Label sel_dur_t_lbl_gymbook;
        private System.Windows.Forms.Label Gym_price;
        private System.Windows.Forms.Label plus_lbl;
        private System.Windows.Forms.RadioButton no_trainer_lbl;
        private System.Windows.Forms.Label yes_or_no_main_lbl;
        private System.Windows.Forms.RadioButton GymTrainerradbtn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hmm_lbl;
    }
}