using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        public string Name { get; set; }
        public int NumberOfEmployees { get; set; }

        public decimal Revenue { get; set; }

        public decimal Expenses { get; set; }

        public string GetCompanySize()
        {
            string result = "";
            if(NumberOfEmployees < 50)
            {
                result = "small";
            } else if (NumberOfEmployees >= 50 && NumberOfEmployees < 250)
            {
                result = "medium";
            } else
            {
                result = "large";
            }
            return result;
        }

        public decimal GetProfit()
        {
            return Revenue - Expenses;
        }
    }
}
