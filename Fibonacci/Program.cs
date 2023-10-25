using System;

namespace Fibonacci
{
    class Program
    {/// <summary>
     /// Nombre: Jorge Esteban Dawson Castillo
     /// Grupo: 140
     /// Programa: Serie Fibonacci
     /// </summary>
        static int p1 = 0, p2 =1, p3;    
        static void Main(string[] args)
            //input del usuario
        {
            Console.WriteLine("Por favor inserte el valor inicial");
            int count = Int32.Parse(Console.ReadLine());
            if (count < 1)
            {
                Console.WriteLine("número invalido");
            }
            else
            {
                Console.Write(p1 + " " + p2);
                Fibonacci(count - 2);
                Console.WriteLine();
            }
         
                      
        }
        // Loop que permite generar la serie fibonacci en pantalla, define la serie
        private static void Fibonacci(int count)
        {
            if (count > 1)
            {
                p3 = p1 + p2;
                Console.Write(" " + p3);
                p1 = p2;
                p2 = p3;
                Fibonacci(count - 1);
            }
                
            
        }
    }
}
