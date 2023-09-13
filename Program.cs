using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> myNumberList = new List<int>();

           Console.WriteLine("Sage mir wie viele Zahlen du in deine Liste hinzufügen möcht");
           int amountNumbers = Convert.ToInt32(Console.ReadLine());

           while(myNumberList.Count < amountNumbers)
           {
                Console.WriteLine("Gebe mir eine Zahl");
                myNumberList.Add(Convert.ToInt32(Console.ReadLine()));

           }

           //Suma de todos los numeros

           int ergebnis = 0;
           foreach(int Zahl in myNumberList)
           {
            ergebnis += Zahl;
           }

           Console.WriteLine($"Das Ergebnis ist {ergebnis}");
             

        }
    }
}