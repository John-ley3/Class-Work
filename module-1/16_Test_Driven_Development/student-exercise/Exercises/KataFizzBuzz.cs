using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string GetFizzBuzz(int num)
        {
            string number = num.ToString();

            if(num > 100 || num <= 0)
            {
                return "";
            }
            if ((num % 3 == 0 && num % 5 == 0) || (number.Contains("3") || number.Contains("5")))
            {
                return "FizzBuzz";
            }
            else if (num % 3 == 0 || number.Contains("3"))
            {
                return "Fizz";
            }
            else if (num % 5 == 0 || number.Contains("5"))
            {
                return "Buzz";
            }
            return $"{num}";
        }
    }
}
