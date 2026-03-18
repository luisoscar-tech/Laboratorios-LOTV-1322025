using System;

class Program
{
    static void Main()
    {
        int opcion;
        double totalVentas = 0;
        int clientes = 0;

        do
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1) Registrar compra");
            Console.WriteLine("2) Mostrar total de ventas");
            Console.WriteLine("3) Mostrar cantidad de clientes");
            Console.WriteLine("4) Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese monto de la compra: ");
                    double monto = double.Parse(Console.ReadLine());
                    totalVentas += monto;
                    clientes++;
                    break;

                case 2:
                    Console.WriteLine("Total de ventas: " + totalVentas);
                    break;

                case 3:
                    Console.WriteLine("Clientes atendidos: " + clientes);
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 4);
    }
}
