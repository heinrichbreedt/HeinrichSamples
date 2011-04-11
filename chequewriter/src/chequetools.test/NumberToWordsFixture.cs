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
        [TestCase("18", "eighteen")]
        [TestCase("17", "seventeen")]
        [TestCase("16", "sixteen")]
        [TestCase("15", "fifteen")]
        [TestCase("14", "fourteen")]
        [TestCase("13", "thirteen")]
        [TestCase("12", "twelve")]
        [TestCase("11", "eleven")]
        [TestCase("10", "ten")]
        public void DoubleDigit(string number, string word)
        {
            number.ToWord().ShouldBe(word);
        }

        [TestCase("21", "twentyone")]
        [TestCase("20", "twenty")]
        [TestCase("29", "twentynine")]
        public void twenty(string number, string word)
        {
            number.ToWord().ShouldBe(word);
        }

        [TestCase("31", "thirtyone")]
        [TestCase("30", "thirty")]
        [TestCase("39", "thirtynine")]
        public void thirty(string number, string word)
        {
            number.ToWord().ShouldBe(word);
        }

        [TestCase("91", "ninetyone")]
        [TestCase("90", "ninety")]
        [TestCase("99", "ninetynine")]
        public void ninety(string number, string word)
        {
            number.ToWord().ShouldBe(word);
        }

        [TestCase("191", "one hundred and ninetyone")]
        [TestCase("237", "two hundred and thirtyseven")]
        [TestCase("853", "eight hundred and fiftythree")]
        [TestCase("612", "six hundred and twelve")]
        [TestCase("100", "one hundred")]
        [TestCase("400", "four hundred")]
        [TestCase("320", "three hundred and twenty")]
        public void hunderds(string number, string word)
        {
            number.ToWord().ShouldBe(word);
        }

        [TestCase("1191", "one thousand and one hundred and ninetyone")]
        [TestCase("237191", "two hundred and thirtyseven thousand and one hundred and ninetyone")]
        [TestCase("400000", "four hundred thousand")]
        [TestCase("99011", "ninetynine thousand and eleven")]
        public void thousands(string number, string word)
        {
            number.ToWord().ShouldBe(word);
        }
    }
}