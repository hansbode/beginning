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

            Console.WriteLine("Wie viele Zahlen willst du in dein Array haben?");
            string eingabe = Console.ReadLine();
            int groese = Convert.ToInt32(eingabe);
            int [] myArray = new int[groese];

            for( int position = 0; position<groese; position++)
            {
                Console.WriteLine("Gebe mir einen Nummer");
                string eingegebenerNummer = Console.ReadLine();
                myArray[position] = Convert.ToInt32(eingegebenerNummer);
                

            }

            int maxNumber = myArray.Max();
            int minNumber = myArray.Min();
            double average = myArray.Average();


            
            




          Console.WriteLine($"Du hast {eingabe}  Zahlen gewählt, die kleinste Zahl ist {minNumber} und die größte ist {maxNumber}");
           
        } 
    }
}
                    
    
