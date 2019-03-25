using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int []edades;
            edades = new int[4];
            //vamos almacenar nuestro array
            edades[0] = 15;
            edades[1] = 25;
            edades[2] = 5;//si ejecutamos nos vamos a mostrar el valor 5
            edades[3] = 19;

            Console.WriteLine(edades[2]);
        }
    }
}
