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
        double totalPrice = 0.00;
        public pay(int uID, List<int> selected, string uName, string[] c, string d)
        {
            InitializeComponent();
            curSeats = selected;
            curshow = c;
            date = d;
            userID = uID;
            curAccount.getAccount(uID);
        }

        private void pay_Load(object sender, EventArgs e)
        {
            foreach (int i in curSeats)
            {
                Ticket curTicket = new Ticket();
                curTicket.userID = userID;
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
            foreach (Ticket t in tickets)
            {
                totalPrice += t.price;
                string display = "" + t.showName + "  " + t.showDate + "   $" + t.price +"0";
                ticketbox.Items.Add(display);
            }
            if (curAccount.isMember == 1) 
            { 
                totalPrice = totalPrice - totalPrice * .10; //10% off for the members
                member.Text = "You are a member, you received 10% off your purchace";
            }
            //Last Date to Cancel: XX/XX/XXXX
            cancelByDate.Text ="You may cancel these tickets by:"+ DateTime.Parse(date).Subtract(TimeSpan.FromDays(2.00)).ToString("yyyy/MM/dd");
            curAccount.getAccount(userID);
            userName.Text = curAccount.firstName + " " + curAccount.lastName;
            total.Text = "$" + Math.Round(totalPrice,2);



        }

        private void confirmPay_Click(object sender, EventArgs e)
        {
            
            if(curSeats.Count>0)
                cur.createOrder(tickets,curAccount.cardNumber, totalPrice, curAccount.accountID);
            curSeats.Clear();
            feedback.Text = "Order Successful";
            //change textbox to check user info 


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void member_TextChanged(object sender, EventArgs e)
        {

        }

        private void backSeats_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
