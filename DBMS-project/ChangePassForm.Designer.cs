namespace DBMS_project
{
    partial class ChangePassForm
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
            this.email_lbl_chps = new System.Windows.Forms.Label();
            this.New_pass_chps_lbl = new System.Windows.Forms.Label();
            this.confirm_new_pass_chps = new System.Windows.Forms.Label();
            this.Ok_btn_chps = new System.Windows.Forms.Button();
            this.email_tb_chps = new System.Windows.Forms.TextBox();
            this.new_pass_tb_chps = new System.Windows.Forms.TextBox();
            this.conf_new_pass_tb_chps = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // email_lbl_chps
            // 
            this.email_lbl_chps.AutoSize = true;
            this.email_lbl_chps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl_chps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.email_lbl_chps.Location = new System.Drawing.Point(64, 20);
            this.email_lbl_chps.Name = "email_lbl_chps";
            this.email_lbl_chps.Size = new System.Drawing.Size(136, 16);
            this.email_lbl_chps.TabIndex = 3;
            this.email_lbl_chps.Text = "Current Password :";
            this.email_lbl_chps.Click += new System.EventHandler(this.current_pass_lbl_chps_Click);
            // 
            // New_pass_chps_lbl
            // 
            this.New_pass_chps_lbl.AutoSize = true;
            this.New_pass_chps_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_pass_chps_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.New_pass_chps_lbl.Location = new System.Drawing.Point(83, 60);
            this.New_pass_chps_lbl.Name = "New_pass_chps_lbl";
            this.New_pass_chps_lbl.Size = new System.Drawing.Size(117, 16);
            this.New_pass_chps_lbl.TabIndex = 4;
            this.New_pass_chps_lbl.Text = "New Password :";
            this.New_pass_chps_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.New_pass_chps_lbl.Click += new System.EventHandler(this.New_pass_chps_lbl_Click);
            // 
            // confirm_new_pass_chps
            // 
            this.confirm_new_pass_chps.AutoSize = true;
            this.confirm_new_pass_chps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_new_pass_chps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirm_new_pass_chps.Location = new System.Drawing.Point(27, 101);
            this.confirm_new_pass_chps.Name = "confirm_new_pass_chps";
            this.confirm_new_pass_chps.Size = new System.Drawing.Size(173, 16);
            this.confirm_new_pass_chps.TabIndex = 5;
            this.confirm_new_pass_chps.Text = "Confirm New Password :";
            this.confirm_new_pass_chps.Click += new System.EventHandler(this.confirm_new_pass_chps_Click);
            // 
            // Ok_btn_chps
            // 
            this.Ok_btn_chps.BackColor = System.Drawing.Color.Black;
            this.Ok_btn_chps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok_btn_chps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ok_btn_chps.Location = new System.Drawing.Point(178, 145);
            this.Ok_btn_chps.Name = "Ok_btn_chps";
            this.Ok_btn_chps.Size = new System.Drawing.Size(86, 24);
            this.Ok_btn_chps.TabIndex = 6;
            this.Ok_btn_chps.Text = "OK";
            this.Ok_btn_chps.UseVisualStyleBackColor = false;
            this.Ok_btn_chps.Click += new System.EventHandler(this.Ok_btn_chps_Click);
            // 
            // email_tb_chps
            // 
            this.email_tb_chps.Location = new System.Drawing.Point(206, 20);
            this.email_tb_chps.Name = "email_tb_chps";
            this.email_tb_chps.Size = new System.Drawing.Size(194, 20);
            this.email_tb_chps.TabIndex = 7;
            this.email_tb_chps.TextChanged += new System.EventHandler(this.curr_pass_tb_chps_TextChanged);
            // 
            // new_pass_tb_chps
            // 
            this.new_pass_tb_chps.Location = new System.Drawing.Point(206, 60);
            this.new_pass_tb_chps.Name = "new_pass_tb_chps";
            this.new_pass_tb_chps.Size = new System.Drawing.Size(194, 20);
            this.new_pass_tb_chps.TabIndex = 8;
            this.new_pass_tb_chps.TextChanged += new System.EventHandler(this.new_pass_tb_chps_TextChanged);
            // 
            // conf_new_pass_tb_chps
            // 
            this.conf_new_pass_tb_chps.Location = new System.Drawing.Point(206, 101);
            this.conf_new_pass_tb_chps.Name = "conf_new_pass_tb_chps";
            this.conf_new_pass_tb_chps.Size = new System.Drawing.Size(194, 20);
            this.conf_new_pass_tb_chps.TabIndex = 9;
            this.conf_new_pass_tb_chps.TextChanged += new System.EventHandler(this.conf_new_pass_tb_chps_TextChanged);
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(452, 190);
            this.Controls.Add(this.conf_new_pass_tb_chps);
            this.Controls.Add(this.new_pass_tb_chps);
            this.Controls.Add(this.email_tb_chps);
            this.Controls.Add(this.Ok_btn_chps);
            this.Controls.Add(this.confirm_new_pass_chps);
            this.Controls.Add(this.New_pass_chps_lbl);
            this.Controls.Add(this.email_lbl_chps);
            this.Name = "ChangePassForm";
            this.Text = "ChangePassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_lbl_chps;
        private System.Windows.Forms.Label New_pass_chps_lbl;
        private System.Windows.Forms.Label confirm_new_pass_chps;
        private System.Windows.Forms.Button Ok_btn_chps;
        private System.Windows.Forms.TextBox email_tb_chps;
        private System.Windows.Forms.TextBox new_pass_tb_chps;
        private System.Windows.Forms.TextBox conf_new_pass_tb_chps;
    }
}