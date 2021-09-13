using System;

namespace Basis_opdrachten
{
    class Program
    {

        static void Main()
        {
           double lenght = 0, widht = 0, height = 0, index = 0;
           double surface = 0, volume = 0, mass = 0;

            Input(ref lenght,ref widht,ref height,ref index);
            SurfaceCal(ref lenght, ref widht, ref height, ref surface);
            VolumeCal(ref lenght, ref widht, ref height, ref volume);
            MassCal(ref volume, ref index, ref mass);
            Output(ref surface, ref volume, ref mass);
        }

        static void Input(ref double lenght, ref double widht, ref double height, ref double index)
        {
            string temp = " ";
            Console.WriteLine("INPUT\n-----\n" );
            Console.WriteLine("geef de lengte in(m):");
            temp = Console.ReadLine();
            double.TryParse(temp, out lenght);

            Console.WriteLine("geef de breedte in(m):");
            temp = Console.ReadLine();
            double.TryParse(temp, out widht);

            Console.WriteLine("geef de hoogte in(m):");
            temp = Console.ReadLine();
            double.TryParse(temp, out height);

            Console.WriteLine("geef de massa index in(kg/m²):");
            temp = Console.ReadLine();
            double.TryParse(temp, out index);

        }
        static void SurfaceCal(ref double lenght, ref double widht, ref double height,ref double surface)
        {
            surface = (2 * lenght * widht) + (2 * lenght * height) + (2 * height * widht);
        }
        static void VolumeCal(ref double lenght, ref double widht, ref double height,ref double volume)
        {
            volume = lenght * widht * height;
        }
        static void MassCal(ref double volume, ref double index, ref double mass)
        {
            mass = volume * index;
        }
        static void Output(ref double surface, ref double volume, ref double mass)
        {
            Console.WriteLine("\n\nOUTPUT\n------\n");
            Console.WriteLine($"De oppervlakte bedraagt:\n{surface} m²");
            Console.WriteLine($"Het volume bedraagt:\n{volume} m³");
            Console.WriteLine($"De massa bedraagt:\n{mass} kg");


        }
    }
}
