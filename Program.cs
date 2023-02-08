using System;

namespace fibseqdeliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 25;
            int[] fibinachinum = new int[size];
            fibinachinum[0] = 0;
            fibinachinum[1] = 1;
            for (int i = 2; i < size; i++)
            {
                fibinachinum[i] = fibinachinum[i - 2] + fibinachinum[i - 1];
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Fib number  (" + i + ") = " + fibinachinum[i]);
            }
        }
    }
}
