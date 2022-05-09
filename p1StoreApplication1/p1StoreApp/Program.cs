using System;
using System.Collections.Generic;
using storeAppDomain;
using storeAppModel;

namespace p1StoreApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            storeAppDomainClass sAD = new storeAppDomainClass();


            List<Member> members = sAD.membersList();
        }
    }
}
