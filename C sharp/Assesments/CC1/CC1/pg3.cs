using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC1
{
    class pg3
    {
        static void Main()
        {
            int[,] SampleInput = { { 1, 2, 3 }, { 1, 3, 2 }, { 1, 2, 2 } };

            for(int j=0; j< SampleInput.GetLength(0); j++)
            {
                int a = SampleInput[j, 0];
                int b = SampleInput[j, 1];
                int c = SampleInput[j, 2];
                int LargestNum = FindLargest(a, b, c);
                Console.WriteLine(LargestNum);
                
                Console.Read();

            }
        }

        static int FindLargest(int a,int b,int c)
        {
            int LargestNum = a;

            if (b > LargestNum)
            {
                LargestNum = b; ;
            }

            if(c>LargestNum)
            {
                LargestNum = c;
            }
            return LargestNum;
            
        }
    }
}
