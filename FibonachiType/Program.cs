using System;
using System.Collections;
using System.Collections.Generic;

namespace FibonachiType
{
    class Fibonachi : IEnumerable<int>
    {
        private int first;
        private int second;
        //private readonly int topNumber;
        public Fibonachi()
        {
            first = 0;
            second = 1;
            //topNumber = top;
        }
        public IEnumerable<int> ReturnFibNumbers()
        {
            List<int> nums = new();
            for (var i = 0; ; i++)
            {
                if (i == 100)
                {
                    break;
                }
                var temp = first;
                first = second;
                second += temp;
                nums.Add(second);
            }
            return nums;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return ReturnFibNumbers().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        public static void PrintFibonachiTopHundred(Fibonachi fibs)
        {
            Console.WriteLine(" ***** Fibonacci numbers *****");
            Console.WriteLine($"\tfrom 0 till 100");
            Console.WriteLine("0\n1");
            foreach (var item in fibs)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            PrintFibonachiTopHundred(new Fibonachi());
        }
    }
}
