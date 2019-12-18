using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas2
{
    class Program
    {
        static void Main(string[] args)
        {
            double isdirbtosValandos;

            Console.WriteLine("Iveskite isdirbtas valandas: ");
            isdirbtosValandos = Convert.ToDouble(Console.ReadLine());

            if (isdirbtosValandos < 160)
            {
                Console.WriteLine("dar reikia isdirbti: {0} valandu", 160 - isdirbtosValandos);
            }
            else if (isdirbtosValandos == 160)
            {
                Console.WriteLine("Isdirbtas pilnas etatas");
            }
            else if (isdirbtosValandos > 160)
            {
                Console.WriteLine("isdirbta virsvalandziu: {0} valandu", isdirbtosValandos - 160);
            }
            else
            {
                Console.WriteLine("Ivedimo klaida");
            }
            Console.ReadLine();

        }
    }
}
