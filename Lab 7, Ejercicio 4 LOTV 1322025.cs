using System;

class Programa
{
    static void Main()
    {
        // ENTRADAS
        // PIN ingresado por el usuario

        // PROCESO
        // Comparar con el PIN correcto
        // Permitir máximo 3 intentos

        // SALIDAS
        // Acceso concedido o cuenta bloqueada

        int pinCorrecto = 1234;
        int pin;
        int intentos = 0;

        do
        {
            Console.Write("Ingrese el PIN: ");
            pin = int.Parse(Console.ReadLine());

            intentos++;

            if (pin == pinCorrecto)
            {
                Console.WriteLine("Acceso concedido");
                break;
            }
            else
            {
                Console.WriteLine("PIN incorrecto");
            }

        } while (intentos < 3);

        if (intentos == 3 && pin != pinCorrecto)
        {
            Console.WriteLine("Cuenta bloqueada");
        }
    }
}