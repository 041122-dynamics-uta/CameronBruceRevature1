using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4DataStructures
{

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make Your Choice In the Switch Case");
            Console.WriteLine("1, 2, or 3");

            int red = 1
            int blue = 2
            int green = 3
            string forCase = Console.ReadLine();

            
            switch (forCase) 
            {
                case 1:
                Console.WriteLine("I can do this");
                break;
                case 2:
                Console.WriteLine("have a great day");
                break;
                case 3:
                Console.WriteLine("Smile more");
                break;
                
                default:
                Console.WriteLine("Choose the Right number");
                int forCase = Console.ReadLine();
                break;
            }
            
            Console.ReadKey();

        }
    }
}