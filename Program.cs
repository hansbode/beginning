namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe mir eine Zahl");
            string ersteZahl = Console.ReadLine();
            int numero = Convert.ToInt16(ersteZahl);

            

            Console.WriteLine("Gebe mir ein zweiten Zahl");
            string zweiterZahl = Console.ReadLine();
            int numero2 = Convert.ToInt16(zweiterZahl);

            int ergebnis = numero + numero2;

            Console.WriteLine($"Du hast  zu erst  {ersteZahl}  zweitens:  + {zweiterZahl} und das Ergebnis ist {ergebnis}");

        }
    }
}