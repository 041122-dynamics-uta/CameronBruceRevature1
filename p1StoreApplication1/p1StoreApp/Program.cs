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
            //Get the Customers Information to setup Login        
            Console.WriteLine("Lets Get some Information");
            Console.WriteLine("Enter First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Email Address");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter Your Secret Identifier");
            string MySecret = Console.ReadLine();

            //setup credential verification to utilize found verification code

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
            MyRepoClass MRC = new MyRepoClass();
            storeAppDomainClass SADC = new storeAppDomainClass(MRC);
            List<MyCustomer> NewCustomers = SADC.MembersList() ;

            foreach (MyCustomer MC in NewCustomers)
            {
            Console.WriteLine($"The members data is Fname-{MC.FirstName}.....");
            } 
            //Add switch case to see store Locations to select one
            //Add question to see the store Inventory list
            //create equation to randomize the store Inventory List to offer different types of products
            //Example could be first 5 stores on list get items 1, 4, and random 2 items above 7, second 5 get items 2, 5, and random 2 above 7,
            //Final 5 have items 3, 6, and 2 random items above 7.
            //add switch cases to select a product for purchase.

            //confirm purchase by pressing enter or typing yes
            //Confirmation would take the variables and push the results to populate tables in My Azure Database for Order because it will alter the variable on row ItemQuantity
            //Order history will show the amount of that Item that has been purchased and a code created to prohibit purchases greater than current ItemQuantity
             
        }

    }
}
