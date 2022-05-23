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

                    // not really needed, if you remove the default
                    // then your loop will not exit and you can start again
                case 4:
                    loopContinue = false;
                    break;
                }
                Console.WriteLine("Please Select from the Following: \n 1 for Store Location \n 2 for Item List and order selection \n 3 for OrderHistory \n 4 to Exit");
            }   
        }
    }
}
           
            
            
            
            
            
            
            
            //setup credential verification to utilize following code
            //public static string ReturnMySecret()
            //{
                //Console.WriteLine("Provide a valid Email");
                //Console.WriteLine("Enter Email:");
                //string Email = Console.ReadLine();
                //Console.WriteLine("Enter MySecret:");
                //string MySecret = "";
                //ConsoleKeyInfo info = Console.ReadKey(true);
                // while (info.Key != ConsoleKey.Enter)
            //{
            //if (info.Key != ConsoleKey.Backspace)
            //{
                //MySecret += info.KeyChar;
                //info = Console.ReadKey(true);
            //}
            //else if (info.Key == ConsoleKey.Backspace)
            //{
            //if (!string.IsNullOrEmpty(password))
            //{
            //    password = password.Substring
            //    (0, password.Length - 1);
            //}
            //info = Console.ReadKey(true);
            //}
        //}
        //for (int i = 0; i < password.Length; i++)
        //Console.Write("*");
        //return password;
        //}

          


            //Syntax to sort and convert customer information to a list and send to the business class layer
            //Repeat, change to create populations for the Order and OrderHistory List               
                      
                    
               
            
            //Console.WriteLine("Hello World!");
            // storeAppDomainClass sAD = new storeAppDomainClass();


            //foreach (MyCustomer MC in NewCustomers)
            //{
            //Console.WriteLine($"The members data is Fname-{MC.FirstName }.....");
           // } 
            //Add switch case to see store Locations to select one
            //Add question to see the store Inventory list
            //create equation to randomize the store Inventory List to offer different types of products
            //Example could be first 5 stores on list get items 1, 4, and random 2 items above 7, second 5 get items 2, 5, and random 2 above 7,
            //Final 5 have items 3, 6, and 2 random items above 7.
            //add switch cases to select a product for purchase.

            //confirm purchase by pressing enter or typing yes
            //Confirmation would take the variables and push the results to populate tables in My Azure Database for Order because it will alter the variable on row ItemQuantity
            //Order history will show the amount of that Item that has been purchased and a code created to prohibit purchases greater than current ItemQuantity
