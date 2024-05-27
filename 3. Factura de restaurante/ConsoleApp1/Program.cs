using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static string nombre;
        static int dni;
        static int nMesa;
        static string menuComprado;
        static int cantidadPlatos;
        static double totalPagar;

        static void datos()
        {
            Console.WriteLine("Ingresa el nombre del cliente");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el DNI del cliente");
            dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la mesa del cliente");
            nMesa = int.Parse(Console.ReadLine());
        }

        static void menuPlatos()
        {
            menuComprado = "";
            totalPagar = 0;

            Console.Write("Ingrese la cantidad de platos: ");
            cantidadPlatos = int.Parse(Console.ReadLine());

            Console.WriteLine("Menú de platos");
            Console.WriteLine("Opciones:");
            Console.WriteLine("a. Arroz con pato - 15 soles");
            Console.WriteLine("b. Chaufa de pollo - 10 soles");
            Console.WriteLine("c. Seco a la norteña - 14 soles");
            Console.WriteLine("d. Sopa de casa - 10 soles");

            for (int i = 1; i <= cantidadPlatos; i++)
            {
                Console.Write($"Plato {i}: ");
                char opcionPlato = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                switch (opcionPlato)
                {
                    case 'a':
                        menuComprado += "Arroz con pato, ";
                        totalPagar += 15;
                        break;
                    case 'b':
                        menuComprado += "Chaufa de pollo, ";
                        totalPagar += 10;
                        break;
                    case 'c':
                        menuComprado += "Seco a la norteña, ";
                        totalPagar += 14;
                        break;
                    case 'd':
                        menuComprado += "Sopa de casa, ";
                        totalPagar += 10;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        i--; 
                        break;
                }
            }

            Console.WriteLine($"Ha seleccionado {cantidadPlatos} platos de {menuComprado.TrimEnd(',', ' ')}.");
            Console.WriteLine($"Total a pagar: {totalPagar} soles");
        }

        static void Facturacion(string nombre, int dni, int nMesa, string menuComprado, int cantidadPlatos, double totalPagar)
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Facturación");
            Console.WriteLine("Boleta:");
            Console.WriteLine($"Nombre del cliente: {nombre}");
            Console.WriteLine($"DNI del cliente: {dni}");
            Console.WriteLine($"Mesa del cliente: {nMesa}");
            Console.WriteLine($"Menú comprado: {menuComprado}");
            Console.WriteLine($"Cantidad: {cantidadPlatos}");
            Console.WriteLine($"Pago final: {totalPagar} soles");
            Console.WriteLine("--------------------------------------------------------------");
        }

        static void SalirPrograma()
        {
            Console.WriteLine("Programa finalizado");
        }


        static void Main(string[] args)
        {
            do
            {
                datos();
                menuPlatos();
                Facturacion(nombre, dni, nMesa, menuComprado, cantidadPlatos, totalPagar);

                Console.WriteLine("¿Desea agregar otro cliente? s/n");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                {
                    SalirPrograma();
                    break;
                }

            } while (true);

            Console.ReadKey();

        }
    }
}
