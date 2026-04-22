using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string texto = Console.ReadLine();

        string invertido = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertido += texto[i];
        }

        Console.WriteLine("Texto invertido: " + invertido);
    }
}