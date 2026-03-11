using System;

class Programa
{
    static void Main()
    {
        // ENTRADAS
        // Número que ingresa el usuario

        // PROCESO
        // Generar número aleatorio
        // Comparar con el número ingresado
        // Indicar si es mayor o menor

        // SALIDAS
        // Mensaje correcto y número de intentos

        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);

        int numero;
        int intentos = 0;

        Console.Write("Adivine el número (1-100): ");
        numero = int.Parse(Console.ReadLine());

        while (numero != numeroSecreto)
        {
            intentos++;

            if (numero < numeroSecreto)
                Console.WriteLine("Más alto");
            else
                Console.WriteLine("Más bajo");

            Console.Write("Intente de nuevo: ");
            numero = int.Parse(Console.ReadLine());
        }

        intentos++;

        Console.WriteLine("¡Correcto!");
        Console.WriteLine("Intentos: " + intentos);
    }
}