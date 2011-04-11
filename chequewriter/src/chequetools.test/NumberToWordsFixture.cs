using NUnit.Framework;
using Shouldly;

namespace chequetools.test
{
    [TestFixture]
    public class NumberToWordsFixture
    {
        [TestCase("0", "")]
        public void SingleDigit(string number, string word)
        {
            number.ToWord().ShouldBe(word);
        }
    }
}