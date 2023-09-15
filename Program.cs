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
            Console.WriteLine("Plus, minus, division, multiplication");
            string signo = Console.ReadLine();

            



            switch (signo)
            {

                case "-":
                    Substract(numero1,numero2);
                    break;

                case "+":
                    Addition(numero1,numero2);
                    break;

                case "/":
                    Division(numero1,numero2);
                    break;

                case "*":
                    Multiplicate(numero1,numero2);
                    break;
                default:
                    Console.WriteLine("Wrong operator");
                    break;
            }

        }

        static int AdditionWithReturn(string zahl1, string zahl2){

            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            
            return numero1 + numero2;

        }

         static int SubstractWithReturn(string zahl1, string zahl2){

            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            
            return numero1 - numero2;

        }


         static int MultiplicateWithReturn(string zahl1, string zahl2){

            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            
            return numero1 * numero2;

        }


         static int DivisionWithReturn(string zahl1, string zahl2){

            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            
            return numero1 / numero2;

        }




        static void Addition(string zahl1, string zahl2){

            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 + numero2);

        }

        static void Substract(string zahl1, string zahl2){

            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 - numero2);

        }
        static void Division(string zahl1, string zahl2){

            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 / numero2);

        }

        static void Multiplicate(string zahl1, string zahl2){

            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 * numero2);

        }

        static void Addition(int zahl1, int zahl2)         
        {
            Console.WriteLine(zahl1 + zahl2);
        } 

        static void Substract(int zahl1, int zahl2)         
        {
            Console.WriteLine(zahl1 - zahl2);
        } 

        static void Division(int zahl1, int zahl2)         
        {
            Console.WriteLine(zahl1 / zahl2);
        } 

        static void Multiplicate(int zahl1, int zahl2)         
        {
            Console.WriteLine(zahl1 * zahl2);
        } 
    }
}
                    
    
