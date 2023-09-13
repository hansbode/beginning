using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           //List<int> myNumberList = new List<int>();

           Console.WriteLine("Sage mir bis zu welcher Zahl aufsummiert werden soll");
           int untilNumber = Convert.ToInt32(Console.ReadLine());

            int ergebnis = 0;
           for(int i = 0; i<=untilNumber; i++){

                ergebnis += i;
                Console.WriteLine($"Added Number  {i}, current result {ergebnis}");

           }

           
        }
    }
}