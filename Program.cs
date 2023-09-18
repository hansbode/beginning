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

          string mis = "MissiSsiPpi";

          
            mis = mis.ToLower();
           int amountM = mis.Count(m => m == 'M' || m == 'm');
           int amountI = mis.Count(i => i == 'I' || i == 'i');
           int amountP = mis.Count(p => p == 'P' || p == 'p');
           int amountS = mis.Count(s => s == 'S' || s == 's');
          Console.WriteLine($"In Wort {mis} kommt M: {amountM}, I:{amountI};  P:{amountP}, S:{amountS}");
          

           // contar cuantas veces viene una letra en la oracion 



           
        } 
    }
}
                    
    
