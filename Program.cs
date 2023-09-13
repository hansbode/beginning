using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //CultureInfo cu = new CultureInfo("en-us");                         esto es para que la coma se vuelva punto en idioma gringo
            //CultureInfo.CurrentCulture = cu;
            string Text = "Esto es freestyle";
            Console.WriteLine(Text);
            int zahl = 17;
            Console.WriteLine(zahl);
            double kommazahl =21.3;
            Console.WriteLine(kommazahl);
            float weiterFliesKomma = 24.34345345F;
            Console.WriteLine(weiterFliesKomma); 
            decimal flieskomma = 26.5M; 
            Console.WriteLine(flieskomma);
           
            bool wahrheitswert =true;
            Console.WriteLine(wahrheitswert);
            bool anders = false;
            Console.WriteLine(anders);

           char buchstabe = (char)42; 
           Console.WriteLine(buchstabe);

           long langezahl = 1234567891012345;
           Console.WriteLine(langezahl);

            uint positiveZahlen= 123;
            Console.WriteLine(positiveZahlen);



            string[] myArray = new string[10];
            myArray[0] = "erster Wert";
            myArray[9] = "letzter Wert";

            List<string> myList = new List<string>();
            
            myList.Add("Hans");
            myList.Add("Samayoa");

            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);

        }
    }
}