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
        List<string[]> shows = new List<string[]>();
        public void getShows()
        {
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * from few_shows";   //at one point we are going to need to add "WHERE show name is [insert name]
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string[] curshow = new string[5];
                    curshow[0] = myReader.GetString(0).Substring(0, myReader.GetString(0).Length - 12);
                    Console.WriteLine(myReader.GetString(0).Substring(0,myReader.GetString(0).Length-12));
                    curshow[1] = myReader.GetString(1).Substring(0, myReader.GetString(1).Length - 12);
                    Console.WriteLine(myReader.GetString(1).Substring(0, myReader.GetString(1).Length - 12));
                    curshow[2] = DateTime.Parse(myReader.GetString(2)).ToString() ;
                    Console.WriteLine(curshow[2]);
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
    }
}
