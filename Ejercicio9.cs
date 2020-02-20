using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da22
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0;
            int dadoExtra = 0;
            int total = 0;
            int contador = 0;
            int vidas = 3;
            string continuar = "s";
            int turnos = 0;

            while (continuar == "s" && total < 100)
            {
                dado1 = aleatorio.Next(1, 7);
                Console.WriteLine("");
                Console.WriteLine("|---------|");
                Console.WriteLine("|         |");
                Console.WriteLine("|    " + dado1 + "    |");
                Console.WriteLine("|         |");
                Console.WriteLine("|---------|");

                turnos++;

                if (turnos % 3 == 0)
                {
                    dadoExtra = aleatorio.Next(1, 7);
                    Console.WriteLine("");
                    Console.WriteLine("|---------|");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|    " + dadoExtra + "    |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|---------|");
                }

                total += dado1 + dadoExtra;

                if (turnos%2 == 0)
                {
                    vidas = vidas - 1;
                    Console.WriteLine("Has perdido una vida");
                }

                if ((vidas < 3) && (dado1 == dadoExtra))
                {
                    vidas++;
                    Console.WriteLine("Has ganado una vida");
                    dadoExtra = 0;
                }

                if (total >= 100)
                {
                    Console.WriteLine("Has ganado!");
                    continuar = "n";
                }

                else if (vidas <= 0)
                {
                    Console.WriteLine("Has perdido!");
                    break;
                }

                else
                {
                    Console.WriteLine("Total: " + total + " puntos");
                    Console.WriteLine("Vidas: " + vidas);
                    if (total < 100)
                    {
                        Console.WriteLine("¿Quieres volver a lanzar? (s/n)");
                        continuar = Console.ReadLine();
                    }
                }
                contador++;
            }
            Console.WriteLine("Su total fue: " + total + " puntos");
            Console.WriteLine("¡Gracias por jugar!");
            Console.ReadLine();
        }
    }
}
