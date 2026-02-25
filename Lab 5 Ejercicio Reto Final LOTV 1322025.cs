using System;

class Program
{
    static void Main()
    {
        Console.Write("Nota previa: ");
        int nota = int.Parse(Console.ReadLine());

        Console.Write("Minutos tarde: ");
        int minutos = int.Parse(Console.ReadLine());

        Console.Write("¿Tiene solvencia? (1/0): ");
        int solvencia = int.Parse(Console.ReadLine());

        Console.Write("¿Trae identificación? (1/0): ");
        int idFisica = int.Parse(Console.ReadLine());

        Console.Write("¿Trae calculadora permitida? (1/0): ");
        int calculadora = int.Parse(Console.ReadLine());

        if (nota >= 61)
            Console.WriteLine("Requisito académico aprobado.");
        else
            Console.WriteLine("Requisito académico NO aprobado.");

        if (minutos <= 10)
        {
            Console.WriteLine("Hora válida");
            if (minutos > 0)
                Console.WriteLine("Advertencia: llegó tarde, pero aún puede ingresar");
        }
        else
            Console.WriteLine("Llegada tarde: fuera de tiempo");

        if (solvencia == 1)
            Console.WriteLine("Solvencia validada");
        else
            Console.WriteLine("Sin solvencia");

        if (idFisica == 1)
            Console.WriteLine("Identificación validada");
        else
            Console.WriteLine("Sin identificación");

        if (calculadora == 1)
            Console.WriteLine("Calculadora permitida");
        else
            Console.WriteLine("Sin calculadora permitida");

        if (nota >= 61 && minutos <= 10 && solvencia == 1 && idFisica == 1)
            Console.WriteLine("Se le permite ingresar al salon");
        else
            Console.WriteLine("No se le permite ingresar al salon");
    }
}
    
