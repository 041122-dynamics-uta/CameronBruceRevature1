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

    public async Task<List<MyCustomer>> await MembersListAsync(string FirstName, string LastName, string Email, string MySecret)
    {
        bool CustomerExistsorNO = await _repo.uNamePwordExistsAsync(Email,MySecret);
        
        if (CustomerExistsorNO){
            return null;    
        }

        else {

           MyCustomer NewCustomer = await MembersListAsync(FirstName, LastName, Email, MySecret);
           return NewCustomer;

        }


        //List<MyCustomer> MC = _repo.MyCustomerList(FirstName, LastName, Email, MySecret);
       //return MC;
    } 
    
}
