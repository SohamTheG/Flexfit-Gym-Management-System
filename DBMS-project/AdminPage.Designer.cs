namespace DBMS_project
{
    partial class AdminPage
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
            this.Inserttrainer_admin_btn = new System.Windows.Forms.Button();
            this.Logoutbtn_admin = new System.Windows.Forms.Button();
            this.Insert_inst_admin_btn = new System.Windows.Forms.Button();
            this.trainer_name_lbl_admin = new System.Windows.Forms.Label();
            this.trainer_age_lbl_admin = new System.Windows.Forms.Label();
            this.trainer_sex_admin_lbl = new System.Windows.Forms.Label();
            this.instructor_name_lbl_admin = new System.Windows.Forms.Label();
            this.instuctor_age_admin_lbl = new System.Windows.Forms.Label();
            this.instructor_sex_lbl_admin = new System.Windows.Forms.Label();
            this.textBox_trainer_name = new System.Windows.Forms.TextBox();
            this.textBox_trainer_age = new System.Windows.Forms.TextBox();
            this.textBox_instructor_name = new System.Windows.Forms.TextBox();
            this.textBox_instructor_age = new System.Windows.Forms.TextBox();
            this.radioButton_male_trainer = new System.Windows.Forms.RadioButton();
            this.radioButton_triner_female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male_Instructor = new System.Windows.Forms.RadioButton();
            this.radioButton_Female_instructor = new System.Windows.Forms.RadioButton();
            this.groupBox_trainer = new System.Windows.Forms.GroupBox();
            this.textBox1_trainerid = new System.Windows.Forms.TextBox();
            this.label_trainer_id = new System.Windows.Forms.Label();
            this.groupBox_instructor_info = new System.Windows.Forms.GroupBox();
            this.textBox_instr_id_adminpg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stats_btn = new System.Windows.Forms.Button();
            this.groupBox_trainer.SuspendLayout();
            this.groupBox_instructor_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inserttrainer_admin_btn
            // 
            this.Inserttrainer_admin_btn.BackColor = System.Drawing.SystemColors.Desktop;
            this.Inserttrainer_admin_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Inserttrainer_admin_btn.Location = new System.Drawing.Point(90, 208);
            this.Inserttrainer_admin_btn.Name = "Inserttrainer_admin_btn";
            this.Inserttrainer_admin_btn.Size = new System.Drawing.Size(116, 31);
            this.Inserttrainer_admin_btn.TabIndex = 0;
            this.Inserttrainer_admin_btn.Text = "Insert Trainer";
            this.Inserttrainer_admin_btn.UseVisualStyleBackColor = false;
            this.Inserttrainer_admin_btn.Click += new System.EventHandler(this.Inserttrainer_admin_btn_Click);
            // 
            // Logoutbtn_admin
            // 
            this.Logoutbtn_admin.BackColor = System.Drawing.SystemColors.Desktop;
            this.Logoutbtn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn_admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Logoutbtn_admin.Location = new System.Drawing.Point(294, 319);
            this.Logoutbtn_admin.Name = "Logoutbtn_admin";
            this.Logoutbtn_admin.Size = new System.Drawing.Size(116, 30);
            this.Logoutbtn_admin.TabIndex = 1;
            this.Logoutbtn_admin.Text = "Log Out";
            this.Logoutbtn_admin.UseVisualStyleBackColor = false;
            this.Logoutbtn_admin.Click += new System.EventHandler(this.Logoutbtn_admin_Click);
            // 
            // Insert_inst_admin_btn
            // 
            this.Insert_inst_admin_btn.BackColor = System.Drawing.SystemColors.Desktop;
            this.Insert_inst_admin_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Insert_inst_admin_btn.Location = new System.Drawing.Point(116, 208);
            this.Insert_inst_admin_btn.Name = "Insert_inst_admin_btn";
            this.Insert_inst_admin_btn.Size = new System.Drawing.Size(116, 31);
            this.Insert_inst_admin_btn.TabIndex = 2;
            this.Insert_inst_admin_btn.Text = "Insert Instructor";
            this.Insert_inst_admin_btn.UseVisualStyleBackColor = false;
            this.Insert_inst_admin_btn.Click += new System.EventHandler(this.Insert_inst_admin_btn_Click);
            // 
            // trainer_name_lbl_admin
            // 
            this.trainer_name_lbl_admin.AutoSize = true;
            this.trainer_name_lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainer_name_lbl_admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trainer_name_lbl_admin.Location = new System.Drawing.Point(8, 71);
            this.trainer_name_lbl_admin.Name = "trainer_name_lbl_admin";
            this.trainer_name_lbl_admin.Size = new System.Drawing.Size(110, 16);
            this.trainer_name_lbl_admin.TabIndex = 3;
            this.trainer_name_lbl_admin.Text = "Trainer Name :";
            this.trainer_name_lbl_admin.Click += new System.EventHandler(this.trainer_name_lbl_admin_Click);
            // 
            // trainer_age_lbl_admin
            // 
            this.trainer_age_lbl_admin.AutoSize = true;
            this.trainer_age_lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainer_age_lbl_admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trainer_age_lbl_admin.Location = new System.Drawing.Point(21, 111);
            this.trainer_age_lbl_admin.Name = "trainer_age_lbl_admin";
            this.trainer_age_lbl_admin.Size = new System.Drawing.Size(97, 16);
            this.trainer_age_lbl_admin.TabIndex = 4;
            this.trainer_age_lbl_admin.Text = "Trainer Age :";
            this.trainer_age_lbl_admin.Click += new System.EventHandler(this.trainer_age_lbl_admin_Click);
            // 
            // trainer_sex_admin_lbl
            // 
            this.trainer_sex_admin_lbl.AutoSize = true;
            this.trainer_sex_admin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainer_sex_admin_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trainer_sex_admin_lbl.Location = new System.Drawing.Point(21, 171);
            this.trainer_sex_admin_lbl.Name = "trainer_sex_admin_lbl";
            this.trainer_sex_admin_lbl.Size = new System.Drawing.Size(95, 16);
            this.trainer_sex_admin_lbl.TabIndex = 5;
            this.trainer_sex_admin_lbl.Text = "Trainer Sex :";
            this.trainer_sex_admin_lbl.Click += new System.EventHandler(this.trainer_sex_admin_lbl_Click);
            // 
            // instructor_name_lbl_admin
            // 
            this.instructor_name_lbl_admin.AutoSize = true;
            this.instructor_name_lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructor_name_lbl_admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructor_name_lbl_admin.Location = new System.Drawing.Point(9, 77);
            this.instructor_name_lbl_admin.Name = "instructor_name_lbl_admin";
            this.instructor_name_lbl_admin.Size = new System.Drawing.Size(123, 16);
            this.instructor_name_lbl_admin.TabIndex = 6;
            this.instructor_name_lbl_admin.Text = "Instructor Name :";
            this.instructor_name_lbl_admin.Click += new System.EventHandler(this.instructor_name_lbl_admin_Click);
            // 
            // instuctor_age_admin_lbl
            // 
            this.instuctor_age_admin_lbl.AutoSize = true;
            this.instuctor_age_admin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instuctor_age_admin_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instuctor_age_admin_lbl.Location = new System.Drawing.Point(22, 117);
            this.instuctor_age_admin_lbl.Name = "instuctor_age_admin_lbl";
            this.instuctor_age_admin_lbl.Size = new System.Drawing.Size(110, 16);
            this.instuctor_age_admin_lbl.TabIndex = 7;
            this.instuctor_age_admin_lbl.Text = "Instructor Age :";
            this.instuctor_age_admin_lbl.Click += new System.EventHandler(this.instuctor_age_admin_lbl_Click);
            // 
            // instructor_sex_lbl_admin
            // 
            this.instructor_sex_lbl_admin.AutoSize = true;
            this.instructor_sex_lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructor_sex_lbl_admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructor_sex_lbl_admin.Location = new System.Drawing.Point(24, 164);
            this.instructor_sex_lbl_admin.Name = "instructor_sex_lbl_admin";
            this.instructor_sex_lbl_admin.Size = new System.Drawing.Size(108, 16);
            this.instructor_sex_lbl_admin.TabIndex = 8;
            this.instructor_sex_lbl_admin.Text = "Instructor Sex :";
            this.instructor_sex_lbl_admin.Click += new System.EventHandler(this.instructor_sex_lbl_admin_Click);
            // 
            // textBox_trainer_name
            // 
            this.textBox_trainer_name.Location = new System.Drawing.Point(124, 71);
            this.textBox_trainer_name.Name = "textBox_trainer_name";
            this.textBox_trainer_name.Size = new System.Drawing.Size(153, 22);
            this.textBox_trainer_name.TabIndex = 9;
            this.textBox_trainer_name.TextChanged += new System.EventHandler(this.textBox_trainer_name_TextChanged);
            // 
            // textBox_trainer_age
            // 
            this.textBox_trainer_age.Location = new System.Drawing.Point(124, 111);
            this.textBox_trainer_age.Name = "textBox_trainer_age";
            this.textBox_trainer_age.Size = new System.Drawing.Size(153, 22);
            this.textBox_trainer_age.TabIndex = 10;
            this.textBox_trainer_age.TextChanged += new System.EventHandler(this.textBox_trainer_age_TextChanged);
            // 
            // textBox_instructor_name
            // 
            this.textBox_instructor_name.Location = new System.Drawing.Point(138, 71);
            this.textBox_instructor_name.Name = "textBox_instructor_name";
            this.textBox_instructor_name.Size = new System.Drawing.Size(153, 22);
            this.textBox_instructor_name.TabIndex = 12;
            this.textBox_instructor_name.TextChanged += new System.EventHandler(this.textBox_instructor_name_TextChanged);
            // 
            // textBox_instructor_age
            // 
            this.textBox_instructor_age.Location = new System.Drawing.Point(138, 114);
            this.textBox_instructor_age.Name = "textBox_instructor_age";
            this.textBox_instructor_age.Size = new System.Drawing.Size(153, 22);
            this.textBox_instructor_age.TabIndex = 13;
            this.textBox_instructor_age.TextChanged += new System.EventHandler(this.textBox_instructor_age_TextChanged);
            // 
            // radioButton_male_trainer
            // 
            this.radioButton_male_trainer.AutoSize = true;
            this.radioButton_male_trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_male_trainer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton_male_trainer.Location = new System.Drawing.Point(124, 171);
            this.radioButton_male_trainer.Name = "radioButton_male_trainer";
            this.radioButton_male_trainer.Size = new System.Drawing.Size(59, 20);
            this.radioButton_male_trainer.TabIndex = 14;
            this.radioButton_male_trainer.TabStop = true;
            this.radioButton_male_trainer.Text = "Male";
            this.radioButton_male_trainer.UseVisualStyleBackColor = true;
            this.radioButton_male_trainer.CheckedChanged += new System.EventHandler(this.radioButton_male_trainer_CheckedChanged);
            // 
            // radioButton_triner_female
            // 
            this.radioButton_triner_female.AutoSize = true;
            this.radioButton_triner_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_triner_female.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton_triner_female.Location = new System.Drawing.Point(200, 171);
            this.radioButton_triner_female.Name = "radioButton_triner_female";
            this.radioButton_triner_female.Size = new System.Drawing.Size(77, 20);
            this.radioButton_triner_female.TabIndex = 15;
            this.radioButton_triner_female.TabStop = true;
            this.radioButton_triner_female.Text = "Female";
            this.radioButton_triner_female.UseVisualStyleBackColor = true;
            this.radioButton_triner_female.CheckedChanged += new System.EventHandler(this.radioButton_triner_female_CheckedChanged);
            // 
            // radioButton_Male_Instructor
            // 
            this.radioButton_Male_Instructor.AutoSize = true;
            this.radioButton_Male_Instructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Male_Instructor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton_Male_Instructor.Location = new System.Drawing.Point(138, 163);
            this.radioButton_Male_Instructor.Name = "radioButton_Male_Instructor";
            this.radioButton_Male_Instructor.Size = new System.Drawing.Size(59, 20);
            this.radioButton_Male_Instructor.TabIndex = 16;
            this.radioButton_Male_Instructor.TabStop = true;
            this.radioButton_Male_Instructor.Text = "Male";
            this.radioButton_Male_Instructor.UseVisualStyleBackColor = true;
            this.radioButton_Male_Instructor.CheckedChanged += new System.EventHandler(this.radioButton_Male_Instructor_CheckedChanged);
            // 
            // radioButton_Female_instructor
            // 
            this.radioButton_Female_instructor.AutoSize = true;
            this.radioButton_Female_instructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Female_instructor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton_Female_instructor.Location = new System.Drawing.Point(206, 164);
            this.radioButton_Female_instructor.Name = "radioButton_Female_instructor";
            this.radioButton_Female_instructor.Size = new System.Drawing.Size(77, 20);
            this.radioButton_Female_instructor.TabIndex = 17;
            this.radioButton_Female_instructor.TabStop = true;
            this.radioButton_Female_instructor.Text = "Female";
            this.radioButton_Female_instructor.UseVisualStyleBackColor = true;
            this.radioButton_Female_instructor.CheckedChanged += new System.EventHandler(this.radioButton_Female_instructor_CheckedChanged);
            // 
            // groupBox_trainer
            // 
            this.groupBox_trainer.Controls.Add(this.textBox1_trainerid);
            this.groupBox_trainer.Controls.Add(this.label_trainer_id);
            this.groupBox_trainer.Controls.Add(this.radioButton_triner_female);
            this.groupBox_trainer.Controls.Add(this.radioButton_male_trainer);
            this.groupBox_trainer.Controls.Add(this.textBox_trainer_age);
            this.groupBox_trainer.Controls.Add(this.textBox_trainer_name);
            this.groupBox_trainer.Controls.Add(this.trainer_sex_admin_lbl);
            this.groupBox_trainer.Controls.Add(this.trainer_age_lbl_admin);
            this.groupBox_trainer.Controls.Add(this.trainer_name_lbl_admin);
            this.groupBox_trainer.Controls.Add(this.Inserttrainer_admin_btn);
            this.groupBox_trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_trainer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox_trainer.Location = new System.Drawing.Point(35, 42);
            this.groupBox_trainer.Name = "groupBox_trainer";
            this.groupBox_trainer.Size = new System.Drawing.Size(307, 259);
            this.groupBox_trainer.TabIndex = 18;
            this.groupBox_trainer.TabStop = false;
            this.groupBox_trainer.Text = "Insert Trainer Info Here";
            this.groupBox_trainer.Enter += new System.EventHandler(this.groupBox_trainer_Enter);
            // 
            // textBox1_trainerid
            // 
            this.textBox1_trainerid.Location = new System.Drawing.Point(124, 28);
            this.textBox1_trainerid.Name = "textBox1_trainerid";
            this.textBox1_trainerid.Size = new System.Drawing.Size(153, 22);
            this.textBox1_trainerid.TabIndex = 21;
            this.textBox1_trainerid.TextChanged += new System.EventHandler(this.textBox1_trainerid_TextChanged);
            // 
            // label_trainer_id
            // 
            this.label_trainer_id.AutoSize = true;
            this.label_trainer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trainer_id.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_trainer_id.Location = new System.Drawing.Point(34, 31);
            this.label_trainer_id.Name = "label_trainer_id";
            this.label_trainer_id.Size = new System.Drawing.Size(84, 16);
            this.label_trainer_id.TabIndex = 20;
            this.label_trainer_id.Text = "Trainer ID :";
            this.label_trainer_id.Click += new System.EventHandler(this.label_trainer_id_Click);
            // 
            // groupBox_instructor_info
            // 
            this.groupBox_instructor_info.Controls.Add(this.textBox_instr_id_adminpg);
            this.groupBox_instructor_info.Controls.Add(this.label1);
            this.groupBox_instructor_info.Controls.Add(this.radioButton_Female_instructor);
            this.groupBox_instructor_info.Controls.Add(this.radioButton_Male_Instructor);
            this.groupBox_instructor_info.Controls.Add(this.textBox_instructor_age);
            this.groupBox_instructor_info.Controls.Add(this.textBox_instructor_name);
            this.groupBox_instructor_info.Controls.Add(this.instructor_sex_lbl_admin);
            this.groupBox_instructor_info.Controls.Add(this.instuctor_age_admin_lbl);
            this.groupBox_instructor_info.Controls.Add(this.instructor_name_lbl_admin);
            this.groupBox_instructor_info.Controls.Add(this.Insert_inst_admin_btn);
            this.groupBox_instructor_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_instructor_info.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox_instructor_info.Location = new System.Drawing.Point(363, 42);
            this.groupBox_instructor_info.Name = "groupBox_instructor_info";
            this.groupBox_instructor_info.Size = new System.Drawing.Size(315, 259);
            this.groupBox_instructor_info.TabIndex = 19;
            this.groupBox_instructor_info.TabStop = false;
            this.groupBox_instructor_info.Text = "Insert Instructor Info Here";
            this.groupBox_instructor_info.Enter += new System.EventHandler(this.groupBox_instructor_info_Enter);
            // 
            // textBox_instr_id_adminpg
            // 
            this.textBox_instr_id_adminpg.Location = new System.Drawing.Point(138, 31);
            this.textBox_instr_id_adminpg.Name = "textBox_instr_id_adminpg";
            this.textBox_instr_id_adminpg.Size = new System.Drawing.Size(153, 22);
            this.textBox_instr_id_adminpg.TabIndex = 19;
            this.textBox_instr_id_adminpg.TextChanged += new System.EventHandler(this.textBox_instr_id_adminpg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Instructor ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stats_btn
            // 
            this.stats_btn.BackColor = System.Drawing.SystemColors.Desktop;
            this.stats_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stats_btn.Location = new System.Drawing.Point(550, 319);
            this.stats_btn.Name = "stats_btn";
            this.stats_btn.Size = new System.Drawing.Size(116, 30);
            this.stats_btn.TabIndex = 20;
            this.stats_btn.Text = "Stats";
            this.stats_btn.UseVisualStyleBackColor = false;
            this.stats_btn.Click += new System.EventHandler(this.stats_btn_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(713, 372);
            this.Controls.Add(this.stats_btn);
            this.Controls.Add(this.groupBox_instructor_info);
            this.Controls.Add(this.groupBox_trainer);
            this.Controls.Add(this.Logoutbtn_admin);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.groupBox_trainer.ResumeLayout(false);
            this.groupBox_trainer.PerformLayout();
            this.groupBox_instructor_info.ResumeLayout(false);
            this.groupBox_instructor_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Inserttrainer_admin_btn;
        private System.Windows.Forms.Button Logoutbtn_admin;
        private System.Windows.Forms.Button Insert_inst_admin_btn;
        private System.Windows.Forms.Label trainer_name_lbl_admin;
        private System.Windows.Forms.Label trainer_age_lbl_admin;
        private System.Windows.Forms.Label trainer_sex_admin_lbl;
        private System.Windows.Forms.Label instructor_name_lbl_admin;
        private System.Windows.Forms.Label instuctor_age_admin_lbl;
        private System.Windows.Forms.Label instructor_sex_lbl_admin;
        private System.Windows.Forms.TextBox textBox_trainer_name;
        private System.Windows.Forms.TextBox textBox_trainer_age;
        private System.Windows.Forms.TextBox textBox_instructor_name;
        private System.Windows.Forms.TextBox textBox_instructor_age;
        private System.Windows.Forms.RadioButton radioButton_male_trainer;
        private System.Windows.Forms.RadioButton radioButton_triner_female;
        private System.Windows.Forms.RadioButton radioButton_Male_Instructor;
        private System.Windows.Forms.RadioButton radioButton_Female_instructor;
        private System.Windows.Forms.GroupBox groupBox_trainer;
        private System.Windows.Forms.GroupBox groupBox_instructor_info;
        private System.Windows.Forms.TextBox textBox_instr_id_adminpg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_trainerid;
        private System.Windows.Forms.Label label_trainer_id;
        private System.Windows.Forms.Button stats_btn;
    }
}