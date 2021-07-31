using System;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*143*/
            // Fixed array avarage
            //double[] doublesArray = { 5, 2, 7, 3.5, 6.5, 8, 1, 9, 1, 3 };
            //double sum = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    sum += doublesArray[i];
            //}
            //double avarage = sum / doublesArray.Length;

            //Console.WriteLine(avarage);



            /*145*/

            //Console.Write("Enter nuber of elements ");
            //string numElementsInput = Console.ReadLine();
            //int numElements = Convert.ToInt32(numElementsInput);
            //double[] doublesArray = new double[numElements];
            //for (int i = 0; i < numElements; i++)
            //{
            //    Console.Write("enter " + (i + 1) + " elemt:");
            //    string val = Console.ReadLine();
            //    double value = Convert.ToDouble(val);
            //    doublesArray[i] = value;
            //}
            //double sum = 0;
            //for (int i = 0; i < numElements; i++)
            //{
            //    sum += doublesArray[i];
            //}
            //double avarage = 0;
            //avarage = sum / numElements;
            //Console.WriteLine();
            //Console.Write(avarage + " is among (" + doublesArray[0]);
            //for (int i = 1; i < numElements; i++)
            //{
            //    Console.Write(" + " + doublesArray[i]);
            //}
            //Console.WriteLine(") / " + numElements);


            /*151*/

            //Console.WriteLine(" 5 nearest palnets near to Sun");
            //string[] planets = new string[]
            //{
            //    "Mercury","Venus", "Eerth","Mars","Jupiter"
            //};
            //foreach (string planet in planets)
            //{
            //    Console.WriteLine("\t" + planet);
            //}
            //Console.WriteLine("\n\nAlphabet order");
            //string[] sortedNames = planets;
            //Array.Sort(sortedNames);

            //foreach (string planet in sortedNames)
            //{
            //    Console.WriteLine("\t" + planet);
            //}
            //Console.WriteLine("\n\nSorted by longest name");
            //int outer, inner;

            //for (outer = planets.Length - 1; outer >= 0; outer--)
            //{
            //    for (inner = 1; inner <= outer; inner++)
            //    {
            //        if (planets[inner - 1].Length > planets[inner].Length)
            //        {
            //            string temp = planets[inner - 1];
            //            planets[inner - 1] = planets[inner];
            //            planets[inner] = temp;
            //        }
            //    }
            //}

            //foreach (string planet in planets)
            //{
            //    Console.WriteLine("\t" + planet);
            //}
            //Console.WriteLine("\n\nin DESC order ");
            //for (int i = planets.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine("\t" + planets[i]);
            //}



        }
    }
}
