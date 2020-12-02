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
            this.ticketbox = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPay = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backSeats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ticketbox
            // 
            this.ticketbox.HideSelection = false;
            this.ticketbox.Location = new System.Drawing.Point(112, 122);
            this.ticketbox.Name = "ticketbox";
            this.ticketbox.Size = new System.Drawing.Size(135, 142);
            this.ticketbox.TabIndex = 0;
            this.ticketbox.UseCompatibleStateImageBehavior = false;
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
            this.confirmPay.Location = new System.Drawing.Point(313, 217);
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
            this.userName.Location = new System.Drawing.Point(274, 122);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(55, 13);
            this.userName.TabIndex = 3;
            this.userName.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Date to Cancel: XX/XX/XXXX";
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
            // pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 415);
            this.Controls.Add(this.backSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.confirmPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketbox);
            this.Name = "pay";
            this.Text = "Confirm Order";
            this.Load += new System.EventHandler(this.pay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ticketbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmPay;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backSeats;
    }
}