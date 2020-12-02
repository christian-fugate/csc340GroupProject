using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.CRUD;


namespace MovieTicketOrdering
{
    class account
    {
        public int accountID;
        public int isMember; //if 0 false, if 1 true.  Database variable
        public string username = "";
        public string password = "";
        public string firstName = "";
        public string lastName = "";
        public string email = "";
        public string cardNumber = "";
        public bool goodUsername = false;
        public void getAccount(int id)
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * from few_accountholder WHERE accountID = '" + id + "';";   //at one point we are going to need to add "WHERE show name is [insert name]
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {

                    accountID = myReader.GetInt32(0);
                    isMember = myReader.GetInt32(1);
                    username = myReader.GetString(2);
                    password = myReader.GetString(3);
                    firstName = myReader.GetString(4);
                    lastName = myReader.GetString(5);
                    email = myReader.GetString(6);
                    cardNumber = myReader.GetString(7);
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
        public void logIn()
        {
            //gather info from database
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * from few_accountholder WHERE username = '"+username+"' AND password ='"+password+"';";   //at one point we are going to need to add "WHERE show name is [insert name]
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                Console.WriteLine("selected");
                while (myReader.Read())
                {

                    accountID = myReader.GetInt32(0);
                    isMember = myReader.GetInt32(1);
                    username = myReader.GetString(2);
                    password = myReader.GetString(3);
                    firstName = myReader.GetString(4);
                    lastName = myReader.GetString(5);
                    email = myReader.GetString(6);
                    cardNumber = myReader.GetString(7);
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
        public void create()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "INSERT INTO few_accountholder  (username, PASSWORD, firstname, lastname, email, cardNumber) VALUES ('"+username+"','"+password+"','"+firstName+"','"+lastName+"','"+email+"','"+cardNumber+"'); ";   //at one point we are going to need to add "WHERE show name is [insert name]
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                myReader.Close();
                goodUsername = true;
            }
            catch (Exception ex)
            {
                goodUsername = false;
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }


    }
}
