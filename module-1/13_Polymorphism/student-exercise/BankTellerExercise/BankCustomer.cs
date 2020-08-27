using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer 
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                int totalBalance = 0;
                foreach(IAccountable element in accounts)
                {
                    totalBalance += element.Balance;
                }
                
                if(totalBalance >= 25000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public List<IAccountable> accounts { get; private set; } = new List<IAccountable>();

        public void AddAccount(IAccountable newAccount)
        {
            accounts.Add(newAccount);
        }
        public IAccountable[] GetAccounts()
        {
            return accounts.ToArray();
        }
    }
}
