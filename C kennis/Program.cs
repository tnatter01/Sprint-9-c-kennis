using System;
using System.Collections.Generic;

namespace C_kennis
{
    class Program
    { 

        struct mp3speler
        {
            public int intID, intMBSize;
            public string strMake, strModel;
            public double dblPrice;
        }

        static List<mp3speler> mp3list = new List<mp3speler>
        {
                    new mp3speler() {intID = 1, strMake= "GET technologies .inc", strModel = "HF 410", intMBSize = 4096, dblPrice = 129.95},
                    new mp3speler() {intID = 2, strMake= "Far & Loud", strModel = "XM 600", intMBSize = 8192, dblPrice = 224.95},
                    new mp3speler() {intID = 3, strMake= "Innotivative", strModel = "Z3", intMBSize = 512, dblPrice = 79.95},
                    new mp3speler() {intID = 4, strMake= "Resistance S.A.", strModel = "3001", intMBSize = 4096, dblPrice = 124.95},
                    new mp3speler() {intID = 5, strMake= "CBA", strModel = "NXT volume", intMBSize = 2048, dblPrice = 159.05},
        };
        public static void nieuwemp3()
        {
            

            mp3speler[] array =
                new mp3speler[]
                {
                    new mp3speler() {intID = 1, strMake= "GET technologies .inc", strModel = "HF 410", intMBSize = 4096, dblPrice = 129.95},
                    new mp3speler() {intID = 2, strMake= "Far & Loud", strModel = "XM 600", intMBSize = 8192, dblPrice = 224.95},
                    new mp3speler() {intID = 3, strMake= "Innotivative", strModel = "Z3", intMBSize = 512, dblPrice = 79.95},
                    new mp3speler() {intID = 4, strMake= "Resistance S.A.", strModel = "3001", intMBSize = 4096, dblPrice = 124.95},
                    new mp3speler() {intID = 5, strMake= "CBA", strModel = "NXT volume", intMBSize = 2048, dblPrice = 159.05},
                };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nID = {0}", array[i].intID);
                Console.WriteLine("Merk = {0}", array[i].strMake);
                Console.WriteLine("Model = {0}", array[i].strModel);
                Console.WriteLine("Capaciteit = {0}", array[i].intMBSize);
                Console.WriteLine("Prijs = {0}", array[i].dblPrice);
            }
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
