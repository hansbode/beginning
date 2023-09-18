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

           Console.WriteLine("Gebe mir eine Nummer und werde Rückwarts zahlen bis 0");
           int numeroG = Convert.ToInt32(Console.ReadLine());

           for(int zaehlvariable=numeroG;zaehlvariable>=0;zaehlvariable--)
           {
            Console.WriteLine(zaehlvariable);
           }
          
           
        } 
    }
}
                    
    
