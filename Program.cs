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


            Console.WriteLine("Gebe mir eine Zahl");
            int numero1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Gebe mir eine Zahl");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            
            
            int ergebnis = numero1% numero2;


            Console.WriteLine($"Die Division von {numero1} und {numero2} erzeugt den Rest {ergebnis}");
           
        } 
    }
}
                    
    
