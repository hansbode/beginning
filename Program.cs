using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 5: Lasse den Nutzer eine Zahl eingeben und berechne von dieser Zahl die Fakultät.

              static void Main(string[] args)
        {   
            Console.WriteLine($"Bitte Zahl 1 eingeben!");
            int zahl1=Convert.ToInt16(Console.ReadLine());

 

            int ergebnis=1;            

            for(int i=1;i<=zahl1;i++)
            {
                ergebnis=ergebnis*i;
            }
            Console.WriteLine($"{ergebnis}");
        } 
    }
}
    }