namespace MovieTicketOrdering
{
    partial class createAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.cardNumber = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.isUsernameGood = new System.Windows.Forms.Label();
            this.returnToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Card Number:";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(238, 86);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(166, 20);
            this.fName.TabIndex = 8;
            this.fName.TextChanged += new System.EventHandler(this.fName_TextChanged);
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(238, 113);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(166, 20);
            this.lName.TabIndex = 9;
            this.lName.TextChanged += new System.EventHandler(this.lName_TextChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(238, 140);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(166, 20);
            this.username.TabIndex = 10;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(238, 164);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(166, 20);
            this.password.TabIndex = 11;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(238, 187);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(166, 20);
            this.email.TabIndex = 12;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // cardNumber
            // 
            this.cardNumber.Location = new System.Drawing.Point(238, 213);
            this.cardNumber.MaxLength = 16;
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(166, 20);
            this.cardNumber.TabIndex = 13;
            this.cardNumber.TextChanged += new System.EventHandler(this.cardNumber_TextChanged);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(267, 239);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(95, 23);
            this.create.TabIndex = 14;
            this.create.Text = "Create Account";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // isUsernameGood
            // 
            this.isUsernameGood.AutoSize = true;
            this.isUsernameGood.Location = new System.Drawing.Point(250, 265);
            this.isUsernameGood.Name = "isUsernameGood";
            this.isUsernameGood.Size = new System.Drawing.Size(0, 13);
            this.isUsernameGood.TabIndex = 15;
            this.isUsernameGood.Click += new System.EventHandler(this.isUsernameGood_Click);
            // 
            // returnToLogin
            // 
            this.returnToLogin.Location = new System.Drawing.Point(12, 12);
            this.returnToLogin.Name = "returnToLogin";
            this.returnToLogin.Size = new System.Drawing.Size(103, 27);
            this.returnToLogin.TabIndex = 16;
            this.returnToLogin.Text = "Return To Login";
            this.returnToLogin.UseVisualStyleBackColor = true;
            this.returnToLogin.Click += new System.EventHandler(this.returnToLogin_Click);
            // 
            // createAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 352);
            this.Controls.Add(this.returnToLogin);
            this.Controls.Add(this.isUsernameGood);
            this.Controls.Add(this.create);
            this.Controls.Add(this.cardNumber);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "createAccount";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.createAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox cardNumber;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label isUsernameGood;
        private System.Windows.Forms.Button returnToLogin;
    }
}