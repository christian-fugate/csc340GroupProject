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
    class Ticket
    {
        public int userID;
        public int ticketNum;
        public int seat;
        public string showName;
        public int orderNumber;
        public int isValid; //if 0 false 1 true
        public double price;
        public string showDate;
        public void cancelTicket(int number)
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE few_tickets SET isValid = 0 WHERE ticketNumber = "+number+";";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
        public List<Ticket> userTickets(int uID)
        {
            List<Ticket> uTickets = new List<Ticket>();
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM few_tickets  WHERE  accID = "+uID+" AND isValid = 1 ORDER BY showDate ASC;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();   
                while (myReader.Read())
                {
                    Ticket toAdd = new Ticket();
                    toAdd.ticketNum = myReader.GetInt32(0);
                    toAdd.seat = myReader.GetInt32(1);
                    toAdd.showName = myReader.GetString(2);
                    toAdd.isValid = myReader.GetInt32(4);
                    toAdd.price = Math.Round(myReader.GetDouble(5),2);
                    toAdd.showDate = myReader.GetString(6);
                    uTickets.Add(toAdd);
                }
                myReader.Close();
                sql = "SELECT * FROM few_tickets WHERE accID = " + uID + " AND isValid = 0";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    Ticket toAdd = new Ticket();
                    toAdd.ticketNum = myReader.GetInt32(0);
                    toAdd.seat = myReader.GetInt32(1);
                    toAdd.showName = myReader.GetString(2);
                    toAdd.isValid = myReader.GetInt32(4);
                    toAdd.price = Math.Round(myReader.GetDouble(5), 2);
                    toAdd.showDate = myReader.GetString(6);
                    uTickets.Add(toAdd);
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return uTickets;
            
        }
    }
}
