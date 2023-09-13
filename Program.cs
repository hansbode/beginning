namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Gebe mir eine Zahl");
           string ersteZahl = Console.ReadLine();


           Console.WriteLine("Gebe mir ein andere Zahl");
           string zweiterZahl = Console.ReadLine();

           int nummer1 = Convert.ToInt16(ersteZahl);
           int nummer2 = Convert.ToInt16(zweiterZahl);
           

           int resultado = nummer1 - nummer2;

           Console.WriteLine($"Du hast zu erst {ersteZahl} danach {zweiterZahl} und die Subtraktion zwischen beide ist {resultado} ");

        }
    }
}