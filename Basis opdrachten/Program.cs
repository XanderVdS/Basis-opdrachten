using System;

namespace Basis_opdrachten
{
    class Program
    {

        static void Main()
        {
            double[] InputOutput = new double[7];
            double temp = 0;

            Input(ref InputOutput);
            SurfaceCal(ref InputOutput);
            VolumeCal(ref InputOutput);
            MassCal(ref InputOutput);
            Output(ref InputOutput);

            do
            { 
             switch(menu())
             {
                case 1:
                    Input(ref InputOutput);
                    SurfaceCal(ref InputOutput);
                    VolumeCal(ref InputOutput);
                    MassCal(ref InputOutput);
                    Output(ref InputOutput);
                    break;
                case 2:
                    Console.WriteLine("BYE");
                        temp++;
                    break;
             }
            } while (temp == 0);
        }

        static void Input(ref double[] InputOutput)
        {
            string temp = " ";
            Console.WriteLine("INPUT\n-----\n");
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("geef de lengte in(m):");
                        break;
                    case 1:
                        Console.Write("geef de breedte in(m):");
                        break;
                    case 2:
                        Console.Write("geef de hoogte in(m):");
                        break;
                    case 3:
                        Console.Write("geef de massa index in(kg/m²):");
                        break;
                }

                do
                {

                    temp = Console.ReadLine();
                    double.TryParse(temp, out InputOutput[i]);
                } while (ControlNumberIfLetter(temp) != true && ControlNumber(InputOutput[i]) != true);

            }

        }
        static void SurfaceCal(ref double[] InputOutput)
        {

            InputOutput[4] = (2 * InputOutput[0] * InputOutput[1]) + (2 * InputOutput[0] * InputOutput[2]) + (2 * InputOutput[2] * InputOutput[1]);

        }
        static void VolumeCal(ref double[] InputOutput)
        {

            InputOutput[5] = InputOutput[0] * InputOutput[1] * InputOutput[2];
            
        }
        static void MassCal(ref double[] InputOutput)
        {
            InputOutput[6] = InputOutput[5] * InputOutput[3];
        }
        static void Output(ref double[] InputOutput)
        {
            Console.WriteLine("\n\nOUTPUT\n------\n");
            Console.WriteLine($"De oppervlakte bedraagt:\n{InputOutput[4]} m²");
            Console.WriteLine($"Het volume bedraagt:\n{InputOutput[5]} m³");
            Console.WriteLine($"De massa bedraagt:\n{InputOutput[6]} kg");
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

