using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double montoArepartir, p1, p2, p3, p4, m1, m2, m3, m4;
            int e1, e2, e3, e4;

            Console.WriteLine("Ingrese el monto a repartir: ");
            montoArepartir = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la edad de la Niña 1: ");
            e1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la Niña 2: ");
            e2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la Niña 3: ");
            e3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la Niña 4: ");
            e4 = Convert.ToInt32(Console.ReadLine());

            int sumaEdades = e1 + e2 + e3 + e4;
            p1 = (e1 * 100) / sumaEdades;
            p2 = (e2 * 100) / sumaEdades;
            p3 = (e3 * 100) / sumaEdades;
            p4 = (e4 * 100) / sumaEdades;

            m1 = (p1 * montoArepartir) / 100;
            m2 = (p2 * montoArepartir) / 100;
            m3 = (p3 * montoArepartir) / 100;
            m4 = (p4 * montoArepartir) / 100;

            Console.WriteLine("La niña 1 recibirá: " + m1);
            Console.WriteLine("La niña 2 recibirá: " + m2);
            Console.WriteLine("La niña 3 recibirá: " + m3);
            Console.WriteLine("La niña 4 recibirá: " + m4);

            Console.ReadKey();
        }
    }
}
