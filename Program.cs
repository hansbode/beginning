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
           int user_Zahl = 0;
           do
            
                //code block
                
           {
                Console.WriteLine("Gebe mir eine Zahl");
                user_Zahl = Convert.ToInt32(Console.ReadLine());
                myNumberList.Add(user_Zahl);

           } while(user_Zahl > 0);

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