using System;

namespace Ejercicio
{
    class Program
    {
        static void TorreHanoi(int n, int o, int d, int auxiliar){
            if(n > 0){
                TorreHanoi(n-1,o,auxiliar,d);
                Console.WriteLine("El anillo de la torre {0} se mueve a la torre {1}",o,d);
                TorreHanoi(n-1,auxiliar,d,o);
                
            }
        }

        static void Main(string[] args)
        {
            //Torre de Hanoi
            int numeroAnillos = 0;

            Console.WriteLine("Ingrese la catindad de anillos");
            numeroAnillos = int.Parse(Console.ReadLine());

            TorreHanoi(numeroAnillos,1,3,2);
            Console.ReadKey();
        }
    }
}
