using NUnit.Framework;
using PasswordGenLib;

namespace PasswordGenTests
{
    public class Tests
    {
        RandomPasswordFunctions testObj;
        [SetUp]
        public void Setup()
        {
            testObj = new RandomPasswordFunctions();
        }

        [Test]
        public void IsPasswordSizeCorrect()
        {
            int size = 10;
            string password = testObj.ReturnRandomString(size);
            Assert.AreEqual(size, password.Length);
        }

        [Test]
        public void DoesPasswordContainSpecialCharacters()
        {
            string password = testObj.ReturnRandomString(5);
            var result = testObj.IsPasswordGood(password);

            Assert.AreEqual(true, result);
        }
    }
}