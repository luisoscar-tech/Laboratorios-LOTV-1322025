using System;

class Program
{
    static void Main()
    {
        string[] nombres = new string[5];
        int contador = 0;
        string masLargo = "";

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese nombre: ");
            nombres[i] = Console.ReadLine();

            if (nombres[i].Length > 5)
                contador++;

            if (nombres[i].Length > masLargo.Length)
                masLargo = nombres[i];
        }

        Console.Write("Nombres ingresados: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(nombres[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Más de 5 letras: " + contador);
        Console.WriteLine("Nombre más largo: " + masLargo);
    }
}