using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    internal class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(99,"Fizz")]
        public void NumberOne_Entered_Returns_One(int number, string expected)
        {
            var result = _fizzBuzz.Process(number);

            Assert.AreEqual(expected, result);
        }
    }
}
