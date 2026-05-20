using System;

// ======
// CLASE 
// ======

class Parcela
{
    public string cultivo;
    public int mesesCrecimiento;
    public int mesesActual;
    public bool regada;

    public Parcela()
    {
        cultivo = "Vacia";
        mesesCrecimiento = 0;
        mesesActual = 0;
        regada = false;
    }
}

// ==============================
// ALGORITMO SIMULADOR DE GRANJA
// ==============================

class Program
{
    static void Main()
    {

        Console.WriteLine("======================================");
        Console.WriteLine("        PROYECTO 2 - LOTV");
        Console.WriteLine("   SIMULADOR DE GRANJA EN CONSOLA");
        Console.WriteLine("======================================");

        // ==========
        // VARIABLES
        // ==========

        int dinero = 0;
        int empleados = 0;
        int sueldo = 0;
        int meses = 0;

        int filas = 0;
        int columnas = 0;

        int opcion = 0;

        int totalIngresos = 0;
        int totalEgresos = 0;
        int totalRiegos = 0;

        int parcelasVacias = 0;

        // ===============
        // VALIDAR DINERO
        // ===============

        do
        {
            Console.Write("Ingrese dinero inicial: ");

            if (int.TryParse(Console.ReadLine(), out dinero))
            {
                if (dinero <= 0)
                {
                    Console.WriteLine("El dinero debe ser mayor a 0");
                }
            }
            else
            {
                Console.WriteLine("No se permiten letras");
                dinero = 0;
            }

        } while (dinero <= 0);

        // ==================
        // VALIDAR EMPLEADOS
        // ==================

        do
        {
            Console.Write("Ingrese cantidad de empleados: ");

            if (int.TryParse(Console.ReadLine(), out empleados))
            {
                if (empleados < 0)
                {
                    Console.WriteLine("Cantidad inválida");
                }
            }
            else
            {
                Console.WriteLine("No se permiten letras");
                empleados = -1;
            }

        } while (empleados < 0);

        // ===============
        // VALIDAR SUELDO
        // ===============

        do
        {
            Console.Write("Ingrese sueldo por empleado: ");

            if (int.TryParse(Console.ReadLine(), out sueldo))
            {
                if (sueldo < 0)
                {
                    Console.WriteLine("Sueldo inválido");
                }
            }
            else
            {
                Console.WriteLine("No se permiten letras");
                sueldo = -1;
            }

        } while (sueldo < 0);

        // ==============
        // VALIDAR MESES
        // ==============

        do
        {
            Console.Write("Ingrese meses a simular: ");

            if (int.TryParse(Console.ReadLine(), out meses))
            {
                if (meses <= 0)
                {
                    Console.WriteLine("Debe ingresar mínimo 1 mes");
                }
            }
            else
            {
                Console.WriteLine("No se permiten letras");
                meses = 0;
            }

        } while (meses <= 0);

        // ==============
        // VALIDAR FILAS
        // ==============

        do
        {
            Console.Write("Ingrese filas (máximo 10): ");

            if (int.TryParse(Console.ReadLine(), out filas))
            {
                if (filas <= 0 || filas > 10)
                {
                    Console.WriteLine("Solo se permiten entre 1 y 10 filas");
                }
            }
            else
            {
                Console.WriteLine("No se permiten letras");
                filas = 0;
            }

        } while (filas <= 0 || filas > 10);

        // =================
        // VALIDAR COLUMNAS
        // =================

        do
        {
            Console.Write("Ingrese columnas (máximo 10): ");

            if (int.TryParse(Console.ReadLine(), out columnas))
            {
                if (columnas <= 0 || columnas > 10)
                {
                    Console.WriteLine("Solo se permiten entre 1 y 10 columnas");
                }
            }
            else
            {
                Console.WriteLine("No se permiten letras");
                columnas = 0;
            }

        } while (columnas <= 0 || columnas > 10);

        // =======
        // MATRIZ 
        // =======

        Parcela[,] granja = new Parcela[10, 10];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                granja[i, j] = new Parcela();
            }
        }

        // =====
        // MENÚ
        // =====

        do
        {
            Console.WriteLine("======================================");
            Console.WriteLine("          PROYECTO 2 - LOTV");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Sembrar");
            Console.WriteLine("2. Regar parcela");
            Console.WriteLine("3. Consultar parcela");
            Console.WriteLine("4. Avanzar mes");
            Console.WriteLine("5. Salir");
            Console.WriteLine("======================================");

            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("No se permiten letras");
                opcion = 0;
            }

            switch (opcion)
            {
                // =========
                // SEMBRAR
                // =========

                case 1:

                    int filaSembrar = 0;
                    int columnaSembrar = 0;
                    int cultivo = 0;

                    Console.Write("Ingrese fila: ");

                    if (int.TryParse(Console.ReadLine(), out filaSembrar))
                    {
                        Console.Write("Ingrese columna: ");

                        if (int.TryParse(Console.ReadLine(), out columnaSembrar))
                        {
                            if (filaSembrar >= 0 && filaSembrar < filas &&
                                columnaSembrar >= 0 && columnaSembrar < columnas)
                            {
                                if (granja[filaSembrar, columnaSembrar].cultivo == "Vacia")
                                {
                                    Console.WriteLine("1. Papa");
                                    Console.WriteLine("2. Tomate");
                                    Console.WriteLine("3. Fresa");

                                    Console.Write("Seleccione cultivo: ");

                                    if (int.TryParse(Console.ReadLine(), out cultivo))
                                    {
                                        switch (cultivo)
                                        {
                                            case 1:

                                                granja[filaSembrar, columnaSembrar].cultivo = "Papa";
                                                granja[filaSembrar, columnaSembrar].mesesCrecimiento = 2;

                                                break;

                                            case 2:

                                                granja[filaSembrar, columnaSembrar].cultivo = "Tomate";
                                                granja[filaSembrar, columnaSembrar].mesesCrecimiento = 3;

                                                break;

                                            case 3:

                                                granja[filaSembrar, columnaSembrar].cultivo = "Fresa";
                                                granja[filaSembrar, columnaSembrar].mesesCrecimiento = 4;

                                                break;

                                            default:

                                                Console.WriteLine("Cultivo inválido");

                                                break;
                                        }

                                        Console.WriteLine("Cultivo sembrado");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se permiten letras");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("La parcela ya está ocupada");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Posición inválida");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se permiten letras");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se permiten letras");
                    }

                    break;

                // ======
                // REGAR
                // ======

                case 2:

                    int filaRegar = 0;
                    int columnaRegar = 0;

                    Console.Write("Ingrese fila: ");

                    if (int.TryParse(Console.ReadLine(), out filaRegar))
                    {
                        Console.Write("Ingrese columna: ");

                        if (int.TryParse(Console.ReadLine(), out columnaRegar))
                        {
                            if (filaRegar >= 0 && filaRegar < filas &&
                                columnaRegar >= 0 && columnaRegar < columnas)
                            {
                                if (granja[filaRegar, columnaRegar].cultivo != "Vacia")
                                {
                                    if (granja[filaRegar, columnaRegar].regada == false)
                                    {
                                        if (dinero >= 40)
                                        {
                                            granja[filaRegar, columnaRegar].regada = true;

                                            dinero = dinero - 40;

                                            totalEgresos = totalEgresos + 40;

                                            totalRiegos++;

                                            Console.WriteLine("Parcela regada");
                                        }
                                        else
                                        {
                                            Console.WriteLine("No tiene suficiente dinero");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("La parcela ya fue regada");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("La parcela está vacía");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Posición inválida");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se permiten letras");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se permiten letras");
                    }

                    break;


                case 3:

                    int filaConsulta = 0;
                    int columnaConsulta = 0;

                    Console.Write("Ingrese fila: ");

                    if (int.TryParse(Console.ReadLine(), out filaConsulta))
                    {
                        Console.Write("Ingrese columna: ");

                        if (int.TryParse(Console.ReadLine(), out columnaConsulta))
                        {
                            if (filaConsulta >= 0 && filaConsulta < filas &&
                                columnaConsulta >= 0 && columnaConsulta < columnas)
                            {
                                if (granja[filaConsulta, columnaConsulta].cultivo == "Vacia")
                                {
                                    Console.WriteLine("La parcela está vacía");
                                }
                                else
                                {
                                    Console.WriteLine("Cultivo: " +
                                        granja[filaConsulta, columnaConsulta].cultivo);

                                    Console.WriteLine("Crecimiento: " +
                                        granja[filaConsulta, columnaConsulta].mesesActual +
                                        "/" +
                                        granja[filaConsulta, columnaConsulta].mesesCrecimiento);

                                    if (granja[filaConsulta, columnaConsulta].regada == true)
                                    {
                                        Console.WriteLine("Regada este mes: Sí");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Regada este mes: No");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Posición inválida");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se permiten letras");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se permiten letras");
                    }

                    break;

                // ============
                // AVANZAR MES
                // ============

                case 4:

                    meses--;

                    int pago;

                    pago = empleados * sueldo;

                    dinero = dinero - pago;

                    totalEgresos = totalEgresos + pago;

                    Console.WriteLine("Pago empleados: Q" + pago);

                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            if (granja[i, j].cultivo != "Vacia")
                            {
                                if (granja[i, j].regada == true)
                                {
                                    granja[i, j].mesesActual =
                                        granja[i, j].mesesActual + 2;
                                }
                                else
                                {
                                    granja[i, j].mesesActual =
                                        granja[i, j].mesesActual + 1;
                                }

                                granja[i, j].regada = false;

                                if (granja[i, j].mesesActual >=
                                    granja[i, j].mesesCrecimiento)
                                {
                                    int ganancia = 0;

                                    switch (granja[i, j].cultivo)
                                    {
                                        case "Papa":

                                            ganancia = 450;

                                            break;

                                        case "Tomate":

                                            ganancia = 650;

                                            break;

                                        case "Fresa":

                                            ganancia = 900;

                                            break;
                                    }

                                    dinero = dinero + ganancia;

                                    totalIngresos = totalIngresos + ganancia;

                                    Console.WriteLine("Se cosechó: " +
                                        granja[i, j].cultivo);

                                    granja[i, j] = new Parcela();
                                }
                            }
                        }
                    }

                    Console.WriteLine("Mes avanzado");
                    Console.WriteLine("Dinero actual: Q" + dinero);

                    break;

                // ======
                // SALIR
                // ======

                case 5:

                    Console.WriteLine("Programa finalizado");

                    break;

                default:

                    Console.WriteLine("Opción inválida");

                    break;
            }

        } while (opcion != 5 && dinero > 0 && meses > 0);

        // ==============
        // REPORTE FINAL
        // ==============

        Console.WriteLine("======================================");
        Console.WriteLine("           REPORTE FINAL");
        Console.WriteLine("======================================");

        Console.WriteLine("Dinero final: Q" + dinero);

        Console.WriteLine("Total ingresos: Q" + totalIngresos);

        Console.WriteLine("Total egresos: Q" + totalEgresos);

        Console.WriteLine("Total riegos: " + totalRiegos);

        // =========================
        // CONTAR PARCELAS VACÍAS
        // =========================

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (granja[i, j].cultivo == "Vacia")
                {
                    parcelasVacias++;
                }
            }
        }

        Console.WriteLine("Parcelas vacías: " + parcelasVacias);

        Console.WriteLine("======================================");
        Console.WriteLine("             PROYECTO 2");
        Console.WriteLine("               LOTV");
        Console.WriteLine("======================================");
    }
}