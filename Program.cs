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
            //Aufgabe 9: Frage den Nutzer nach einer Eingabe mit Semikolons ( ; ) und Splitte die Eingabe an diesem Zeichen. Gebe die einzelnen Werte auf der Console aus.
            // lo de los emails de ayer darlos cuando se separan por medio de puntocoma y hacerlos una fila para abajo
            Console.WriteLine("Schreibe einen Text");
                       string[] text = new string[] {

                            


                       };
             
                      foreach(string email in text){
                            Console.WriteLine($"Die Email lautet: {email}");
           }

                      for(int position=0;position< text.Length; position++)
                                          {
                             Console.WriteLine($"Die Email lautet: {text[position]}");
                                        }

            
        }
    }
}