using System;

namespace flyDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            double Z, X, t1, t2, t, d;
            string inputData = Console.ReadLine();
            Z = Convert.ToInt32(inputData);
            inputData = Console.ReadLine();
            X = Convert.ToInt32(inputData);
            t1 = Z / (4 * X);
            t2 = Z / (X * 2);
            t = t2 - t1;
            d = 2 * X * t;

            Console.Write(d);
            
        }
    }
}

