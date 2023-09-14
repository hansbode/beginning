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
            //Aufgabe 11: Frage den Nutzer nach einer Zahl und zähle von dieser Rückwärts bis 0

            Console.WriteLine("Gibt einfach eine Zahl");
            int numero = Convert.ToInt32(Console.ReadLine());


                for(int zaehlvariable=numero;zaehlvariable>=0;zaehlvariable--){

                    Console.WriteLine(zaehlvariable);
           }
            
        }
    }
}