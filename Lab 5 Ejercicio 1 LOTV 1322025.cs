using System;

class Program
{
    static void Main()
    {

        // Ejercicio 1
        Console.WriteLine("======= Panel de control del usuario =======");
        Console.WriteLine("Ingrese ID de usuario: ");
        int Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el pin de acceso: ");
        int PIN = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el token de seguridad: ");
        int token = int.Parse(Console.ReadLine());

        Console.WriteLine("Modo seguro activado ( 1 = Si, 0 = No ): ");
        int modoSeguro = int.Parse(Console.ReadLine());

        bool IdCorrecto = false;
        bool PINCorrecto = false;
        bool tokenCorrecto = false;

        //a) Validar el Usuario
        if (Id == 2026)
        {
            Console.WriteLine("====== Usuario correcto =====");
            IdCorrecto = true;
        }
        else
        {
            Console.WriteLine("====== Usuario incorrecto =====");
        }
        //b) Validar el PIN
        if (PIN == 1234)
        {
            Console.WriteLine("====== PIN correcto =====");
            PINCorrecto = true;
        }
        else
        {
            Console.WriteLine("====== PIN incorrecto =====");
        }
        //c) Validar el Token
        if (token == 777)
        {
            Console.WriteLine("===== Token correcto =====");
            tokenCorrecto = true;
        }
        else
        {
            Console.WriteLine("===== Token incorrecto =====");
        }
        //d) Modo seguro
        if (modoSeguro == 1)
        {
            Console.WriteLine("===== Modo seguro activado =====");
            if (token >= 700)
                Console.WriteLine("===== Regla extra aprobada =====");
            else
                Console.WriteLine("===== Regla extra no aprobada =====");
        }
        else
        {
            Console.WriteLine("===== Modo seguro desactivado =====");
        }
        //d) Acceso total
        if (IdCorrecto && PINCorrecto && tokenCorrecto)
            Console.WriteLine("===== Regla extra aprobada =====");
        else
            Console.WriteLine("===== Regla extra fallida =====");

    }
}