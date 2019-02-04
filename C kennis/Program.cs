using System;

namespace C_kennis
{
    class Program
    {

        public static void Login()
        {
            //Declaratie van de variabelen
            const string strWachtwoord = "SHARPSOUND";
            string strNaam, strInputWachtwoord;
            int intPoging = 1;

            //Naam opvragen
            Console.Write("Geef je naam op: ");
            strNaam = Console.ReadLine();

            //Welkomstbericht weergeven
            do
            {
                switch (intPoging)
                {
                    case 1:
                        //Wachtwoord opvragen
                        Console.Write("Voer het wachtwoord in: ");
                        strInputWachtwoord = Console.ReadLine();

                        if (strInputWachtwoord == strWachtwoord)
                        {
                            Console.WriteLine("Welkom bij SoundSharp " + strNaam);
                            return;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Password is onjuist.");
                            Console.ResetColor();
                            intPoging++;
                            break;
                        }

                    case 2:
                        Console.WriteLine("Poging " + intPoging + " van 3");
                        Console.Write("Voer het wachtwoord in: ");
                        strInputWachtwoord = Console.ReadLine();
                        if (strInputWachtwoord == strWachtwoord)
                        {
                            Console.WriteLine("Welkom bij SoundSharp " + strNaam);
                            return;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Password is onjuist.");
                            Console.ResetColor();
                            intPoging++;
                            break;
                        }

                    case 3:
                        Console.WriteLine("Poging " + intPoging + " van 3");
                        Console.WriteLine("LET OP: Laatste poging! \nVoer het wachtwoord in: ");
                        strInputWachtwoord = Console.ReadLine();
                        if (strInputWachtwoord == strWachtwoord)
                        {
                            Console.WriteLine("Correct wachtwoord");
                            Console.WriteLine("U bent ingelogd");
                            return;
                            break;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Password is onjuist.");
                            Console.ResetColor();
                            break;
                        }

                }
            }

            while (intPoging < 4);
        }
        static void Main(string[] args)
        {
            Login();
            Console.ReadLine();
        }
    }
}
