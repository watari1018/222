using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Concepts_and_Inheritance
{
    public class CurrentAccount:Account
    {
        private static double interestRate = 0.25;

        public CurrentAccount(string Number, string Holder, double bal)
            :base(Number, Holder, bal)
        { 
        }
        public override double CalculateInterest()
        {
            return Balance * interestRate / 100;
        }

        public override bool Withdraw(double amt)
        {
            if (amt < Balance)
            {
            return base.Withdraw(amt);
            }
            else
            {
                return false;
            }
        }
    }
}
