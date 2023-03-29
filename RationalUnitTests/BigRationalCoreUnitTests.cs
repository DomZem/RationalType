using RationalLib;

namespace RationalUnitTests
{
    [TestClass]
    public class BigRationalCoreUnitTests
    {
        [DataTestMethod]
        [DataRow(2, -3, -2, 3)]
        [DataRow(2, 3, 2, 3)]
        [DataRow(-2, -3, 2, 3)]
        [DataRow(-2, 3, -2, 3)]
        public void TestConstructor_2args_sign_normalization(int numerator, int denominator, int expectedNumerator, int expectedDenominator)
        {
            var u = new BigRational(numerator, denominator);

            Assert.AreEqual(expectedNumerator, u.Numerator);
            Assert.AreEqual(expectedDenominator, u.Denominator);
        }

        [DataTestMethod]
        [DataRow(2, 4, 1, 2)]
        [DataRow(4, 4, 1, 1)]
        [DataRow(6, 5, 6, 5)]
        [DataRow(0, 5, 0, 1)]
        public void TestConstructor_2args_reduction(int numerator, int denominator, int expectedNumerator, int expectedDenominator)
        {
            var u = new BigRational(numerator, denominator);

            Assert.AreEqual(expectedNumerator, u.Numerator);
            Assert.AreEqual(expectedDenominator, u.Denominator);
        }
    }
}