using System;
using System.Collections.Generic;

namespace chequetools
{
    public static class NumberToWord
    {
        static readonly List<string> easyNumbers = new List<string>
            {
                "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen",
                "nineteen"
            };

        static readonly List<string> tens = new List<string> {"", "ten", "twenty"};

        public static string ToWord(this string numberText)
        {
            int number;
            try
            {
                number = Convert.ToInt32(numberText);
            }
            catch (Exception)
            {
                return "error";
            }

            if (number < 20)
                return easyNumbers[number];

            var onedigit = number%10;
            var tendigit = number/10;

            return tens[tendigit] + easyNumbers[onedigit];
        }
    }
}