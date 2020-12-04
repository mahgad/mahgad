using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Density_law
{
    class Program
    {
        static void Main(string[] args)
        {

            //Density Law = mass/volume
            Console.WriteLine(" The program made by Dr Mahmoud Alwasify");
            Console.WriteLine("========================================");

            Console.Write("Enter the Mass : ");
            string mass = Console.ReadLine();
            Console.Write("Enter the volume : ");
            string volume = Console.ReadLine();

            double mass_1 = double.Parse(mass);
            double volume_1 = double.Parse(volume);

            double density = mass_1 / volume_1;

            Console.WriteLine("================================== ");

            Console.WriteLine("The Density Law = Mass / Volume ");
            Console.WriteLine("================================== ");

            Console.WriteLine("Density = " + density);

            if (density > 1)
                Console.Write("the matter is diving");
            else if (density == 1)
                Console.Write("the matter is water");
            else
                Console.Write("the matter is floating");

            Console.ReadLine();




        }
    }
}
