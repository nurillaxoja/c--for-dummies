using System;

namespace Chapter13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*285 start*/
            decimal principal = 0M;
            decimal interest = 0M;
            decimal duration = 0M;
            InputInterestData(ref principal, ref interest, ref duration);

            Console.WriteLine("\nContribution = " + principal);
            Console.WriteLine("\nInterest rate = " + interest + "%");
            Console.WriteLine("\nDuration = " + duration + " year\n");

            OutputInteresetTable(principal, interest, duration);
            /*285 end*/

            /*293 start */
            //AvarageAndDisplay("Score 1", 3.5, "scores 2", 4.0);
            /*293 end*/


            /*295 start */

            //AvarageAndDisplay("my scores ", 3.5, "your scores",  4.0);
            //Console.WriteLine();
            //AvarageAndDisplay(3.5, 4.0);

            /*295 end*/

            /*300 start */

            //Console.WriteLine("{0}\n\n", DisplayRoundedDecimal(12.345678M, 3));
            //Console.WriteLine("{0}", DisplayRoundedDecimal(12.345678M));

            /*300 end*/

        }
        /*285 start*/
        public static void InputInterestData(ref decimal principal,
           ref decimal interest, ref decimal duration)
        {
            principal = InputPositiveDecimal("Contribution");
            interest = InputPositiveDecimal("Interest");
            duration = InputPositiveDecimal("duration");
        }
        public static decimal InputPositiveDecimal(string prompt)
        {
            while (true)
            {
                Console.WriteLine("Insert " + prompt + ":");
                string input = Console.ReadLine();
                decimal value = Convert.ToDecimal(input);

                if (value >= 0)
                {
                    return value;
                }
                Console.WriteLine(prompt + "cannot insert negative value");
                Console.WriteLine("Try again!!\n");
            }
        }
        public static void OutputInteresetTable(decimal principal,
            decimal interest, decimal duration)
        {
            for (int year = 1; year <= duration; year++)
            {
                decimal interestPaid;
                interestPaid = principal * (interest / 100);

                principal = principal + interestPaid;

                principal = decimal.Round(principal, 2);

                Console.WriteLine(year + "-" + principal);
            }
        }
        /*285 end*/

        /*293 start*/
        //public static void AvarageAndDisplay(string s1, double d1,
        //    string s2, double d2)
        //{
        //    double avarage = (d1 + d2) / 2;
        //    Console.WriteLine("avarage " + s1 + ", equal " + d1 + " and " +
        //        s2 + " equal " + d2 + " equal " + avarage);
        //}
        /*293 end*/

        /*295 start */

        //public static void AvarageAndDisplay(string s1, 
        //    double d1, string s2, double d2)
        //{
        //    double avarage = (d1 + d2) / 2;
        //    Console.WriteLine("avarage " + s1 + ", equal " + d1 + " and " +
        //s2 + " equal " + d2 + " equal " + avarage);
        //}

        //public static void AvarageAndDisplay(double d1 , double d2)
        //{
        //    double avarage = (d1 + d2) / 2;
        //    Console.WriteLine("avarage " + d1 + " and " +
        // "avarage "+d2 + " equal " + avarage);
        //}

        /*295 end*/

        /*300 start */
        //public static string DisplayRoundedDecimal(decimal value , int nNumberOfSignificantDigints)
        //{
        //    decimal mRoundedValue = decimal.Round(value, nNumberOfSignificantDigints);
        //    string s = Convert.ToString(mRoundedValue);
        //    return s;
        //}
        //public static string DisplayRoundedDecimal(decimal value)
        //{
        //    string s = DisplayRoundedDecimal(value, 2);
        //    return s;
        //}
        /*300 end*/
    }
}


