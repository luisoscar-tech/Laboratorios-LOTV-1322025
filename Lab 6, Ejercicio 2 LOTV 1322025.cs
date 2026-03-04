using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=================================================");
        Console.WriteLine("                  Ejercicio 2");
        Console.WriteLine("=================================================");

        Console.Write("Ingrese su límite actual: ");
        double limite = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el tipo de tarjeta: ");
        int tipoTarjeta = int.Parse(Console.ReadLine());

        double porcentaje;

        if (tipoTarjeta == 1)
        {
            porcentaje = 0.25;
        }
        else if (tipoTarjeta == 2)
        {
            porcentaje = 0.35;
        }
        else if (tipoTarjeta == 3)
        {
            porcentaje = 0.40;
        }
        else
        {
            porcentaje = 0.50;
        }

        double aumento = limite * porcentaje;
        double nuevoLimite = limite + aumento;

        Console.WriteLine("Aumento aplicado: " + (porcentaje * 100) + "%");
        Console.WriteLine("Nuevo límite de crédito: Q" + nuevoLimite);

        Console.WriteLine("\n---------------------------------------\n");

    }
}