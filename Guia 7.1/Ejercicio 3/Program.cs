using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int parteNumerica = numero % 1000;
            string parteAAA = parteNumerica.ToString("D3");

            int parteLetras = numero / 1000;

            int valor1 = parteLetras / (26 * 26);
            int resto1 = parteLetras % (26 * 26);

            int valor2 = resto1 / 26;
            int valor3 = resto1 % 26;

            char letra1 = (char)(65 + valor1);
            char letra2 = (char)(65 + valor2);
            char letra3 = (char)(65 + valor3);

            string parteBBB = "" + letra1 + letra2 + letra3;

            Console.WriteLine(parteBBB + parteAAA);

            Console.ReadKey();
        }
    }
}
