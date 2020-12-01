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
        public shows()
        {
            InitializeComponent();
        }
        showClass currentShows = new showClass();
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
            if (showBox.SelectedIndex != -1)
            {
                Form seats = new seats();
                seats.Show();
            }
            else
                selectAShow.Text = "Select a show and try again";
        }
    }
}
