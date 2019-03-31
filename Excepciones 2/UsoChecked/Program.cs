using System;

namespace UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int numero = int.MaxValue;
                int resultado = numero + 20;//va marcar un numero negativo

                Console.WriteLine(resultado);
            }
        }
    }
}
