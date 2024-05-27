using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Edad, Suma = 0, Contador = 0, Promedio = 0;

            do
            {

                Console.WriteLine("Ingresa su edad");

                Edad = int.Parse(Console.ReadLine());

                Suma = Suma + Edad;

                Contador = Contador + 1;

                Promedio = Suma / Contador;

                Console.WriteLine("El promedio por ahora es " + Promedio);

                if (Promedio > 26)
                {

                    break;

                }

            } 
            
            while (Promedio > 0);

            Console.WriteLine("La suma de las edades es :" + Suma + " La Cantidad de edades ingresadas fueron: " + Contador);

            Console.WriteLine("El promedio es igual a: " + Promedio);

            if (Promedio > 27)
            {

                Console.WriteLine("El promedio fue mayor que 27 y ha finalizado");

            }
            else
            {

                Console.WriteLine("Reinicia el programa ya que el promedio no fue superior a 27");

            }
            Console.ReadKey();
        }
    }
}
