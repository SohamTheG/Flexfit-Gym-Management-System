namespace DBMS_project
{
    partial class SessionBookingForm
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
            this.back_btnSessForm = new System.Windows.Forms.Button();
            this.SessionBtn_GrpBox = new System.Windows.Forms.GroupBox();
            this.Boxing_Session_rdiobtn = new System.Windows.Forms.RadioButton();
            this.Zumba_Session_Radio = new System.Windows.Forms.RadioButton();
            this.Gym_radiobtn = new System.Windows.Forms.RadioButton();
            this.From_am_pm = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.BookSessionMain = new System.Windows.Forms.GroupBox();
            this.BookSessionHeading = new System.Windows.Forms.Label();
            this.done_btn_bookSess = new System.Windows.Forms.Button();
            this.sel_timeslot_grpbox = new System.Windows.Forms.GroupBox();
            this.sel_slot_lbl = new System.Windows.Forms.Label();
            this.zumba_time_slots = new System.Windows.Forms.ComboBox();
            this.Sel_start_time_grpbox = new System.Windows.Forms.GroupBox();
            this.No_of_hrs_lbl = new System.Windows.Forms.Label();
            this.Session_starts_lbl = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.SessionBtn_GrpBox.SuspendLayout();
            this.BookSessionMain.SuspendLayout();
            this.sel_timeslot_grpbox.SuspendLayout();
            this.Sel_start_time_grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btnSessForm
            // 
            this.back_btnSessForm.BackColor = System.Drawing.SystemColors.ControlText;
            this.back_btnSessForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_btnSessForm.Location = new System.Drawing.Point(12, 12);
            this.back_btnSessForm.Name = "back_btnSessForm";
            this.back_btnSessForm.Size = new System.Drawing.Size(81, 24);
            this.back_btnSessForm.TabIndex = 3;
            this.back_btnSessForm.Text = "Back";
            this.back_btnSessForm.UseVisualStyleBackColor = false;
            this.back_btnSessForm.Click += new System.EventHandler(this.back_btnSessForm_Click);
            // 
            // SessionBtn_GrpBox
            // 
            this.SessionBtn_GrpBox.Controls.Add(this.Boxing_Session_rdiobtn);
            this.SessionBtn_GrpBox.Controls.Add(this.Zumba_Session_Radio);
            this.SessionBtn_GrpBox.Controls.Add(this.Gym_radiobtn);
            this.SessionBtn_GrpBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SessionBtn_GrpBox.Location = new System.Drawing.Point(599, 96);
            this.SessionBtn_GrpBox.Name = "SessionBtn_GrpBox";
            this.SessionBtn_GrpBox.Size = new System.Drawing.Size(176, 252);
            this.SessionBtn_GrpBox.TabIndex = 5;
            this.SessionBtn_GrpBox.TabStop = false;
            this.SessionBtn_GrpBox.Text = "Select Your Session";
            this.SessionBtn_GrpBox.Enter += new System.EventHandler(this.SessionBtn_GrpBox_Enter);
            // 
            // Boxing_Session_rdiobtn
            // 
            this.Boxing_Session_rdiobtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Boxing_Session_rdiobtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Boxing_Session_rdiobtn.AutoSize = true;
            this.Boxing_Session_rdiobtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.Boxing_Session_rdiobtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Boxing_Session_rdiobtn.Location = new System.Drawing.Point(19, 151);
            this.Boxing_Session_rdiobtn.MinimumSize = new System.Drawing.Size(140, 50);
            this.Boxing_Session_rdiobtn.Name = "Boxing_Session_rdiobtn";
            this.Boxing_Session_rdiobtn.Padding = new System.Windows.Forms.Padding(5);
            this.Boxing_Session_rdiobtn.Size = new System.Drawing.Size(140, 50);
            this.Boxing_Session_rdiobtn.TabIndex = 2;
            this.Boxing_Session_rdiobtn.Text = "Boxing Session";
            this.Boxing_Session_rdiobtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Boxing_Session_rdiobtn.UseVisualStyleBackColor = false;
            this.Boxing_Session_rdiobtn.CheckedChanged += new System.EventHandler(this.Boxing_Session_rdiobtn_CheckedChanged);
            // 
            // Zumba_Session_Radio
            // 
            this.Zumba_Session_Radio.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Zumba_Session_Radio.Appearance = System.Windows.Forms.Appearance.Button;
            this.Zumba_Session_Radio.AutoSize = true;
            this.Zumba_Session_Radio.BackColor = System.Drawing.SystemColors.InfoText;
            this.Zumba_Session_Radio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Zumba_Session_Radio.Location = new System.Drawing.Point(19, 95);
            this.Zumba_Session_Radio.MinimumSize = new System.Drawing.Size(140, 50);
            this.Zumba_Session_Radio.Name = "Zumba_Session_Radio";
            this.Zumba_Session_Radio.Padding = new System.Windows.Forms.Padding(5);
            this.Zumba_Session_Radio.Size = new System.Drawing.Size(140, 50);
            this.Zumba_Session_Radio.TabIndex = 1;
            this.Zumba_Session_Radio.Text = "Zumba Session";
            this.Zumba_Session_Radio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Zumba_Session_Radio.UseVisualStyleBackColor = false;
            this.Zumba_Session_Radio.CheckedChanged += new System.EventHandler(this.Boxing_Session_CheckedChanged);
            // 
            // Gym_radiobtn
            // 
            this.Gym_radiobtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Gym_radiobtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Gym_radiobtn.AutoSize = true;
            this.Gym_radiobtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.Gym_radiobtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gym_radiobtn.Location = new System.Drawing.Point(19, 39);
            this.Gym_radiobtn.MinimumSize = new System.Drawing.Size(140, 50);
            this.Gym_radiobtn.Name = "Gym_radiobtn";
            this.Gym_radiobtn.Padding = new System.Windows.Forms.Padding(5);
            this.Gym_radiobtn.Size = new System.Drawing.Size(140, 50);
            this.Gym_radiobtn.TabIndex = 0;
            this.Gym_radiobtn.Text = "Gym Session";
            this.Gym_radiobtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Gym_radiobtn.UseVisualStyleBackColor = false;
            this.Gym_radiobtn.CheckedChanged += new System.EventHandler(this.Gym_radiobtn_CheckedChanged);
            // 
            // From_am_pm
            // 
            this.From_am_pm.FormattingEnabled = true;
            this.From_am_pm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.From_am_pm.Location = new System.Drawing.Point(160, 23);
            this.From_am_pm.Name = "From_am_pm";
            this.From_am_pm.Size = new System.Drawing.Size(68, 21);
            this.From_am_pm.TabIndex = 6;
            this.From_am_pm.Text = "AM";
            this.From_am_pm.SelectedIndexChanged += new System.EventHandler(this.From_am_pm_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(26, 49);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // BookSessionMain
            // 
            this.BookSessionMain.Controls.Add(this.BookSessionHeading);
            this.BookSessionMain.Controls.Add(this.done_btn_bookSess);
            this.BookSessionMain.Controls.Add(this.monthCalendar1);
            this.BookSessionMain.Controls.Add(this.Sel_start_time_grpbox);
            this.BookSessionMain.Controls.Add(this.sel_timeslot_grpbox);
            this.BookSessionMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookSessionMain.Location = new System.Drawing.Point(56, 96);
            this.BookSessionMain.Name = "BookSessionMain";
            this.BookSessionMain.Size = new System.Drawing.Size(537, 252);
            this.BookSessionMain.TabIndex = 9;
            this.BookSessionMain.TabStop = false;
            this.BookSessionMain.Text = "Select Date and Time";
            this.BookSessionMain.Enter += new System.EventHandler(this.BookSessionMain_Enter);
            // 
            // BookSessionHeading
            // 
            this.BookSessionHeading.AutoSize = true;
            this.BookSessionHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookSessionHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BookSessionHeading.Location = new System.Drawing.Point(176, 220);
            this.BookSessionHeading.Name = "BookSessionHeading";
            this.BookSessionHeading.Size = new System.Drawing.Size(129, 20);
            this.BookSessionHeading.TabIndex = 11;
            this.BookSessionHeading.Text = "Select Session";
            this.BookSessionHeading.Click += new System.EventHandler(this.BookSessionHeading_Click);
            // 
            // done_btn_bookSess
            // 
            this.done_btn_bookSess.BackColor = System.Drawing.SystemColors.ControlText;
            this.done_btn_bookSess.Location = new System.Drawing.Point(476, 215);
            this.done_btn_bookSess.Name = "done_btn_bookSess";
            this.done_btn_bookSess.Size = new System.Drawing.Size(43, 29);
            this.done_btn_bookSess.TabIndex = 13;
            this.done_btn_bookSess.Text = "Done";
            this.done_btn_bookSess.UseVisualStyleBackColor = false;
            this.done_btn_bookSess.Click += new System.EventHandler(this.done_btn_bookSess_Click);
            // 
            // sel_timeslot_grpbox
            // 
            this.sel_timeslot_grpbox.Controls.Add(this.sel_slot_lbl);
            this.sel_timeslot_grpbox.Controls.Add(this.zumba_time_slots);
            this.sel_timeslot_grpbox.Location = new System.Drawing.Point(258, 49);
            this.sel_timeslot_grpbox.Name = "sel_timeslot_grpbox";
            this.sel_timeslot_grpbox.Size = new System.Drawing.Size(261, 162);
            this.sel_timeslot_grpbox.TabIndex = 14;
            this.sel_timeslot_grpbox.TabStop = false;
            this.sel_timeslot_grpbox.Text = "Select Time Slot";
            this.sel_timeslot_grpbox.Visible = false;
            this.sel_timeslot_grpbox.Enter += new System.EventHandler(this.sel_timeslot_grpbox_Enter);
            // 
            // sel_slot_lbl
            // 
            this.sel_slot_lbl.AutoSize = true;
            this.sel_slot_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_slot_lbl.Location = new System.Drawing.Point(4, 30);
            this.sel_slot_lbl.Name = "sel_slot_lbl";
            this.sel_slot_lbl.Size = new System.Drawing.Size(120, 15);
            this.sel_slot_lbl.TabIndex = 13;
            this.sel_slot_lbl.Text = "Select Time Slot :";
            this.sel_slot_lbl.Click += new System.EventHandler(this.sel_slot_lbl_Click);
            // 
            // zumba_time_slots
            // 
            this.zumba_time_slots.FormattingEnabled = true;
            this.zumba_time_slots.Items.AddRange(new object[] {
            "7 AM - 8 AM",
            "8 AM - 9 AM",
            "9 AM - 10 AM",
            "4 PM - 5 PM",
            "5 PM - 6 PM",
            "6 PM - 7 PM"});
            this.zumba_time_slots.Location = new System.Drawing.Point(126, 29);
            this.zumba_time_slots.Name = "zumba_time_slots";
            this.zumba_time_slots.Size = new System.Drawing.Size(125, 21);
            this.zumba_time_slots.TabIndex = 12;
            this.zumba_time_slots.Text = "7 AM - 8 AM";
            this.zumba_time_slots.SelectedIndexChanged += new System.EventHandler(this.zumba_time_slots_SelectedIndexChanged);
            // 
            // Sel_start_time_grpbox
            // 
            this.Sel_start_time_grpbox.Controls.Add(this.No_of_hrs_lbl);
            this.Sel_start_time_grpbox.Controls.Add(this.Session_starts_lbl);
            this.Sel_start_time_grpbox.Controls.Add(this.trackBar1);
            this.Sel_start_time_grpbox.Controls.Add(this.numericUpDown1);
            this.Sel_start_time_grpbox.Controls.Add(this.From_am_pm);
            this.Sel_start_time_grpbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sel_start_time_grpbox.Location = new System.Drawing.Point(259, 49);
            this.Sel_start_time_grpbox.Name = "Sel_start_time_grpbox";
            this.Sel_start_time_grpbox.Size = new System.Drawing.Size(261, 162);
            this.Sel_start_time_grpbox.TabIndex = 12;
            this.Sel_start_time_grpbox.TabStop = false;
            this.Sel_start_time_grpbox.Text = "Select Starting Time and Duration";
            this.Sel_start_time_grpbox.Visible = false;
            this.Sel_start_time_grpbox.Enter += new System.EventHandler(this.Sel_start_time_grpbox_Enter);
            // 
            // No_of_hrs_lbl
            // 
            this.No_of_hrs_lbl.AutoSize = true;
            this.No_of_hrs_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_of_hrs_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.No_of_hrs_lbl.Location = new System.Drawing.Point(96, 107);
            this.No_of_hrs_lbl.Name = "No_of_hrs_lbl";
            this.No_of_hrs_lbl.Size = new System.Drawing.Size(60, 20);
            this.No_of_hrs_lbl.TabIndex = 10;
            this.No_of_hrs_lbl.Text = "1 hour";
            this.No_of_hrs_lbl.Click += new System.EventHandler(this.No_of_hrs_lbl_Click);
            // 
            // Session_starts_lbl
            // 
            this.Session_starts_lbl.AutoSize = true;
            this.Session_starts_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Session_starts_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Session_starts_lbl.Location = new System.Drawing.Point(16, 24);
            this.Session_starts_lbl.Name = "Session_starts_lbl";
            this.Session_starts_lbl.Size = new System.Drawing.Size(65, 15);
            this.Session_starts_lbl.TabIndex = 11;
            this.Session_starts_lbl.Text = "Starting :";
            this.Session_starts_lbl.Click += new System.EventHandler(this.Session_starts_lbl_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 59);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(239, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.UseWaitCursor = true;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(87, 24);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // SessionBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookSessionMain);
            this.Controls.Add(this.SessionBtn_GrpBox);
            this.Controls.Add(this.back_btnSessForm);
            this.Name = "SessionBookingForm";
            this.Text = "-";
            this.Load += new System.EventHandler(this.SessionBookingForm_Load);
            this.SessionBtn_GrpBox.ResumeLayout(false);
            this.SessionBtn_GrpBox.PerformLayout();
            this.BookSessionMain.ResumeLayout(false);
            this.BookSessionMain.PerformLayout();
            this.sel_timeslot_grpbox.ResumeLayout(false);
            this.sel_timeslot_grpbox.PerformLayout();
            this.Sel_start_time_grpbox.ResumeLayout(false);
            this.Sel_start_time_grpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back_btnSessForm;
        private System.Windows.Forms.GroupBox SessionBtn_GrpBox;
        private System.Windows.Forms.ComboBox From_am_pm;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox BookSessionMain;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Session_starts_lbl;
        private System.Windows.Forms.GroupBox Sel_start_time_grpbox;
        private System.Windows.Forms.Button done_btn_bookSess;
        private System.Windows.Forms.Label BookSessionHeading;
        private System.Windows.Forms.ComboBox zumba_time_slots;
        private System.Windows.Forms.GroupBox sel_timeslot_grpbox;
        private System.Windows.Forms.Label sel_slot_lbl;
        private System.Windows.Forms.Label No_of_hrs_lbl;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton Gym_radiobtn;
        private System.Windows.Forms.RadioButton Boxing_Session_rdiobtn;
        private System.Windows.Forms.RadioButton Zumba_Session_Radio;
    }
}