namespace DBMS_project
{
    partial class StatsForm
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
            this.labela = new System.Windows.Forms.Label();
            this.dataGridNO_gym_sess = new System.Windows.Forms.DataGridView();
            this.label_rev = new System.Windows.Forms.Label();
            this.dataGridViewMalevsFemale = new System.Windows.Forms.DataGridView();
            this.male_n_fe_lbl = new System.Windows.Forms.Label();
            this.dataGridViewInstructors = new System.Windows.Forms.DataGridView();
            this.labelx = new System.Windows.Forms.Label();
            this.dataGridTrainers = new System.Windows.Forms.DataGridView();
            this.labely = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNO_gym_sess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalevsFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTrainers)).BeginInit();
            this.SuspendLayout();
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labela.Location = new System.Drawing.Point(40, 222);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(217, 16);
            this.labela.TabIndex = 4;
            this.labela.Text = "No of Gym session For a Day :";
            // 
            // dataGridNO_gym_sess
            // 
            this.dataGridNO_gym_sess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNO_gym_sess.Location = new System.Drawing.Point(41, 255);
            this.dataGridNO_gym_sess.Name = "dataGridNO_gym_sess";
            this.dataGridNO_gym_sess.Size = new System.Drawing.Size(273, 144);
            this.dataGridNO_gym_sess.TabIndex = 5;
            this.dataGridNO_gym_sess.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNO_gym_sess_CellContentClick);
            // 
            // label_rev
            // 
            this.label_rev.AutoSize = true;
            this.label_rev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rev.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_rev.Location = new System.Drawing.Point(349, 340);
            this.label_rev.Name = "label_rev";
            this.label_rev.Size = new System.Drawing.Size(35, 16);
            this.label_rev.TabIndex = 7;
            this.label_rev.Text = "Rev";
            this.label_rev.Click += new System.EventHandler(this.label_rev_Click);
            // 
            // dataGridViewMalevsFemale
            // 
            this.dataGridViewMalevsFemale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMalevsFemale.Location = new System.Drawing.Point(352, 255);
            this.dataGridViewMalevsFemale.Name = "dataGridViewMalevsFemale";
            this.dataGridViewMalevsFemale.Size = new System.Drawing.Size(271, 61);
            this.dataGridViewMalevsFemale.TabIndex = 9;
            this.dataGridViewMalevsFemale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMalevsFemale_CellContentClick);
            // 
            // male_n_fe_lbl
            // 
            this.male_n_fe_lbl.AutoSize = true;
            this.male_n_fe_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_n_fe_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.male_n_fe_lbl.Location = new System.Drawing.Point(349, 222);
            this.male_n_fe_lbl.Name = "male_n_fe_lbl";
            this.male_n_fe_lbl.Size = new System.Drawing.Size(224, 16);
            this.male_n_fe_lbl.TabIndex = 8;
            this.male_n_fe_lbl.Text = "Males and Females on platform";
            this.male_n_fe_lbl.Click += new System.EventHandler(this.male_n_fe_lbl_Click);
            // 
            // dataGridViewInstructors
            // 
            this.dataGridViewInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstructors.Location = new System.Drawing.Point(43, 57);
            this.dataGridViewInstructors.Name = "dataGridViewInstructors";
            this.dataGridViewInstructors.Size = new System.Drawing.Size(273, 144);
            this.dataGridViewInstructors.TabIndex = 11;
            this.dataGridViewInstructors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInstructors_CellContentClick);
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelx.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelx.Location = new System.Drawing.Point(42, 24);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(78, 16);
            this.labelx.TabIndex = 10;
            this.labelx.Text = "Instructors";
            this.labelx.Click += new System.EventHandler(this.labelx_Click);
            // 
            // dataGridTrainers
            // 
            this.dataGridTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTrainers.Location = new System.Drawing.Point(350, 57);
            this.dataGridTrainers.Name = "dataGridTrainers";
            this.dataGridTrainers.Size = new System.Drawing.Size(273, 144);
            this.dataGridTrainers.TabIndex = 13;
            this.dataGridTrainers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTrainers_CellContentClick);
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labely.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labely.Location = new System.Drawing.Point(349, 24);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(65, 16);
            this.labely.TabIndex = 12;
            this.labely.Text = "Trainers";
            this.labely.Click += new System.EventHandler(this.labely_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.dataGridTrainers);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.dataGridViewInstructors);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.dataGridViewMalevsFemale);
            this.Controls.Add(this.male_n_fe_lbl);
            this.Controls.Add(this.label_rev);
            this.Controls.Add(this.dataGridNO_gym_sess);
            this.Controls.Add(this.labela);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNO_gym_sess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMalevsFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTrainers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.DataGridView dataGridNO_gym_sess;
        private System.Windows.Forms.Label label_rev;
        private System.Windows.Forms.DataGridView dataGridViewMalevsFemale;
        private System.Windows.Forms.Label male_n_fe_lbl;
        private System.Windows.Forms.DataGridView dataGridViewInstructors;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.DataGridView dataGridTrainers;
        private System.Windows.Forms.Label labely;
    }
}