using System;
using System.Collections.Generic;

namespace C_kennis
{
    class Program
    { 

        struct mp3speler
        {
            public int intID, intMBSize, intVoorraad;
            public string strMake, strModel;
            public double dblPrice;
        }

        static List<mp3speler> mp3list = new List<mp3speler>
        {
                    new mp3speler() {intID = 1, strMake= "GET technologies .inc", strModel = "HF 410", intMBSize = 4096, dblPrice = 129.95, intVoorraad =  500},
                    new mp3speler() {intID = 2, strMake= "Far & Loud", strModel = "XM 600", intMBSize = 8192, dblPrice = 224.95, intVoorraad =  500},
                    new mp3speler() {intID = 3, strMake= "Innotivative", strModel = "Z3", intMBSize = 512, dblPrice = 79.95, intVoorraad =  500},
                    new mp3speler() {intID = 4, strMake= "Resistance S.A.", strModel = "3001", intMBSize = 4096, dblPrice = 124.95, intVoorraad =  500},
                    new mp3speler() {intID = 5, strMake= "CBA", strModel = "NXT volume", intMBSize = 2048, dblPrice = 159.05, intVoorraad =  500},
        };
        public static void nieuwemp3()
        {
            for (int i = 0; i < mp3list.Count; i++)
            {
                Console.WriteLine("\nID = {0}", mp3list[i].intID);
                Console.WriteLine("Merk = {0}", mp3list[i].strMake);
                Console.WriteLine("Model = {0}", mp3list[i].strModel);
                Console.WriteLine("Capaciteit = {0}", mp3list[i].intMBSize);
                Console.WriteLine("Prijs = {0}", mp3list[i].dblPrice);
            }
        }

        public static void showVoorraad()
        {
            for (int i = 0; i < mp3list.Count; i++)
            {
                Console.Write("\nID: " + mp3list[i].intID);
                Console.Write("\nVoorraad: " + mp3list[i].intVoorraad + " stuks\n");
            }
            Console.WriteLine("Druk op 8 om terug te keren naar het menu.");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.D8) { ShowMenu(); }
    }
        public static void ShowMenu()
        {
            //Declaratie van de variabelen
            string strGekozenMenu;
            
            Console.WriteLine("SoundSharp\n");
            Console.WriteLine("1. Overzicht mp3 spelers");
            Console.WriteLine("2. Overzicht voorraad");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");
            Console.WriteLine("7. ");
            Console.WriteLine("8. Toon menu");
            Console.WriteLine("9. Exit");

            Console.WriteLine("Kies een menu door het getal in te voeren: ");
            strGekozenMenu = Console.ReadKey().KeyChar.ToString();

            switch (strGekozenMenu)
            {
                case "1":
                    nieuwemp3();
                    break;
                case "2":
                    showVoorraad();
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
