using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzd1
{
    class Program
    {
        static void Main(string[] args)
        {
            char simbolis1;
            char simbolis2;
            char simbolis3; 

            Console.WriteLine("Ivesti pirma simboli: ");
            simbolis1 = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            Console.WriteLine("simbolis1 {0}", simbolis1);

            Console.WriteLine("Ivesti antra simboli: ");
            simbolis2 = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            Console.WriteLine("simbolis2 {0}", simbolis2);

            Console.WriteLine("Ivesti trecia simboli: ");
            simbolis3 = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            Console.WriteLine("simbolis3 {0}", simbolis3);

            Console.WriteLine("{0} {1} {2}", simbolis3, simbolis2, simbolis1);



            Console.ReadLine();
        }
    }
}
