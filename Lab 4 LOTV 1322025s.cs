using System;

class Program
{
    static void Main()
    { 
        // Ejercicio 1: Registro de Nave Espacial
        Console.WriteLine("=== Registro de la Nave ===");

        string modelo = "X-Wing";
        int capacidadCarga = 500;
        float nivelCombustible = 78.5f;
        bool motorSaltoActivo = true;

        Console.WriteLine("Modelo: " + modelo +
                          " | Capacidad: " + capacidadCarga +
                          " kg | Combustible: " + nivelCombustible +
                          "% | Motor activo: " + motorSaltoActivo);


        // Ejercicio 2: Expansión de Memoria 
        Console.WriteLine("\n=== Expansión de Memoria ===");

        short sensoresActivos = 128;
        int registroProcesador = sensoresActivos;   
        double precisionTotal = registroProcesador;

        Console.WriteLine("Precisión total: " + precisionTotal);


        // Ejercicio 3: Ajuste de Energía
        Console.WriteLine("\n=== Ajuste de Energía ===");

        double energiaGenerada = 987.65;
        int energiaLimitada = (int)energiaGenerada;

        Console.WriteLine("Energía original: " + energiaGenerada);
        Console.WriteLine("Energía limitada: " + energiaLimitada);


        // Ejercicio 4: Recepción de Coordenadas 
        Console.WriteLine("\n=== Recepción de Coordenadas ===");

        Console.Write("Ingresar la distancia del planeta más cercano: ");
        string entradaRadar = Console.ReadLine();

        int distancia = int.Parse(entradaRadar);
        int distanciaSegura = distancia + 100;

        Console.WriteLine("Distancia con margen de seguridad: " + distanciaSegura);


        // Ejercicio 5: Panel de Control 
        Console.WriteLine("\n=== Panel de Control ===");

        string señalOxigeno = "true";
        bool oxigenoActivo = Convert.ToBoolean(señalOxigeno);

        string temperaturaCabina = "22.8";
        double temperatura = Convert.ToDouble(temperaturaCabina);

        Console.WriteLine("Oxígeno activo: " + oxigenoActivo);
        Console.WriteLine("Temperatura cabina: " + temperatura);


        // Ejercicio 6: Reporte de Misión 
        Console.WriteLine("\n=== Reporte de Misión ===");

        double velocidadLuz = 299792.458;

        string velocidadTexto = velocidadLuz.ToString();
        string velocidadFormateada = velocidadLuz.ToString("N3");

        Console.WriteLine("Velocidad (texto): " + velocidadTexto);
        Console.WriteLine("Velocidad formateada: " + velocidadFormateada);

        // Ejercicio 7: Calculadora de Suministros
        Console.WriteLine("\n=== Calculadora de Suministros ===");

        Console.Write("Ingrese el precio por galón de Litio: ");
        string precioTexto = Console.ReadLine();

        double precio = Convert.ToDouble(precioTexto);

        double impuesto = precio * 0.12;
        double total = precio + impuesto;

        int totalEntero = (int)total;

        Console.WriteLine("El costo final de suministro es: " + totalEntero);


        // Ejercicio 8: BONUS ASCII
        Console.WriteLine("                 .\"-,.__");
        Console.WriteLine("                 `.     `.  ,");
        Console.WriteLine("              .--'  .._,'\"-\"' `.");
        Console.WriteLine("             .    .'         `'");
        Console.WriteLine("             `.   /          ,'");
        Console.WriteLine("               `  '--.   ,-\"'");
        Console.WriteLine("                `\"`   |  \\");
        Console.WriteLine("                   -. \\, |");
        Console.WriteLine("                    `--Y.'      ___.");
        Console.WriteLine("                         \\     L._, \\");
        Console.WriteLine("               _.,        `.   <  <\\\\                _");
        Console.WriteLine("             ,' '           `, `.   | \\\\            ( `");
        Console.WriteLine("          ../, `.            `  |    .\\\\`.           \\\\ \\_");
        Console.WriteLine("         ,' ,..  .           _.,'    ||\\\\l            )  \"'.");
        Console.WriteLine("        , ,'   \\           ,'.-.`-._,'  |           .  _._`.");
        Console.WriteLine("      ,' /      \\ \\        `' ' `--/   | \\\\          / /   ..\\");
        Console.WriteLine("    .'  /        \\ .         |\\\\__ - _ ,'` `        / /     `.`.");
        Console.WriteLine("    |  '          ..         `-...-\"  |  `-'      / /        . `.");
        Console.WriteLine("    | /           |L__           |    |          / /          `. `.");
        Console.WriteLine("   , /            .   .          |    |         / /             ` `");
        Console.WriteLine("  / /          ,. ,`._ `-_       |    |  _   ,-' /               ` \\");
        Console.WriteLine(" / .           \"`_/. `-_ \\_,.  ,'    +-' `-'  _,        ..,-.    \\`.");
        Console.WriteLine(".  '         .-f    ,'   `    '.       \\__.---'     _   .'   '     \\ \\");
        Console.WriteLine("' /          `.'    l     .' /          \\..      ,_|/   `.  ,'`     L`");
        Console.WriteLine("|'      _.-\"\"` `.    \\ _,'  `            \\ `.___`.\"`-.  , |   |    | \\");
        Console.WriteLine("||    ,'      `. `.   '       _,...._        `  |    `/ '  |   '     .|");
        Console.WriteLine("||  ,'          `. ;.,.---' ,'       `.   `.. `-'  .-' /_ .'    ;_   ||");
        Console.WriteLine("|| '              V      / /           `   | `   ,'   ,' '.    !  `. ||");
        Console.WriteLine("||/            _,-------7 '              . |  `-'    l         /    `||");
        Console.WriteLine(". |          ,' .-   ,' ||               | .-.        `.      .'     ||");
        Console.WriteLine(" `'        ,'    `\".'    |               |    `.        '. -.'       `'");
        Console.WriteLine("          /      ,'      |               |,'    \\-.._,.'/'");
        Console.WriteLine("          .     /        .               .       \\    .''");
        Console.WriteLine("        .`.    |         `.             /         :_,'.'");
        Console.WriteLine("          \\ `...\\   _     ,'-.        .'         /_.-'");
        Console.WriteLine("           `-.__ `,  `'   .  _.>----''.  _  __  /");
        Console.WriteLine("                .'        /\"'          |  \"'   '_");
        Console.WriteLine("               /_|.-'\\ ,\".             '.'`__'-( \\");
        Console.WriteLine("                 / ,\"'\"\\,'               `/  `-.|\"");

        Console.WriteLine("");
        Console.WriteLine("CHARIZARD - POKEMON FUEGO");
        Console.WriteLine("¡Listos para pasar los parciales!");
    }
}