using System;

namespace Interface
{

    interface IMyNumber<T> where T : IMyNumber<T>
    {
        T Add(T b);
        T Subtract(T b);
        T Multiply(T b);
        T Divide(T b);
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyFrac[] fracs = new MyFrac[5];
            Random random = new Random();

            for (int i = 0; i < fracs.Length; ++i)
            {
                fracs[i] = new MyFrac(random.Next(1, 11), random.Next(5, 17));
            }
            
            testAPlusBSquare(new MyFrac(1, 3), new MyFrac(1, 6));

            testAPlusBSquare(new MyComplex(1, 2), new MyComplex(1, 5));
            testAPlusBSquare(new MyComplex(0.23, 7), new MyComplex(67.59, 3));

            testSquaresDifference(new MyFrac(1, 3), new MyFrac(1, 6));

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Масив даних MyFracs =>");

            foreach (MyFrac frac in fracs)
            {
                Console.Write("{0} ",frac);
            }

            Console.WriteLine();
            Array.Sort(fracs);

            Console.WriteLine();
            Console.WriteLine("Одсортований масив даних MyFracs =>");

            foreach (MyFrac frac in fracs)
            {
                Console.Write("{0} ", frac);
            }

            Console.ReadKey();
        }

        static void testAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            Console.ForegroundColor = ConsoleColor.Green;
            T aPlusB = a.Add(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine("(a + b)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine(" = = = ");
            T curr = a.Multiply(a);
            Console.WriteLine("a^2 = " + curr);
            T wholeRightPart = curr;
            a.Divide(b);
            curr = a.Multiply(b); 
            curr = curr.Add(curr);                                                                       
            Console.WriteLine("2 * a * b = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            curr = b.Multiply(b);
            Console.WriteLine("b^2 = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            Console.WriteLine("a^2 + 2ab + b^2 = " + wholeRightPart);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            Console.WriteLine();
        }

        static void testSquaresDifference<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            Console.ForegroundColor = ConsoleColor.Green;
            T aPlusB = a.Add(b);           
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine("(a + b)^2 = " + aPlusB.Multiply(aPlusB));
            T aMinusB = a.Subtract(b);            
            Console.WriteLine("(a - b) = " + aMinusB);
            Console.WriteLine("(a - b)^2 = " + aMinusB.Multiply(aMinusB));
            Console.WriteLine("a^2 - b^2 / a + b = " + aMinusB.Multiply(aMinusB) + " / " + aPlusB);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
        }       
    }  
}
