
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Alumno
    {
        public string nombre;
        public double promedio;
        public int numeroFaltas;

        public void Datos() {
            Console.WriteLine("Ingrese el nombre del alumno:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el promedio del alumno:");
            promedio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el número de faltas del alumno:");
            numeroFaltas = Convert.ToInt32(Console.ReadLine());

        }


        public int CalcularPuntosARestar()
        {
            if (numeroFaltas == 0)
            {
                return 0;
            }
            else if (numeroFaltas >= 1 && numeroFaltas <= 3)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Promedio actualizado: " + (promedio - CalcularPuntosARestar()));
            Console.WriteLine("Número de faltas: " + numeroFaltas);
        }
    }
}
