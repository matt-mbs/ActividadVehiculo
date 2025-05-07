using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculo;

namespace ActividadVehiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Seleccione el tipo de vehículo a registrar:");
                Console.WriteLine("1. Taxi");
                Console.WriteLine("2. Autobús");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Registro de Taxi
                        Console.Write("Ingrese la matrícula del taxi: ");
                        string matriculaTaxi = Console.ReadLine();

                        Console.Write("Ingrese el modelo del taxi: ");
                        string modeloTaxi = Console.ReadLine();

                        Console.Write("Ingrese la potencia (CV) del taxi: ");
                        int potenciaTaxi = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese el número de licencia: ");
                        string licenciaTaxi = Console.ReadLine();

                        Taxi taxi = new Taxi(matriculaTaxi, modeloTaxi, potenciaTaxi);
                        taxi.setNumeroLicencia(licenciaTaxi);

                        Console.WriteLine("\n--- DATOS DEL TAXI ---");
                        Console.WriteLine($"Matrícula: {taxi.getMatricula()}");
                        Console.WriteLine($"Modelo: {taxi.getModelo()}");
                        Console.WriteLine($"Potencia: {taxi.getPotenciaCV()} CV");
                        Console.WriteLine($"Licencia: {taxi.getNumeroLicencia()}");
                        break;

                    case "2":
                        // Registro de Autobús
                        Console.Write("Ingrese la matrícula del autobús: ");
                        string matriculaBus = Console.ReadLine();

                        Console.Write("Ingrese el modelo del autobús: ");
                        string modeloBus = Console.ReadLine();

                        Console.Write("Ingrese la potencia (CV) del autobús: ");
                        int potenciaBus = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese el número de plazas: ");
                        int plazasBus = int.Parse(Console.ReadLine());

                        Autobus autobus = new Autobus(matriculaBus, modeloBus, potenciaBus);
                        autobus.setNumeroPlazas(plazasBus);

                        Console.WriteLine("\n--- DATOS DEL AUTOBÚS ---");
                        Console.WriteLine($"Matrícula: {autobus.getMatricula()}");
                        Console.WriteLine($"Modelo: {autobus.getModelo()}");
                        Console.WriteLine($"Potencia: {autobus.getPotenciaCV()} CV");
                        Console.WriteLine($"Plazas: {autobus.getNumeroPlazas()}");
                        break;

                    case "3":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }
    }
}

