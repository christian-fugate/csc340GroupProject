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

        private void theaterInfo_Click(object sender, EventArgs e)
        {
            Form tInfo = new theaterInfo();
            tInfo.Show();
        }
    }
}
