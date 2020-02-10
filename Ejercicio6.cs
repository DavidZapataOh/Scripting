using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa tu salario mensual: ");
            int salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu tipo de contrato (1-2):");
            Console.WriteLine("1. Dependiente");
            Console.WriteLine("2. Independiente");
            int contrato = int.Parse(Console.ReadLine());
            int minimo = 877803;
            int prima = 0;
            double pension = 0;
            double eps = 0;
            double ARL = 0;
            double baseCot = salario * 0.40;
            if (baseCot < minimo){
                baseCot = minimo;
            }

            switch (contrato)
            {
                case 1:
                    pension = baseCot * 0.04;
                    eps = baseCot * 0.04;
                    prima = salario;
                    break;

                case 2:
                    pension = baseCot * 0.16;
                    eps = baseCot * 0.125;
                    Console.Write("Ingresa clase de riesgo (1-5): ");
                    int riesgo = int.Parse(Console.ReadLine());
                    switch (riesgo)
                    {
                        case 1:
                            ARL = baseCot * 0.00522;
                            break;
                        case 2:
                            ARL = baseCot * 0.01044;
                            break;
                        case 3:
                            ARL = baseCot * 0.02436;
                            break;
                        case 4:
                            ARL = baseCot * 0.04350;
                            break;
                        case 5:
                            ARL = baseCot * 0.06960;
                            break;
                    }
                    break;
            }

            double salarioReal = salario - pension - eps - ARL;
            double salarioAnual = (salarioReal * 12) + prima;
            //Console.WriteLine("El salario real mensual es: " + salarioReal);
            //Console.WriteLine("El salario Anual es: " + salarioAnual);
            Console.WriteLine("El salario real mensual es: " + salarioReal.ToString("C", CultureInfo.CreateSpecificCulture("es-CO")));
            Console.WriteLine("El salario Anual es: " + salarioAnual.ToString("C", CultureInfo.CreateSpecificCulture("es-CO")));
            Console.ReadLine();
        }
    }
}
