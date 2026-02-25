// Librería:
// Permite utilizar funcionalidades básicas del sistema,
// como mostrar mensajes y leer datos del usuario.
using System;
// Espacio de nombres:
// Se utiliza para organizar el código del programa.
namespace Laboratorio3
{
    // Clase principal del programa
    class Program
    {
        // Método principal:
        // Punto de inicio de la ejecución del programa.
        static void Main(string[] args)
        {
            Console.Write("Este mensaje se muestra ");
            Console.WriteLine("en la misma línea.");
            Console.WriteLine("Este mensaje aparece en una nueva línea.")
            string nombre;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            // Uso de la variable en una salida
            Console.WriteLine("Nombre del estudiante " + nombre);

            // Mensaje informativo
            Console.WriteLine("Presione cualquier tecla para continuar...");
            // ReadKey:
            // Espera a que el usuario presione una tecla.
            // No requiere presionar Enter.
            Console.ReadKey();
            // El programa finaliza después de presionar una tecla
        }
    }
}