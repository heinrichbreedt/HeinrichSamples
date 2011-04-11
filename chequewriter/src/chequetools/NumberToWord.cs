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

        static readonly List<string> tens = new List<string>
            {
                "", "ten", "twenty", "thirty", "fourty", "fifty", 
                "sixty", "seventy", "eighty", "ninety"
            };

        static readonly List<string> groups = new List<string>
            {
                "", " thousand", " million", " billion"
            };

        public static bool IsEvenHundred(this int number)
        {
            return number%100 == 0;
        }

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
            if (number == 0) return string.Empty;

            string word = null;
            
            var groupIndex = 0;
            while(number > 0)
            {
                var remainder = number % 1000;
                if(string.IsNullOrEmpty(word))
                    word = GetHundredsWord(remainder) + groups[groupIndex];
                else
                    word = GetHundredsWord(remainder) + groups[groupIndex] + " and " + word;
                
                number = number/1000;
                groupIndex++;
            }
            return word;
        }

        static string GetHundredsWord(int number)
        {
            if (number < 20)
                return easyNumbers[number];

            if (number < 100)
                return GetNumberWithoutHundred(number);

            var hunderdDigit = number/100;
            if (number.IsEvenHundred())
                return easyNumbers[hunderdDigit] + " hundred";

            return easyNumbers[hunderdDigit] + " hundred and " + GetNumberWithoutHundred(number);
        }

        static string GetNumberWithoutHundred(int number)
        {
            var lessHundredNumber = number%100;
            if (lessHundredNumber < 20)
                return easyNumbers[lessHundredNumber];


            var onedigit = lessHundredNumber % 10;
            var tendigit = lessHundredNumber / 10;

            return tens[tendigit] + easyNumbers[onedigit];
        }
    }
}