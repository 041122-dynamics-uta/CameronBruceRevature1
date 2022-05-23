using System;
using System.Collections.Generic;
using storeAppDomain;
using storeAppModel;
using storeAppStorage;




//Innitial program
namespace p1StoreApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Magnus's Potion Emporium");
            Console.WriteLine("Please Select \n To Register Press 1 \n To Log Into Your Account 2");
            int Option1 = Convert.ToInt32(Console.ReadLine());
          
            switch(Option1)
            {
                case 1:
                    Console.WriteLine("Lets Get some Information");
                    Console.WriteLine("Enter First Name");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Enter Your Email Address");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Enter Your Secret Identifier");
                    string MySecret = Console.ReadLine();

                    MyRepoClass MRC = new MyRepoClass();
                    storeAppDomainClass SADC = new storeAppDomainClass(MRC);
                    List<MyCustomer> NewCustomers = SADC.MembersList(FirstName, LastName, Email, MySecret);
                    break;
                case 2: 
                    Console.WriteLine("Enter your Email and Secret Identifier");
                    string ExistingEmail = Console.ReadLine();
                    string ExistingMySecret = Console.ReadLine();
                    //kicks these variables to the business layer and repo layer for verify
                    //if verify true do while loop activates for store options
                    MyRepoClass MRC1 = new MyRepoClass();
                    storeAppDomainClass SADC1 = new storeAppDomainClass(MRC1);
                    List<MyCustomer> ExistingCustomers = SADC1.uNamePwordExists(ExistingEmail, ExistingMySecret);
                    break;
                default:
                    Console.WriteLine("Please Try Again");
                    break;
            }
            bool  loopContinue = true;
            while (loopContinue)
            {
                Console.WriteLine("Welcome User");
                Console.WriteLine("select 1 Setting Your Store Location, 2 for List of Products , 3 for Order");
                // Use TryParse when reading the user input. This will avoid an 
                // Exception if the user types a letter for example.
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                case 1:
                    Console.WriteLine("Please Select Your City");
                    MyRepoClass MRC2 = new MyRepoClass();
                    storeAppDomainClass SADC2 = new storeAppDomainClass(MRC2);
                    List<MyStoreLocations> SL = SADC2.MyStoreLocationsList();
                    foreach(MyStoreLocations SL2 in SL)
                    {
                        Console.WriteLine("--------------------------");
                        Console.WriteLine($"City --- [{SL2.City}]");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Please Select your City");
                        string SelectCity= Console.ReadLine();
                    }
                    loopContinue = true;
                    break;
                case 2:
                    MyRepoClass MRC3 = new MyRepoClass();
                    storeAppDomainClass SADC3 = new storeAppDomainClass(MRC3);
                    List<MyStoreInventory> SI = SADC3.MyStoreInventoryList();
                    foreach(MyStoreInventory SI2 in SI)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine($"Item Name --- [{SI2.ItemName}]");
                        Console.WriteLine($"Item Price --- [{SI2.ItemPrice}]");
                        Console.WriteLine($"Item Description --- [{SI2.ItemDescription}]");
                        Console.WriteLine($"Item Quantity --- [{SI2.ItemQuantity}]");
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Please Select your Item Name");
                        string ItemName= Console.ReadLine();
                        int ItemPrice = SI2.ItemPrice;
                        string ItemDescription = SI2.ItemDescription;
                        Console.WriteLine("Enter Your Quantity");
                        int ItemQuantity = Convert.ToInt32(Console.ReadLine());
                    }
                    loopContinue = true;
                    break;
                case 3:
                    MyRepoClass MRC4 = new MyRepoClass();
                    storeAppDomainClass SADC4 = new storeAppDomainClass(MRC4);
                    List<MyCustomerOrderHistory> COH = SADC4.MyCustomerOrderHistoryList();
                    foreach(MyCustomerOrderHistory COH2 in COH)
                    {   
                        Console.WriteLine($"Item Name --- [{COH2.ItemName}]");
                        Console.WriteLine($"Item Price --- [{COH2.ItemPrice}]");
                        Console.WriteLine($"Item Description --- [{COH2.ItemDescription}]");
                        Console.WriteLine($"Item Quantity --- [{COH2.Quantity}]");
                        Console.WriteLine("Please Select your Item Name");
                        string ItemName= Console.ReadLine();
                        int ItemPrice = COH2.ItemPrice;
                        Console.WriteLine("Enter Your Quantity");
                    }
                    loopContinue = true;
                    break;

                case 4:
                    loopContinue = false;
                    break;
                }
                Console.WriteLine("Please Select from the Following: \n 1 for Store Location \n 2 for Item List and order selection \n 3 for OrderHistory \n 4 to Exit");
            }   
        }
    }
}
           
            
            
            
            
            
            
          