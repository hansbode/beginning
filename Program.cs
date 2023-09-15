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


            Console.WriteLine("Wähle deine Zahl");
             int numeroSuerte = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            int randomN = random.Next(0, 101);


            while(randomN!=numeroSuerte)
            {
               
                if(numeroSuerte>randomN)
                {
                    Console.WriteLine($"Deine Nummmer {numeroSuerte} ist größer als die random Nummer");

                }
                else if(numeroSuerte<randomN)
                {
                    Console.WriteLine($"Deine Nummer {numeroSuerte} ist kleiner als die random Nummer");

                }
                numeroSuerte = Convert.ToInt32(Console.ReadLine());
            }

             if(randomN==numeroSuerte)
                {
                        Console.WriteLine($"Du hast gewonnen  mit Nummer {numeroSuerte}");
                }
          
        } 
    }
}
                    
    
