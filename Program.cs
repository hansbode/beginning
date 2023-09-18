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

            Console.WriteLine("Schreibe einen Text wie du willst");
            string textito = Console.ReadLine();
    	    

            string[] splittedtext = textito.Split("h");

            int largo = textito.Length;




          Console.WriteLine($"Dein Text ist {largo} lang und enthält die Buchstabe h {splittedtext.Length -1} mal");
           
        } 
    }
}
                    
    
