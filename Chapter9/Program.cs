using System;

namespace Chapter9
{
    public class MyMathFunctions
    {
        public static int Factorial(int value)
        {
            if (value < 0) 
            {
                string s = String.Format("Negative argument calling in " +
                    "Factorial {0}", value);
                throw new ArgumentException(s);
            }
            int factorial = 1;
            do
            {
                factorial *= value;
            } while (--value >1 );
            return factorial;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*232*/
            try
            {
                for (int i = 6; i > -6; i--)
                {
                    int factorial = MyMathFunctions.Factorial(i);
                    Console.WriteLine("i = {0}, factorial = {1}", i, factorial);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Factorial error:");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
