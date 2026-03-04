using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("=================================================");
        Console.WriteLine("                  Ejercicio 1");
        Console.WriteLine("=================================================");

        Console.WriteLine("1: Bicicleta");
        Console.WriteLine("2: Motocicleta");
        Console.WriteLine("3: Auto");
        Console.WriteLine("4: Camión");
        Console.WriteLine("5: Autobús");
        Console.Write("Ingrese el número del vehículo: ");

        int vehiculo = int.Parse(Console.ReadLine());

        if (vehiculo == 1)
        {
            Console.WriteLine("Bicicleta → No motorizado");
        }
        else
        {
            if (vehiculo == 2)
            {
                Console.WriteLine("Motocicleta → Ligero");
            }
            else
            {
                if (vehiculo == 3)
                {
                    Console.WriteLine("Auto → Mediano");
                }
                else
                {
                    if (vehiculo == 4)
                    {
                        Console.WriteLine("Camión → Pesado");
                    }
                    else
                    {
                        if (vehiculo == 5)
                        {
                            Console.WriteLine("Autobús → Transporte público");
                        }
                        else
                        {
                            Console.WriteLine("ERROR: Número fuera del rango permitido.");
                        }
                    }
                }
            }
        }

        Console.WriteLine("\n---------------------------------------\n");
    }
}