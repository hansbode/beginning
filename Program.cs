using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
                //Aufgabe 4: Lasse den Nutzer eine Zahl eingeben und gebe nur die geraden Zahlen aus.

            //           (Hinweis: Modulo operator. => Geteilt durch 2,

            //                  wenn der Rest 0 ist, ist die Zahl gerade)

              Console.WriteLine($"Bitte Zahl 1 eingeben!");
            int zahl1=Convert.ToInt16(Console.ReadLine());

            for(int i=0;i<=zahl1;i++)
            {
                
                if(i%2==0&&i!=0)
                {
                    Console.WriteLine($"{i}");
                }
                           }
    }
}
    }