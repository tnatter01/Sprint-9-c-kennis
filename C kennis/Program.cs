using System;

namespace C_kennis
{
    class Program
    { 
        public static void ShowMenu()
        {
            //Declaratie van de variabelen
            string strGekozenMenu;
            
            Console.WriteLine("SoundSharp\n");
            Console.WriteLine("1. Overzicht mp3 spelers");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");
            Console.WriteLine("7. ");
            Console.WriteLine("8. ");
            Console.WriteLine("9. Exit");

            Console.Write("Kies een menu door het getal in te voeren: ");
            strGekozenMenu = Console.ReadKey().KeyChar.ToString();

            switch (strGekozenMenu)
            {
                case "1":
                    Console.WriteLine("\ngekozen actie: 1. Overzicht mp3 spelers");
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    Console.WriteLine("\ngekozen actie: 9. Exit");
                    break;
                default:
                    Console.WriteLine("\nOngeldige keuze");
                    return;
                    break;
            }
        }

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
                            Console.WriteLine("Welkom bij SoundSharp " + strNaam);
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
            ShowMenu();
            Login();
            Console.ReadLine();
        }
    }
}
