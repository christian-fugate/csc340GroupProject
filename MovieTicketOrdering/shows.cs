using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketOrdering
{
    public partial class shows : Form
    {
        showClass currentShows = new showClass();
        int userID = -1;
        string username;
        public shows()
        {
            InitializeComponent();
        }
        public shows(int uID)
        {
            InitializeComponent();
            userID = uID;
        }
        
        private void shows_Load(object sender, EventArgs e)
        {
            currentShows.getShows();
            foreach (string[] show in currentShows.shows)
            {
                string cur = "";
                cur += show[3];
                cur += "  The Show time is: " + show[2];
                showBox.Items.Add(cur);
            }
            Console.WriteLine(showBox.SelectedIndex);
        }

        private void showBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDescription.Text = currentShows.shows[showBox.SelectedIndex][4];
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderTickets_Click(object sender, EventArgs e)
        {
            if (showBox.SelectedIndex != -1 && userID != -1)
            {
                Form seatOrder = new seats(currentShows.shows[showBox.SelectedIndex], userID, username);
                seatOrder.Show();
            }
            else if (showBox.SelectedIndex != -1)
            {
                Form login = new LogIn();
                login.Show();
                this.Close();
            }
            else
            {
                selectAShow.Text = "Select a show before continuing";
            }
                
        }
    }
}
