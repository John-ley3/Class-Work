using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return the count of the number of times that a substring length 2 appears in the string and
         also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
         Last2("hixxhi") → 1
         Last2("xaxxaxaxx") → 1
         Last2("axxxaaxx") → 2
         */
        public int Last2(string str)
        {
            int count = 0;
            
            if(str.Length > 1)
            {
                string twoChars = str.Substring(str.Length - 2, 2);

                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i].Equals(twoChars[1]) && str[i - 1].Equals(twoChars[0]))
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    count--;
                }

                return count;
            }
            else
            {
                return 0;
            }
        }
    }
}
