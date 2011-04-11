using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chequetools
{
    public static class NumberToWord
    {
        static List<string> singleDigitNumbers = new List<string> {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
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
            if (number == 0)
                return "";

            return singleDigitNumbers[number];
        }


    }

}
