using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa número de votos del partido Liberal: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingresa número de votos del partido Conservador: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Ingresa número de votos en blanco: ");
            int blanco = int.Parse(Console.ReadLine());
            Console.Write("Ingresa número de votos anulados: ");
            int anulados = int.Parse(Console.ReadLine());
            Console.Write("Número total de la población: ");
            int poblacion = int.Parse(Console.ReadLine());
            Console.Write("Porcentaje de población mayor de edad: ");
            int mayor = int.Parse(Console.ReadLine());

            int numeroVotantes = (a + b + blanco + anulados);
            double abstencion = ((mayor * poblacion) / 100) - numeroVotantes;

            bool A = numeroVotantes > poblacion; //Si el total de votos es superior al total de la población  
            bool B = (Math.Abs(a - b)) < (numeroVotantes * 0.10); //la diferencia de votos entre el partido 1 y 2 es menor al 10% de los votos totales
            bool C = numeroVotantes < (poblacion * 0.30); //el número de votantes es inferior al 30% de la población
            bool D = a > b;

            if ((A || B) && C)
            {

                Console.Write("Las elecciones deben repetirse");              
            }
            else
            {
                Console.WriteLine("Las votaciones fueron realizadas con éxito. ");
                if (D)
                {
                    Console.WriteLine("Ha ganado el partido Liberal");
                }
                else
                {
                    Console.WriteLine("Ha ganado el partido Conservador");
                }
            }
            Console.ReadLine();
        }
    }
}
