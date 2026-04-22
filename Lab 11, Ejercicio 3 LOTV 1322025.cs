using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Cuántos números desea ingresar? ");
        int n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];
        int suma = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Ingrese número: ");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i];
        }

        int mayor = numeros[0];
        int menor = numeros[0];

        for (int i = 1; i < n; i++)
        {
            if (numeros[i] > mayor)
                mayor = numeros[i];

            if (numeros[i] < menor)
                menor = numeros[i];
        }

        double promedio = (double)suma / n;

        Console.WriteLine("Suma = " + suma);
        Console.WriteLine("Promedio = " + promedio);
        Console.WriteLine("Mayor = " + mayor);
        Console.WriteLine("Menor = " + menor);
    }
}