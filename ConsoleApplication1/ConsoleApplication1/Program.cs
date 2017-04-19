using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// by default everything in this assembly is CLS compliant
[assembly: CLSCompliant(true)]
namespace ConsoleApplication1
{

    public static class Program
    {

        private static void Main()
        {
            Console.WriteLine("Hello world !");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

    }
}
