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
}
