﻿using System.Numerics;

namespace RationalLib
{
    public readonly struct BigRational
    {
        public BigInteger Numerator { get; }
        public BigInteger Denominator { get; }

        public readonly static BigRational NaN = new(0, 0);
        public readonly static BigRational One = new(1, 1);
        public readonly static BigRational Zero = new(0, 1);
        public readonly static BigRational Half = new(1, 2);

        #region === constructors === 
        public BigRational(BigInteger numerator, BigInteger denominator)
        {
            if (denominator < 0)
                (numerator, denominator) = (-numerator, -denominator);

            var nwd = BigInteger.GreatestCommonDivisor(numerator, denominator);

            Numerator = numerator / nwd;
            Denominator = denominator / nwd;
        }

        public BigRational(BigInteger value) : this(value, 1) { }
        
        public BigRational() : this(0, 1) { }

        #endregion

        public override string ToString() => $"{Numerator}/{Denominator}";
    }
}