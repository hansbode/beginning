using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 8: Frage den Nutzer nach einer Texteingabe und fülle diese mit bis zu 20 Stellen mit einem y von links auf
            // escribir un texto que siempre sea de 20 letras y las letras que faltan le sume una y
            Console.WriteLine("Schreibe einen Text");
            string textito = Console.ReadLine();
            string texto2 = textito.PadRight(20, 'y');
            
             
           
            



            Console.WriteLine($"Die neue text Variante lautet: {texto2} ");
        }
    }
}