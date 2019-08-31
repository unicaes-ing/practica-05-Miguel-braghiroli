using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            dia();
            Console.ReadKey();
        }
        static void dia()
        {
            DateTime hoy = DateTime.Today;
            String fecha = "31 Diciembre 2019";
            DateTime cambio = DateTime.Parse(fecha);
            TimeSpan dif = cambio - hoy;
            int dias = dif.Days;
            Console.WriteLine("Faltan {0:N2} dias", dias.ToString());
        }
    }
}
