using System;

namespace p1StoreApplication.mwb
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //syntax to call in the database

            string connectionString = $"Server=tcp:cameronbrucedb.database.windows.net,1433;Initial Catalog=yourDBName;Persist Security Info=False;User ID=CameronBruceRevature1;Password={"GundamWing04"};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            
            
            string myQuery1 = "SELECT  FROM  WHERE ";
            //this using block creates teh SqlConnection.
            // the SqlConnection is the object that communicates with the Db.
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
                //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1/*0xf35ba*/);

                command.Connection.Open();//open the connection to the Db

                SqlDataReader results = command.ExecuteReader();//actually conduct the query.

                while (results.Read())
                {
                    Console.WriteLine($"The address is => {results[0]} {results[1]}, {results[2]}");
                }
                query1.Close();
            }
        }
    }
}
