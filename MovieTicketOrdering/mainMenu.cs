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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void seats_Click(object sender, EventArgs e)
        {
            Form seat = new seats();
            seat.Show();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            Form logIn = new LogIn();
            logIn.Show();
        }

        private void seeShows_Click(object sender, EventArgs e)
        {
            Form shows = new shows();
            shows.Show();
        }
    }
}
