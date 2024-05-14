namespace DBMS_project
{
    partial class payment_history
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
            this.Transaction_lbl_transpg = new System.Windows.Forms.Label();
            this.Ok_btn_transpg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Transaction_lbl_transpg
            // 
            this.Transaction_lbl_transpg.AutoSize = true;
            this.Transaction_lbl_transpg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction_lbl_transpg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Transaction_lbl_transpg.Location = new System.Drawing.Point(30, 48);
            this.Transaction_lbl_transpg.Name = "Transaction_lbl_transpg";
            this.Transaction_lbl_transpg.Size = new System.Drawing.Size(97, 16);
            this.Transaction_lbl_transpg.TabIndex = 2;
            this.Transaction_lbl_transpg.Text = "Transactions";
            this.Transaction_lbl_transpg.Click += new System.EventHandler(this.Transaction_lbl_transpg_Click);
            // 
            // Ok_btn_transpg
            // 
            this.Ok_btn_transpg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ok_btn_transpg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ok_btn_transpg.Location = new System.Drawing.Point(463, 393);
            this.Ok_btn_transpg.Name = "Ok_btn_transpg";
            this.Ok_btn_transpg.Size = new System.Drawing.Size(86, 24);
            this.Ok_btn_transpg.TabIndex = 3;
            this.Ok_btn_transpg.Text = "OK";
            this.Ok_btn_transpg.UseVisualStyleBackColor = false;
            this.Ok_btn_transpg.Click += new System.EventHandler(this.Ok_btn_transpg_Click);
            // 
            // payment_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.Ok_btn_transpg);
            this.Controls.Add(this.Transaction_lbl_transpg);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "payment_history";
            this.Text = "payment_history";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Transaction_lbl_transpg;
        private System.Windows.Forms.Button Ok_btn_transpg;
    }
}