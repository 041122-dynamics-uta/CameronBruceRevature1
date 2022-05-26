using System.Data.SqlClient;
using storeAppModel;
namespace storeAppStorage
{
    public class MyMapperClass
    { //created to populate the tables and to recall thier contents in the order they appear in the DB repeat for more tables
        public MyCustomer DboToMyCustomer(SqlDataReader reader)
        {
            MyCustomer MC = new MyCustomer
            {
                MyCustomerId = (int)reader[0],
                FirstName = (string)reader[1],
                LastName = (string)reader[2],
                Email = (string)reader[3],
                MySecret = (string)reader[4]
            };
            return MC;
        }
        public MyCustomerOrder DboToMyCustomerOrder(SqlDataReader reader)
        {
            MyCustomerOrder MCO = new MyCustomerOrder
            {
                MyCustomerOrderId = (int)reader[0],
                FirstName = (string)reader[1],
                LastName = (string)reader[2],
                ItemName = (string)reader[3],
                ItemDescription = (string)reader[4],
                Quantity = (int)reader[5],
                ItemPrice = (int)reader[6],
                City = (string)reader[7]
            };
            return MCO;
        }
        public MyCustomerOrderHistory DboToMyCustomerOrderHistory(SqlDataReader reader)
        {
            MyCustomerOrderHistory MCOH = new MyCustomerOrderHistory
            {
                MyCustomerOrderHistoryId = (int)reader[0],
                FirstName = (string)reader[1],
                LastName = (string)reader[2],
                ItemName = (string)reader[3],
                ItemDescription = (string)reader[4],
                Quantity = (int)reader[5],
                ItemPrice = (int)reader[6],
                MyStoreLocationsId = (int)reader[7],
                MyCustomerOrderHistoryDateTime = (DateTime)reader[8]
            };
            return MCOH;
        }
        public MyStoreInventory DboToMyStoreInventory(SqlDataReader reader)
        {
            MyStoreInventory MSI = new MyStoreInventory
            {
                MyStoreInventoryId = (int)reader[0],
                ItemName = (string)reader[1],
                ItemPrice = (int)reader[2],
                ItemDescription = (string)reader[3],
                ItemQuantity = (int)reader[4]     
            };
            return MSI;
        }
        public MyStoreLocations DboToMyStoreLocations(SqlDataReader reader)
        {
            MyStoreLocations MSL = new MyStoreLocations
            {
                MyStoreLocationsId = (int)reader[0],
                City = (string)reader[1]  
            };
            return MSL;
        }
    }
}
