using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve
{
    class Program
    {
        static Stopwatch stopwatch = new Stopwatch();
        private const int max = 2001;
        static readonly double limit = Math.Sqrt(max);

        static void Main(string[] args)
        {
            stopwatch.Start();
            BitArray values = new BitArray(max, true);
            for (int i = 2; i <= limit; i++)
            {
                int squared = i * i;
                if (values[i])
                {
                    for (int j = 0; squared + (i * j) < values.Count; j++)
                    {
                        values[squared + (i * j)] = false;
                    }
                }
            }

            /*
            List<int> numbers = new List<int>();
            for (int i = 2; i < max; i++)
            {
                numbers.Add(i);
            }

            foreach (int val in numbers)
            {
                if (numbers.Contains(val) && val < limit)
                {
                    numbers = numbers.Except(new List<int>(from x in numbers where x >= val * val && x % val == 0 select x)).ToList();
                }
            }

            List<int> multiples = new List<int>();
            for (int i = 0; numbers[i] <= limit; i++)
            {
                if (!multiples.Contains(numbers[i]))
                {
                    for (int j = 0; numbers[i] * numbers[i] + numbers[i] * j <= max; j++)
                    {
                        multiples.Add(numbers[i] * numbers[i] + numbers[i] * j);
                    }
                }
            }
            numbers = numbers.Except(multiples).ToList();

            foreach (int val in numbers)
            {
                Console.WriteLine(val);
            }
            */
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + "ms");

            while (Console.ReadKey() == null)
            {
                Thread.Sleep(1000);
            }

            int count = 0;
            for (int i = 2; i < values.Count; i++)
            {
                if (values[i])
                {
                    //Console.WriteLine(i);
                    count++;
                }
            }
            
            Console.WriteLine("There are " + count + " primes in this range.");

            while (Console.ReadKey() == null)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
