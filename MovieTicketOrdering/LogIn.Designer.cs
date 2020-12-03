namespace MovieTicketOrdering
{
    partial class LogIn
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
            this.cancelTicket = new System.Windows.Forms.Button();
            this.findShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updateUser = new System.Windows.Forms.Button();
            this.ticketBox = new System.Windows.Forms.ListBox();
            this.fName = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fNameChange = new System.Windows.Forms.TextBox();
            this.lNameChange = new System.Windows.Forms.TextBox();
            this.emailChange = new System.Windows.Forms.TextBox();
            this.cardChange = new System.Windows.Forms.TextBox();
            this.signUp = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.Panel();
            this.userOrPass = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.userfname = new System.Windows.Forms.Label();
            this.userlname = new System.Windows.Forms.Label();
            this.useremail = new System.Windows.Forms.Label();
            this.usercardnumber = new System.Windows.Forms.Label();
            this.Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(117, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tickets";
            // 
            // cancelTicket
            // 
            this.cancelTicket.Location = new System.Drawing.Point(346, 90);
            this.cancelTicket.Name = "cancelTicket";
            this.cancelTicket.Size = new System.Drawing.Size(90, 23);
            this.cancelTicket.TabIndex = 2;
            this.cancelTicket.Text = "Cancel Ticket";
            this.cancelTicket.UseVisualStyleBackColor = true;
            this.cancelTicket.Click += new System.EventHandler(this.cancelTicket_Click);
            // 
            // findShow
            // 
            this.findShow.Location = new System.Drawing.Point(346, 182);
            this.findShow.Name = "findShow";
            this.findShow.Size = new System.Drawing.Size(90, 23);
            this.findShow.TabIndex = 3;
            this.findShow.Text = "Find Show";
            this.findShow.UseVisualStyleBackColor = true;
            this.findShow.Click += new System.EventHandler(this.findShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Info";
            // 
            // updateUser
            // 
            this.updateUser.Location = new System.Drawing.Point(583, 349);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(75, 23);
            this.updateUser.TabIndex = 5;
            this.updateUser.Text = "Update";
            this.updateUser.UseVisualStyleBackColor = true;
            // 
            // ticketBox
            // 
            this.ticketBox.FormattingEnabled = true;
            this.ticketBox.Location = new System.Drawing.Point(120, 49);
            this.ticketBox.Name = "ticketBox";
            this.ticketBox.Size = new System.Drawing.Size(162, 303);
            this.ticketBox.TabIndex = 9;
            this.ticketBox.SelectedIndexChanged += new System.EventHandler(this.ticketBox_SelectedIndexChanged);
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Location = new System.Drawing.Point(540, 49);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(60, 13);
            this.fName.TabIndex = 10;
            this.fName.Text = "First Name:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(540, 77);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(61, 13);
            this.lName.TabIndex = 11;
            this.lName.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Card Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Change Details here:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Card Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(540, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(540, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Last Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(540, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "First Name:";
            // 
            // fNameChange
            // 
            this.fNameChange.Location = new System.Drawing.Point(607, 249);
            this.fNameChange.Name = "fNameChange";
            this.fNameChange.Size = new System.Drawing.Size(100, 20);
            this.fNameChange.TabIndex = 19;
            // 
            // lNameChange
            // 
            this.lNameChange.Location = new System.Drawing.Point(607, 275);
            this.lNameChange.Name = "lNameChange";
            this.lNameChange.Size = new System.Drawing.Size(100, 20);
            this.lNameChange.TabIndex = 20;
            // 
            // emailChange
            // 
            this.emailChange.Location = new System.Drawing.Point(607, 297);
            this.emailChange.Name = "emailChange";
            this.emailChange.Size = new System.Drawing.Size(100, 20);
            this.emailChange.TabIndex = 21;
            // 
            // cardChange
            // 
            this.cardChange.Location = new System.Drawing.Point(607, 320);
            this.cardChange.Name = "cardChange";
            this.cardChange.Size = new System.Drawing.Size(125, 20);
            this.cardChange.TabIndex = 22;
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(24, 62);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(75, 23);
            this.signUp.TabIndex = 12;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 14);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(102, 45);
            this.back.TabIndex = 11;
            this.back.Text = "Back To Main";
            this.back.UseVisualStyleBackColor = true;
            // 
            // Input
            // 
            this.Input.Controls.Add(this.userOrPass);
            this.Input.Controls.Add(this.log);
            this.Input.Controls.Add(this.password);
            this.Input.Controls.Add(this.label4);
            this.Input.Controls.Add(this.label3);
            this.Input.Controls.Add(this.username);
            this.Input.Location = new System.Drawing.Point(36, 431);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(776, 414);
            this.Input.TabIndex = 24;
            // 
            // userOrPass
            // 
            this.userOrPass.AutoSize = true;
            this.userOrPass.Location = new System.Drawing.Point(212, 225);
            this.userOrPass.Name = "userOrPass";
            this.userOrPass.Size = new System.Drawing.Size(0, 13);
            this.userOrPass.TabIndex = 12;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(334, 199);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 11;
            this.log.Text = "Log In";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(291, 174);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(161, 20);
            this.password.TabIndex = 10;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(291, 141);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(161, 20);
            this.username.TabIndex = 7;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // userfname
            // 
            this.userfname.AutoSize = true;
            this.userfname.Location = new System.Drawing.Point(606, 49);
            this.userfname.Name = "userfname";
            this.userfname.Size = new System.Drawing.Size(52, 13);
            this.userfname.TabIndex = 25;
            this.userfname.Text = "Firstname";
            // 
            // userlname
            // 
            this.userlname.AutoSize = true;
            this.userlname.Location = new System.Drawing.Point(607, 77);
            this.userlname.Name = "userlname";
            this.userlname.Size = new System.Drawing.Size(53, 13);
            this.userlname.TabIndex = 26;
            this.userlname.Text = "Lastname";
            // 
            // useremail
            // 
            this.useremail.AutoSize = true;
            this.useremail.Location = new System.Drawing.Point(580, 100);
            this.useremail.Name = "useremail";
            this.useremail.Size = new System.Drawing.Size(32, 13);
            this.useremail.TabIndex = 27;
            this.useremail.Text = "Email";
            // 
            // usercardnumber
            // 
            this.usercardnumber.AutoSize = true;
            this.usercardnumber.Location = new System.Drawing.Point(619, 123);
            this.usercardnumber.Name = "usercardnumber";
            this.usercardnumber.Size = new System.Drawing.Size(65, 13);
            this.usercardnumber.TabIndex = 28;
            this.usercardnumber.Text = "cardNumber";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.cardChange);
            this.Controls.Add(this.emailChange);
            this.Controls.Add(this.lNameChange);
            this.Controls.Add(this.fNameChange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.ticketBox);
            this.Controls.Add(this.updateUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findShow);
            this.Controls.Add(this.cancelTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usercardnumber);
            this.Controls.Add(this.useremail);
            this.Controls.Add(this.userlname);
            this.Controls.Add(this.userfname);
            this.Name = "LogIn";
            this.Text = "Log In ";
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelTicket;
        private System.Windows.Forms.Button findShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.ListBox ticketBox;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fNameChange;
        private System.Windows.Forms.TextBox lNameChange;
        private System.Windows.Forms.TextBox emailChange;
        private System.Windows.Forms.TextBox cardChange;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.Panel Input;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Label userOrPass;
        private System.Windows.Forms.Label userfname;
        private System.Windows.Forms.Label userlname;
        private System.Windows.Forms.Label useremail;
        private System.Windows.Forms.Label usercardnumber;
    }
}