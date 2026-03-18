using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int n = int.Parse(Console.ReadLine());

        int suma = 0;
        int pares = 0;
        int impares = 0;

        for (int i = 1; i <= n; i++)
        {
            suma += i;

            if (i % 2 == 0)
                pares++;
            else
                impares++;
        }

        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine("Cantidad de pares: " + pares);
        Console.WriteLine("Cantidad de impares: " + impares);
    }
}
