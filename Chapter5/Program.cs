using System;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {

            /*117*/

            //Console.WriteLine("Enter input currensy :");
            //string principalInput = Console.ReadLine();
            //decimal principal = Convert.ToDecimal(principalInput);
            //if (principal < 0)
            //{
            //    Console.WriteLine("Enter currensy cannot be negative");
            //    principal = 0;
            //}
            //Console.WriteLine("Enter percent per year:");
            //string interestInput = Console.ReadLine();
            //decimal interest = Convert.ToDecimal(interestInput);

            //if (interest < 0)
            //{
            //    Console.WriteLine("percent per year can not be negative");
            //    interest = 0;
            //}
            //decimal interestPaid;
            //interestPaid = principal * (interest / 100);
            //decimal total = principal + interestPaid;
            //Console.WriteLine("\nCurrency = " + principal);
            //Console.WriteLine("Percent = " + interest + "%");
            //Console.WriteLine("\nAdded percents = " + interestPaid);
            //Console.WriteLine("Total amount =" + total);




            /*120*/

            //int maxInterest = 50;

            //Console.WriteLine("Enter input currency :");
            //string principalInput = Console.ReadLine();
            //decimal principal = Convert.ToDecimal(principalInput);
            //if (principal < 0)
            //{
            //    Console.WriteLine("Enter currensy cannot be negative");
            //}
            //else
            //{
            //    Console.WriteLine("Enter percent per year:");
            //    string interestInput = Console.ReadLine();
            //    decimal interest = Convert.ToDecimal(interestInput);

            //    if (interest < 0 || interest > maxInterest)
            //    {
            //        Console.WriteLine("percent per year can not be negative");
            //        interest = 0;
            //    }
            //    else
            //    {
            //        decimal interestPaid;
            //        interestPaid = principal * (interest / 100);
            //        decimal total = principal + interestPaid;
            //        Console.WriteLine("\nCurrency = " + principal);
            //        Console.WriteLine("Percent = " + interest + "%");
            //        Console.WriteLine("\nAdded percents = " + interestPaid);
            //        Console.WriteLine("Total amount =" + total);
            //    }
            //}





            /*126*/

            //int maxInterest = 50;

            //Console.WriteLine("Enter input currency :");
            //string principalInput = Console.ReadLine();
            //decimal principal = Convert.ToDecimal(principalInput);
            //if (principal < 0)
            //{
            //    Console.WriteLine("Enter currensy cannot be negative");
            //}
            //else
            //{
            //    Console.WriteLine("Enter percent per year:");
            //    string interestInput = Console.ReadLine();
            //    decimal interest = Convert.ToDecimal(interestInput);

            //    if (interest < 0 || interest > maxInterest)
            //    {
            //        Console.WriteLine("percent per year can not be negative");
            //        interest = 0;
            //    }
            //    else
            //    {
            //        Console.WriteLine("enter Number of years:");
            //        string durationInput = Console.ReadLine();
            //        int duration = Convert.ToInt32(durationInput);
            //        Console.WriteLine("\nInput Currency" + principal);
            //        Console.WriteLine("Percent " + interest + "%");
            //        Console.WriteLine("Duratoin = " + duration + "years\n\n");

            //        int year = 1;
            //        while (year <= duration)
            //        {
            //            decimal interestPaid;
            //            interestPaid = principal * (interest / 100);
            //            principal = principal + interestPaid;
            //            principal = decimal.Round(principal, 2);
            //            Console.WriteLine(year + " - " + principal);
            //            year += 1;
            //        }
            //    }
            //}




            /*131 */

            //int maxInterest = 50;

            //decimal principal;

            //while (true)
            //{
            //    Console.WriteLine("Enter input currensy :");
            //    string principalInput = Console.ReadLine();
            //    principal = Convert.ToDecimal(principalInput);

            //    if (principal >= 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Enter currensy cannot be negative");
            //    Console.WriteLine("Try agin!!\n");
            //}

            //decimal interest;
            //while (true)
            //{
            //    Console.WriteLine("Enter percent per year:");
            //    string interestInput = Console.ReadLine();
            //    interest = Convert.ToDecimal(interestInput);
            //    if (interest >= 0 && interest <= maxInterest)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("percent per year can not be negative" +
            //        "or overvalue " + maxInterest);
            //    Console.WriteLine("Try agin!!\n");
            //}

            //Console.WriteLine("enter Number of years:");
            //string durationInput = Console.ReadLine();
            //int duration = Convert.ToInt32(durationInput);

            //Console.WriteLine("\nInput Currency = " + principal);
            //Console.WriteLine("Percent = " + interest + "%");
            //Console.WriteLine("Duration = " + duration + " years\n\n");

            //int year = 1;
            //while (year <= duration)
            //{
            //    decimal interestPaid;
            //    interestPaid = principal * (interest / 100);
            //    principal = principal + interestPaid;
            //    principal = decimal.Round(principal, 2);
            //    Console.WriteLine(year + " - " + principal);
            //    year += 1;
            //}

        }
    }
}
