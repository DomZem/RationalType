using RationalLib;

namespace RationalUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(2, -3, -2, 3)]
        [DataRow(2, 3, 2, 3)]
        [DataRow(-2, -3, 2, 3)]
        [DataRow(-2, 3, -2, 3)]
        public void TestConstructor_2args_sign_normalization(int a, int b, int l, int m)
        {
            var u = new BigRational(a, b);

            Assert.AreEqual(l, u.Numerator);
            Assert.AreEqual(m, u.Denominator);
        }
    }
}