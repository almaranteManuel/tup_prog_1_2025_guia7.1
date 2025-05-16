using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double cantidadMasa, masaSobrante;
            int cantidadBudines, cantidadPaquetes, cantidadCajas, budinesSobrantes, paquetesSobrantes;

            Console.WriteLine("Ingrese la cantidad de masa disponible en gramos: ");
            cantidadMasa = Convert.ToDouble(Console.ReadLine());

            masaSobrante = cantidadMasa % 55;
            cantidadBudines = (int)((cantidadMasa - masaSobrante) / 55);
            cantidadPaquetes = (int)Math.Truncate((double)cantidadBudines / 12);
            cantidadCajas = (int)Math.Truncate((double)cantidadPaquetes / 20);

            budinesSobrantes = cantidadBudines % 12;
            paquetesSobrantes = cantidadPaquetes % 20;

            Console.WriteLine("Cantidad de budines: " + cantidadBudines + " Cantidad de paquetes: " + cantidadPaquetes + " Cantidad de cajas: " + cantidadCajas);
            Console.WriteLine("Budines sobrantes: " + budinesSobrantes + " Paquetes sobrantes: " + paquetesSobrantes);

            Console.ReadKey();
        }
    }
}
