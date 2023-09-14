using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
                 //Aufgabe 1: Initialisiere 2 Zahlen und gebe die Summe auf der Console aus

                 Console.WriteLine("Gebe mir eine Zahl");
                 string ersteZahl = Console.ReadLine();

                 Console.WriteLine("Gebe mir eine andere Zahl");
                 string zweiteZahl = Console.ReadLine();


                 int nummer1 = Convert.ToInt16(zweiteZahl);
                 int nummer2 = Convert.ToInt16(ersteZahl);

                 int ergebnis = nummer1 +nummer2;


                 Console.WriteLine($"Deine erste Zahl ist {ersteZahl} und deine zweite {zweiteZahl} und die Summe zwishcen beide ist {ergebnis}");


           
           }

           
        
    }
}