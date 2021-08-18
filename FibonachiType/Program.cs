using System;
using System.Collections.Generic;

namespace FibonacciType
{
    class Fibonacci
    {
        private readonly List<int> FibonacciList;
        public Fibonacci(int top)
        {
            FibonacciList = CreateFibList(top);
        }
        private List<int> CreateFibList(int top)
        {
            List<int> fibList = new();
            int a = 0;
            int b = 1;
            fibList.Add(a);
            fibList.Add(b);
            for (int i = 0; i <= top; i++)
            {
                var temp = a;
                a = b;
                fibList.Add(b += temp);
            }
            return fibList;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return FibonacciList.GetEnumerator();
        }
    }
    class Program
    {
        public static void PrintFibonachiTopHundred(Fibonacci fibList)
        {
            Console.WriteLine(" ***** Fibonacci numbers *****");
            Console.WriteLine($"\tfrom 0 till 100");
            foreach (var item in fibList)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            PrintFibonachiTopHundred(new Fibonacci(100));
        }
    }
}
