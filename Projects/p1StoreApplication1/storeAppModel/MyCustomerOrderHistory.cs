namespace storeAppModel
{
    public class MyCustomerOrderHistory
    {// get and set order History Items in there respective spaces
        public int MyCustomerOrderHistoryId {get; set;} = 0;
        public string FirstName {get; set;} = "";
        public string LastName {get; set;} = "";
        public string ItemName {get; set;} = "";
        public string ItemDescription {get; set;} ="";
        public int Quantity {get; set;}
        public int ItemPrice {get; set;}
        public int MyStoreLocationsId {get; set;}
        public DateTime MyCustomerOrderHistoryDateTime {get; set;} = DateTime.Now;
    }
}