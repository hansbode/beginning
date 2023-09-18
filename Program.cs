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

          Console.WriteLine("Gebe mir eine Zahl und ich werde bis dieser Zahl die Fibonaccii Reihe machen");
            int numeroFibo = Convert.ToInt32(Console.ReadLine());
            int fib1 = 1;
            int fib2 = 1;
            int ergebnis = 0;
            

            while(numeroFibo>(fib1+fib2))
            {
                    ergebnis = fib1 +fib2;
                    Console.WriteLine($"Ergebnis {fib1} + {fib2} = {ergebnis}");
                    fib1 = fib2;
                    fib2 = ergebnis;
            };
           // 65 = 65,63->0



           
        } 
    }
}
                    
    
