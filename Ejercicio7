using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            string volerAJugar = "s";

            while(volerAJugar == "s") {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Blackjack");
                Console.WriteLine("Presiona enter para comenzar a jugar...");
                Console.ReadLine();
                Random aleatorio = new Random();
                int carta = 0, carta2 = 0;
                int total = 0;
                int contador = 0;
                string continuar = "s";

                while (continuar == "s" && total < 21)
                {
                    carta = aleatorio.Next(1, 11);
                    //Console.WriteLine("Carta: " + carta);

                    Console.WriteLine("|---------|");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|    "+ carta +"    |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|---------|");

                    total += carta;

                    if (contador == 0)
                    {
                        carta2 = aleatorio.Next(1, 11);
                        Console.WriteLine("");
                        Console.WriteLine("|---------|");
                        Console.WriteLine("|         |");
                        Console.WriteLine("|         |");
                        Console.WriteLine("|    " + carta2 + "    |");
                        Console.WriteLine("|         |");
                        Console.WriteLine("|         |");
                        Console.WriteLine("|---------|");
                        total += carta2;
                    }
                    
                    if(total == 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Has ganado");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("");
                    }
                    else if (total > 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Has perdido");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("");
                    }
                    else
                    {
                    
                        Console.WriteLine(" Total = " + total);
                        Console.Write("Solicitar carta extra? (s/n)");
                        continuar = Console.ReadLine();
                    }

                    contador++;
                }

                Console.WriteLine("Su total fue: " + total + " puntos");
                Console.WriteLine("Quieres volver a jugar? (s/n)");

                volerAJugar = Console.ReadLine();
            }

            Console.WriteLine("Gracias por jugar");
            Console.ReadLine();
        }
    }
}
