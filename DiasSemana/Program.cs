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
            if (sePudoConvertir && dia >=1 && dia <=7) 
            {
                Console.WriteLine(sePudoConvertir + " " + dia);
            }

            
        }
    }
}
