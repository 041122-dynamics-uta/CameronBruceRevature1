using storeAppStorage;
using storeAppModel;

namespace storeAppDomain;
public class storeAppDomainClass
{

    //Repo injector make more to inject into and recieve Order, Order History, store locations, and store Inventory tables
    public MyRepoClass _repo { get; set; }
    public storeAppDomainClass(MyRepoClass MRC)
    {
        this._repo = MRC;
    }
    public List<MyCustomer> MembersList(string FirstName, string LastName, string Email, string MySecret)
    {
        List<MyCustomer> MC = _repo.MyCustomerList(FirstName, LastName, Email, MySecret);
        return MC;
    }
    public List<MyCustomer> uNamePwordExists(string ExistingEmail, string ExistingMySecret)
    {
        return null;   
    }
public List<MyStoreLocations> MyStoreLocationsList()
    {
        List<MyStoreLocations> SL = _repo.MyStoreLocationsList();
        return SL;
    }
    public List<MyStoreInventory> MyStoreInventoryList()
    {
        List<MyStoreInventory> SI = _repo.MyStoreInventoryList();
        return SI;
    }
    public List<MyCustomerOrder> MyCustomerOrderList()
    {
        List<MyCustomerOrder> MCO = _repo.MyCustomerOrderList();
        return MCO;
    } 
    public List<MyCustomerOrderHistory> MyCustomerOrderHistoryList()
    {
        List<MyCustomerOrderHistory> MCOH = _repo.MyCustomerOrderHistoryList();
        return MCOH;
    }  
} 
    

