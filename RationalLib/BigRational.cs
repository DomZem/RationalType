using System.Numerics;

namespace RationalLib
{
    public readonly struct BigRational
    {
        public BigInteger Numerator { get; }
        public BigInteger Denominator { get; }   

        public BigRational(BigInteger numerator, BigInteger denominator)
        {
            if (denominator < 0)
                (numerator, denominator) = (-numerator, -denominator);

            Numerator = numerator;
            Denominator = denominator;
        }
    }
}