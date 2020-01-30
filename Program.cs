using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            int smmlv = 877803;
            Console.WriteLine("Cálculo de tarifa");

            Console.Write("Introduce tu salario: ");
            int salario = int.Parse(Console.ReadLine());
            

            if (salario < (smmlv*2))
            {
                Console.Write("Tarifa: 20.000 pesos");
            }

            else if (salario >= (smmlv * 4))
            {
                Console.Write("Tarifa: 40.000 pesos");
            }

            else
            {
                Console.Write("Tarifa: 30.000 pesos");
            }

            Console.ReadLine();

        }
    }
}
