using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int aletorio = numero.Next(0, 100);
            int minumero;
            int intentos = 0;
            Console.WriteLine("introduce  un n° entre 0 y 100");

            do
            {
                intentos++;
                try
                {
                    minumero = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                  Console.WriteLine("has introducido un valor alto, los valores deven de ser 0 , 100");
                    Console.WriteLine(ex.Message);
                    minumero = 0;

                }
                    if (minumero > aletorio) Console.WriteLine("el es mas bajo");
                    if (minumero < aletorio) Console.WriteLine("el es mas alto");
                
                } while (aletorio != minumero) ;
                Console.WriteLine("continuara intentos"+intentos);

            }
            }
        }
    

