using System;
namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            string nombre_del_curso;
            Console.Write("Ingrese el nombre del curso: ");
            nombre_del_curso = Console.ReadLine();

            Console.WriteLine("Muy bien " + nombre);
            Console.WriteLine("Vas con una buena nota en " + nombre_del_curso);
            Console.WriteLine("Sigue asi y pasaras el curso con una excelente calificacion");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}