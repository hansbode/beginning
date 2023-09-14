using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 7: Frage den Nutzer nach einem Text und ersetze im Text alle vorkommenden „U“ und „u“ durch „G“ und „g“

            Console.WriteLine("Schreibe einen Text");
            string textito = Console.ReadLine();
            string textito1 = textito.Replace("U", "G");
            string textito2 = textito1.Replace("u", "g");
            



            Console.WriteLine($"Die neue text Variante lautet: {textito2}");
        }
    }
}