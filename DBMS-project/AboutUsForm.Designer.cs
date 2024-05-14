namespace DBMS_project
{
    partial class AboutUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsForm));
            this.About_US_LBL = new System.Windows.Forms.Label();
            this.button1_abtus = new System.Windows.Forms.Button();
            this.label1_abtus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // About_US_LBL
            // 
            this.About_US_LBL.AutoSize = true;
            this.About_US_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_US_LBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.About_US_LBL.Location = new System.Drawing.Point(310, 56);
            this.About_US_LBL.Name = "About_US_LBL";
            this.About_US_LBL.Size = new System.Drawing.Size(171, 24);
            this.About_US_LBL.TabIndex = 0;
            this.About_US_LBL.Text = "About Us Section";
            this.About_US_LBL.Click += new System.EventHandler(this.About_US_LBL_Click);
            // 
            // button1_abtus
            // 
            this.button1_abtus.BackColor = System.Drawing.Color.Black;
            this.button1_abtus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_abtus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_abtus.Location = new System.Drawing.Point(679, 413);
            this.button1_abtus.Name = "button1_abtus";
            this.button1_abtus.Size = new System.Drawing.Size(97, 25);
            this.button1_abtus.TabIndex = 1;
            this.button1_abtus.Text = "OK";
            this.button1_abtus.UseVisualStyleBackColor = false;
            this.button1_abtus.Click += new System.EventHandler(this.button1_abtus_Click);
            // 
            // label1_abtus
            // 
            this.label1_abtus.AutoSize = true;
            this.label1_abtus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_abtus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1_abtus.Location = new System.Drawing.Point(17, 105);
            this.label1_abtus.MaximumSize = new System.Drawing.Size(780, 0);
            this.label1_abtus.Name = "label1_abtus";
            this.label1_abtus.Size = new System.Drawing.Size(771, 192);
            this.label1_abtus.TabIndex = 2;
            this.label1_abtus.Text = resources.GetString("label1_abtus.Text");
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1_abtus);
            this.Controls.Add(this.button1_abtus);
            this.Controls.Add(this.About_US_LBL);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AboutUsForm";
            this.Text = "AboutUsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label About_US_LBL;
        private System.Windows.Forms.Button button1_abtus;
        private System.Windows.Forms.Label label1_abtus;
    }
}