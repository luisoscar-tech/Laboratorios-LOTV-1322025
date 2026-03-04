using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("=================================================");
        Console.WriteLine("                  Ejercicio 3");
        Console.WriteLine("=================================================");

        Console.Write("Ingrese su puntuación (0.0, 0.4, 0.6 o más): ");
        double puntuacion = double.Parse(Console.ReadLine());

        string nivel = "";
        double dinero = 0;

        if (puntuacion == 0.0)
        {
            nivel = "Inaceptable";
        }
        else
        {
            if (puntuacion == 0.4)
            {
                nivel = "Aceptable";
            }
            else
            {
                if (puntuacion >= 0.6)
                {
                    nivel = "Meritorio";
                }
                else
                {
                    Console.WriteLine("ERROR: Puntuación inválida.");
                    return;
                }
            }
        }

        dinero = 2400 * puntuacion;

        Console.WriteLine("Nivel de rendimiento: " + nivel);
        Console.WriteLine("Dinero recibido: €" + dinero);

        Console.WriteLine("\n---------------------------------------\n");

    }
}