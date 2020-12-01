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
        }
    }
}
