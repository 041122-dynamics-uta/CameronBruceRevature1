using System;

namespace switchCase
{
    
    
    
    public class switchCase
    {
        
        
        
        public static void Main(string[] args)
        { 
            
            // string outputs
            Console.WriteLine("Greetings User, Welcome To My Switch Case Tuitorial");
            Console.WriteLine("Please Select A Number 1 to 3"); // Can add more cases to 
            
            //declare Variable and get user input
            int answer = Console.ReadLine();

            Console.WriteLine("Your Selection is " answer);

            // to Innitiate the switch
            switch (answer)
            {
                //The Cases and Default
               
                case 1:
                Console.WriteLine("You are an awesome individual");
                break; // breakpoint tells compiler to exit this method instead of reading the other cases.

                case 2:
                Console.WriteLine("Please Enter two variables");
                //calling for more variables and preform on the fly calculations.
                int var1 = Console.ReadLine();
                int var2 = Console.ReadLine();

                Console.WriteLine("Your two numbers are " var1 " and " var2);
                break;
                
                case 3:
                Console.WriteLine("You Shall Bring Me A Shrubbery");
                break;
                
                Default:
                Console.WriteLine("Its Just a Flesh Wound");
                break;
  
            }


        }

            Console.ReadKey();

    }
}



