using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Ejercicio2
    {
        static int Valor(int num)
        {
            return num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Favor ingrese un número entero:");
            int canti = Convert.ToInt32(Console.ReadLine());
            if (canti == 0)
            {
                Console.WriteLine("El número que usted ingreso es 0");
            }
            if (canti < 0)
            {
                Console.WriteLine("El valor del número {0:N2} es negativo", Valor(canti));
            }
            if (canti > 0)
            {
                Console.WriteLine("El valor del número {0:N2} es positivo", Valor(canti));
            }
            Console.ReadKey();
        }
    }
}
