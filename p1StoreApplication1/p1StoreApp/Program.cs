using System;
using System.Collections.Generic;
using storeAppDomain;
using storeAppModel;


//Innitial program
namespace p1StoreApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            //While Loop to innitialize program
            
            bool loopContinue = true;
            bool admin = false;
            bool existingCustomer = false;
            bool newCustomer = false;
            while (loopContinue == true)
            {

                //User Prompt
                Console.WriteLine("Please Select From the Following Options");
                Console.WriteLine("select 1 for Admin \n 2 for Existing Customer \n 3 for New Customer \n 4 to Exit Program ");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                // Use TryParse when reading the user input. This will avoid an 
                // Exception if the user types a letter for example.
                if(choice > 4)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please Enter Admin Varify ");
                            int adminVerify = Convert.ToInt32(Console.ReadLine());
                            
                            if(adminVerify == 12345)
                             {
                                 admin = true;
                             }
                            else
                            {
                                Console.WriteLine();
                            }
                        //Choice 1 enters into Admin Interface
                           //Admin UN and P Verify
                           
                           
                        break;
                        case 2:
                        //Choice 2 enters into Existing Customer Interface
                            //Existing Customer UN and P Verify
                            
                            
                        break;
                        case 3:
                        //Choice 3 enters into New Customer Interface
                            
                            
                        break;

                               
                        case 4:

                        //Exits program
                        loopContinue = false;
                        break;
                    }
                    
                }
                while(admin == true)
                {
                    //Admin Interface Enters and Updates Store Information
                           //Store location info, Product List add store Inventory info

                }
                while (existingCustomer == true)
                {
                    //Existing Customer Selects store Location, Selects product from inventory list, views/edits cart, and order history.
                }
                while (newCustomer == true)
                {
                    //Enters Customer Information into Database populates Various content in cart and Order History
                            //Creates Customer UN and P for Future Verify
                }
            
            //Console.WriteLine("Hello World!");
            // storeAppDomainClass sAD = new storeAppDomainClass();


            // List<Member> members = sAD.membersList();
            }
        }
    }
}
