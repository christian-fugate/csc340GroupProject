namespace MovieTicketOrdering
{
    //hannah is here
    partial class mainMenu
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
            this.logIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.theaterInfo = new System.Windows.Forms.Button();
            this.seeShows = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(413, 294);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(77, 43);
            this.logIn.TabIndex = 0;
            this.logIn.Text = "Log In Or Sign Up";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 303);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // theaterInfo
            // 
            this.theaterInfo.Location = new System.Drawing.Point(76, 367);
            this.theaterInfo.Name = "theaterInfo";
            this.theaterInfo.Size = new System.Drawing.Size(114, 48);
            this.theaterInfo.TabIndex = 3;
            this.theaterInfo.Text = "Staff Only";
            this.theaterInfo.UseVisualStyleBackColor = true;
            this.theaterInfo.Click += new System.EventHandler(this.theaterInfo_Click);
            // 
            // seeShows
            // 
            this.seeShows.Location = new System.Drawing.Point(382, 265);
            this.seeShows.Name = "seeShows";
            this.seeShows.Size = new System.Drawing.Size(138, 23);
            this.seeShows.TabIndex = 4;
            this.seeShows.Text = "See Show Information";
            this.seeShows.UseVisualStyleBackColor = true;
            this.seeShows.Click += new System.EventHandler(this.seeShows_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(376, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome!";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seeShows);
            this.Controls.Add(this.theaterInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logIn);
            this.Name = "mainMenu";
            this.Text = "FEW Theater";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button theaterInfo;
        private System.Windows.Forms.Button seeShows;
        private System.Windows.Forms.Label label1;
    }
}

