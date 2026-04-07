using System.ComponentModel;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("CalcBasic");
        Console.WriteLine("***MENÚ DE OPCIONES***");
        int num1;
        int num2;
        int opc;
        //Opciones       
        Console.WriteLine("1-Suma");
        Console.WriteLine("2-Resta");
        Console.WriteLine("3-Multiplicación");
        Console.WriteLine("4-División");
        Console.WriteLine("Digite la opción");
        opc= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite dos valores numericos");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        //Operacion
        switch (opc)
        {
            case 1:
                Console.WriteLine("La suma es:" + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("La suma es: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("La multiplicación es " + (num1 * num2));
                break;
            case 4:
                Console.WriteLine("La división es " + (num1 / num2));
                break;
            default:
                Console.WriteLine("Digite un número del 1 al 4");
                break;


        }
        
    }
}