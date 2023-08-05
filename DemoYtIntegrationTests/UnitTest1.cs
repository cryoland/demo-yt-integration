using DemoYtIntegration;

namespace DemoYtIntegrationTests
{
    public class Tests
    {
        private TestClass _testClass;
        private string[] _atomicValues = new string[3] { "Ivanov", "Alexey", "Sergeevich" };

        [SetUp]
        public void Setup()
        {
            _testClass = new(_atomicValues[0], _atomicValues[1], _atomicValues[2]);
        }

        [Test]
        public void Test1()
        {
            Assert.That(string.Join(" ", _atomicValues), Is.EqualTo(_testClass.FullName));
        }
    }
}