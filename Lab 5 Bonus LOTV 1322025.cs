using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== BONUS: SAN VALENTÍN HACKER EDITION ===");

        Console.Write("Nombre de la persona: ");
        string nombre = Console.ReadLine();

        Console.Write("Nivel de valentía (0-100): ");
        int valentia = int.Parse(Console.ReadLine());

        Console.Write("¿Le gusta la programación? (1/0): ");
        int programacion = int.Parse(Console.ReadLine());

        Console.Write("¿Le gustan los memes técnicos? (1/0): ");
        int memes = int.Parse(Console.ReadLine());

        Console.Write("Nivel de interés (0-100): ");
        int interes = int.Parse(Console.ReadLine());

        Console.Write("¿Está soltera/o? (1/0): ");
        int soltero = int.Parse(Console.ReadLine());

        if (interes >= 70)
            Console.WriteLine("Interés alto detectado.");
        else
            Console.WriteLine("Interés insuficiente. Riesgo de friend zone elevado.");

        if (valentia >= 70)
            Console.WriteLine("Valentía favorable. Confía en sí mismo(a).");
        else
            Console.WriteLine("Nivel de valentía bajo. Actualización de hardware requerida (vaya al gym).");

        if (soltero == 1)
            Console.WriteLine("Estado sentimental favorable… aunque lo esté, no le crea: todos/todas mienten.");
        else
            Console.WriteLine("Estado sentimental comprometido, no es recomendable hackear esa relación.");

        if (programacion == 1 && memes == 1)
            Console.WriteLine("Compatibilidad geek detectada.");
        else
            Console.WriteLine("Compatibilidad parcial o inexistente.");

        if (interes >= 70 && soltero == 1 && programacion == 1 && memes == 1 && valentia >= 70)
        {
            Console.WriteLine("DECLARACIÓN APROBADA. Proceder con chocolates y flores.");
        }
        else if (interes >= 70 && soltero == 1 && programacion == 1 && memes == 1 && valentia < 70)
        {
            Console.WriteLine("No le tenga miedo al éxito que vida solo hay 1.");
        }
        else
        {
            Console.WriteLine(nombre + ", no te ama.. por ahora.");
        }
    }
}
