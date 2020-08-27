using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return true if the sum of all the 2's in the array is exactly 8.
         Sum28([2, 3, 2, 2, 4, 2]) → true
         Sum28([2, 3, 2, 2, 4, 2, 2]) → false
         Sum28([1, 2, 3, 4]) → false
         */
        public bool Sum28(int[] nums)
        {
            int sumOfTwo = 0;
            for(int index = 0; index < nums.Length; index++)
            {
                if(nums[index] == 2)
                {
                    sumOfTwo += 2;
                }
            }
            if(sumOfTwo == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
