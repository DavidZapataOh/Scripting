using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuota
{
    class Program
    {
        static void Main(string[] args)
        {
            int smmlv = 877803;
            Console.WriteLine("Cálculo de cuota moderadora");

            Console.Write("Introduce tu salario: ");
            int salario = int.Parse(Console.ReadLine());


            if (salario < (smmlv * 2))
            {
                Console.WriteLine("Tarifa: $15.000");
                Console.WriteLine("Cuota moderadora: $3.400");
            }

            else if (salario >= (smmlv * 5))
            {
                Console.WriteLine("Tarifa: $30.000");
                Console.WriteLine("Cuota moderadora: $35.600");
            }

            else
            {
                Console.WriteLine("Tarifa: $20.000");
                Console.WriteLine("Cuota moderadora: $13.500");
            }

            Console.ReadLine();
        }
    }
}
