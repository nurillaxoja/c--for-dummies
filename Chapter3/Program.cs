using System;
using System.Collections.Generic;

namespace Chapter3
{
    //class Student
    //{
    //    public string Name;
    //}

    class Program
    {
        string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
            " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
            " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi " +
            "ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in " +
            "voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat " +
            "cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        static void Main(string[] args)
        {

            //Student s1 = new Student();
            //Student s2 = new Student();
            //s1.Name = "xoja";
            //s2.Name = s1.Name.ToUpper();
            //Console.WriteLine("s1 =  "+ s1.Name + "s2 = "+ s2.Name);
            //int a = string.Compare("EXIT", "exit");
            //Console.WriteLine(a);


            /* 2 nd exampel */

            //List<string> names = new List<string> {"Christa"
            //, "Sarah","Jhonathan", "Sam" , "Schemkowintz"};
            //foreach(string s in names)
            //{
            //    Console.WriteLine("Name ' "+s+ "' befor beautified");
            //}
            //Console.WriteLine();

            //List<string> stringsToAlign = new List<string>();
            //for (int i = 0; i < names.Count; i++)
            //{
            //    string trimmedName = names[i].Trim();
            //    stringsToAlign.Add(trimmedName);
            //}
            //int maxLength = 0;
            //foreach (string s in stringsToAlign)
            //{
            //    if (s.Length > maxLength)
            //    {
            //        maxLength = s.Length;
            //    }
            //}
            //for (int i = 0; i < stringsToAlign.Count; i++)
            //{
            //    stringsToAlign[i] = stringsToAlign[i].PadRight(maxLength + 1);
            //}
            //Console.WriteLine("after beautify \n");

            //foreach (string s in stringsToAlign)
            //{
            //    Console.WriteLine("Name ' " + s + "' after beautified");
            //}





            /* 95 page code 
              output format control */
            for(; ; )
            {
                Console.WriteLine("Enter float number");
                string numberInput = Console.ReadLine();
                if (numberInput.Length == 0)
                {
                    break;
                }
                double number = Double.Parse(numberInput);
                Console.WriteLine("Enter modificators with , forms , devisions and space");
                Console.WriteLine("Example : C E F1 N0 0000000.00000");

                char[] separator = { ' ' };
                string formatString = Console.ReadLine();
                string[] formats = formatString.Split(separator);

                foreach(string s in formats)
                {
                    if (s.Length != 0)
                    {
                        string formantCommand = "{0:}" + s + "}";
                        Console.WriteLine("Modificator {0:"+s+"} gives ", formantCommand);
                        try
                        {
                            Console.WriteLine(formantCommand, number);
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Wrong modificator");
                        }
                        Console.WriteLine();
                    }
                }
            }



            Console.ReadLine();
        }
    }
    
}
