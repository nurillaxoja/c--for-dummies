using System;

namespace Chapter16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with object in " +
               "base class ");
            ВaseClass bc = new ВaseClass();
            bc._dataMemЬer = 1;
            bc.SomeMethod();
            SubClass sc = new SubClass();
            sc._dataMemЬer = 2;
            sc.SomeOtherMethod();




            BankAccount ba = new BankAccount();
            ba.InitBankAccount(100M);
            ba.Deposit(100M);
            Console.WriteLine("Account {0}", ba.ToBankAccountString());
            SavingsAccount sa = new SavingsAccount();
            sa.InitSavingsAccount(100M, 12.5M);
            sa.AccumulateInterst();
            Console.WriteLine("account {0}", sa.ToSavingsAccountString());



        }
    }

    public class BankAccount
    {
        public static int _nextAccountNumber = 1000;
        public int _accountNumber;
        public decimal _balance;

        public void InitBankAccount()
        {
            InitBankAccount(0);
        }
        public void InitBankAccount(decimal initalBalance)
        {
            _accountNumber = ++_nextAccountNumber;
            _balance = initalBalance;
        }
        public decimal Balance
        {
            get { return _balance; }
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }
        public decimal Withdraw(decimal withdrawal)
        {
            if (Balance <= withdrawal)
            {
                withdrawal = Balance;
            }
            _balance -= withdrawal;
            return withdrawal;
        }
        public string ToBankAccountString()
        {
            return string.Format("{0} - {1:C}", _accountNumber, Balance);
        }
    }

    public class SavingsAccount : BankAccount
    {
        public decimal _interstRate;
        public void InitSavingsAccount(decimal _interstRate)
        {
            InitSavingsAccount(0, _interstRate);
        }
        public void InitSavingsAccount(decimal initial, decimal interestRate)
        {
            InitBankAccount(initial);
            _interstRate = interestRate / 100;
        }
        public void AccumulateInterst()
        {
            _balance = Balance + (decimal)(Balance * _interstRate);
        }
        public string ToSavingsAccountString()
        {
            return string.Format("{0} ({1}%)", ToBankAccountString(), _interstRate);
        }

    }
    public class ВaseClass
    {
        public int _dataMemЬer;
        public void SomeMethod()
        {
            Console.WriteLine("SomeMethod ( ) ");
        }
    }
    public class SubClass : ВaseClass
    {
        public void SomeOtherMethod()
        {
            Console.WriteLine("SomeOtherMethod ( ) ");
        }
    }
}
