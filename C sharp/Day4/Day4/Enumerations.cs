using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    enum cities { Banglore,Chennai,Delhi,Hyderabad,Agra}
    class Enumerations
    {
        enum days { Monday,Tuesday,Wednesday}

       public static void EnumOp()
        {
            foreach(int x in Enum.GetValues(typeof(cities)))
            {
                if(x==1)
                
                    Console.WriteLine(Enum.GetName(typeof(cities),x) + " it is garden city");
                else if(x==2)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) +  " it is temple city");




            }
            foreach(var c in Enum.GetNames(typeof(cities)))
            {
                Console.WriteLine(c);
            }
        }


    }
}
