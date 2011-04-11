using NUnit.Framework;
using Shouldly;

namespace chequetools.test
{
    [TestFixture]
    public class NumberToWordsFixture
    {
        [TestCase("0", "")]
        [TestCase("1", "one")]
        [TestCase("2", "two")]
        [TestCase("3", "three")]
        [TestCase("4", "four")]
        [TestCase("5", "five")]
        [TestCase("6", "six")]
        [TestCase("7", "seven")]
        [TestCase("8", "eight")]
        [TestCase("9", "nine")]
        public void SingleDigit(string number, string word)
        {
            number.ToWord().ShouldBe(word);
        }

        [TestCase("19", "nineteen")]
        [TestCase("18", "eightteen")]
        [TestCase("17", "seventeen")]
        [TestCase("16", "sixteen")]
//        [TestCase("15", "nineteen")]
        [TestCase("14", "fourteen")]
        public void DoubleDigit(string number, string word)
        {
            number.ToWord().ShouldBe(word);
        }
    }
}