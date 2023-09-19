using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        
          Console.WriteLine("Gebe mir eine Zahl");
          int Zahl = Convert.ToInt16(Console.ReadLine());
          string ergebnis = Fahren(Zahl);
          Console.WriteLine($"Das Auto {ergebnis}");

           
        } 

         /*
            // Passe die Methode "Fahren" so an, dass 
            //- bei einer Geschwindigkeit von 0 die Methode "steht" zurück gibt: Hinweis: return
            //- bei einer Geschwindigkeit von 1-10 "schleicht" zurück gibt
            //- bei einer Geschwindigkeit von 11-50 "fährt langsam" zurück gibt
            //- bei einer Geschwindigkeit von 51-100 "fährt schnell" zurück gibt
            //- bei einer Geschwindigkeit über 100 "rast" zurück gibt.

            //Bau die Ausgabe so, dass nach jedem Aufruf folgende Texte ausgegeben werden können. 
            //Das Auto steht.
            //Das Auto schleicht.
            //Das Auto fährt langsam.
            //Das Auto fährt schnell. 
            //Das Auto rast.
            */

        static string Fahren( int geschwindigkeit)
        {
            
            
            

            if(geschwindigkeit==0)
            {
                return "steht";
            }
            else if(geschwindigkeit>0 && geschwindigkeit<=10)
            {
                return "schleicht";
            }
            else if(geschwindigkeit>10 && geschwindigkeit<=50)
            {
                return "fährt langsam";
            }
            else if(geschwindigkeit>50 && geschwindigkeit<=100)
            {
                return "fährt schnell";
            }
            else if(geschwindigkeit>100)
            {
                return "rast";
            }
            else
            {
                return "Du hast ja kein Auto";

            }


            // geschwindigkeit = 0 "Steht"
            // geschwindigkeit >0<=10 "schleicht"
            // geschwindigkeit >10<51 "fährt langsam"
            // geschwindigkeit >50<101"fährt schnell"
            //geschwindigkeit>100 " rast"

            
        }
    }
}
                    
    
