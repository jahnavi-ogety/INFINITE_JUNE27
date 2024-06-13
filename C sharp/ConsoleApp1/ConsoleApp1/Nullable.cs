using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Nullable
    {
       public  static void nullExp()
        {
            int? data1 = null;
            int data2;

            if (data1 == null)
            {
                data2 = 0;
            }
            else
                data2 = (int)data1;
        }
    }
}
