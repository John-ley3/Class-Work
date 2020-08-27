using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        
        public int Result { get; private set; }

        public int Add (int addEnd)
        {
            Result += addEnd;
            return Result;
        }

        public int Multiply(int multiplier)
        {
            Result *= multiplier;
            return Result;
        }

        public int Power (int exponent)
        {
            if(exponent > 0)
            {
                while(exponent - 1 > 0)
                {
                    Result *= Result;
                    exponent--;
                }
                return Result;
            }
            else if(exponent < 0)
            {
                while (exponent + 1 > 0)
                {
                    Result /= Result;
                    exponent++;
                }
                return Result;
            }
            else
            {
                return 1;
            }
        }

        public void Reset()
        {
            Result = 0;
        }

        public int Subtract(int subtrahend)
        {
            Result -= subtrahend;
            return Result;
        }

    }
}
