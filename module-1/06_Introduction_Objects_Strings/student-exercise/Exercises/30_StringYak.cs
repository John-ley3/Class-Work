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
         Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, but
         the "a" can be any char. The "yak" strings will not overlap.
         StringYak("yakpak") → "pak"
         StringYak("pakyak") → "pak"
         StringYak("yak123ya") → "123ya"
         */
        public string StringYak(string str)
        {
            for(int i = 1; i < str.Length - 2; i++)
            {
                if(str.Substring(i - 1, 3).Equals("yak"))
                {
                    return str.Substring(0, i - 2) + str.Substring(i + 2);
                }
            }
            return str;
        }
    }
}
