using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0;
            int total = 0;
            int contador = 0;
            string continuar = "s";
            int contador12 = 0;
            bool cond = false;

            while (continuar == "s" && total < 100)
            {
                dado1 = aleatorio.Next(10, 13);
                //Console.WriteLine("Dado 1: " + dado1);
                Console.WriteLine("");
                Console.WriteLine("  /-----\\  ");
                Console.WriteLine(" /       \\ ");
                Console.WriteLine("|    " + dado1 + "    |");
                Console.WriteLine(" \\       /");
                Console.WriteLine("  \\-----/ ");


                total += dado1;

                if (dado1 == 12)
                {
                    contador12 = 1;
                }
                

                if (dado1 == 10 && contador12 == 1)
                {
                    cond = true;
                }

                if (total >= 100 || cond == true)
                {
                    Console.WriteLine("Has ganado");
                    continuar = "n";
                }

                else if ((dado1 % 2) != 0 && contador > 2)
                {
                    Console.WriteLine("Has perdido. Sigue intentando");
                    continuar = "n";
                }
                else
                {

                    Console.WriteLine("Total: " + total + " puntos");
                    if (total < 100)
                    {
                        Console.WriteLine("¿Quieres volver a lanzar? (s/n)");
                        continuar = Console.ReadLine();
                    }

                }

                contador++;

                if (dado1 !=12 )
                {
                    contador12 = 0;
                }
            }
            Console.WriteLine("Su total fue: " + total + " puntos");
            Console.WriteLine("¡Gracias por jugar!");
            Console.ReadLine();
        }
    }
}
