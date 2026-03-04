using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("=================================================");
        Console.WriteLine("                  Ejercicio 3");
        Console.WriteLine("=================================================");

        Console.WriteLine("1: Vegetariana");
        Console.WriteLine("2: No Vegetariana");
        Console.Write("Seleccione una opción: ");

        int opcionPizza = int.Parse(Console.ReadLine());
        string ingrediente = "";

        if (opcionPizza == 1)
        {
            Console.WriteLine("1: Pimiento");
            Console.WriteLine("2: Tofu");
            Console.Write("Elija un ingrediente: ");

            int opcionIng = int.Parse(Console.ReadLine());

            if (opcionIng == 1)
            {
                ingrediente = "Pimiento";
            }
            else
            {
                if (opcionIng == 2)
                {
                    ingrediente = "Tofu";
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                    return;
                }
            }

            Console.WriteLine("Pizza Vegetariana con Mozzarella, Tomate y " + ingrediente);
        }
        else
        {
            if (opcionPizza == 2)
            {
                Console.WriteLine("1: Peperoni");
                Console.WriteLine("2: Jamón");
                Console.WriteLine("3: Salmón");
                Console.Write("Elija un ingrediente: ");

                int opcionIng = int.Parse(Console.ReadLine());

                if (opcionIng == 1)
                {
                    ingrediente = "Peperoni";
                }
                else
                {
                    if (opcionIng == 2)
                    {
                        ingrediente = "Jamón";
                    }
                    else
                    {
                        if (opcionIng == 3)
                        {
                            ingrediente = "Salmón";
                        }
                        else
                        {
                            Console.WriteLine("Opción inválida.");
                            return;
                        }
                    }
                }

                Console.WriteLine("Pizza No Vegetariana con Mozzarella, Tomate y " + ingrediente);
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }

    }
}