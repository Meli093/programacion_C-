using System;

namespace Operadores_Aritmetico
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416f;
            Console.WriteLine("Introdce el valor medio de la radio");

             double radio=  double.Parse(Console.ReadLine());

            //float area = radio * radio * pi;//forma tipica
            double area = Math.Pow(radio, 2)*pi;
           // Console.WriteLine($"el area del circulo es:{area}");//solo se puede en c#
            Console.WriteLine("el area del circulo es:" + area );//la clasica 
        }
    }
}
