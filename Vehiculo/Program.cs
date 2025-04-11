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
            Taxi taxi = new Taxi("ABC123", "Toyota Prius", 120);
            taxi.setNumeroLicencia("LIC-456789");

            Autobus autobus = new Autobus("XYZ789", "Mercedes Sprinter", 180);
            autobus.setNumeroPlazas(30);

            Console.WriteLine("TAXI:");
            Console.WriteLine("Matrícula: " + taxi.getMatricula());
            Console.WriteLine("Modelo: " + taxi.getModelo());
            Console.WriteLine("Potencia: " + taxi.getPotenciaCV() + " CV");
            Console.WriteLine("Número de Licencia: " + taxi.getNumeroLicencia());

            Console.WriteLine("\nAUTOBÚS:");
            Console.WriteLine("Matrícula: " + autobus.getMatricula());
            Console.WriteLine("Modelo: " + autobus.getModelo());
            Console.WriteLine("Potencia: " + autobus.getPotenciaCV() + " CV");
            Console.WriteLine("Número de Plazas: " + autobus.getNumeroPlazas());

            Console.ReadLine();
        }
    }
}
