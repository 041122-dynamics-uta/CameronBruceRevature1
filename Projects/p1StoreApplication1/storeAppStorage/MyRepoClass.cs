using System.Data.SqlClient;
using storeAppModel;

namespace storeAppStorage;
public class MyRepoClass
{//inject the mapper class
        public MyRepoClass(MyMapperClass _mapper) 
        {
            this._mapper = _mapper;
               
        }
            public MyMapperClass _mapper {get; set;}

            //Ado.Net connection Command
    string connectionstring = "Server=tcp:cameronbrucedb.database.windows.net,1433;Initial Catalog=CameronBruceDB;Persist Security Info=False;User ID=CameronBruceRevature1;Password=GundamWing03@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
    //Mapper reference
    public MyRepoClass()
    {
        this._mapper = new MyMapperClass();
    }  

    //this query is supposed to extract the customers information that has the same email and secret Identifier
    public bool uNamePwordExists(string ExistingEmail, string ExistingMySecret)
    {
        string query = "select FirstName, LastName from MyCustomer where Email = '@E' and MySecret = '@C';";
        using (SqlConnection conn = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(query, conn);
            //command.Parameters.AddWithValue("@F", FirstName);
            //command.Parameters.AddWithValue("@L", LastName);
            command.Parameters.AddWithValue("@C", ExistingMySecret);
            command.Parameters.AddWithValue("@E", ExistingEmail);
            conn.Open(); //open the connection to the DB
            SqlDataReader results =  command.ExecuteReader(); //do the query
            conn.Close(); //close the connection to the DB
            
            if (results.Read())
            {
                return true;
            }
            else
            {
                conn.Close(); //close the connection to the DB
                return false;
            }
        }
    }
    public List<MyCustomer> MyCustomerList(string FirstName, string LastName, string Email, string MySecret)
    {
        //Query string to populate the customer information table
        string myQuery1 = "Insert Into MyCustomer ( FirstName, LastName, Email, MySecret ) Values ( @F, @L, @E, @MyS );";

        
        using (SqlConnection query1 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery1, query1);
            command.Parameters.AddWithValue("@F", FirstName);
            command.Parameters.AddWithValue("@L", LastName);
            command.Parameters.AddWithValue("@MyS", MySecret);
            command.Parameters.AddWithValue("@E", Email);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<MyCustomer> MC = new List<MyCustomer>();
            while (results.Read())
            {
                MC.Add(this._mapper.DboToMyCustomer(results));//send in the row of the reader to be mapped.
            }
            query1.Close();
            return MC;      
        }

    }
    //More Sql Queries to populate and manipulate the data from the database.
    //This query is supposed to have a insert into where all the variable come from different tables.
    public List<MyCustomerOrder> MyCustomerOrderList()
    {
        string myQuery2 = "SELECT * FROM MyCustomerOrder";

        using (SqlConnection query2 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery2, query2);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<MyCustomerOrder> MCO1 = new List<MyCustomerOrder>();
            while (results.Read())
            {
                MCO1.Add(this._mapper.DboToMyCustomerOrder(results));//send in the row of the reader to be mapped.
            }
            query2.Close();
            return MCO1;      
        }

    }
    //This query is supposed to copy the data from the MyCustomerOrder
    public List<MyCustomerOrderHistory> MyCustomerOrderHistoryList()
    {
        string myQuery3 = "SELECT * FROM MyCustomerOrderHistory";

        using (SqlConnection query3 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery3, query3);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<MyCustomerOrderHistory> MCOH1 = new List<MyCustomerOrderHistory>();
            while (results.Read())
            {
                MCOH1.Add(this._mapper.DboToMyCustomerOrderHistory(results));//send in the row of the reader to be mapped.
            }
            query3.Close();
            return MCOH1;      
        }

    }//reference to get the list of items
    //needs to be able to utilize quantity for a calculation and randomizer to place random items into each stores marker
    public List<MyStoreInventory> MyStoreInventoryList()
    {
        string myQuery4 = "SELECT * FROM MyStoreInventory";

        using (SqlConnection query4 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery4, query4);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<MyStoreInventory> MSI1 = new List<MyStoreInventory>();
            while (results.Read())
            {
                MSI1.Add(this._mapper.DboToMyStoreInventory(results));//send in the row of the reader to be mapped.
            }
            query4.Close();
            return MSI1;      
        }

    }
    public List<MyStoreLocations> MyStoreLocationsList()
    {
        string myQuery5 = "SELECT * FROM MyStoreLocations";

        using (SqlConnection query5 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery5, query5);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<MyStoreLocations> MSL1 = new List<MyStoreLocations>();
            while (results.Read())
            {
                MSL1.Add(this._mapper.DboToMyStoreLocations(results));//send in the row of the reader to be mapped.
            }
            query5.Close();
            return MSL1;      
        }

    }
}
