using System;

namespace C_kennis
{
    class Program
    { 

        struct mp3speler
        {
            public int intID;
            public string strMake;
            public string strModel;
            public int intMBSize;
            public double dblPrice;
        }

        public static void nieuwemp3()
        {
            mp3speler mp3_1;
            mp3_1.intID = 1;
            mp3_1.strMake = "GET technologies .inc";
            mp3_1.strModel = "HF 410";
            mp3_1.intMBSize = 4096;
            mp3_1.dblPrice = 129.95;

            Console.WriteLine("\nID: " + mp3_1.intID);
            Console.WriteLine("Merk: " + mp3_1.strMake);
            Console.WriteLine("Model: " + mp3_1.strModel);
            Console.WriteLine("MB Size: " + mp3_1.intMBSize);
            Console.WriteLine("Price: " + mp3_1.dblPrice);
        }
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

            Console.WriteLine("Kies een menu door het getal in te voeren: ");
            strGekozenMenu = Console.ReadKey().KeyChar.ToString();

            switch (strGekozenMenu)
            {
                case "1":
                    nieuwemp3();
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
                            ShowMenu();
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
                            ShowMenu();
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
                            ShowMenu();
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
