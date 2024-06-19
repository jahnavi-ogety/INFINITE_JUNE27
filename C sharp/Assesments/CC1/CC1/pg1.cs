using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC1
{
    class pg1
    {
        static void Main()
        {
            Console.WriteLine("The Expected output is :");
            Console.WriteLine(t("Python", 1));
            Console.WriteLine(t("python", 0));
            Console.WriteLine(t("python", 4));
            
            Console.ReadLine();

        }
        public static string t (string str,int n)
        {
            return str.Remove(n, 1);
        }
    }
}
