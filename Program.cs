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

          Console.WriteLine("Schreibe ein Text die durch ';' geteilt wird");
          string texto = Console.ReadLine();
          texto.Split(";");
          string[]  myArray = texto.Split(';');

          foreach(string textito in myArray)
          {
            Console.WriteLine(texto);
          }

          for(int index=0; index < myArray.Length; index++)
          {

            Console.WriteLine(myArray[index]);
          }


          //Split

           
            
            

          

           // sacar cuanto tiempo hay, si son 190s sean 3min con 10s



           
        } 
    }
}
                    
    
