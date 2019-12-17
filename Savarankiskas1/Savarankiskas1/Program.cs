using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
    class Program
    {
        static void Main(string[] args)
        {
            int grupesNariuKiekis = 0;

            Console.WriteLine("Ivesti grupes nariu kieki:");
            if (!int.TryParse(Console.ReadLine(), out grupesNariuKiekis))
            {
                Console.WriteLine("Negaliu konvertuoti");
                Console.ReadLine();
                Environment.Exit(0);
            }
            //grupesNariuKiekis = int.Parse(Console.ReadLine());

            // grupesNariuKiekis = Convert.ToInt32(Console.ReadLine());

            if (grupesNariuKiekis == 1)
            {
                Console.WriteLine("Tai solo atlikejas");
            }
            else if (grupesNariuKiekis == 2)
            {
                Console.WriteLine("tai duetas");
            }
            else if ((grupesNariuKiekis > 2) && (grupesNariuKiekis < 10))
            {
                Console.WriteLine("tai ansamblis");
            }
            else if (grupesNariuKiekis >= 10)
            {
                Console.WriteLine("tai kamerinis ansamblis");
            }
            else
            {
                Console.WriteLine("nariu skaicius negalimas: {0}", grupesNariuKiekis);
            }

            Console.ReadLine();

                
            


        }
    }
}
