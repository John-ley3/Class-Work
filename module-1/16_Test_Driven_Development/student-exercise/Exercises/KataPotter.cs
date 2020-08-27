using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPotter
    {
        public decimal GetCost(int[] books)
        {
            double discount1 = 0.0;
            double discount2 = 0.0;

            for(int i = 1; i < books.Length; i++)
            {
                if(books[i] > 0 && books[i - 1] > 0)
                {
                    discount1 += .05;
                    i++;
                }
                if()
                {

                }
            }
        }
    }
}
