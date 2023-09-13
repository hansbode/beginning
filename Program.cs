using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
             int zahl1 = 25;
             int zahl2 = 45;

             int ergebnis1 = zahl1 + zahl2;
             Console.WriteLine(ergebnis1);
             int ergebnis2 = zahl1 - zahl2;
             Console.WriteLine(ergebnis2);

             int ergebnis3 = zahl1 * zahl2;
             Console.WriteLine(ergebnis3);

             int ergebnis4 = zahl1 / zahl1;
             Console.WriteLine(ergebnis4);

             int ergebnis5 = zahl1*zahl1-zahl1*zahl1;
             Console.WriteLine(ergebnis5);

             int ergebnis6 = zahl2 % zahl1;
             Console.WriteLine(ergebnis6);


            zahl2++;
            Console.WriteLine(zahl2);

            zahl1--;
            Console.WriteLine(zahl1);

             Console.WriteLine(zahl2%zahl1);
            // C# Operators (w3schools.com)   link para poder hacer tantas operaciones como se me ronque la gana 
         

        }
    }
}