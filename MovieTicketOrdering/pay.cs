﻿using System;
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
    public partial class pay : Form
    {
        int userID = -1;
        List<int> curSeats;
        order cur = new order();
        string[] curshow;
        string date;
        public pay(int uID, List<int> selected, string uName, string[] c, string d)
        {
            InitializeComponent();
            userID = uID;
            userName.Text = uName + "";
            curSeats = selected;
            curshow = c;
            date = d;
        }

        private void pay_Load(object sender, EventArgs e)
        {
            
        }
    }
}
