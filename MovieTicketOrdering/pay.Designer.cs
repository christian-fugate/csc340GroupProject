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
            this.backSeats = new System.Windows.Forms.Button();
            this.ticketbox = new System.Windows.Forms.ListBox();
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
            this.confirmPay.Location = new System.Drawing.Point(386, 219);
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
            this.userName.Location = new System.Drawing.Point(347, 124);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(55, 13);
            this.userName.TabIndex = 3;
            this.userName.Text = "Username";
            // 
            // cancelByDate
            // 
            this.cancelByDate.AutoSize = true;
            this.cancelByDate.Location = new System.Drawing.Point(334, 288);
            this.cancelByDate.Name = "cancelByDate";
            this.cancelByDate.Size = new System.Drawing.Size(173, 13);
            this.cancelByDate.TabIndex = 4;
            this.cancelByDate.Text = "Last Date to Cancel: XX/XX/XXXX";
            // 
            // backSeats
            // 
            this.backSeats.Location = new System.Drawing.Point(25, 13);
            this.backSeats.Name = "backSeats";
            this.backSeats.Size = new System.Drawing.Size(75, 23);
            this.backSeats.TabIndex = 5;
            this.backSeats.Text = "Back To Seats";
            this.backSeats.UseVisualStyleBackColor = true;
            // 
            // ticketbox
            // 
            this.ticketbox.FormattingEnabled = true;
            this.ticketbox.Location = new System.Drawing.Point(88, 108);
            this.ticketbox.Name = "ticketbox";
            this.ticketbox.Size = new System.Drawing.Size(240, 212);
            this.ticketbox.TabIndex = 6;
            // 
            // pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 415);
            this.Controls.Add(this.ticketbox);
            this.Controls.Add(this.backSeats);
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
        private System.Windows.Forms.Button backSeats;
        private System.Windows.Forms.ListBox ticketbox;
    }
}