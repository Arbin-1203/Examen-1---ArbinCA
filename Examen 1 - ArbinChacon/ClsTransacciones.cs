using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1___ArbinChacon
{
    internal class ClsTransacciones
    {
        private const int moto = 500;
        private const int vehiculo_liviano = 700;
        private const int camion_pesado = 2700;
        private const int autobus = 3700;

        private const int vehiculos = 15;
        private int[] numeroFactura = new int[vehiculos];
        private string[] numeroPlaca = new string[vehiculos];
        private DateTime[] fecha = new DateTime[vehiculos];
        private TimeSpan[] hora = new TimeSpan[vehiculos];
        private int[] tipoVehiculo = new int[vehiculos];
        private int[] numeroCaseta = new int[vehiculos];
        private float[] montoPagar = new float[vehiculos];
        private float[] pagaCon = new float[vehiculos];
        private float[] vuelto = new float[vehiculos];
        private int cantidadVehiculos = 0;

        public void InicializarVectores()
        {
            for (int i = 0; i < vehiculos; i++)
            {
                numeroFactura[i] = 0;
                numeroPlaca[i] = "";
                fecha[i] = DateTime.MinValue;
                hora[i] = TimeSpan.MinValue;
                tipoVehiculo[i] = 0;
                numeroCaseta[i] = 0;
                montoPagar[i] = 0;
                pagaCon[i] = 0;
                vuelto[i] = 0;

            }

        }

        public void IngresoVehiculos()
        {
            if (cantidadVehiculos >= vehiculos)
            {
                Console.WriteLine("\nSe ha alcanzado el límite máximo de vehículos registrados");
                return;
            }
            {
                Console.Write("\nIngrese el número de placa: ");
                numeroPlaca[cantidadVehiculos] = Console.ReadLine();

                Console.Write("\nIngrese el número de factura: ");
                numeroFactura[cantidadVehiculos] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la fecha (dd/mm/yyyy): ");
                fecha[cantidadVehiculos] = DateTime.Parse(Console.ReadLine());

                Console.Write("Ingrese la hora (hh:mm:ss): ");
                hora[cantidadVehiculos] = TimeSpan.Parse(Console.ReadLine());

                Console.Write("Ingrese el número de caseta (1 - 4): ");
                numeroCaseta[cantidadVehiculos] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el tipo de vehículo (1 = Automóvil, 2 = Camión, 3 = Motocicleta, 4 = Autobus): ");
                tipoVehiculo[cantidadVehiculos] = int.Parse(Console.ReadLine());

                switch (tipoVehiculo[cantidadVehiculos])
                {
                    case 1:
                        montoPagar[cantidadVehiculos] = moto;
                        break;
                    case 2:
                        montoPagar[cantidadVehiculos] = vehiculo_liviano;
                        break;
                    case 3:
                        montoPagar[cantidadVehiculos] = camion_pesado;
                        break;
                    case 4:
                        montoPagar[cantidadVehiculos] = autobus;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        return;
                }

                Console.Write("Monto a pagar: {0}\n", montoPagar[cantidadVehiculos]);


                Console.Write("Pago con: ");
                pagaCon[cantidadVehiculos] = float.Parse(Console.ReadLine());

                while (pagaCon[cantidadVehiculos] < montoPagar[cantidadVehiculos])
                {
                    Console.WriteLine("El monto pagado no es suficiente. Intente de nuevo.");
                    Console.WriteLine("Paga con: ");
                    pagaCon[cantidadVehiculos] = float.Parse(Console.ReadLine());
                }

                vuelto[cantidadVehiculos] = pagaCon[cantidadVehiculos] - montoPagar[cantidadVehiculos];

                Console.WriteLine("Vuelto: {0}", vuelto[cantidadVehiculos]);

                Console.WriteLine("Transacción registrada correctamente.");

                cantidadVehiculos++;
            }
        }
        public void ConlsutarPlaca()
        {
            Console.Write("\nIngrese el número de placa del vehículo a consultar: ");
            string placa = Console.ReadLine();

            for (int i = 0; i < cantidadVehiculos; i++)
            {
                if (numeroPlaca[i].Equals(placa))
                {
                    Console.WriteLine("\nNúmero de placa: {0}", numeroPlaca[i]);
                    Console.WriteLine("\nNúmero de factura: {0}", numeroFactura[i]);
                    Console.WriteLine("Número de placa: {0}", numeroPlaca[i]);
                    Console.WriteLine("Fecha: {0}", fecha[i].ToString("dd/MM/yyyy"));
                    Console.WriteLine("Hora: {0}", hora[i].ToString());
                    Console.WriteLine("Tipo de vehículo: {0}", tipoVehiculo[i]);
                    Console.WriteLine("Número de caseta: {0}", numeroCaseta[i]);
                    Console.WriteLine("Monto a pagar: {0}", montoPagar[i]);
                    Console.WriteLine("Monto pagado: {0}", pagaCon[i]);
                    Console.WriteLine("Vuelto: {0}", vuelto[i]);
                    return;
                }
            }
            Console.WriteLine("\nNo se encontró un vehículo registrado con la placa ingresada.");
        }

        public void ModificarDatos()
        {
            Console.Write("\nIngrese el número de placa del vehículo a modificar: ");
            string placa = Console.ReadLine();

            for (int i = 0; i < cantidadVehiculos; i++)
            {
                if (numeroPlaca[i].Equals(placa))
                {
                    Console.WriteLine("Numero de factura: {0}", numeroFactura[i]);
                    Console.WriteLine("Numero de placa {0}", numeroPlaca[i]);
                    Console.WriteLine("Fecha: {0}", fecha[i].ToString("dd/MM/xxxx"));
                    Console.WriteLine("Hora: {0}", hora[i].ToString());
                    Console.WriteLine("Tipo de vehículo: {0}", tipoVehiculo[i]);
                    Console.WriteLine("Número de caseta:{0}", numeroCaseta[i]);
                    Console.WriteLine("Monto a pagar: {0}", montoPagar[i]);
                    Console.WriteLine("Monto pagado: {0}", pagaCon[i]);
                    Console.WriteLine("Vuelto: {0}", vuelto[i]);

                    Console.Write("\nIngrese el nuevo número de factura: ");
                    numeroFactura[i] = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese la nueva fecha (dd/mm/yyyy): ");
                    fecha[i] = DateTime.Parse(Console.ReadLine());

                    Console.Write("Ingrese la nueva hora (hh:mm:ss): ");
                    hora[i] = TimeSpan.Parse(Console.ReadLine());

                    Console.Write("Ingrese el nuevo número de caseta (1 - 4): ");
                    numeroCaseta[i] = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el nuevo tipo de vehículo (1 = Automóvil, 2 = Camión, 3 = Motocicleta 4=Autobus): ");
                    tipoVehiculo[cantidadVehiculos] = int.Parse(Console.ReadLine());

                    switch (tipoVehiculo[cantidadVehiculos])
                    {
                        case 1:
                            montoPagar[cantidadVehiculos] = moto;
                            break;
                        case 2:
                            montoPagar[cantidadVehiculos] = vehiculo_liviano;
                            break;
                        case 3:
                            montoPagar[cantidadVehiculos] = camion_pesado;
                            break;
                        case 4:
                            montoPagar[cantidadVehiculos] = autobus;
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente de nuevo.");
                            return;
                    }

                    Console.Write("Monto a pagar: {0}\n", montoPagar[cantidadVehiculos]);


                    Console.Write("Pago con: ");
                    pagaCon[cantidadVehiculos] = float.Parse(Console.ReadLine());

                    while (pagaCon[cantidadVehiculos] < montoPagar[cantidadVehiculos])
                    {
                        Console.WriteLine("El monto pagado no es suficiente. Intente de nuevo.");
                        Console.WriteLine("Paga con: ");
                        pagaCon[cantidadVehiculos] = float.Parse(Console.ReadLine());
                    }

                    vuelto[cantidadVehiculos] = pagaCon[cantidadVehiculos] - montoPagar[cantidadVehiculos];

                    Console.WriteLine("Vuelto: {0}", vuelto[cantidadVehiculos]);

                    Console.WriteLine("Transacción registrada correctamente.");

                    Console.WriteLine("\nLos datos del vehículo han sido modificados.");
                    return;
                }

            }
            Console.WriteLine("\nNo se encontró un vehículo registrado con la placa ingresada.");
        }
    }
}
