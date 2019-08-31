using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Ejercicio4
    {
        static string NumCel(string Cel1, string Cel2, string Cel3, string Cel4)
        {
            int nombre;
            Random list = new Random();
            nombre = list.Next(0, 7);
            return nombre.ToString();
        }
        static void Main(string[] args)
        {
            string N1, N2, N3, N4, Celulares;
            Console.WriteLine("Favor ingrese el primer numero de telefono celular: ");
            N1 = Console.ReadLine();
            Console.WriteLine("Favor ingrese el segundo numero de telefono celular: ");
            N2 = Console.ReadLine();
            Console.WriteLine("Favor ingrese el tercer numero de telefono celular: ");
            N3 = Console.ReadLine();
            Console.WriteLine("Favor ingrese el cuarto numero de telefono celular: ");
            N4 = Console.ReadLine();
            Celulares = NumCel(N1, N2, N3, N4);
            Console.WriteLine(Celulares);
            Console.ReadKey();
        }
    }
}
