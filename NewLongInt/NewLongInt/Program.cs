using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLongInt
{
    class Program
    {
        static void Main(string[] args)
        {
            LongNumber longNumber1 = new LongNumber("123");
            LongNumber longNumber2 = new LongNumber("-23");
            LongNumber longNumber3 = new LongNumber();
            LongNumber longNumber4 = new LongNumber(longNumber1);

            Console.WriteLine(longNumber1);
            Console.WriteLine(longNumber2);
            Console.WriteLine(longNumber3);
            Console.WriteLine(longNumber4);

            Console.ReadKey();
        }
    }
}
