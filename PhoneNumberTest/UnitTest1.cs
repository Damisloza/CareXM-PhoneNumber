namespace PhoneNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = PhoneNumber.Program.Number();
            Assert.AreEqual("801-100-1000", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool result = PhoneNumber.Program.test2("8011001000");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string result = PhoneNumber.Program.ValidatePhoneNumber();
            Console.WriteLine(result);
        }
    }
}