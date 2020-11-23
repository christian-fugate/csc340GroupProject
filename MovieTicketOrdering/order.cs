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
    class order
    {
        private void createOrder()
        {

        }
        private void cancelOrder()
        {

        }

        public List<int> getSeats() //this will be used by seats to get the already taken seats. 
        {


            List<int> takenSeats = new List<int>();
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT seat FROM few_tickets;";   //at one point we are going to need to add "WHERE show name is [insert name]
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    takenSeats.Add(myReader.GetInt32(0));
                    Console.WriteLine(myReader.GetInt32(0));
                }
                myReader.Close();  
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return takenSeats;
        }
    }
}
