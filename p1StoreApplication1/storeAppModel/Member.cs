namespace storeAppModel;
public class Member // Customer -- everything belo wis in Customer Table
{
   //public Guid CustomerID {get; set;}
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
    public string Secret {get; set;}
    //public Guid StoreID {get; set;}


    // --  STORE TABLE -- with the following columns
    public string StoreName {get; set;}
    public string StoreLocation {get; set;}

    // -=- JOINS TABLE  remember store <-> product relationship is many to many... .create a JOINS TABLE
    public string StoreInventory {get; set;}
   // public Guid ProductId {get; set;}


   // --- PRODUCT TABLE 
    public string ProductName {get; set;}
    public string ProductPrice {get; set;}
    public DateTime DateCreated {get; set;} = DateTime.Now;
}
