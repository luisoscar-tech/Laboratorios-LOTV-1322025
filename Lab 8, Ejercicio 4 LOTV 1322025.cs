using System;

class Program
{
    static void Main()
    {
        int num;
        int contador = 0;
        int positivos = 0;
        int negativos = 0;
        int suma = 0;

        do
        {
            Console.Write("Ingrese un número (0 para salir): ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                contador++;
                suma += num;

                if (num > 0)
                    positivos++;
                else
                    negativos++;
            }

        } while (num != 0);

        Console.WriteLine("Cantidad de números: " + contador);
        Console.WriteLine("Positivos: " + positivos);
        Console.WriteLine("Negativos: " + negativos);
        Console.WriteLine("Suma total: " + suma);
    }
}
