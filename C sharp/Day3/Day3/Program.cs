using System;


namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
           DecisionMaking dec = new DecisionMaking();
         //   DecisionMaking.Checkgrade();
         //   dec.CheckGradeSwitch();
          //  Loops.WhileLoop();
         //   Loops.DoWhile();
          //  Loops.ForLoop();
           // Loops.ImplicitExample();
           // ArrayEg.ArraysExamp();
            ArrayEg.TwoDim();
            ArrayEg.Jagged();




            int x = 10;
            CallByValue(x);
            Console.WriteLine("Value of x is {0}", x);
            Console.WriteLine("-------------------");

            Program pgm = new Program();
            pgm.CallByRef(ref x);
            Console.WriteLine("value of x {0}", x);
            Console.WriteLine("-------------------");
            int total, prod, dif, div  = 0;

            div = Calfunc(5, 2, out total, out prod, out dif);
            Console.WriteLine($"The sum is {total}, The product is {prod}, difference is {dif}");
            
            
            
            
            Console.Read();


        }
        public static void CallByValue(int j)
        {
            Console.WriteLine("The value of j {0}", j);
            j = 100;
            Console.WriteLine("j is {0}", j);
        }

        public void CallByRef(ref int j)
        {
            Console.WriteLine("The ref value of j is {0}", j);
            j = 100;
            Console.WriteLine("The ref value of j {0}", j);
        }

         public static int Calfunc(int a,int b,out int sum,out int product,out int diff)
        {
            sum = a + b;
            product = a * b;
            diff = a - b;
            return a / b;
        }

            

    }
}
