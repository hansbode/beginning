using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
                 //Aufgabe 3: Lasse den Nutzer eine Zahl eingeben und gebe alle Zahlen

            //           bis einschließlich der eingegeben Zahl aus

              Console.WriteLine("Gebe mir eine Zahl und ich werde bis dieser zahlen");
                int zahl1 = Convert.ToInt32(Console.ReadLine());
                

                           for(int zaehlvariable=0;zaehlvariable<=zahl1;zaehlvariable++){

                           
                                            Console.WriteLine(zaehlvariable);

           
                           }
    }
}
}