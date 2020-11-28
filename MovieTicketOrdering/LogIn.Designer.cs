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
            this.ticketsView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelTicket = new System.Windows.Forms.Button();
            this.findShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updateUser = new System.Windows.Forms.Button();
            this.userView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsView
            // 
            this.ticketsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsView.Location = new System.Drawing.Point(27, 64);
            this.ticketsView.Name = "ticketsView";
            this.ticketsView.Size = new System.Drawing.Size(251, 253);
            this.ticketsView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(24, 30);
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
            // 
            // findShow
            // 
            this.findShow.Location = new System.Drawing.Point(346, 182);
            this.findShow.Name = "findShow";
            this.findShow.Size = new System.Drawing.Size(90, 23);
            this.findShow.TabIndex = 3;
            this.findShow.Text = "Find Show";
            this.findShow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Info";
            // 
            // updateUser
            // 
            this.updateUser.Location = new System.Drawing.Point(657, 182);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(75, 23);
            this.updateUser.TabIndex = 5;
            this.updateUser.Text = "Update";
            this.updateUser.UseVisualStyleBackColor = true;
            // 
            // userView
            // 
            this.userView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userView.Location = new System.Drawing.Point(540, 49);
            this.userView.Name = "userView";
            this.userView.Size = new System.Drawing.Size(192, 127);
            this.userView.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(334, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Log In";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(292, 144);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(161, 20);
            this.username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(292, 177);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(161, 20);
            this.password.TabIndex = 4;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(15, 20);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(102, 45);
            this.back.TabIndex = 5;
            this.back.Text = "Back To Main";
            this.back.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userView);
            this.Controls.Add(this.updateUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findShow);
            this.Controls.Add(this.cancelTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ticketsView);
            this.Name = "LogIn";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ticketsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ticketsView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelTicket;
        private System.Windows.Forms.Button findShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.DataGridView userView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button button4;
    }
}