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
    public partial class pay : Form
    {
        int userID = -1;
        List<int> curSeats;
        order cur = new order();
        string[] curshow;
        string date;
        List<Ticket> tickets = new List<Ticket>();
        account curAccount = new account();
        public pay(int uID, List<int> selected, string uName, string[] c, string d)
        {
            InitializeComponent();
            curSeats = selected;
            curshow = c;
            date = d;

            curAccount.getAccount(uID);
        }

        private void pay_Load(object sender, EventArgs e)
        {
            foreach (int i in curSeats)
            {
                Ticket curTicket = new Ticket();
                curTicket.seat = i;
                Console.WriteLine(curTicket.seat);
                curTicket.showDate = date;
                Console.WriteLine(curTicket.showDate);
                curTicket.showName = curshow[3];
                Console.WriteLine(curTicket.showName);
                if (i < 33) //vip seats
                    curTicket.price = 13.50;
                else
                    curTicket.price = 9.50;
                Console.WriteLine(curTicket.price);
                tickets.Add(curTicket);
            }
            
        }

        private void confirmPay_Click(object sender, EventArgs e)
        {
            if(curSeats.Count>0)
                cur.createOrder(tickets);
            curSeats.Clear();
            //change textbox to check user info 
            

        }
    }
}
