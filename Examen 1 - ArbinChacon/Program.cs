using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1___ArbinChacon
{
    internal class Program
    {
        static ClsTransacciones transacciones = new ClsTransacciones();
        static void Main(string[] args)
        {
            int opcion = 0;

            while (opcion != 6)
            {
                Console.Clear();
                Console.WriteLine("Menú Principal del Sistema:");
                Console.WriteLine("1. Inicializar Vectores");
                Console.WriteLine("2. Ingresar Paso Vehicular");
                Console.WriteLine("3. Consulta de vehículos por numero placa");
                Console.WriteLine("4. Modificar Datos Vehículos por numero placa");
                Console.WriteLine("5. Reporte Todos los Datos de los vectores");
                Console.WriteLine("6. Salir");

                Console.Write("\nIngrese una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        transacciones.InicializarVectores();
                        Console.WriteLine("\nVectores inicializados correctamente.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        transacciones.IngresoVehiculos();
                        Console.WriteLine("\nPaso vehicular registrado correctamente.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        transacciones.ConlsutarPlaca();
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        transacciones.ModificarDatos();
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    /*case 5:
                        transacciones.ReporteTodosLosDatos();
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;*/
                    case 6:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida. Intente nuevamente.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
