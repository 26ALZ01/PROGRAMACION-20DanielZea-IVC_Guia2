using System;

class Program
{
    static void Main()
    {
        string l;

        // Interfaz de usuario
        Console.WriteLine("*** MENÚ DE CALIFICACIONES ***");
        Console.Write("Ingrese una letra (A, B, C, D o F): ");

        // Leemos la entrada y la convertimos a mayúsculas de una vez
        l = Console.ReadLine().ToUpper();

        // Estructura Switch
        switch (l)
        {
            case "A":
                Console.WriteLine("Resultado: Excelente");
                break;
            case "B":
                Console.WriteLine("Resultado: Bueno");
                break;
            case "C":
                Console.WriteLine("Resultado: Regular");
                break;
            case "D":
                Console.WriteLine("Resultado: Deficiente");
                break;
            case "F":
                Console.WriteLine("Resultado: Reprobado");
                break;
            default:
                Console.WriteLine("Error: Letra no válida.");
                break;
        }

        // Esperar a que el usuario presione una tecla para cerrar
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}