using System;

namespace C_kennis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            string naam;

            //Naam opvragen
            Console.Write("Geef je naam op: ");
            naam = Console.ReadLine();

            //Resultaat weergeven
            Console.WriteLine("Welkom bij SoundSharp " + naam);
            Console.ReadLine();
        }
    }
}
