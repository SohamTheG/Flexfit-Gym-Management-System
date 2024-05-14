namespace DBMS_project
{
    partial class bookedsessionForm
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
            this.Ok_btn_mysesspg = new System.Windows.Forms.Button();
            this.Mysess_lbl_mysesspg = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok_btn_mysesspg
            // 
            this.Ok_btn_mysesspg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ok_btn_mysesspg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ok_btn_mysesspg.Location = new System.Drawing.Point(490, 397);
            this.Ok_btn_mysesspg.Name = "Ok_btn_mysesspg";
            this.Ok_btn_mysesspg.Size = new System.Drawing.Size(86, 24);
            this.Ok_btn_mysesspg.TabIndex = 7;
            this.Ok_btn_mysesspg.Text = "OK";
            this.Ok_btn_mysesspg.UseVisualStyleBackColor = false;
            this.Ok_btn_mysesspg.Click += new System.EventHandler(this.Ok_btn_mysesspg_Click);
            // 
            // Mysess_lbl_mysesspg
            // 
            this.Mysess_lbl_mysesspg.AutoSize = true;
            this.Mysess_lbl_mysesspg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mysess_lbl_mysesspg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mysess_lbl_mysesspg.Location = new System.Drawing.Point(42, 34);
            this.Mysess_lbl_mysesspg.Name = "Mysess_lbl_mysesspg";
            this.Mysess_lbl_mysesspg.Size = new System.Drawing.Size(95, 16);
            this.Mysess_lbl_mysesspg.TabIndex = 6;
            this.Mysess_lbl_mysesspg.Text = "My Sessions";
            this.Mysess_lbl_mysesspg.Click += new System.EventHandler(this.Mysess_lbl_mysesspg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 119);
            this.dataGridView1.TabIndex = 8;
            // 
            // bookedsessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ok_btn_mysesspg);
            this.Controls.Add(this.Mysess_lbl_mysesspg);
            this.Name = "bookedsessionForm";
            this.Text = "bookedsessionForm";
            this.Load += new System.EventHandler(this.bookedsessionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_btn_mysesspg;
        private System.Windows.Forms.Label Mysess_lbl_mysesspg;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}