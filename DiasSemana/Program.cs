namespace DiasSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un número");
            string dato = Console.ReadLine();

            int dia = 0;
            bool sePudoConvertir = false;
            sePudoConvertir = int.TryParse(dato, out dia);
            if (sePudoConvertir)
            {
                switch (dia)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        break;
                    case 3:
                        Console.WriteLine("Miercoles");
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Sabado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                    default:
                        Console.WriteLine("$Dato incorrecto (switch): {dato}");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"El dato introducido es incorrecto: {dato}");
            }

        }
    }
}
