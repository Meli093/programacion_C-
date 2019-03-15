using System;

namespace Practica_Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            //un metodo nunca se va ejecutar si no lo llamas.
            mensajeEnPantalla();
            Console.WriteLine("enviando msj");
        }

       //aqui va buscar el metodo y lo ejecuta si exite.
        static void mensajeEnPantalla()
        {



            Console.WriteLine("Mensaje desde pantalla ");
        }
    }
    }

