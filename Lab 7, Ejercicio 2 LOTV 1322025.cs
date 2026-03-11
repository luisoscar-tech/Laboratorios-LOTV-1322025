using System;

class Programa
{
    static void Main()
    {
        // ENTRADAS
        // opcion del menú
        // temperatura o distancia ingresada por el usuario

        // PROCESO
        // Mostrar menú y realizar conversión según opción
        // Repetir hasta que el usuario elija salir

        // SALIDAS
        // Resultado de la conversión

        int opcion;

        do
        {
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Kilómetros a Millas");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese Celsius: ");
                double celsius = double.Parse(Console.ReadLine());

                double resultado = (celsius * 9 / 5) + 32;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese Fahrenheit: ");
                double fahrenheit = double.Parse(Console.ReadLine());

                double resultado = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == 3)
            {
                Console.Write("Ingrese kilómetros: ");
                double km = double.Parse(Console.ReadLine());

                double resultado = km * 0.62137;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                Console.WriteLine("Opción inválida");
            }

        } while (opcion != 4);
    }
}