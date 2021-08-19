using System;
using System.Collections;
using System.Collections.Generic;

namespace FibonachiType
{
    class Fibonachi : IEnumerable<int>
    {
        private int first;
        private int second;
        private readonly int topNumber;
        public Fibonachi(int top)
        {
            first = 0;
            second = 1;
            topNumber = top;
        }
        public IEnumerable<int> ReturnFibNumbers()
        {
            for (int i = 0; i <= topNumber; i++)
            {
                var temp = first;
                first = second;
                second += temp;
                yield return second;
            }
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
            PrintFibonachiTopHundred(new Fibonachi(100));
        }
    }
}
