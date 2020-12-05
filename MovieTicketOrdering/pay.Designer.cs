namespace MovieTicketOrdering
{
    partial class pay
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
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPay = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.cancelByDate = new System.Windows.Forms.Label();
            this.ticketbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.member = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tickets";
            // 
            // confirmPay
            // 
            this.confirmPay.Location = new System.Drawing.Point(370, 226);
            this.confirmPay.Name = "confirmPay";
            this.confirmPay.Size = new System.Drawing.Size(73, 47);
            this.confirmPay.TabIndex = 2;
            this.confirmPay.Text = "Confirm and Pay";
            this.confirmPay.UseVisualStyleBackColor = true;
            this.confirmPay.Click += new System.EventHandler(this.confirmPay_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(347, 108);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(55, 13);
            this.userName.TabIndex = 3;
            this.userName.Text = "Username";
            // 
            // cancelByDate
            // 
            this.cancelByDate.AutoSize = true;
            this.cancelByDate.Location = new System.Drawing.Point(318, 307);
            this.cancelByDate.Name = "cancelByDate";
            this.cancelByDate.Size = new System.Drawing.Size(173, 13);
            this.cancelByDate.TabIndex = 4;
            this.cancelByDate.Text = "Last Date to Cancel: XX/XX/XXXX";
            // 
            // ticketbox
            // 
            this.ticketbox.FormattingEnabled = true;
            this.ticketbox.Location = new System.Drawing.Point(38, 108);
            this.ticketbox.Name = "ticketbox";
            this.ticketbox.Size = new System.Drawing.Size(240, 212);
            this.ticketbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total: ";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(383, 210);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(37, 13);
            this.total.TabIndex = 8;
            this.total.Text = "Total: ";
            // 
            // member
            // 
            this.member.Location = new System.Drawing.Point(350, 134);
            this.member.Multiline = true;
            this.member.Name = "member";
            this.member.ReadOnly = true;
            this.member.Size = new System.Drawing.Size(109, 58);
            this.member.TabIndex = 9;
            this.member.Text = "You are not a Member - Members get 10% off their purchases";
            this.member.TextChanged += new System.EventHandler(this.member_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 324);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 47);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Return to User Info and Click \"Update Tickets\" to see these tickets.";
            // 
            // feedback
            // 
            this.feedback.AutoSize = true;
            this.feedback.Location = new System.Drawing.Point(367, 276);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(0, 13);
            this.feedback.TabIndex = 11;
            // 
            // pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 383);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.member);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketbox);
            this.Controls.Add(this.cancelByDate);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.confirmPay);
            this.Controls.Add(this.label1);
            this.Name = "pay";
            this.Text = "Confirm Order";
            this.Load += new System.EventHandler(this.pay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmPay;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label cancelByDate;
        private System.Windows.Forms.ListBox ticketbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox member;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label feedback;
    }
}