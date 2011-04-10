using NUnit.Framework;
using Shouldly;

namespace chequetools.test
{
    [TestFixture]
    public class NumberToWordsFixture
    {
        [TestCase("1", "One")]
        public void SingleDigit(string number, string word)
        {
            number.ToWord().ShouldBe(word);
        }
    }
}