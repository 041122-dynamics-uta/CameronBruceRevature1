namespace storeAppModel;
public class Member
{
   // public Guid CustomerID {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Address {get; set;}
    public string City {get; set;}
    public string State {get; set;}
    public string Country{get; set;}
    public int PostalCode {get; set;}
    public int Phone {get; set;}
    public string Email {get; set;}
   // public Guid PassWordId {get; set;}
    public string PassWord {get; set;}
    //public Guid StoreID {get; set;}
    public string StoreName {get; set;}
    public string StoreLocation {get; set;}
    public string StoreInventory {get; set;}
   // public Guid ProductId {get; set;}
    public string ProductName {get; set;}
    public string ProductPrice {get; set;}
    public DateTime DateCreated {get; set;} = DateTime.Now;
}
