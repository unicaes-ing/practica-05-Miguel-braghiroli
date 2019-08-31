using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Ejercicio3
    {
        static int fac(int valor)
        {
            int fac = valor;
            for (int n = 1; n < valor; n++)
            {
                fac = fac * (valor - n);
            }
            return fac;
        }
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                Console.WriteLine("Favor ingresar un número entero:");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num <= 0);
            Console.WriteLine("El factorial del numero ingresado {0:N2} es {1:N2}", num, fac(num));
            Console.ReadKey();
        }
    }
}
