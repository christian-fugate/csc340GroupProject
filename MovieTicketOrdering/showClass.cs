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
    class showClass
    {
        public List<string[]> shows = new List<string[]>();
        public List<Ticket> getAllTickets(string show)
        {
            List<Ticket> allTickets = new List<Ticket>();
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM few_tickets where showName ='"+show+"';";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    Ticket toAdd = new Ticket();
                    toAdd.ticketNum = myReader.GetInt32(0);
                    toAdd.seat = myReader.GetInt32(1);
                    toAdd.showName = myReader.GetString(2);
                    toAdd.orderNumber = myReader.GetInt32(3);
                    toAdd.isValid = myReader.GetInt32(4);
                    toAdd.price = myReader.GetDouble(5);
                    toAdd.showDate = myReader.GetString(6);
                    allTickets.Add(toAdd);
                    Console.WriteLine(toAdd.ticketNum);
                }
                Console.WriteLine(shows.Count());
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return allTickets;
        }
        public void getAllShows()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM few_shows;";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string[] curshow = new string[5];
                    //show start date
                    curshow[0] = myReader.GetString(0).Substring(0, myReader.GetString(0).Length - 12);
                    Console.WriteLine(DateTime.Parse(myReader.GetString(0).Substring(0, myReader.GetString(0).Length - 12)));
                    Console.WriteLine(curshow[0]);
                    //show end date
                    curshow[1] = myReader.GetString(1).Substring(0, myReader.GetString(1).Length - 12);
                    Console.WriteLine(curshow[1]);
                    //show time 
                    curshow[2] = DateTime.Parse(myReader.GetString(2)).ToString().Substring(10);
                    Console.WriteLine(curshow[2]);
                    //show title
                    curshow[3] = myReader.GetString(3);
                    Console.WriteLine(curshow[3]);
                    //show description
                    curshow[4] = myReader.GetString(4);
                    Console.WriteLine(curshow[4]);
                    shows.Add(curshow);
                }
                Console.WriteLine(shows.Count());
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
        public void getShows()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM few_shows WHERE CURDATE() < endDate;";   
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string[] curshow = new string[5];
                    //show start date
                    curshow[0] = myReader.GetString(0).Substring(0, myReader.GetString(0).Length - 12);
                    Console.WriteLine(DateTime.Parse(myReader.GetString(0).Substring(0, myReader.GetString(0).Length - 12)));
                    Console.WriteLine(curshow[0]);
                    //show end date
                    curshow[1] = myReader.GetString(1).Substring(0, myReader.GetString(1).Length - 12);
                    Console.WriteLine(curshow[1]);
                    //show time 
                    curshow[2] = DateTime.Parse(myReader.GetString(2)).ToString().Substring(10);
                    Console.WriteLine(curshow[2]);
                    //show title
                    curshow[3] = myReader.GetString(3);
                    Console.WriteLine(curshow[3]);
                    //show description
                    curshow[4] = myReader.GetString(4);
                    Console.WriteLine(curshow[4]);
                    shows.Add(curshow);
                }
                Console.WriteLine(shows.Count());
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
