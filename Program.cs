﻿namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe mir deinen Namen!");
            string name = Console.ReadLine();

            Console.WriteLine("Sage mir wie alt bist du");
            string age = Console.ReadLine();
            int alter = Convert.ToInt16(age);
            int alterInZehn = alter+ 10;
            
            Console.WriteLine("Hello, " + name + " Dein Alter ist "+ age + " In Zehn jahren bist du " + alterInZehn);
        }
    }
}