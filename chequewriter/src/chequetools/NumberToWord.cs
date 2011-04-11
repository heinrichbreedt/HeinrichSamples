﻿using System;
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

            var hunderdDigit = number/100;

            if(hunderdDigit > 0)
                return easyNumbers[hunderdDigit] + " hundred and " + GetNumberWithoutHundred(number);

            return GetNumberWithoutHundred(number);
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