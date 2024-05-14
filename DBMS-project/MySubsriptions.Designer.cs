namespace DBMS_project
{
    partial class MySubsriptions
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
            this.Ok_btn_mysubspg = new System.Windows.Forms.Button();
            this.Mysubs_lbl_mysubpg = new System.Windows.Forms.Label();
            this.dataGridView_subs = new System.Windows.Forms.DataGridView();
            this.dataGridzumba = new System.Windows.Forms.DataGridView();
            this.dataGridboxing = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_subs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridzumba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridboxing)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok_btn_mysubspg
            // 
            this.Ok_btn_mysubspg.BackColor = System.Drawing.Color.Black;
            this.Ok_btn_mysubspg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Ok_btn_mysubspg.Location = new System.Drawing.Point(474, 396);
            this.Ok_btn_mysubspg.Name = "Ok_btn_mysubspg";
            this.Ok_btn_mysubspg.Size = new System.Drawing.Size(86, 24);
            this.Ok_btn_mysubspg.TabIndex = 5;
            this.Ok_btn_mysubspg.Text = "OK";
            this.Ok_btn_mysubspg.UseVisualStyleBackColor = false;
            this.Ok_btn_mysubspg.Click += new System.EventHandler(this.Ok_btn_mysubspg_Click);
            // 
            // Mysubs_lbl_mysubpg
            // 
            this.Mysubs_lbl_mysubpg.AutoSize = true;
            this.Mysubs_lbl_mysubpg.BackColor = System.Drawing.Color.Black;
            this.Mysubs_lbl_mysubpg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mysubs_lbl_mysubpg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mysubs_lbl_mysubpg.Location = new System.Drawing.Point(26, 49);
            this.Mysubs_lbl_mysubpg.Name = "Mysubs_lbl_mysubpg";
            this.Mysubs_lbl_mysubpg.Size = new System.Drawing.Size(125, 16);
            this.Mysubs_lbl_mysubpg.TabIndex = 4;
            this.Mysubs_lbl_mysubpg.Text = "My Subscriptions";
            this.Mysubs_lbl_mysubpg.Click += new System.EventHandler(this.Mysubs_lbl_mysubpg_Click);
            // 
            // dataGridView_subs
            // 
            this.dataGridView_subs.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_subs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_subs.Location = new System.Drawing.Point(30, 84);
            this.dataGridView_subs.Name = "dataGridView_subs";
            this.dataGridView_subs.ReadOnly = true;
            this.dataGridView_subs.Size = new System.Drawing.Size(529, 80);
            this.dataGridView_subs.TabIndex = 6;
            this.dataGridView_subs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_subs_CellContentClick);
            // 
            // dataGridzumba
            // 
            this.dataGridzumba.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridzumba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridzumba.Location = new System.Drawing.Point(30, 203);
            this.dataGridzumba.Name = "dataGridzumba";
            this.dataGridzumba.ReadOnly = true;
            this.dataGridzumba.Size = new System.Drawing.Size(529, 80);
            this.dataGridzumba.TabIndex = 7;
            // 
            // dataGridboxing
            // 
            this.dataGridboxing.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridboxing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridboxing.Location = new System.Drawing.Point(29, 289);
            this.dataGridboxing.Name = "dataGridboxing";
            this.dataGridboxing.ReadOnly = true;
            this.dataGridboxing.Size = new System.Drawing.Size(529, 80);
            this.dataGridboxing.TabIndex = 8;
            // 
            // MySubsriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.dataGridboxing);
            this.Controls.Add(this.dataGridzumba);
            this.Controls.Add(this.dataGridView_subs);
            this.Controls.Add(this.Ok_btn_mysubspg);
            this.Controls.Add(this.Mysubs_lbl_mysubpg);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "MySubsriptions";
            this.Text = "MySubsriptions";
            this.Load += new System.EventHandler(this.MySubsriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_subs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridzumba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridboxing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_btn_mysubspg;
        private System.Windows.Forms.Label Mysubs_lbl_mysubpg;
        private System.Windows.Forms.DataGridView dataGridView_subs;
        private System.Windows.Forms.DataGridView dataGridzumba;
        private System.Windows.Forms.DataGridView dataGridboxing;
    }
}