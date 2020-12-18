using System;


namespace Interface
{
    class MyComplex : IMyNumber<MyComplex>
    {
        double re;
        double im;

        public MyComplex()
        {

        }

        public MyComplex(int re, int im)
        {
            this.re = re;
            this.im = im;
        }

        public MyComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        

        public MyComplex Add(MyComplex that)
        {
            return new MyComplex(re + that.re, im + that.im);
        }

        public MyComplex Subtract(MyComplex that)
        {
            return new MyComplex(re - that.re, im - that.im);
        }

        public MyComplex Multiply(MyComplex that)
        {
            return new MyComplex(re * that.re - im * that.im, re * that.im + im * that.re);
        }

        public MyComplex Divide(MyComplex that)
        {
            try
            {
                return new MyComplex((re * that.re + im * that.im) / (Math.Pow(that.re, 2) + Math.Pow(that.im, 2)), (im * that.re - re * that.im) / (Math.Pow(that.re, 2) + Math.Pow(that.im, 2)));
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }

        }

        override public String ToString()
        {
            return re + " + " + im + "i";
        }
    }
}
