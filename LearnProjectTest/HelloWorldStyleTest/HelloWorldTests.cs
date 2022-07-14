using LearnProject.HelloWorldStyle;
using NUnit.Framework;

namespace LearnProjectTest.HelloWorldStyleTest
{
    [TestFixture]
    public sealed class HelloWorldTests
    {
        [TestCase("Hello", "world", ExpectedResult = "Hello, world!")]
        [TestCase("Привет", "мир", ExpectedResult = "Привет, мир!")]
        public string ReturnGreeting(string hello, string addressee)
        {
            return HelloWorld.ReturnGreeting(hello, addressee);
        }

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(0, 1, ExpectedResult = 1)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(1, 1, ExpectedResult = 2)]
        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(2, 1, ExpectedResult = 3)]
        public int ReturnSum(int a, int b)
        {
            return HelloWorld.ReturnSum(a, b);
        }

        [TestCase(0, ExpectedResult = new int[] { })]
        [TestCase(1, ExpectedResult = new[] { 0 })]
        [TestCase(2, ExpectedResult = new[] { 0, 1 })]
        [TestCase(3, ExpectedResult = new[] { 0, 1, 2 })]
        public int[] ReturnArray(int arrayLength)
        {
            return HelloWorld.ReturnArray(arrayLength);
        }
    }
}
