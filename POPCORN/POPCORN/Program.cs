using System;
using System.Threading;

namespace POPCORN
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 60; i++)
            {
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
