internal class Program
{
    private static void Main()
    {
        Console.WriteLine("== DIAS DE LA SEMANA ==");
        Console.Write("Ingrese un numero (1-7): ");
        // Variables
        int dia;
        //dato al usuario
        dia = Convert.ToInt32(Console.ReadLine());

        // Lógica de decisión
        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;

            case 3:
                Console.WriteLine("Miércoles");
                break;

            case 4:
                Console.WriteLine("Jueves");
                break;

            case 5:
                Console.WriteLine("Viernes");
                break;

            case 6:
                Console.WriteLine("Sábado");
                break;

            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Digite un numero del 1 al 7");
                break;
        }
    }
}