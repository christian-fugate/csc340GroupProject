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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        account user = new account();
        Ticket selectedTicket = new Ticket();
        List<Ticket> userTickets = new List<Ticket>();

        private void username_TextChanged(object sender, EventArgs e)
        {
            user.username = username.Text;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            user.password = password.Text;
        }
        private void log_Click(object sender, EventArgs e)
        {
            user.logIn();
            if(user.firstName.Length > 0)
            {
                Input.Hide();
                userfname.Text = user.firstName;
                userlname.Text = user.lastName;
                useremail.Text = user.email;
                usercardnumber.Text = user.cardNumber;
                userTickets = selectedTicket.userTickets(user.accountID);
                foreach(Ticket t in userTickets)
                {
                    string toAdd = "";
                    toAdd += "Seat Number: " + t.seat;
                    toAdd += " Show Title: " + t.showName;
                    toAdd += " Show Date: " + t.showDate.Substring(0, 9);
                    toAdd += " Price: $" + t.price +"0";
                    if(t.isValid == 1)
                    {
                        toAdd += " Still Valid";
                    }
                    else
                    {
                        toAdd += " Not Valid";
                    }
                    ticketBox.Items.Add(toAdd);
                }
            }
            else
            {
                userOrPass.Text = "Username or Password is incorect or you dont have an account";
            }
            


        }

        private void signUp_Click(object sender, EventArgs e)
        {
            Form create = new createAccount();
            create.Show();
        }

        private void findShow_Click(object sender, EventArgs e)
        {
            Form shows = new shows(user.accountID);
            shows.Show();
        }

        private void cancelTicket_Click(object sender, EventArgs e)
        {
            if (selectedTicket.isValid == 1)
            {
                selectedTicket.cancelTicket(selectedTicket.ticketNum);
                ticketBox.Items.Clear();
                userTickets = selectedTicket.userTickets(user.accountID);
                foreach (Ticket t in userTickets)
                {
                    string toAdd = "";
                    toAdd += "Seat Number: " + t.seat;
                    toAdd += " Show Title: " + t.showName;
                    toAdd += " Show Date: " + t.showDate.Substring(0, 9);
                    toAdd += " Price: $" + t.price + "0";
                    if (t.isValid == 1)
                    {
                        toAdd += " Still Valid";
                    }
                    else
                    {
                        toAdd += " Not Valid";
                    }
                    ticketBox.Items.Add(toAdd);
                }
            }
        }

        private void ticketBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTicket = userTickets[ticketBox.SelectedIndex];
        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            user.updateAccount(fNameChange.Text + "", lNameChange.Text + "", emailChange.Text + "", cardChange.Text + "");
            userfname.Text = user.firstName;
            userlname.Text = user.lastName;
            useremail.Text = user.email;
            usercardnumber.Text = user.cardNumber;
            

        }

        private void update_Click(object sender, EventArgs e)
        {
            ticketBox.Items.Clear();
            userTickets = selectedTicket.userTickets(user.accountID);
            foreach (Ticket t in userTickets)
            {
                string toAdd = "";
                toAdd += "Seat Number: " + t.seat;
                toAdd += " Show Title: " + t.showName;
                toAdd += " Show Date: " + t.showDate.Substring(0, 9);
                toAdd += " Price: $" + t.price + "0";
                if (t.isValid == 1)
                {
                    toAdd += " Still Valid";
                }
                else
                {
                    toAdd += " Not Valid";
                }
                ticketBox.Items.Add(toAdd);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void submitMember_Click(object sender, EventArgs e)
        {
            if (user.isMember == 0)
            {
                //this is where we would send to the owner to review their account details and decide on membership status
                sentInfo.Text = "Your Information has been sent";
            }
            else
            {
                sentInfo.Text = "You are already a member";
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
