using System;

namespace Module3HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            var del = new ClassDelegate();

            del.EventSum += del.SumFunc;
            del.EventSum += del.SumFunc;

            del.SumResult(3, 5);
            del.SumResult(1, 3);

            Console.WriteLine("Sum = " + del.Sum);

            

            Console.ReadKey();
        }
    }
}
