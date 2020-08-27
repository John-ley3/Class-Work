using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureProblem
    {
        /*
         10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers)
        {
            // grab the first value
            int highest = randomNumbers[0];

            // Loop through array
            for(int index = 0; index < randomNumbers.Length; index++)
            {
                // is the value at the current index, the highest value?
                int currentValue = randomNumbers[index];

                // check if current is higher than highest
                if(currentValue > highest)
                {
                    // If current is higher, remember it in the highest variable
                    highest = currentValue;
                }

            }
            return highest;
        }
    }
}
