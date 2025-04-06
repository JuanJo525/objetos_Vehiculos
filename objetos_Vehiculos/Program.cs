    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos_Vehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tipoVehiculo = 0;

            while (tipoVehiculo != 3)
            {
                Console.Clear();
                Console.WriteLine("Que tipo de vehiculo desea instanciar.");
                Console.WriteLine("1: Taxi");
                Console.WriteLine("2: Autobus");
                Console.WriteLine("3: salir");
                tipoVehiculo = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (tipoVehiculo)
                {
                    case 1:
                        Console.WriteLine("Instanciando un taxi");
                        Console.WriteLine("ingrese matricula");
                        string matricula = Console.ReadLine();
                        Console.WriteLine("ingrese modelo");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("ingrese potencia");
                        int potencia = int.Parse(Console.ReadLine());

                        ClsTaxi taxi = new ClsTaxi(matricula, modelo, potencia);

                        Console.WriteLine("ingrese licencia");
                        string licencia = Console.ReadLine();

                        taxi.setLicencia(licencia);

                        Console.Clear();
                        Console.WriteLine("Datos del taxi;");
                        Console.WriteLine("matricula: " + taxi.GetMatricula());
                        Console.WriteLine("modelo: " + taxi.GetModelo());
                        Console.WriteLine("potencia: " + taxi.GetPotencia());
                        Console.WriteLine("licencia: " + taxi.getLicencia());
                        break;

                    case 2:
                        Console.WriteLine("instanciando un autobus");
                        Console.WriteLine("ingrese matricula");
                        matricula = Console.ReadLine();
                        Console.WriteLine("ingrese modelo");
                        modelo = Console.ReadLine();
                        Console.WriteLine("ingrese potencia");
                        potencia = int.Parse(Console.ReadLine());

                        ClsAutobus bus = new ClsAutobus(matricula, modelo, potencia);

                        Console.WriteLine("ingrese cantidad de plazas");
                        int pasajeros = int.Parse(Console.ReadLine());

                        bus.setPlazas(pasajeros);

                        Console.Clear();
                        Console.WriteLine("datos del bus:");
                        Console.WriteLine("matricula: " + bus.GetMatricula());
                        Console.WriteLine("modelo: " + bus.GetModelo());
                        Console.WriteLine("potencia: " + bus.GetPotencia());
                        Console.WriteLine("plazas: " + bus.getPlazas());
                        break;

                    case 3:
                        Console.WriteLine("saliendo ...");
                    break;

                    default: Console.WriteLine("Incorrecto"); break;
                }
                Console.WriteLine("Preciones enter para continuar");
                Console.ReadKey();
            }
        }
    }
}
