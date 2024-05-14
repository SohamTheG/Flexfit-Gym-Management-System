namespace DBMS_project
{
    partial class PaymentForm
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
            this.account_no_lbl_pay = new System.Windows.Forms.Label();
            this.Pin_pay_lbl = new System.Windows.Forms.Label();
            this.amount_lbl_pay = new System.Windows.Forms.Label();
            this.payment_amt_pay = new System.Windows.Forms.Label();
            this.acctno_textBox_pay = new System.Windows.Forms.TextBox();
            this.pin_textBox_pay = new System.Windows.Forms.TextBox();
            this.submit_btn_pay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // account_no_lbl_pay
            // 
            this.account_no_lbl_pay.AutoSize = true;
            this.account_no_lbl_pay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.account_no_lbl_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_no_lbl_pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.account_no_lbl_pay.Location = new System.Drawing.Point(61, 38);
            this.account_no_lbl_pay.Name = "account_no_lbl_pay";
            this.account_no_lbl_pay.Size = new System.Drawing.Size(98, 16);
            this.account_no_lbl_pay.TabIndex = 11;
            this.account_no_lbl_pay.Text = "Account No. :";
            this.account_no_lbl_pay.Click += new System.EventHandler(this.account_no_lbl_pay_Click);
            // 
            // Pin_pay_lbl
            // 
            this.Pin_pay_lbl.AutoSize = true;
            this.Pin_pay_lbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pin_pay_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin_pay_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pin_pay_lbl.Location = new System.Drawing.Point(111, 82);
            this.Pin_pay_lbl.Name = "Pin_pay_lbl";
            this.Pin_pay_lbl.Size = new System.Drawing.Size(40, 16);
            this.Pin_pay_lbl.TabIndex = 12;
            this.Pin_pay_lbl.Text = "PIN :";
            this.Pin_pay_lbl.Click += new System.EventHandler(this.Pin_pay_lbl_Click);
            // 
            // amount_lbl_pay
            // 
            this.amount_lbl_pay.AutoSize = true;
            this.amount_lbl_pay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.amount_lbl_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_lbl_pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.amount_lbl_pay.Location = new System.Drawing.Point(36, 126);
            this.amount_lbl_pay.Name = "amount_lbl_pay";
            this.amount_lbl_pay.Size = new System.Drawing.Size(115, 16);
            this.amount_lbl_pay.TabIndex = 13;
            this.amount_lbl_pay.Text = "Total Payment :";
            this.amount_lbl_pay.Click += new System.EventHandler(this.amount_lbl_pay_Click);
            // 
            // payment_amt_pay
            // 
            this.payment_amt_pay.AutoSize = true;
            this.payment_amt_pay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.payment_amt_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_amt_pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.payment_amt_pay.Location = new System.Drawing.Point(162, 126);
            this.payment_amt_pay.Name = "payment_amt_pay";
            this.payment_amt_pay.Size = new System.Drawing.Size(24, 16);
            this.payment_amt_pay.TabIndex = 14;
            this.payment_amt_pay.Text = "no";
            this.payment_amt_pay.Click += new System.EventHandler(this.payment_amt_pay_Click);
            // 
            // acctno_textBox_pay
            // 
            this.acctno_textBox_pay.Location = new System.Drawing.Point(165, 38);
            this.acctno_textBox_pay.Name = "acctno_textBox_pay";
            this.acctno_textBox_pay.Size = new System.Drawing.Size(191, 20);
            this.acctno_textBox_pay.TabIndex = 15;
            this.acctno_textBox_pay.TextChanged += new System.EventHandler(this.acctno_textBox_pay_TextChanged);
            // 
            // pin_textBox_pay
            // 
            this.pin_textBox_pay.Location = new System.Drawing.Point(165, 82);
            this.pin_textBox_pay.Name = "pin_textBox_pay";
            this.pin_textBox_pay.Size = new System.Drawing.Size(191, 20);
            this.pin_textBox_pay.TabIndex = 16;
            this.pin_textBox_pay.TextChanged += new System.EventHandler(this.pin_textBox_pay_TextChanged);
            // 
            // submit_btn_pay
            // 
            this.submit_btn_pay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submit_btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn_pay.Location = new System.Drawing.Point(165, 173);
            this.submit_btn_pay.Name = "submit_btn_pay";
            this.submit_btn_pay.Size = new System.Drawing.Size(119, 25);
            this.submit_btn_pay.TabIndex = 17;
            this.submit_btn_pay.Text = "Submit";
            this.submit_btn_pay.UseVisualStyleBackColor = false;
            this.submit_btn_pay.Click += new System.EventHandler(this.submit_btn_pay_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(431, 241);
            this.Controls.Add(this.submit_btn_pay);
            this.Controls.Add(this.pin_textBox_pay);
            this.Controls.Add(this.acctno_textBox_pay);
            this.Controls.Add(this.payment_amt_pay);
            this.Controls.Add(this.amount_lbl_pay);
            this.Controls.Add(this.Pin_pay_lbl);
            this.Controls.Add(this.account_no_lbl_pay);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label account_no_lbl_pay;
        private System.Windows.Forms.Label Pin_pay_lbl;
        private System.Windows.Forms.Label amount_lbl_pay;
        private System.Windows.Forms.Label payment_amt_pay;
        private System.Windows.Forms.TextBox acctno_textBox_pay;
        private System.Windows.Forms.TextBox pin_textBox_pay;
        private System.Windows.Forms.Button submit_btn_pay;
    }
}