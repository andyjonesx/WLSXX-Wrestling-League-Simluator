using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.DataAccess;
using WLSXX.Model;
using WLSXX.Model.Enumerations;
using WLSXX.View;
using WLSXX.Helpers;

namespace WLSXX.View.Menu
{
    public static class WrestlerMenu
    {
        public static void ShowMainMenu()
        {
            DisplayHelper.ClearScreen();
            Console.WriteLine("MANAGE WRESTLERS");
            Console.WriteLine("1. View Wrestlers");
            Console.WriteLine("2. Add Wrestler");
            Console.WriteLine("3. Back");
            var choice = Console.ReadKey();

            switch (choice.KeyChar)
            {
                case '1':
                    ShowViewWrestlers();
                    break;
                case '2':
                    ShowAddWrestler();
                    break;
                case '3':
                    MainMenu.ShowMainMenu();
                    break;
                default:
                    ShowMainMenu();
                    break;
            }
        }

        public static void ShowAddWrestler()
        {
            var wrestler = new Wrestler();

            DisplayHelper.ClearScreen();
            Console.WriteLine("ADD WRESTLER");

            wrestler.Name = InputHelper.GetString("Name: ");
            wrestler.Nickname = InputHelper.GetString("Nickname: ");
            wrestler.Gender = InputHelper.GetGender();

            Console.WriteLine("");
            Console.WriteLine("ATTRIBUTES");

            wrestler.Attributes = new Attributes();

            wrestler.Attributes.Strength = InputHelper.GetIntRating("Strength: ");
            wrestler.Attributes.Agility = InputHelper.GetIntRating("Agility: ");
            wrestler.Attributes.Intelligence = InputHelper.GetIntRating("Intelligence: ");
            wrestler.Attributes.Toughness = InputHelper.GetIntRating("Toughness: ");

            if (WrestlerManager.AddWrestler(wrestler))
            {
                ShowViewWrestlers();
            }
            else
            {
                Console.WriteLine("Adding wrestler failed. What do you want to do?");
                Console.WriteLine("1. Try again");
                Console.WriteLine("2. Go back to wrestlers list");

                var choice = Console.ReadKey();

                switch (choice.KeyChar)
                {
                    case '1':
                        ShowViewWrestlers();
                        break;
                    case '2':
                        ShowAddWrestler();
                        break;
                    default:
                        ShowViewWrestlers();
                        break;
                }
            }

        }

        public static void ShowViewWrestlers()
        {
            DisplayHelper.ClearScreen();
            Console.WriteLine("SHOW WRESTLERS");

            var wrestler = InputHelper.SelectWrestlerAll();

            if (wrestler != null)
            {
                ShowViewWrestler(wrestler);
            }
            else
            {
                ShowMainMenu();
            }
        }

        public static void ShowViewWrestler(Wrestler wrestler)
        {
            DisplayHelper.ClearScreen();
            Console.WriteLine("WRESTLER DETAILS");
            Console.WriteLine("Name: " + wrestler.Name);
            Console.WriteLine("Nickname: " + wrestler.Nickname);

            if (wrestler.Gender == GenderEnum.Male)
            {
                Console.WriteLine("Gender: Male");
            }
            else if (wrestler.Gender == GenderEnum.Female)
            {
                Console.WriteLine("Gender: Female");
            }

            Console.WriteLine("ATTRIBUTES");
            Console.WriteLine("Agility: " + wrestler.Attributes.Agility);
            Console.WriteLine("Intelligence: " + wrestler.Attributes.Intelligence);
            Console.WriteLine("Strength: " + wrestler.Attributes.Strength);
            Console.WriteLine("Toughness: " + wrestler.Attributes.Toughness);
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Edit");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Back");

            var choice = Console.ReadKey();

            switch (choice.KeyChar)
            {
                case '1':
                    ShowEditWrestler(wrestler.ID);
                    break;
                case '2':
                    ShowDeleteWrestler(wrestler.ID);
                    break;
                case '3':
                    ShowViewWrestlers();
                    break;
                default:
                    ShowViewWrestler(wrestler);
                    break;
            }
        }

        public static void ShowDeleteWrestler(Guid wrestlerId)
        {
            var wrestler = WrestlerManager.GetWrestlerByID(wrestlerId);

            DisplayHelper.ClearScreen();
            Console.WriteLine("DELETE WRESTER");
            Console.WriteLine("Are you sure you want to delete '" + wrestler.Name + "'? (y/n)");

            var choice = Console.ReadKey();

            switch (choice.KeyChar)
            {
                case 'y':
                    WrestlerManager.RemoveWrestler(wrestlerId);
                    ShowViewWrestlers();
                    break;
                case 'n':
                    ShowViewWrestler(wrestler);
                    break;
                default:
                    ShowDeleteWrestler(wrestlerId);
                    break;
            }
        }
    
        public static void ShowEditWrestler(Guid wrestlerId)
        {
            var wrestler = WrestlerManager.GetWrestlerByID(wrestlerId);

            DisplayHelper.ClearScreen();
            Console.WriteLine("WRESTLER DETAILS");
            Console.WriteLine("1. Name: " + wrestler.Name);
            Console.WriteLine("2. Nickname: " + wrestler.Nickname);

            if (wrestler.Gender == GenderEnum.Male)
            {
                Console.WriteLine("3. Gender: Male");
            }
            else if (wrestler.Gender == GenderEnum.Female)
            {
                Console.WriteLine("3. Gender: Female");
            }

            Console.WriteLine("ATTRIBUTES");
            Console.WriteLine("4. Agility: " + wrestler.Attributes.Agility);
            Console.WriteLine("5. Intelligence: " + wrestler.Attributes.Intelligence);
            Console.WriteLine("6. Strength: " + wrestler.Attributes.Strength);
            Console.WriteLine("7. Toughness: " + wrestler.Attributes.Toughness);
            Console.WriteLine();
            Console.WriteLine("8. Back");

            var choice = Console.ReadKey();

            switch (choice.KeyChar)
            {
                case '1':
                    wrestler.Name = InputHelper.GetString("New name: ");
                    WrestlerManager.UpdateWrestler(wrestler);
                    ShowEditWrestler(wrestlerId);
                    break;

                case '2':
                    wrestler.Name = InputHelper.GetString("New nickname: ");
                    WrestlerManager.UpdateWrestler(wrestler);
                    ShowEditWrestler(wrestlerId);
                    break;

                case '3':
                    wrestler.Gender = InputHelper.GetGender("New gender (M/F): ");
                    WrestlerManager.UpdateWrestler(wrestler);
                    ShowEditWrestler(wrestlerId);
                    break;

                case '4':
                    wrestler.Attributes.Agility = InputHelper.GetIntRating("Agility: ");
                    WrestlerManager.UpdateWrestler(wrestler);
                    ShowEditWrestler(wrestlerId);
                    break;

                case '5':
                    wrestler.Attributes.Intelligence = InputHelper.GetIntRating("Intelligence: ");
                    WrestlerManager.UpdateWrestler(wrestler);
                    ShowEditWrestler(wrestlerId);
                    break;

                case '6':
                    wrestler.Attributes.Strength = InputHelper.GetIntRating("Strength: ");
                    WrestlerManager.UpdateWrestler(wrestler);
                    ShowEditWrestler(wrestlerId);
                    break;

                case '7':
                    wrestler.Attributes.Toughness = InputHelper.GetIntRating("Toughness: ");
                    WrestlerManager.UpdateWrestler(wrestler);
                    ShowEditWrestler(wrestlerId);
                    break;

                case '8':
                    ShowViewWrestlers();
                    break;

                default:
                    ShowEditWrestler(wrestlerId);
                    break;
            }

        }
    }
}
