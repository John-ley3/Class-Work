using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class KataPotter
    {
        public decimal GetCost(int[] books)
        {
            decimal sum = 0.0M;
            // Set the price levels for number of different books {0,1,2,3,4,5} per book
            decimal[] priceLevels = { 0M, 8.0M, 7.6M, 7.2M, 6.4M, 6M };

            if (books == null)
            {
                return sum;
            }

            // create a copy of the array for manipulation, it's polite to do
            int[] basket = new int[books.Length];
            books.CopyTo(basket,0);
            while(BooksInBasket(basket) > 0)
            {
                //Count how many unique books
                int uniqueBooks = 0;
                int totalBooksBought = 0;
                for (int i = 0; i < basket.Length; i++)
                {
                    if (basket[i] != 0)
                    {
                        // counts the unique books
                        uniqueBooks++;
                        // counts the total books
                        totalBooksBought++; // += basket[i];
                        // take the book out of the basket
                        basket[i]--;
                    }
                }
                // Its cheaper to get 2 sets of 4 than a set of 5 and a set of 3
                if (uniqueBooks == 5 && BooksInBasket(basket) == 3 && MaxValueInBasket(basket) == 1)
                {
                    sum += priceLevels[4] * 8;
                    break;
                }

                // now we've counted one set, let's add the price
                sum += priceLevels[uniqueBooks] * totalBooksBought;
            }

            return sum;
        }

        private int BooksInBasket(int [] books)
        {
            int sum = 0;
            for (int i = 0; i < books.Length; i++)
            {
                sum += books[i];
            }
            return sum;
        }

        private int MaxValueInBasket(int[] books)
        {
            int maxValue = 0;
            for (int i = 0; i < books.Length; i++)
            {
                maxValue = books[i] > maxValue ? books[i] :  maxValue;
            }
            return maxValue;
        }
    }
}
