namespace MovieTicketOrdering
{
    partial class theaterInfo
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
            this.showBox = new System.Windows.Forms.ListBox();
            this.ticketBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketSales = new System.Windows.Forms.Label();
            this.totalCanceled = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showDate = new System.Windows.Forms.MonthCalendar();
            this.emplogin = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.logIn = new System.Windows.Forms.Button();
            this.emplogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // showBox
            // 
            this.showBox.FormattingEnabled = true;
            this.showBox.Location = new System.Drawing.Point(12, 67);
            this.showBox.Name = "showBox";
            this.showBox.Size = new System.Drawing.Size(461, 147);
            this.showBox.TabIndex = 1;
            this.showBox.SelectedIndexChanged += new System.EventHandler(this.showBox_SelectedIndexChanged);
            // 
            // ticketBox
            // 
            this.ticketBox.FormattingEnabled = true;
            this.ticketBox.Location = new System.Drawing.Point(485, 67);
            this.ticketBox.Name = "ticketBox";
            this.ticketBox.Size = new System.Drawing.Size(408, 342);
            this.ticketBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Sales";
            // 
            // ticketSales
            // 
            this.ticketSales.AutoSize = true;
            this.ticketSales.Location = new System.Drawing.Point(680, 428);
            this.ticketSales.Name = "ticketSales";
            this.ticketSales.Size = new System.Drawing.Size(0, 13);
            this.ticketSales.TabIndex = 4;
            // 
            // totalCanceled
            // 
            this.totalCanceled.AutoSize = true;
            this.totalCanceled.Location = new System.Drawing.Point(680, 452);
            this.totalCanceled.Name = "totalCanceled";
            this.totalCanceled.Size = new System.Drawing.Size(0, 13);
            this.totalCanceled.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Canceled";
            // 
            // showDate
            // 
            this.showDate.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.showDate.Location = new System.Drawing.Point(15, 226);
            this.showDate.MaxSelectionCount = 1;
            this.showDate.Name = "showDate";
            this.showDate.TabIndex = 7;
            this.showDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.showDate_DateChanged);
            // 
            // emplogin
            // 
            this.emplogin.Controls.Add(this.logIn);
            this.emplogin.Controls.Add(this.password);
            this.emplogin.Controls.Add(this.label2);
            this.emplogin.Controls.Add(this.back);
            this.emplogin.Location = new System.Drawing.Point(12, 12);
            this.emplogin.Name = "emplogin";
            this.emplogin.Size = new System.Drawing.Size(916, 504);
            this.emplogin.TabIndex = 8;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(13, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the Employee Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(342, 214);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(170, 20);
            this.password.TabIndex = 2;
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(385, 260);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(75, 23);
            this.logIn.TabIndex = 3;
            this.logIn.Text = "Login";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // theaterInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 528);
            this.Controls.Add(this.emplogin);
            this.Controls.Add(this.showDate);
            this.Controls.Add(this.totalCanceled);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ticketSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketBox);
            this.Controls.Add(this.showBox);
            this.Name = "theaterInfo";
            this.Text = "theaterInfo";
            this.emplogin.ResumeLayout(false);
            this.emplogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox showBox;
        private System.Windows.Forms.ListBox ticketBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ticketSales;
        private System.Windows.Forms.Label totalCanceled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar showDate;
        private System.Windows.Forms.Panel emplogin;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
    }
}