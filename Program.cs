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

            List<int> myList = new List<int>(){19,59,1,3};

            int summaDeMetodo = Sum(myList);

            Console.WriteLine("Die Summe meiner Liste ist: " + summaDeMetodo);

          
        }

        static int Sum(List<int> toCalculate) 
        {
                int summe = 0;
            foreach(int value in toCalculate)
            {

                summe += value;


            }
           return summe;

        }

    }                   


} 
