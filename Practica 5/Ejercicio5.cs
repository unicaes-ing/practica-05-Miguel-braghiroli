using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Ejercicio5
    {
        static double Precio(double pago, double descuent)
        {
            double total = 0.0;
            descuent = descuent * 0.010;
            if (descuent != 0)
            {
                total = pago + (pago * descuent);
                return total;
            }
            else
            {
                return pago;
            }
        }
        static void Main(string[] args)
        {
            double Pre = 0, Porcen = 0;
            do
            {
                Console.WriteLine("Favor ingrese el precio del producto correspondiente: ");
                Pre = Convert.ToDouble(Console.ReadLine());
            } while (Pre <= 0);
            do
            {
                Console.WriteLine("Favor ingrese el porcentaje de descuento del producto: ");
                Porcen = Convert.ToDouble(Console.ReadLine());
            } while (Porcen < 0 || Porcen > 100);
            Console.WriteLine("Valor de descuento: {0:P}\nTotal a pagar: {1:C2}", Porcen / 100, Precio(Pre, Porcen));
            Console.ReadKey();
        }
    }
}
