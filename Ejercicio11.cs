using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] CoordsX = { 0, 2, 3, 7 };
            double[] CoordsY = { 0, 1, 5, 6 };
            double distanciaMayor = 0;
            bool lineaRecta = false;

            for (int i = 0; i < CoordsX.Length; i++)
            {
                double distancia;
                distancia = Math.Abs(CoordsX[i] - CoordsY[i]);
                if (distancia > distanciaMayor)
                {
                    distanciaMayor = distancia;
                }

                if (distancia == 1)
                {
                    lineaRecta = true;
                }
                 
            }

            Console.WriteLine("La distancia mayor es: " + distanciaMayor);
            Console.WriteLine("Pertenece a la misma linea recta");
            Console.ReadLine();
        }
    }
}
