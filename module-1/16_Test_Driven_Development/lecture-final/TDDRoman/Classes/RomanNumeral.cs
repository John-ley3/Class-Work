using System;
using System.Collections.Generic;
using System.Text;

namespace TDDRoman.Classes
{
    public class RomanNumeral
    {
        public string GetRomanNumeral(int numberToConvert)
        {
            string result = "";
            if(numberToConvert > 2999)
            { return result; }
            result += ConvertArabicToRoman(1000, "M", ref numberToConvert);
            result += ConvertArabicToRoman(500, "D", ref numberToConvert);
            result += ConvertArabicToRoman(100, "C", ref numberToConvert);
            result += ConvertArabicToRoman(50, "L", ref numberToConvert);
            result += ConvertArabicToRoman(10, "X", ref numberToConvert);
            result += ConvertArabicToRoman(5, "V", ref numberToConvert);
            result += ConvertArabicToRoman(1, "I", ref numberToConvert);
            result = result.Replace("DCCCC", "CM");
            result = result.Replace("CCCC", "CD");
            result = result.Replace("LXXXX", "XC");
            result = result.Replace("XXXX", "XL");
            result = result.Replace("VIIII", "IX");
            result = result.Replace("IIII", "IV");
            return result;
        }

        private string ConvertArabicToRoman(int places, string romanNumeral, ref int targetNumber)
        {
            string result = "";
            while (targetNumber >= places)
            {
                result += romanNumeral;
                targetNumber -= places;
            }
            return result;
        }
    }
}
