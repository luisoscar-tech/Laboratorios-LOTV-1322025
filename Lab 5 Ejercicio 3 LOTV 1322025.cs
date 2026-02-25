using System;

class Program
{
    static void Main()
    {
        Console.Write("Código de activación: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("¿Aceptó los términos y condiciones? (1/0): ");
        int terminos = int.Parse(Console.ReadLine());

        Console.Write("¿Activó la verificadcion en 2 pasos? (1/0): ");
        int dosFA = int.Parse(Console.ReadLine());

        Console.Write("Puntaje (0-100): ");
        int puntaje = int.Parse(Console.ReadLine());

        bool codigoCorrecto = false;
        bool edadCorrecta = false;
        bool terminosCorrectos = false;
        bool dosFACorrecto = false;
        bool puntajeCorrecto = false;

        if (codigo == 2026)
        {
            Console.WriteLine("Código correcto.");
            codigoCorrecto = true;
        }
        else
            Console.WriteLine("Código incorrecto.");

        if (edad >= 18)
        {
            Console.WriteLine("Edad válida.");
            edadCorrecta = true;
        }
        else
            Console.WriteLine("Edad no válida.");

        if (terminos == 1)
        {
            Console.WriteLine("Términos aceptados.");
            terminosCorrectos= true;
        }
        else
            Console.WriteLine("Debe aceptar términos.");

        if (dosFA == 1)
        {
            Console.WriteLine("2FA activado.");
            dosFACorrecto = true;
        }
        else
            Console.WriteLine("2FA no activado.");

        if (puntaje >= 70)
        {
            Console.WriteLine("Puntaje suficiente.");
            puntajeCorrecto = true;
        }
        else
            Console.WriteLine("Puntaje insuficiente.");

        if (codigoCorrecto && edadCorrecta && terminosCorrectos && dosFACorrecto && puntajeCorrecto)
            Console.WriteLine("Cuenta activada exitosamente.");
        else
            Console.WriteLine("Cuenta NO activada.");
    }
}