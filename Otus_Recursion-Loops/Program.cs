using BenchmarkDotNet.Attributes;
using System.Diagnostics;

namespace Otus_Recursion_Loops
{
    internal class Program
    {
        private static int[] values = { 5, 10, 20 };

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < values.Length; i++)
            {
                sw.Start();
                RecursionFibonachi(values[i]);
                sw.Stop();
                Console.WriteLine($"Рекурсия: {sw.ElapsedTicks}");
                sw.Reset();

                sw.Start();
                LoopFibonachi(values[i]);
                sw.Stop();
                Console.WriteLine($"Цикл: {sw.ElapsedTicks}");
                sw.Reset();
            }
            
            Console.ReadLine();
        }

        static int RecursionFibonachi(int _value)
        {
            if (_value <= 1) return _value;
            else
            {                
                return RecursionFibonachi(_value - 1) + RecursionFibonachi(_value - 2);
            }
        }

        static int LoopFibonachi(int _value)
        {
            int a = 0, b = 1, temp;

            if (_value <= 1) return _value;
            else
            {
                for (int i = 2; i < _value; i++)
                {
                    temp = a + b;
                    a = b;
                    b = temp;
                }
                return b;
            }
        }
    }
}
