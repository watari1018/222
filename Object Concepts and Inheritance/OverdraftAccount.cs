using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Concepts_and_Inheritance
{
    public class OverdraftAccount:Account
    {
        private static double interestrate = 0.25;
        private static double overdraftInterest = 6;

        public OverdraftAccount(string Number, string Holder, double bal)
    : base(Number, Holder, bal)
        {
        }

        public override double CalculateInterest()
        {
            if(Balance>0)
            {
                return Balance * interestrate / 100;
            }
            else 
            {
                return Balance * overdraftInterest / 100; 
            }
        }

    }
}
