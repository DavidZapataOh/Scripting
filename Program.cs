using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigonometría
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solución de triangulos rectangulos");
            Console.ReadLine();
            Console.WriteLine("¿Cuales son los datos conocidos?");
            Console.WriteLine("1. Dos catetos");
            Console.WriteLine("2. Hipotenusa y angulo");
            Console.WriteLine("3. Cateto y angulo");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Ingresa el cateto y: ");
                    double y = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el cateto z: ");
                    double z = double.Parse(Console.ReadLine());
                    Console.Write("Presiona enter para continuar...");
                    Console.ReadLine();

                    double t = Math.Round(Math.Sqrt(Math.Pow(z,2) + Math.Pow(y,2)), 3);
                    double arad = Math.Asin(y / t);
                    double brad = Math.Asin(z / t);
                    double a = Math.Round((arad * 180) / Math.PI, 3) ;
                    double b = Math.Round((brad * 180) / Math.PI, 3);

                    Console.WriteLine("Hipotenusa t = " + t);
                    Console.WriteLine("Angulo a = " + a);
                    Console.WriteLine("Angulo b = " + b);
                    Console.ReadLine();
                   
                    break;

                case 2:
                    Console.Write("Ingresa la hipotenusa t: ");
                    double t2 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el angulo a: ");
                    double a2 = double.Parse(Console.ReadLine());
                    Console.Write("Presiona enter para continuar...");
                    Console.ReadLine();

                    double a2rad = (a2 * Math.PI) / 180;
                    double b2 = Math.Round(180 - 90 - a2, 3);
                    double b2rad = (b2 * Math.PI) / 180;
                    double y2 = Math.Round(Math.Sin(a2rad) * t2);
                    double z2 = Math.Round(Math.Sin(b2rad) * t2);

                    Console.WriteLine("Cateto y = " + y2);
                    Console.WriteLine("Cateto z = " + z2);
                    Console.WriteLine("Angulo b = " + b2);
                    Console.ReadLine();
                    break;

                case 3:
                    Console.Write("Ingresa el cateto z: ");
                    double z3 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el angulo b: ");
                    double b3 = double.Parse(Console.ReadLine());
                    Console.Write("Presiona enter para continuar...");
                    Console.ReadLine();
    
                    double a3 = Math.Round(180 - 90 - b3, 3);
                    double a3rad = (a3 * Math.PI) / 180;
                    double y3 = Math.Round(Math.Tan(a3rad) * z3);
                    double t3 = Math.Round(Math.Sqrt(Math.Pow(z3, 2) + Math.Pow(y3, 2)), 3);

                    Console.WriteLine("Cateto y = " + y3);
                    Console.WriteLine("Hipotenusa t = " + t3);
                    Console.WriteLine("Angulo a = " + a3);
                    Console.ReadLine();
                    break;
            }

            
        }
    }
}
