using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MovieTicketOrdering
{
    public partial class theaterInfo : Form
    {
        showClass shows = new showClass();
        List<Ticket> tickets = new List<Ticket>();
        int canceled = 0;
        int total = 0;
        public theaterInfo()
        {
            InitializeComponent();
            shows.getAllShows();
            foreach (string[] show in shows.shows)
            {
                string cur = "";
                cur += show[3];
                cur += " The Show start date: " + show[0];
                cur += " The Show end date: " + show[1];
                showBox.Items.Add(cur);
            }
        }

        private void showBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTickets();
        }
        
        public void updateTickets()
        {
            if (showBox.SelectedIndex > -1)
            {
                tickets = shows.getAllTickets(shows.shows[showBox.SelectedIndex][3]);
                ticketBox.Items.Clear();
                canceled = 0;
                total = 0;
                foreach (Ticket t in tickets)
                {

                    string toAdd = "";
                    if (DateTime.Parse(t.showDate) == showDate.SelectionRange.Start)
                    {
                        if (t.isValid == 0)
                        {
                            canceled++;
                            toAdd += "Cancelled ";
                        }
                        toAdd += t.showName + " ";
                        toAdd += t.showDate + " Price:";
                        toAdd += t.price + " Seate:";
                        toAdd += t.seat;
                        ticketBox.Items.Add(toAdd);
                        total++;
                    }
                }
                ticketSales.Text = total + "";
                totalCanceled.Text = canceled + "";
            }
        }

        private void showDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            updateTickets();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            if(password.Text == "employee1234")
            {
                emplogin.Hide();
            }
        }
    }
}
