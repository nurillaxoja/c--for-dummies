using System;

namespace Chapter19
{
    class Program
    {
        delegate int MyDelType(string name);
        static void Main(string[] args)
        {
            MyDelType del = new MyDelType(CallBackMethod);
            UseTheDel(del, "Hello");
        }
        private static void UseTheDel(MyDelType del , string arg)
        {
            if (del == null)
            {
                return;
            }
            Console.WriteLine("UseTheDel writing {0}", del(arg));
        }
        public static int CallBackMethod(string stringPassed)
        {
            Console.WriteLine("CallBackMethod writing {0}", stringPassed);
            return stringPassed.Length;
        }

    }
}
