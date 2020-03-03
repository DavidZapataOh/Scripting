using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Blackjack");

            Console.WriteLine("Presiona enter para comenzar a jugar...");
            Console.ReadLine();

            Console.Write("Ingresa el numero de jugadores (2 - 5): ");
            int jugador = 0;
            int jugadorGanador = 0;
            bool empate = false;
            int puntajeMayor = 0;
            int jugadorMayor = 0;

            int n = int.Parse(Console.ReadLine());

            int[] puntaje = new int[n];

            while (n < 2 || n > 5)
            {
                Console.Write("Numero invalido de jugadores. Intenta de nuevo: ");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Turno del jugador " + (jugador + 1));
                Random aleatorio = new Random();
                int carta = 0, carta2 = 0;
                int contador = 0;
                string continuar = "s";

                while (continuar == "s" && puntaje[i] < 21)
                {
                    carta = aleatorio.Next(1, 11);
                    //Console.WriteLine("Carta: " + carta);

                    Console.WriteLine("|---------|");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|    " + carta + "    |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|---------|");


                    puntaje[i] += carta;

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
                        puntaje[i] += carta2;
                    }

                    if (puntaje[i] == 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Has ganado");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("");
                        if (jugadorGanador == 0)
                        {
                            jugadorGanador = jugador + 1;
                        }
                        else
                        {
                            empate = true;
                        }

                    }
                    else if (puntaje[i] > 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Has perdido");
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine(" Total = " + puntaje[i]);
                        Console.Write("Solicitar carta extra? (s/n)");
                        continuar = Console.ReadLine();

                        while (continuar != "s" && continuar != "n")
                        {
                            Console.Write("Respuesta Incorrecta: ");
                            continuar = Console.ReadLine();
                        }
                    }

                    contador++;
                    
                }


                if (puntaje[i] == puntajeMayor)
                {
                    empate = true;
                    puntajeMayor = 0;
                }
                if (puntaje[i] > puntajeMayor && puntaje[i] < 21)
                {
                    puntajeMayor = puntaje[i];
                    jugadorMayor = jugador + 1;
                }

                Console.WriteLine("Su total fue: " + puntaje[i] + " puntos");
                jugador++;
                Console.ReadLine();
            }

            if (jugadorGanador == 0 && empate == false)
            {
                if (puntajeMayor > 0)
                {
                    Console.WriteLine("El jugador que más se acercó es el jugador " + jugadorMayor + " con puntaje: " + puntajeMayor);
                }
                else
                {
                    Console.WriteLine("No hay ganador");
                }
            }

            else if (empate == true)
            {
                Console.WriteLine("Empate");
            }

            else
            {
                Console.WriteLine("El ganador es el jugador " + jugadorGanador);
            }

            Console.WriteLine("Gracias por jugar");
            Console.ReadLine();
        }
    }
}
