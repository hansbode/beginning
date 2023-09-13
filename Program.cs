using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] emails = new string[] {
                    "hans.bode@tecalliance.net",
                    "abc@tecalliance.net",
                    "quertz@tecalliance.net"

           };
           foreach(string email in emails){
                Console.WriteLine($"Die Email lautet: {email}");

           }
           for(int position=0;position< emails.Length; position++)
           {
                Console.WriteLine($"Die Email lautet: {emails[position]}");

           }
             

        }
    }
}