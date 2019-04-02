using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eliga el medio de transporte (coche,tren,avion)");
            string medioTranporte = Console.ReadLine();
            switch (medioTranporte)
            {
                case "coche":
                    Console.WriteLine("Velocidad media: 100 km/h");
                    break;

                case "tren":
                    Console.WriteLine("Velocidad media: 250 km/h");
                    break;

                case "avion":
                    Console.WriteLine("Velocidad media: 800 km/h");
                    break;

                default:
                    Console.WriteLine("Transporte no contemplado");
                    break;

            }
            Console.WriteLine("Ha finalizado el programa");
        }

    }
}
