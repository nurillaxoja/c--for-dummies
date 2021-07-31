    using System;

namespace Chapter17
{
    public class MyClass
    {
        public static void AMethod1()
        {
            Console.WriteLine("MYclass method 1");
        }
        public void AMethod2()
        {
            Console.WriteLine("MYclass method 2");
        }

    }
    public class UrClass
    {
        public static void AMethod1()
        {
            Console.WriteLine("URclass method 1");
        }
        public void AMethod2()
        {
            Console.WriteLine("URclass method 1");
        }
    }

   public class BankAccount
    {
        protected decimal _balance;

        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }
        public decimal Balance
        {
            get { return _balance; }
        }
        public virtual decimal Withdraw(decimal amount)
        {
            Console.WriteLine("BankAccount.Withdraw() ${0}..", amount);
            decimal amountToWithdraw = amount;

            if (amountToWithdraw > Balance)
            {
                amountToWithdraw = Balance;
            }
            _balance -= amountToWithdraw;
            return amountToWithdraw;
        }
    }
    public class SavingsAccount : BankAccount
    {
        public decimal _interestRate;

        public SavingsAccount(decimal initialBalance, decimal interstRate) : base (initialBalance)
        {
            _interestRate = interstRate / 100;
        }
        public void AccumulateInterest()
        {
            _balance = Balance + (Balance * _interestRate);
        }
        public decimal Withdrawal(decimal withdrawal)
        {
            base.Withdraw(1.5M);
            return base.Withdraw(withdrawal);
        }
    }
    abstract public class AbstractBaseClass
    {
        abstract public void Output(string OutputString);

    }
    public class Subclass1 : AbstractBaseClass
    {
        override public void Output(string source)
        {
            string s = source.ToUpper();
            Console.WriteLine("Calling Subclass.output() from {0}", s);
        }
    }
    public class Subclass2 : AbstractBaseClass
    {
        override public void Output(string source)
        {
            string s = source.ToLower();
            Console.WriteLine("Calling Subclass.output() from {0}", s);

        }
    }
    class Program
    {
        public static void Test(AbstractBaseClass ba)
        {
            ba.Output("Test");
        }
        public static void MakeAWithdrawal(BankAccount ba, decimal amount)
        {
            ba.Withdraw(amount);
        }
        static void Main(string[] args)
        {
            //BankAccount ba;
            //SavingsAccount sa;
            //// Вывод баланса
            //Console.WriteLine("MakeAWithdrawal (Ьа, . . . ) ");
            //ba = new BankAccount(200M);
            //MakeAWithdrawal(ba, 100M);
            //Console.WriteLine("Бaлaнc BankAccount равен { 0 : С ) ",
            //ba.Balance);
            //Console.WriteLine("MakeAWithdrawal ( sa, . . . ) ");
            //sa = new SavingsAccount(200M, 12);
            //MakeAWithdrawal(sa, 100M);
            //Console.WriteLine("Бaлaнc SavingsAccount равен { 0 : С } ",
            //sa.Balance);




            Console.WriteLine("Creating object of subclass1 ");
            AbstractBaseClass sc1 = new Subclass1();
            Test(sc1);

            Console.WriteLine("Creating object of subclass2 ");
            AbstractBaseClass sc2 = new Subclass2();
            Test(sc2);
        }
    } 
}
