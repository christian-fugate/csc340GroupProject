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
            }
            else
            {
                userOrPass.Text = "Username or Password is incorect or you dont have an account";
            }
            userfname.Text = user.firstName;
            userlname.Text = user.lastName;
            useremail.Text = user.email;
            usercardnumber.Text = user.cardNumber;


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

        }
    }
}
