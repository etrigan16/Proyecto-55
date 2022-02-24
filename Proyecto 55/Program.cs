using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_55
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, valor;
            string linea;
            suma = 0;

            do
            {
                Console.Write("Ingrese un valor (Para terminar ingrese 9999): ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);

                if (valor != 9999)
                {
                   
                    suma = valor + suma;
                }
               

            } while (valor != 9999);

            if (suma != 0)
            {
                if (suma > 0)
                {
                    Console.Write("La suma de los valores es: ");
                    Console.WriteLine(suma);
                    Console.Write("El valor de la suma es mayor a 0");
                }
                else
                {
                    Console.Write("La suma de los valores es: ");
                    Console.WriteLine(suma);
                    Console.Write("El valor de la suma es menor a 0");
                }
            }
            else
            {
                Console.Write("La suma de los valores es 0");
            }
            Console.ReadKey();
        }
    }
}
