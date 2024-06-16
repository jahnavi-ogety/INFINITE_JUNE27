using System;


namespace Day3
{
    class ArrayEg
    {
        public static void  ArraysExamp()
        {
            int[] data = new int[] { 2, 3, 4, 5, 8 };
            Console.WriteLine(data.Length);
            Console.WriteLine(data.Rank);
            Console.WriteLine("-----------Before sort------");
            
            for(int i=0;i<=5;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------After sort------");
            Array.Sort(data);
            foreach (int x in data)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------Reverse ------");

            Array.Reverse(data);
            foreach (int x in data)
            {
                Console.WriteLine(x);
            }




        }

        public static void TwoDim()
        {
            int[,] data1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            
            // first loop iterate the rows
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(data1[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Jagged()
        {
            // declare jagg array of 2 rows
            int[][] myjagg = new int[2][];

            // size of each row
            myjagg[0] = new int[3];
            myjagg[1] = new int[2];

            //initilize the jag arrays
            myjagg[0][0] = 2;
            myjagg[0][1] = 4;
            myjagg[0][2] = 6;

            myjagg[1][0] = 1;
            myjagg[1][1] = 3;
    //another way
            int[][] jag2 =
                {
                new int[] {5,9,7,8},
                new int[] { 23,76 },
                new int[] { 35,40,45 }
            };

            for (int i=0; i<jag2.Length; i++)
            {
                Console.WriteLine(" Number of elements at row : " + i + "are" + " " + jag2[i].Length);
                //inner loop
                for(int j=0;j<jag2[i].Length;j++)
                {
                    Console.WriteLine(jag2[i][j] + " ");
                }
            }

        }
    }
}
