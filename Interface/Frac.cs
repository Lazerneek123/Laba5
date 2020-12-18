using System;
using System.Numerics;

namespace Interface
{
    class MyFrac : IMyNumber<MyFrac>, IComparable
    {
        BigInteger num;
        BigInteger denom;

        public int CompareTo(Object o)
        {
            MyFrac frac = o as MyFrac;
            
            if (Value < frac.Value)
            {
                return -1;
            }

            if (Value > frac.Value)
            {
                return 1;
            }

            return 0;
        }
        
        public double Value
        {
            get
            {
                return (double)num / (double)denom;
            }
        }

        public MyFrac()
        {

        }

        public MyFrac(BigInteger num, BigInteger denom)
        {
            this.num = num;
            this.denom = denom;
        }

        public MyFrac(int num, int denom)
        {
            this.num = num;
            this.denom = denom;
        }

        public MyFrac Add(MyFrac that)
        {
            return new MyFrac(num * that.denom + that.num * denom, denom * that.denom);
        }

        public MyFrac Subtract(MyFrac that)
        {
            return new MyFrac(num * that.denom - that.num * denom, denom * that.denom);
        }

        public MyFrac Multiply(MyFrac that)
        {
            return new MyFrac(num * that.num, denom * that.denom);
        }

        public MyFrac Divide(MyFrac that)
        {
            return new MyFrac(num * that.denom, denom * that.num);
        }

        override public string ToString()
        {
            try
            {
                return num + "/" + denom;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }
    }
}
