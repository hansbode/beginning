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

                Console.WriteLine("Gebe mir  Zahl");
                string zahl1 =Console.ReadLine();  
                int numero1 = Convert.ToInt32(zahl1);
         

                Console.WriteLine("Gebe mir eine andere Zahl");
                string zahl2 =Console.ReadLine();  
                int numero2 = Convert.ToInt32(zahl2);

                Console.WriteLine("Plus oder minus");
                string signo = Console.ReadLine();

                if(signo == "+")
                {
                    Console.WriteLine(numero1+numero2);
                }
                else if(signo == "-")
                {
                    Console.WriteLine(numero1-numero2);
                }

         
          
          
          
        }


     }
 }                   
    
