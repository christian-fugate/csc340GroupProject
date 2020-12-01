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
            this.back = new System.Windows.Forms.Button();
            this.showDescription = new System.Windows.Forms.TextBox();
            this.orderTickets = new System.Windows.Forms.Button();
            this.selectAShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showBox
            // 
            this.showBox.FormattingEnabled = true;
            this.showBox.Location = new System.Drawing.Point(40, 73);
            this.showBox.Name = "showBox";
            this.showBox.Size = new System.Drawing.Size(294, 342);
            this.showBox.TabIndex = 0;
            this.showBox.SelectedIndexChanged += new System.EventHandler(this.showBox_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 22);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(91, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // showDescription
            // 
            this.showDescription.Location = new System.Drawing.Point(388, 73);
            this.showDescription.Multiline = true;
            this.showDescription.Name = "showDescription";
            this.showDescription.Size = new System.Drawing.Size(227, 269);
            this.showDescription.TabIndex = 3;
            this.showDescription.Text = "Show Description";
            // 
            // orderTickets
            // 
            this.orderTickets.Location = new System.Drawing.Point(448, 371);
            this.orderTickets.Name = "orderTickets";
            this.orderTickets.Size = new System.Drawing.Size(92, 23);
            this.orderTickets.TabIndex = 4;
            this.orderTickets.Text = "Order Tickets";
            this.orderTickets.UseVisualStyleBackColor = true;
            this.orderTickets.Click += new System.EventHandler(this.orderTickets_Click);
            // 
            // selectAShow
            // 
            this.selectAShow.AutoSize = true;
            this.selectAShow.Location = new System.Drawing.Point(425, 397);
            this.selectAShow.Name = "selectAShow";
            this.selectAShow.Size = new System.Drawing.Size(0, 13);
            this.selectAShow.TabIndex = 5;
            // 
            // shows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.selectAShow);
            this.Controls.Add(this.orderTickets);
            this.Controls.Add(this.showDescription);
            this.Controls.Add(this.back);
            this.Controls.Add(this.showBox);
            this.Name = "shows";
            this.Text = "Shows";
            this.Load += new System.EventHandler(this.shows_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox showBox;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox showDescription;
        private System.Windows.Forms.Button orderTickets;
        private System.Windows.Forms.Label selectAShow;
    }
}