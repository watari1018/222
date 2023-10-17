using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Concepts_and_Inheritance
{
    public class Account
    {

        private string acctNumber;
        private string acctHolderId;
        private double balance;

        public Account(string Number, string Holder, double bal)
        {
            acctNumber = Number;
            acctHolderId = Holder;
            balance = bal;
        }

        public string AccountNumber
        {
            get 
            {
                return this.acctNumber; 
            }
        }

        public string AccountHolderId
        {
            get { return this.acctHolderId; }
            set { this.acctHolderId = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double amt) 
        {
            Balance += amt;
            Console.WriteLine("This is Deposit");
        }



        public virtual bool Withdraw(double amt)
        {
            Balance -= amt;
            Console.WriteLine("this is Withdraw");
            return true;
        }


        public bool TransferTo(double amt,Account another)
        {
            bool isWithdrawOk=Withdraw(amt);

            

            if(isWithdrawOk)
            {
                another.Deposit(amt);
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual double CalculateInterest()
        {
            return 0;
        }
        
        public void CreditInterest()
        {
            var interest=CalculateInterest();
            Deposit(interest);
        }

    }
}
