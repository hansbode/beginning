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


            Console.WriteLine("Wie viele Texte willst du in einem Array speichern.");
            int numero = Convert.ToInt32(Console.ReadLine());
            string[] myText = new string[numero];
           
           // Console.WriteLine($"Gebe mir die {numero} Texte die du willst");
          //  string textito = Console.ReadLine();

            for(int position=0; position<numero; position++)
            {
                Console.WriteLine("Gebe einen Text ein");
                string eingegebenertext = Console.ReadLine();
                myText[position] = eingegebenertext;
                string eingegebenerText2 = eingegebenertext.PadLeft(20, ' ');

                Console.WriteLine($"Es lautet {eingegebenerText2}");
            }

            

                    //string texto2 = textito.PadRight(20, 'y');
        } 
    }
}
                    
    
