using System;
using System.IO;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*173*/

            //string directoryName;
            //if (args.Length == 0)
            //{
            //    directoryName = Directory.GetCurrentDirectory();
            //}
            //else
            //{
            //    directoryName = args[0];
            //}
            //Console.WriteLine(directoryName);
            //string[] files = Directory.GetFiles(directoryName);
            //foreach (FileInfo file in files)
            //{
            //    Console.WriteLine("Dump of the file {0};", file.FullName);
            //    DumpHex(file);
            //    Console.WriteLine();
            //}





            /*176*/

            //FileStream fs;
            //BinaryReader reader;
            //try
            //{
            //    fs = file.OpenRead();
            //    reader = new BinaryReader(fs);
            //}
            //catch (Exception е)
            //{
            //    Console.WriteLine("\nHe могу читать \" " + file.FullName
            //        + " \" ");
            //    Console.WriteLine(e.Message);
            //    return;
            //}

            //for (int l ine = 1; true; l ine++)
            //{
            //    byte[] buffer = new byte[l0];
            //    int numВytes = reader.Read(buffer, 0, buffer.Length);
            //    if (numВytes == 0)
            //    {
            //        return;
            //    }

            //    Console.Write(" { 0 : D3 } - ", line);
            //    DumpBuffer(buffer, numВytes);
            //    if ((line % 20) == 0)
            //    {
            //        Console.WriteLine("Haжмитe <Enter> для вывода " +
            //        "очередных 20 строк");
            //        Console.ReadLine();

            //    }
            //}





            /*185*/

            //KeyedArray ma = new KeyedArray(100);
            //ma{ "Bart "}= 8;
            //ma{ "Lisa " } = 10;
            //ma{ "Maggie" } = 2;
            //Console.WriteLine("Searching Lisa age");
            //int age = (int)ma("Lisa ") ;
            //Console.WriteLine("Lisa's age - { O } ", age);




            /*188*/
            MonthDays md = new MonthDays();
            Console.WriteLine("Monthes: \n");
            foreach (string month in md)
            {
                Console.WriteLine(month);
            }


            StringChunks sc = new StringChunks();

            Console.WriteLine("String : \n");
            foreach (string chunk in sc)
            {
                Console.Write(chunk);
            }
            Console.WriteLine();
            Console.WriteLine("Show in one line: \n");
            foreach (string chunk in sc)
            {
                Console.WriteLine(chunk);
            }
            Console.WriteLine();


            YieldBreakEx yb = new YieldBreakEx();
            Console.WriteLine("Simple numbers: \n");
            foreach (int prime in yb)
            {
                Console.WriteLine(prime);
            }


            EvenNumbers en = new EvenNumbers();
            Console.WriteLine("Even numbers: \n");
            foreach (int even in en.DescendingEvens(11 ,3))
            {
                Console.WriteLine(even);
            }


            PropertyIterator prop = new PropertyIterator();
            Console.WriteLine("\n Double numbers: \n");
            foreach (double db in prop.DoubleProp)
            {
                Console.WriteLine(db);
            }


            Console.ReadLine();



            /* 2 */
        }
    }

    /*183*/
    class KeyedArray
    {

        private string[] _keys;
        private object[] _arrayElements;

        public KeyedArray(int nSize)
        {
            _keys = new string[nSize];
            _arrayElements = new object[nSize];
        }
    }

    class MonthDays
    {
        string[] months =
        { "January 31" , "February 28" , "March 31" ,
        "April 30" , "Мау 31" , "June 30" , "July 31" ,
        "August 31" , "SeptemЬer 30" , "October 31" ,
        "NovemЬer 30" , " DecemЬer 31" };

        public System.Collections.IEnumerator GetEnumerator()
        {
            foreach (string month in months)
            {
                yield return month;
            }
        }
    }


    class StringChunks
    {
        public System.Collections.IEnumerator GetEnumerator()
        {
            yield return "Using iterator ";
            yield return "Ьlocks ";
            yield return "isn ' t all ";
            yield return "that hard";
            yield return ".";
        }
    }

   class YieldBreakEx
    {
        int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
        public System.Collections.IEnumerator GetEnumerator()
        {
            foreach (int  prime in primes)
            {
                if (prime > 13) yield break;
                yield return prime;
            }
        }
    }

    class EvenNumbers
    {
        public System.Collections.IEnumerable DescendingEvens(int top, int stop)
        {
            if (top % 2 != 0 )
            {
                top -= 1;
            }
            for (int i = top; i >= stop; i -=2)
            {
                if (i < stop)
                    yield break;
                yield return i;
            }
        }
    }

    class PropertyIterator
    {
        double[] doubles = { 1.0, 2.0, 3.5, 4.67 };
        public System.Collections.IEnumerable DoubleProp
        {
            get
            {
                foreach (double db in doubles)
                {
                    yield return db;
                }
            }
        }
    }
}