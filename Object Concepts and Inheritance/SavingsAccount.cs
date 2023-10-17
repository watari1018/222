using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Concepts_and_Inheritance
{
    public class SavingsAccount : Account
    {
        private static double interestRate = 0.1;
        public SavingsAccount(string Number, string Holder, double bal)
            : base(Number, Holder, bal)
        {
        }
        public override double CalculateInterest()
        {
            return Balance * interestRate / 100;
        }

        public override bool Withdraw(double amt)
        {
            if (Balance < interestRate)
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
