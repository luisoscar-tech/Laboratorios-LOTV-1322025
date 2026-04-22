class Program
{
    static void Main()
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("== Ejercicio 1, Validacion de contraseña ==");
        Console.WriteLine("===========================================");
        Console.WriteLine("Ingrese la conntraseña");
        Console.WriteLine("Debe tener al menos 8 caracteres, una mayúscula, un número y un carácter especial");
        string Contraseña = Console.ReadLine();
        bool TieneMayuscula = false;
        bool TieneNumero = false;
        bool TieneCaracterEspecial = false;

        for (int i = 0; i < Contraseña.Length; i++) 


        {
            char c = Contraseña[i];
            if (char.IsUpper(c))
                TieneMayuscula = true;
            else if (char.IsDigit(c))
                TieneNumero = true;
            else if (!char.IsLetterOrDigit(c))
                TieneCaracterEspecial = true;
        }
        if (Contraseña.Length >= 8 && TieneMayuscula && TieneNumero && TieneCaracterEspecial)
        {
            Console.WriteLine("Contraseña válida");
        }
        else
        {
            Console.WriteLine("Inválida: ");

            if (Contraseña.Length < 8)
                Console.WriteLine("falta longitud mínima ");
            if (!TieneMayuscula)
                Console.WriteLine("falta mayúscula ");
            if (!TieneNumero)
                Console.WriteLine("falta número ");
            if (!TieneCaracterEspecial)
                Console.WriteLine("falta carácter especial ");

        }
    }
}
