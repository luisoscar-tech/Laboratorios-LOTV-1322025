using System;

class Programa
{
    static void Main()
    {
        // ENTRADAS
        // N = cantidad de números a ingresar
        // numero = números que ingresa el usuario

        // PROCESO
        // 1. Validar que N sea mayor que 0
        // 2. Usar while para leer N números
        // 3. Sumar los números
        // 4. Calcular el promedio

        // SALIDAS
        // Mostrar la suma total y el promedio

        int N;
        int contador = 0;
        double numero;
        double suma = 0;

        Console.Write("Ingrese la cantidad de números: ");
        N = int.Parse(Console.ReadLine());

        while (N <= 0)
        {
            Console.WriteLine("N debe ser mayor que 0");
            Console.Write("Ingrese nuevamente N: ");
            N = int.Parse(Console.ReadLine());
        }

        while (contador < N)
        {
            Console.Write("Ingrese un número: ");
            numero = double.Parse(Console.ReadLine());

            suma = suma + numero;
            contador = contador + 1;
        }

        double promedio = suma / N;

        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine("Promedio: " + promedio);
    }
}