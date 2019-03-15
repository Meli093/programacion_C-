using System;

namespace Metodo_suma
{
    class Program
    {
        static void Main(string[] args)
        {
            sumaNumeros(7, 9);
        }
        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine("la suma de los dos numeros son :" + (num1 + num2));
        }
    }
}
