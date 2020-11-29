namespace MovieTicketOrdering
{
    partial class shows
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
            this.backToLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.showDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showBox
            // 
            this.showBox.FormattingEnabled = true;
            this.showBox.Location = new System.Drawing.Point(40, 73);
            this.showBox.Name = "showBox";
            this.showBox.Size = new System.Drawing.Size(207, 342);
            this.showBox.TabIndex = 0;
            // 
            // backToLogin
            // 
            this.backToLogin.Location = new System.Drawing.Point(12, 22);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(91, 23);
            this.backToLogin.TabIndex = 1;
            this.backToLogin.Text = "Back To Info";
            this.backToLogin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Order Tickets";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // showDescription
            // 
            this.showDescription.Location = new System.Drawing.Point(326, 73);
            this.showDescription.Multiline = true;
            this.showDescription.Name = "showDescription";
            this.showDescription.Size = new System.Drawing.Size(227, 269);
            this.showDescription.TabIndex = 3;
            this.showDescription.Text = "Show Description";
            // 
            // shows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.showDescription);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.showBox);
            this.Name = "shows";
            this.Text = "Shows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox showBox;
        private System.Windows.Forms.Button backToLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox showDescription;
    }
}