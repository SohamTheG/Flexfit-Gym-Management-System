namespace DBMS_project
{
    partial class ForgotPasswordForm
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
            this.textBox_password_forgpasspg = new System.Windows.Forms.TextBox();
            this.textBox_email_id_forgpasspg = new System.Windows.Forms.TextBox();
            this.new_password_lbl_forgpasspg = new System.Windows.Forms.Label();
            this.Email_id_lbl_forgpasspg = new System.Windows.Forms.Label();
            this.textBox_confirm_pass = new System.Windows.Forms.TextBox();
            this.confirmpasslbl_forgpasspg = new System.Windows.Forms.Label();
            this.submit_new_password_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_password_forgpasspg
            // 
            this.textBox_password_forgpasspg.Location = new System.Drawing.Point(195, 76);
            this.textBox_password_forgpasspg.Name = "textBox_password_forgpasspg";
            this.textBox_password_forgpasspg.Size = new System.Drawing.Size(180, 20);
            this.textBox_password_forgpasspg.TabIndex = 10;
            this.textBox_password_forgpasspg.TextChanged += new System.EventHandler(this.textBox_password_forgpasspg_TextChanged);
            // 
            // textBox_email_id_forgpasspg
            // 
            this.textBox_email_id_forgpasspg.Location = new System.Drawing.Point(195, 29);
            this.textBox_email_id_forgpasspg.Name = "textBox_email_id_forgpasspg";
            this.textBox_email_id_forgpasspg.Size = new System.Drawing.Size(180, 20);
            this.textBox_email_id_forgpasspg.TabIndex = 9;
            this.textBox_email_id_forgpasspg.TextChanged += new System.EventHandler(this.textBox_email_id_forgpasspg_TextChanged);
            // 
            // new_password_lbl_forgpasspg
            // 
            this.new_password_lbl_forgpasspg.AutoSize = true;
            this.new_password_lbl_forgpasspg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_password_lbl_forgpasspg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.new_password_lbl_forgpasspg.Location = new System.Drawing.Point(72, 76);
            this.new_password_lbl_forgpasspg.Name = "new_password_lbl_forgpasspg";
            this.new_password_lbl_forgpasspg.Size = new System.Drawing.Size(117, 16);
            this.new_password_lbl_forgpasspg.TabIndex = 8;
            this.new_password_lbl_forgpasspg.Text = "New Password :";
            this.new_password_lbl_forgpasspg.Click += new System.EventHandler(this.new_password_lbl_forgpasspg_Click);
            // 
            // Email_id_lbl_forgpasspg
            // 
            this.Email_id_lbl_forgpasspg.AutoSize = true;
            this.Email_id_lbl_forgpasspg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_id_lbl_forgpasspg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Email_id_lbl_forgpasspg.Location = new System.Drawing.Point(116, 33);
            this.Email_id_lbl_forgpasspg.Name = "Email_id_lbl_forgpasspg";
            this.Email_id_lbl_forgpasspg.Size = new System.Drawing.Size(73, 16);
            this.Email_id_lbl_forgpasspg.TabIndex = 7;
            this.Email_id_lbl_forgpasspg.Text = "Email ID :";
            this.Email_id_lbl_forgpasspg.Click += new System.EventHandler(this.Email_id_lbl_forgpasspg_Click);
            // 
            // textBox_confirm_pass
            // 
            this.textBox_confirm_pass.Location = new System.Drawing.Point(195, 117);
            this.textBox_confirm_pass.Name = "textBox_confirm_pass";
            this.textBox_confirm_pass.Size = new System.Drawing.Size(180, 20);
            this.textBox_confirm_pass.TabIndex = 12;
            this.textBox_confirm_pass.TextChanged += new System.EventHandler(this.textBox_confirm_pass_TextChanged);
            // 
            // confirmpasslbl_forgpasspg
            // 
            this.confirmpasslbl_forgpasspg.AutoSize = true;
            this.confirmpasslbl_forgpasspg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasslbl_forgpasspg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmpasslbl_forgpasspg.Location = new System.Drawing.Point(16, 118);
            this.confirmpasslbl_forgpasspg.Name = "confirmpasslbl_forgpasspg";
            this.confirmpasslbl_forgpasspg.Size = new System.Drawing.Size(173, 16);
            this.confirmpasslbl_forgpasspg.TabIndex = 11;
            this.confirmpasslbl_forgpasspg.Text = "Confirm New Password :";
            this.confirmpasslbl_forgpasspg.Click += new System.EventHandler(this.confirmpasslbl_forgpasspg_Click);
            // 
            // submit_new_password_btn
            // 
            this.submit_new_password_btn.BackColor = System.Drawing.Color.Black;
            this.submit_new_password_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_new_password_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit_new_password_btn.Location = new System.Drawing.Point(157, 163);
            this.submit_new_password_btn.Name = "submit_new_password_btn";
            this.submit_new_password_btn.Size = new System.Drawing.Size(119, 25);
            this.submit_new_password_btn.TabIndex = 13;
            this.submit_new_password_btn.Text = "Submit";
            this.submit_new_password_btn.UseVisualStyleBackColor = false;
            this.submit_new_password_btn.Click += new System.EventHandler(this.submit_new_password_btn_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(441, 224);
            this.Controls.Add(this.submit_new_password_btn);
            this.Controls.Add(this.textBox_confirm_pass);
            this.Controls.Add(this.confirmpasslbl_forgpasspg);
            this.Controls.Add(this.textBox_password_forgpasspg);
            this.Controls.Add(this.textBox_email_id_forgpasspg);
            this.Controls.Add(this.new_password_lbl_forgpasspg);
            this.Controls.Add(this.Email_id_lbl_forgpasspg);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_password_forgpasspg;
        private System.Windows.Forms.TextBox textBox_email_id_forgpasspg;
        private System.Windows.Forms.Label new_password_lbl_forgpasspg;
        private System.Windows.Forms.Label Email_id_lbl_forgpasspg;
        private System.Windows.Forms.TextBox textBox_confirm_pass;
        private System.Windows.Forms.Label confirmpasslbl_forgpasspg;
        private System.Windows.Forms.Button submit_new_password_btn;
    }
}