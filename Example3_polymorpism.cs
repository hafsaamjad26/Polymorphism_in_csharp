using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    class BankAccount
    {
        public double balance;

        //construvtor
        public BankAccount(double b)
        {
            balance = b;
        }
        public virtual double CalculateInterest()
        {
            return 0;
        }
    }
    class SavingAccount : BankAccount
    {
        public SavingAccount(double b) : base(b)
        {

        }
        public override double CalculateInterest()
        {
            return balance * 0.05;
        }
    }
    class CurrentAccount : BankAccount
    {
        public CurrentAccount(double b) : base(b)
        {

        }
        public override double CalculateInterest()
        {
            return balance * 0.02;
        }
    }
            internal class Program
            {
                static void Main(string[] args)
                {
                    BankAccount b1 = new BankAccount(3490.65);
                    Console.WriteLine( b1.CalculateInterest());
                    BankAccount b2 = new SavingAccount(3870.25);
                    Console.WriteLine(b2.CalculateInterest());
                    BankAccount b3 = new CurrentAccount(7640.95);
                    Console.WriteLine(b3.CalculateInterest());
                }
            }
        }
    
