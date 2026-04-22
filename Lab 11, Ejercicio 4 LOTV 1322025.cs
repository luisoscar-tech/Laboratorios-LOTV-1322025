using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[8];

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("Ingrese número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Número a buscar: ");
        int buscar = int.Parse(Console.ReadLine());

        int posicion = -1;

        for (int i = 0; i < 8; i++)
        {
            if (numeros[i] == buscar)
            {
                posicion = i;
                break;
            }
        }

        if (posicion != -1)
            Console.WriteLine("El número sí existe en la posición " + posicion);
        else
            Console.WriteLine("El número no existe en el arreglo");
    }
}
