using System;

namespace p1StoreApplication.mwb
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            //create switch statement to ask client to sign in or register.

            //sign in asks for email and pasword?, and register asks for information from customer list. 
            // after sign in client can access store, store location, products, order history, and cart section.
            input = true
            while (input = true)
            {
                Console.WriteLine("Would You like to sign up or Log in. press 1 to sign up and 2 to log in");
                selection1 = Console.ReadLine();

                if (selection1 > 2)
                {
                    switch (selection1)
                    {
                        case 1: //sign up get information from repository for signup name, address, email.

                            break;
                        case 2: //log in email address name and password


                        default:
                            break;
                    }
                    
                }
                else
                {
                    Console.Writeline("Invalid Selection")
                }
            }


            //create store section that calls for location choice and product list

            //create logger and unitx sections.

            //syntax to call in the database.
            // to be in the repository section when created.

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
