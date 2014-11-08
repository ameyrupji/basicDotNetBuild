using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBuildLibrary;

namespace BuildTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var example = new Example();
            Console.WriteLine(example.GetFibonacciNumber(10));
        }
    }
}
