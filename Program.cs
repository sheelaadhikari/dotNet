
using System;
namespace Delegate
{
    delegate int AddDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            AddDelegate addDelegate = Add;

            Console.WriteLine(addDelegate(7, 6));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
