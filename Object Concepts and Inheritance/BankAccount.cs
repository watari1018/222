using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Concepts_and_Inheritance
{
    internal class BankAccount
    {
        private List<Account> _accounts;

        public BankAccount(string name)
        {
            Name = name;
            _accounts = new List<Account>();
        }

        // Auto-properties
        public string Name { get; set; }

        /**
         * TODO: Implement method AddAccount()
         * This method helps this bank branch keeps another
         * bank account, by adding a given Account object to the
         * _accounts list.
         * 
         * For more information about how to use List, refer
         * to https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1#examples
         */
        public void AddAccount(Account account)
        {
            // Hint: this method only has 1 
            // line of code
            _accounts.Add(account);
        }

        /**
         * This method prints the information of all 
         * the accounts' that this branch keeps
         */
        public void PrintAccounts()
        {
            foreach (Account account in _accounts)
            {
                Console.WriteLine(account);
            }
        }

        public double TotalDeposits()
        {
            double total = 0;
            foreach (Account acc in _accounts)
            {
                double bal = acc.Balance; // Use of polymorphism
                if (bal > 0)
                    total += bal;
            }
            return total;
        }

        public double TotalInterestPaid()
        {
            double total = 0;
            foreach (Account acc in _accounts)
            {
                double intr = acc.CalculateInterest(); // Use of polymorphism
                if (intr > 0)
                    total += intr;
            }
            return total;
        }


        public double TotalInterestEarned()
        {
            double total = 0;
            foreach (Account acc in _accounts)
            {
                double intr = acc.CalculateInterest(); // Use of polymorphism
                if (intr < 0)
                    total += (-intr);
            }
            return total;
        }

        public void PrintCustomers()
        {
            List<string> holderIds = GetAllHolderIds();

            for (int i = 0; i < holderIds.Count; i++)
                Console.WriteLine(holderIds[i]);
        }

        private List<string> GetAllHolderIds()
        {
            List<string> holderIds = new List<string>();
            foreach (Account acc in _accounts)
            {
                string holderId = acc.AccountHolderId; // Use of polymorphism
                if (!holderIds.Contains(holderId))
                {
                    // Only add non-existed holderId
                    holderIds.Add(holderId);
                }
            }

            return holderIds;
        }
    }
}
