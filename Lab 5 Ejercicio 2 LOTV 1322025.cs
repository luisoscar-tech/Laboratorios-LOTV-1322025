using System;

class Program
{
    static void Main()
    {

        Console.Write("Ingrese PIN: ");
        int pin = int.Parse(Console.ReadLine());

        bool cuatroDigitos = false;
        bool esPar = false;
        bool multiplo5 = false;

        // a)
        if (pin >= 1000 && pin <= 9999)
        {
            Console.WriteLine("PIN de 4 dígitos: OK");
            cuatroDigitos = true;
        }
        else
        {
            Console.WriteLine("PIN inválido: debe tener 4 dígitos");
        }

        // b)
        if (pin % 2 == 0)
        {
            Console.WriteLine("PIN par");
            esPar = true;
        }
        else
        {
            Console.WriteLine("PIN impar");
        }

        // c)
        if (pin % 5 == 0)
        {
            Console.WriteLine("Múltiplo de 5");
            multiplo5 = true;
        }
        else
        {
            Console.WriteLine("No es múltiplo de 5");
        }

        // d)
        if (cuatroDigitos && esPar && !multiplo5)
            Console.WriteLine("PIN aceptado por política");
        else
            Console.WriteLine("PIN rechazado por política");
    }
}