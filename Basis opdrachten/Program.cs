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
            menu();

            switch(menu())
            {
                case 1:
                    Input(ref lenght, ref widht, ref height, ref index);
                    SurfaceCal(ref lenght, ref widht, ref height, ref surface);
                    VolumeCal(ref lenght, ref widht, ref height, ref volume);
                    MassCal(ref volume, ref index, ref mass);
                    Output(ref surface, ref volume, ref mass);
                    menu();
                    break;
                case 2:
                    Console.WriteLine("BYE");
                    break;
            }
        }

        static void Input(ref double lenght, ref double widht, ref double height, ref double index)
        {
            string temp = " ";
            Console.WriteLine("INPUT\n-----\n");

            do
            {
            Console.WriteLine("geef de lengte in(m):");
            temp = Console.ReadLine();
            double.TryParse(temp, out lenght);
            } while (ControlNumberIfLetter(temp) != true && ControlNumber(lenght) != true);

            do
            {
            Console.WriteLine("geef de breedte in(m):");
            temp = Console.ReadLine();
            double.TryParse(temp, out widht);
            } while (ControlNumberIfLetter(temp) != true && ControlNumber(lenght) != true);

            do
            {
            Console.WriteLine("geef de hoogte in(m):");
            temp = Console.ReadLine();
            double.TryParse(temp, out height);
            } while (ControlNumberIfLetter(temp) != true && ControlNumber(lenght) != true);

            do
            {
            Console.WriteLine("geef de massa index in(kg/m²):");
            temp = Console.ReadLine();
            double.TryParse(temp, out index);
            } while (ControlNumberIfLetter(temp) != true && ControlNumber(lenght) != true);

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
        static bool ControlNumber(double number)
        {
            if (number <= 0)
                return false;

            return true;
        }
        static bool ControlNumberIfLetter(string temp)
        {
            double number;
            if (double.TryParse(temp, out number) == false)
            {
                Console.WriteLine("Geef een geldig cijfer in.");
                return false;
            }
                return true;
        }
        static int menu()
        {
            string temp  =" ";
            int choice = 0;
            Console.WriteLine("\n\nCHOICE\n------\n");
            Console.WriteLine("1) opnieuw");
            Console.WriteLine("2) Stop \n");
            do
            {
             
                temp = Console.ReadLine();
                int.TryParse(temp, out choice);
                return choice;
            } while (ControlNumberIfLetter(temp) != true && ControlNumber(choice) != true);
        }
    }
}

