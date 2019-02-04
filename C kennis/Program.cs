using System;

namespace C_kennis
{
    class Program
    {

        public static void Login()
        {
            //Declaratie van de variabelen
            const string strWachtwoord = "SHARPSOUND";
            string strNaam;
            string strInputWachtwoord;

            //Naam opvragen
            Console.Write("Geef je naam op: ");
            strNaam = Console.ReadLine();

            //Wachtwoord opvragen
            Console.Write("Geef je wachtwoord op: ");
            strInputWachtwoord = Console.ReadLine();

            //Welkomstbericht weergeven
            switch (strInputWachtwoord)
            {
                case (strWachtwoord):
                    Console.WriteLine("Welkom bij SoundSharp " + strNaam);
                    break;
                default:
                    Console.WriteLine("Password is onjuist.");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Login();
            Console.ReadLine();
        }
    }
}
