using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replaceFile
{
  public  class Program
    {
        static void Main(string[] args)
        {
            myProperty l = new myList();
            l.programWork();

            myCollection c = new myCollection();
           c.createException();

           myEnum e = new myEnum();
           e.createEnum();

           myProperty r = new myProperty();
           r.Name = "\n\n\t\t\t\tMy property works";
           Console.WriteLine(r.Name);

           Interface1 i = new myProperty();
           i.myInterface();

            Console.ReadKey();
         }               
     }
}

