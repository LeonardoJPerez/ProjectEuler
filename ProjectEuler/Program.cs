using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Problem1();
            Problem2();
            Problem3();
            Console.Read();
        }

        private static void Problem1()
        {
            var sum = 0;
            for (var i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Problem 1: {sum}");
        }

        private static void Problem2()
        {
            var sum = 0;
            fibi(1, 2, ref sum);

            Console.WriteLine($"Problem 2: {sum}");
        }

        private static void Problem3()
        {
            var largestFactor = 0;
            var number = 600851475143;
            var n2 = 50;

            var fs = GetFactors(n2);
            foreach (var e in fs)
            {
                Console.WriteLine(e);
            }

            for (var i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    // Is prime
                }
            }

            Console.WriteLine($"Problem 3: {largestFactor}");
        }

        private static int fibi(int x, int y, ref int sum, int limit = 4000000)
        {
            if (y > limit) return y;

            if (y % 2 == 0) { sum += y; }

            return fibi(y, y + x, ref sum, limit);
        }

        private static List<int> GetFactors(int number, int factor = 2)
        {
            if (factor >= number)
            {
                return new List<int> { factor };
            }

            var list = new List<int> { number };
            if (number % factor == 0)
            {
                list.Add(factor);
            }
            else
            {
                factor++;
            }

            list.AddRange(GetFactors(number / factor, factor));

            return list.Distinct().OrderBy(x => x).ToList();
        }
    }
}