using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzd2
{
    class Program
    {
        static void Main(string[] args)
        {
            double atstumas;
            double laikasSekundemis;
            double greitis;
            double km;
            double valandos;

            Console.WriteLine("iveskite atstuma (metrais): ");

            atstumas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite Laika (sekundemis): ");
            laikasSekundemis = Convert.ToInt32(Console.ReadLine());
            km = atstumas / 1000;
            valandos = laikasSekundemis / (60d * 60d);
            greitis = km / valandos;
            Console.WriteLine("greitis: {0}", greitis );

            Console.ReadLine();


            

        }
    }
}
