using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketOrdering
{
    public partial class createAccount : Form
    {
        account user = new account();
        public createAccount()
        {
            InitializeComponent();
        }

        private void fName_TextChanged(object sender, EventArgs e)
        {
            user.firstName = fName.Text;
        }

        private void lName_TextChanged(object sender, EventArgs e)
        {
            user.lastName = lName.Text;
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            user.username = username.Text;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            user.password = password.Text;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            user.email = email.Text;
        }

        private void cardNumber_TextChanged(object sender, EventArgs e)
        {
            user.cardNumber = cardNumber.Text;
        }

        private void create_Click(object sender, EventArgs e)
        {
            user.create();
            if (user.goodUsername)
            {
                isUsernameGood.Text = "Account successful";
            }
            else
            {
                isUsernameGood.Text = "Username is already taken";
            }
        }

        private void isUsernameGood_Click(object sender, EventArgs e)
        {

        }
        private void createAccount_Load(object sender, EventArgs e)
        {

        }

        private void returnToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
