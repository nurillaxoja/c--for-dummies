using System;

namespace Chapter15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating bank account ");
            BankAccount ba = new BankAccount();
            ba.InitBankAccount();
            double deposit = 123;
            Console.WriteLine("Depositing {0:C}", deposit);
            ba.Deposit(deposit);
            Console.WriteLine("Account = { 0 } ", ba.GetString());


            double fractionalAddition = 0.002;
            Console.WriteLine("Adding { 0 : С } ", fractionalAddition);
            ba.Deposit(fractionalAddition);

            Console.WriteLine("In a result accont { 0 } ", ba.GetString());





            MyObject localObject = new MyObject();
            Console.WriteLine("localObject.n = {0}", localObject.n);
            if (localObject.nextObject == null)
            {
                Console.WriteLine(" localObject . nextObject null ");
            }



            Console.WriteLine("Starting local Main ( ) ");
            Console.WriteLine("creating local object " +
            "MyObject in Main(): ");
            myObject localObject = new myObject();

        }
    }
    public class myObject
    {
        private static MyOtherObject _staticObj = new MyOtherObject();
        private MyOtherObject _dynamicObj;

        public myObject()
        {
            Console.WriteLine("calss constructor");
            _dynamicObj = new MyOtherObject();
        }

    }
    public class MyOtherObject
    {
        public MyOtherObject()
        {
            Console.WriteLine("Constructing myotherobject");
        }
    }
    public class MyObject
    {
        internal int n;
        internal MyObject nextObject;
    }
    public class BankAccount
    {
        private static int _nextAccountNumЬer = 1000;
        private int _accountNumЬer;
        private decimal _balance;
        public void InitBankAccount()
        {
            _accountNumЬer = ++_nextAccountNumЬer;
            _balance = 0;
        }

        public double GetBalance()
        {
            return (double)_balance;
        }

        public int GetAccountNumber()
        {
            return _accountNumЬer;
        }
        public void SetAccountNumber(int accountNumЬer)
        {
            this._accountNumЬer = accountNumЬer;
        }

        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                decimal temp = (decimal)amount;
                temp = Decimal.Round(temp, 2);
                _balance += temp;

            }
        }

        public double Withdraw(double withdrawal)
        {
            decimal decWithdrawal = (decimal)withdrawal;
            if (_balance <= decWithdrawal)
            {
                decWithdrawal = _balance;
            }
            _balance -= decWithdrawal;
            return (double)decWithdrawal;
        }
        public string GetString()
        {
            string s = String.Format(" #{0} = { 1 : С } ", GetAccountNumber(), GetBalance());
            return s;
        }

    }
}
