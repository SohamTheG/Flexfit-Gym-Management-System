namespace DBMS_project
{
    partial class ZumbaSubBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZumbaSubBookingForm));
            this.Facilities_info_grpboxZumbaSub = new System.Windows.Forms.GroupBox();
            this.groupbox_sele_ZumbaSub = new System.Windows.Forms.GroupBox();
            this.no_of_months_lbl_ZumbaSub = new System.Windows.Forms.Label();
            this.Sel_duration_lbl_ZumbaSub = new System.Windows.Forms.Label();
            this.Sel_date_ZumbaSub_lbl = new System.Windows.Forms.Label();
            this.ZumbaSubDurationTrackbr = new System.Windows.Forms.TrackBar();
            this.sel_date_ZumbaSub = new System.Windows.Forms.MonthCalendar();
            this.Back_bt_ZumbaSub = new System.Windows.Forms.Button();
            this.instructorinfo_grpbox = new System.Windows.Forms.GroupBox();
            this.changing_info_lbl_ZumbaSub = new System.Windows.Forms.Label();
            this.sel_slot_lbl_ZumbaSub = new System.Windows.Forms.Label();
            this.zumba_time_slots_ZumbaSub = new System.Windows.Forms.ComboBox();
            this.ZumbaSub_price = new System.Windows.Forms.Label();
            this.purchase_btn_ZumbaSub = new System.Windows.Forms.Button();
            this.price_lbl_ZumbaSub = new System.Windows.Forms.Label();
            this.efg_ahhh = new System.Windows.Forms.Label();
            this.Facilities_info_grpboxZumbaSub.SuspendLayout();
            this.groupbox_sele_ZumbaSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZumbaSubDurationTrackbr)).BeginInit();
            this.instructorinfo_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Facilities_info_grpboxZumbaSub
            // 
            this.Facilities_info_grpboxZumbaSub.Controls.Add(this.efg_ahhh);
            this.Facilities_info_grpboxZumbaSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Facilities_info_grpboxZumbaSub.Location = new System.Drawing.Point(27, 42);
            this.Facilities_info_grpboxZumbaSub.Name = "Facilities_info_grpboxZumbaSub";
            this.Facilities_info_grpboxZumbaSub.Size = new System.Drawing.Size(227, 353);
            this.Facilities_info_grpboxZumbaSub.TabIndex = 15;
            this.Facilities_info_grpboxZumbaSub.TabStop = false;
            this.Facilities_info_grpboxZumbaSub.Text = "Facilities";
            this.Facilities_info_grpboxZumbaSub.Enter += new System.EventHandler(this.Facilities_info_grpboxZumbaSub_Enter);
            // 
            // groupbox_sele_ZumbaSub
            // 
            this.groupbox_sele_ZumbaSub.Controls.Add(this.no_of_months_lbl_ZumbaSub);
            this.groupbox_sele_ZumbaSub.Controls.Add(this.Sel_duration_lbl_ZumbaSub);
            this.groupbox_sele_ZumbaSub.Controls.Add(this.Sel_date_ZumbaSub_lbl);
            this.groupbox_sele_ZumbaSub.Controls.Add(this.ZumbaSubDurationTrackbr);
            this.groupbox_sele_ZumbaSub.Controls.Add(this.sel_date_ZumbaSub);
            this.groupbox_sele_ZumbaSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupbox_sele_ZumbaSub.Location = new System.Drawing.Point(260, 42);
            this.groupbox_sele_ZumbaSub.Name = "groupbox_sele_ZumbaSub";
            this.groupbox_sele_ZumbaSub.Size = new System.Drawing.Size(272, 354);
            this.groupbox_sele_ZumbaSub.TabIndex = 14;
            this.groupbox_sele_ZumbaSub.TabStop = false;
            this.groupbox_sele_ZumbaSub.Text = "Provide Details Here";
            this.groupbox_sele_ZumbaSub.Enter += new System.EventHandler(this.groupbox_sele_ZumbaSub_Enter);
            // 
            // no_of_months_lbl_ZumbaSub
            // 
            this.no_of_months_lbl_ZumbaSub.AutoSize = true;
            this.no_of_months_lbl_ZumbaSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_months_lbl_ZumbaSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.no_of_months_lbl_ZumbaSub.Location = new System.Drawing.Point(112, 307);
            this.no_of_months_lbl_ZumbaSub.Name = "no_of_months_lbl_ZumbaSub";
            this.no_of_months_lbl_ZumbaSub.Size = new System.Drawing.Size(60, 16);
            this.no_of_months_lbl_ZumbaSub.TabIndex = 6;
            this.no_of_months_lbl_ZumbaSub.Text = "1 Month";
            this.no_of_months_lbl_ZumbaSub.Click += new System.EventHandler(this.no_of_months_lbl_ZumbaSub_Click);
            // 
            // Sel_duration_lbl_ZumbaSub
            // 
            this.Sel_duration_lbl_ZumbaSub.AutoSize = true;
            this.Sel_duration_lbl_ZumbaSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sel_duration_lbl_ZumbaSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sel_duration_lbl_ZumbaSub.Location = new System.Drawing.Point(18, 224);
            this.Sel_duration_lbl_ZumbaSub.Name = "Sel_duration_lbl_ZumbaSub";
            this.Sel_duration_lbl_ZumbaSub.Size = new System.Drawing.Size(117, 16);
            this.Sel_duration_lbl_ZumbaSub.TabIndex = 5;
            this.Sel_duration_lbl_ZumbaSub.Text = "Select Duration:";
            this.Sel_duration_lbl_ZumbaSub.Click += new System.EventHandler(this.Sel_duration_lbl_ZumbaSub_Click);
            // 
            // Sel_date_ZumbaSub_lbl
            // 
            this.Sel_date_ZumbaSub_lbl.AutoSize = true;
            this.Sel_date_ZumbaSub_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sel_date_ZumbaSub_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sel_date_ZumbaSub_lbl.Location = new System.Drawing.Point(18, 27);
            this.Sel_date_ZumbaSub_lbl.Name = "Sel_date_ZumbaSub_lbl";
            this.Sel_date_ZumbaSub_lbl.Size = new System.Drawing.Size(92, 16);
            this.Sel_date_ZumbaSub_lbl.TabIndex = 4;
            this.Sel_date_ZumbaSub_lbl.Text = "Select Date:";
            this.Sel_date_ZumbaSub_lbl.Click += new System.EventHandler(this.Sel_date_ZumbaSub_lbl_Click);
            // 
            // ZumbaSubDurationTrackbr
            // 
            this.ZumbaSubDurationTrackbr.Location = new System.Drawing.Point(21, 259);
            this.ZumbaSubDurationTrackbr.Maximum = 4;
            this.ZumbaSubDurationTrackbr.Name = "ZumbaSubDurationTrackbr";
            this.ZumbaSubDurationTrackbr.Size = new System.Drawing.Size(240, 45);
            this.ZumbaSubDurationTrackbr.TabIndex = 2;
            this.ZumbaSubDurationTrackbr.Scroll += new System.EventHandler(this.ZumbaSubDurationTrackbr_Scroll);
            // 
            // sel_date_ZumbaSub
            // 
            this.sel_date_ZumbaSub.Location = new System.Drawing.Point(21, 53);
            this.sel_date_ZumbaSub.Name = "sel_date_ZumbaSub";
            this.sel_date_ZumbaSub.TabIndex = 1;
            this.sel_date_ZumbaSub.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.sel_date_ZumbaSub_DateChanged);
            // 
            // Back_bt_ZumbaSub
            // 
            this.Back_bt_ZumbaSub.BackColor = System.Drawing.Color.Black;
            this.Back_bt_ZumbaSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Back_bt_ZumbaSub.Location = new System.Drawing.Point(15, 12);
            this.Back_bt_ZumbaSub.Name = "Back_bt_ZumbaSub";
            this.Back_bt_ZumbaSub.Size = new System.Drawing.Size(80, 26);
            this.Back_bt_ZumbaSub.TabIndex = 13;
            this.Back_bt_ZumbaSub.Text = "Back";
            this.Back_bt_ZumbaSub.UseVisualStyleBackColor = false;
            this.Back_bt_ZumbaSub.Click += new System.EventHandler(this.Back_bt_ZumbaSub_Click);
            // 
            // instructorinfo_grpbox
            // 
            this.instructorinfo_grpbox.Controls.Add(this.changing_info_lbl_ZumbaSub);
            this.instructorinfo_grpbox.Controls.Add(this.sel_slot_lbl_ZumbaSub);
            this.instructorinfo_grpbox.Controls.Add(this.zumba_time_slots_ZumbaSub);
            this.instructorinfo_grpbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructorinfo_grpbox.Location = new System.Drawing.Point(541, 42);
            this.instructorinfo_grpbox.Name = "instructorinfo_grpbox";
            this.instructorinfo_grpbox.Size = new System.Drawing.Size(248, 353);
            this.instructorinfo_grpbox.TabIndex = 17;
            this.instructorinfo_grpbox.TabStop = false;
            this.instructorinfo_grpbox.Text = "Meet Our Instructors";
            this.instructorinfo_grpbox.Enter += new System.EventHandler(this.instructorinfo_grpbox_Enter);
            // 
            // changing_info_lbl_ZumbaSub
            // 
            this.changing_info_lbl_ZumbaSub.AutoSize = true;
            this.changing_info_lbl_ZumbaSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changing_info_lbl_ZumbaSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changing_info_lbl_ZumbaSub.Location = new System.Drawing.Point(45, 74);
            this.changing_info_lbl_ZumbaSub.Name = "changing_info_lbl_ZumbaSub";
            this.changing_info_lbl_ZumbaSub.Size = new System.Drawing.Size(134, 16);
            this.changing_info_lbl_ZumbaSub.TabIndex = 11;
            this.changing_info_lbl_ZumbaSub.Text = "changing info here";
            this.changing_info_lbl_ZumbaSub.Visible = false;
            this.changing_info_lbl_ZumbaSub.Click += new System.EventHandler(this.changing_info_lbl_ZumbaSub_Click);
            // 
            // sel_slot_lbl_ZumbaSub
            // 
            this.sel_slot_lbl_ZumbaSub.AutoSize = true;
            this.sel_slot_lbl_ZumbaSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_slot_lbl_ZumbaSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sel_slot_lbl_ZumbaSub.Location = new System.Drawing.Point(10, 28);
            this.sel_slot_lbl_ZumbaSub.Name = "sel_slot_lbl_ZumbaSub";
            this.sel_slot_lbl_ZumbaSub.Size = new System.Drawing.Size(120, 15);
            this.sel_slot_lbl_ZumbaSub.TabIndex = 15;
            this.sel_slot_lbl_ZumbaSub.Text = "Select Time Slot :";
            this.sel_slot_lbl_ZumbaSub.Click += new System.EventHandler(this.sel_slot_lbl_ZumbaSub_Click);
            // 
            // zumba_time_slots_ZumbaSub
            // 
            this.zumba_time_slots_ZumbaSub.FormattingEnabled = true;
            this.zumba_time_slots_ZumbaSub.Items.AddRange(new object[] {
            "7 AM - 8 AM",
            "8 AM - 9 AM",
            "9 AM - 10 AM",
            "4 PM - 5 PM",
            "5 PM - 6 PM",
            "6 PM - 7 PM"});
            this.zumba_time_slots_ZumbaSub.Location = new System.Drawing.Point(136, 26);
            this.zumba_time_slots_ZumbaSub.Name = "zumba_time_slots_ZumbaSub";
            this.zumba_time_slots_ZumbaSub.Size = new System.Drawing.Size(103, 21);
            this.zumba_time_slots_ZumbaSub.TabIndex = 14;
            this.zumba_time_slots_ZumbaSub.Text = "select here";
            this.zumba_time_slots_ZumbaSub.SelectedIndexChanged += new System.EventHandler(this.zumba_time_slots_ZumbaSub_SelectedIndexChanged);
            // 
            // ZumbaSub_price
            // 
            this.ZumbaSub_price.AutoSize = true;
            this.ZumbaSub_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZumbaSub_price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZumbaSub_price.Location = new System.Drawing.Point(605, 414);
            this.ZumbaSub_price.Name = "ZumbaSub_price";
            this.ZumbaSub_price.Size = new System.Drawing.Size(66, 16);
            this.ZumbaSub_price.TabIndex = 20;
            this.ZumbaSub_price.Text = "2000 Rs.";
            this.ZumbaSub_price.Click += new System.EventHandler(this.ZumbaSub_price_Click);
            // 
            // purchase_btn_ZumbaSub
            // 
            this.purchase_btn_ZumbaSub.BackColor = System.Drawing.Color.Black;
            this.purchase_btn_ZumbaSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.purchase_btn_ZumbaSub.Location = new System.Drawing.Point(685, 409);
            this.purchase_btn_ZumbaSub.Name = "purchase_btn_ZumbaSub";
            this.purchase_btn_ZumbaSub.Size = new System.Drawing.Size(95, 26);
            this.purchase_btn_ZumbaSub.TabIndex = 19;
            this.purchase_btn_ZumbaSub.Text = "Purchase";
            this.purchase_btn_ZumbaSub.UseVisualStyleBackColor = false;
            this.purchase_btn_ZumbaSub.Click += new System.EventHandler(this.purchase_btn_ZumbaSub_Click);
            // 
            // price_lbl_ZumbaSub
            // 
            this.price_lbl_ZumbaSub.AutoSize = true;
            this.price_lbl_ZumbaSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_lbl_ZumbaSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.price_lbl_ZumbaSub.Location = new System.Drawing.Point(406, 414);
            this.price_lbl_ZumbaSub.Name = "price_lbl_ZumbaSub";
            this.price_lbl_ZumbaSub.Size = new System.Drawing.Size(188, 16);
            this.price_lbl_ZumbaSub.TabIndex = 18;
            this.price_lbl_ZumbaSub.Text = "Zumba Subscription Price:";
            this.price_lbl_ZumbaSub.Click += new System.EventHandler(this.price_lbl_ZumbaSub_Click);
            // 
            // efg_ahhh
            // 
            this.efg_ahhh.AutoSize = true;
            this.efg_ahhh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.efg_ahhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efg_ahhh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.efg_ahhh.Location = new System.Drawing.Point(17, 35);
            this.efg_ahhh.MaximumSize = new System.Drawing.Size(200, 800);
            this.efg_ahhh.Name = "efg_ahhh";
            this.efg_ahhh.Size = new System.Drawing.Size(188, 288);
            this.efg_ahhh.TabIndex = 21;
            this.efg_ahhh.Text = resources.GetString("efg_ahhh.Text");
            this.efg_ahhh.Click += new System.EventHandler(this.efg_ahhh_Click);
            // 
            // ZumbaSubBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ZumbaSub_price);
            this.Controls.Add(this.purchase_btn_ZumbaSub);
            this.Controls.Add(this.price_lbl_ZumbaSub);
            this.Controls.Add(this.instructorinfo_grpbox);
            this.Controls.Add(this.Facilities_info_grpboxZumbaSub);
            this.Controls.Add(this.groupbox_sele_ZumbaSub);
            this.Controls.Add(this.Back_bt_ZumbaSub);
            this.Name = "ZumbaSubBookingForm";
            this.Text = "aaaa";
            this.Facilities_info_grpboxZumbaSub.ResumeLayout(false);
            this.Facilities_info_grpboxZumbaSub.PerformLayout();
            this.groupbox_sele_ZumbaSub.ResumeLayout(false);
            this.groupbox_sele_ZumbaSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZumbaSubDurationTrackbr)).EndInit();
            this.instructorinfo_grpbox.ResumeLayout(false);
            this.instructorinfo_grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Facilities_info_grpboxZumbaSub;
        private System.Windows.Forms.GroupBox groupbox_sele_ZumbaSub;
        private System.Windows.Forms.Label no_of_months_lbl_ZumbaSub;
        private System.Windows.Forms.Label Sel_duration_lbl_ZumbaSub;
        private System.Windows.Forms.Label Sel_date_ZumbaSub_lbl;
        private System.Windows.Forms.TrackBar ZumbaSubDurationTrackbr;
        private System.Windows.Forms.MonthCalendar sel_date_ZumbaSub;
        private System.Windows.Forms.Button Back_bt_ZumbaSub;
        private System.Windows.Forms.GroupBox instructorinfo_grpbox;
        private System.Windows.Forms.Label ZumbaSub_price;
        private System.Windows.Forms.Button purchase_btn_ZumbaSub;
        private System.Windows.Forms.Label price_lbl_ZumbaSub;
        private System.Windows.Forms.Label sel_slot_lbl_ZumbaSub;
        private System.Windows.Forms.ComboBox zumba_time_slots_ZumbaSub;
        private System.Windows.Forms.Label changing_info_lbl_ZumbaSub;
        private System.Windows.Forms.Label efg_ahhh;
    }
}