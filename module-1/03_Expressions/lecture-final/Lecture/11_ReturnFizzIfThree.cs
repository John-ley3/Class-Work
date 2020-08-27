using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureExample
    {

        /*
        11. Write an if statement that returns "Fizz" 
            if the parameter is 3 and returns an empty string for anything else.
            TOPIC: Conditional Logic
        */
        public string ReturnFizzIfThree(int number)
        {
            // set variable to default value
            string result = "";
            // check the condition
            if(number == 3)
            {
                // if true, set the result to the proper value
                result = "Fizz";
            }
            // return the result
            return result;
        }
    }
}
