using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = Convert.ToInt32(Console.ReadLine());
            int i2 = Convert.ToInt32(Console.ReadLine());
            //int i3 = Convert.ToInt32(Console.ReadLine());
            double a = miaFunc(i1, i2);
            Console.WriteLine("answer is: " + a);
        }

        static double miaFunc(int i, int j)
        {
            return (double) i / j;
        }

        static double colFunc(int i1, int i2, int i3)
        {
            return i1 + i2 + i3;
        }
    }

}