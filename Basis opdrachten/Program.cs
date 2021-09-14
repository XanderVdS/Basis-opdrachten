/*
Xander Van der Steichel
14/09/2021
Opdracht 5
 */

using System;

namespace Basis_opdrachten
{
    class Program
    {

        static void Main()
        {
            double[,] InputOutput = new double[10,7];
            double temp = 0;
            int row = 0;

            do
            { 
             switch(menu(row))
             {
                case 1:
                    Input(ref InputOutput, row);
                    SurfaceCal(ref InputOutput, row);
                    VolumeCal(ref InputOutput, row);
                    MassCal(ref InputOutput, row);
                    row++;
                        break;
                case 2:
                        Output(ref InputOutput, row);
                        break;
                case 3:
                    Console.WriteLine("BYE");
                        temp++;
                        break;
             }
            } while (temp == 0);
        }

        static void Input(ref double[,] InputOutput, int row)
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
                    double.TryParse(temp, out InputOutput[row,i]);
                } while (ControlNumberIfLetter(temp) != true && ControlNumber(InputOutput[row,i]) != true);

            }

        }
        static void SurfaceCal(ref double[,] InputOutput,int row)
        {
            InputOutput[row,4] = (2 * InputOutput[row,0] * InputOutput[row,1]) + (2 * InputOutput[row,0] * InputOutput[row,2]) + (2 * InputOutput[row,2] * InputOutput[row,1]);
           
        }
        static void VolumeCal(ref double[,] InputOutput, int row)
        {
            InputOutput[row,5] = InputOutput[row,0] * InputOutput[row,1] * InputOutput[row,2];
            
        }
        static void MassCal(ref double[,] InputOutput, int row)
        {
            InputOutput[row,6] = InputOutput[row,5] * InputOutput[row,3];
           
        }
        static void Output(ref double[,] InputOutput,int row)
        {

            for (int i = 0; i < row; i++)     
            {
                Console.WriteLine($"\n\nOUTPUT BALK {i}\n------\n");
                Console.WriteLine($"De oppervlakte bedraagt:\n{InputOutput[i,4]} m²");
                Console.WriteLine($"Het volume bedraagt:\n{InputOutput[i,5]} m³");
                Console.WriteLine($"De massa bedraagt:\n{InputOutput[i,6]} kg");
            }

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
        static int menu(int row)
        {
            string temp  =" ";
            int choice = 0;
            Console.WriteLine("\n\nCHOICE\n------\n");
            Console.WriteLine("1) invoer nieuwe balk (MAX 10)");
            Console.WriteLine("2) uitvoer alle balken ");
            Console.WriteLine("3) Stop \n");
          
            do
            {

                temp = Console.ReadLine();
                int.TryParse(temp, out choice);
                if (row > 9 && choice == 1) 
                {
                    Console.WriteLine("\nJe hebt de maximum balken bereikt vul opnieuw de keuze in");
                    return 4;
                }
                return choice;
            } while (ControlNumberIfLetter(temp) != true && choice >3 && choice < 0);
        }
    }
}