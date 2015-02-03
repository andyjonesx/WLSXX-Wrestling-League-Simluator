using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Helpers;
using WLSXX.Model;

namespace WLSXX.View.Menu
{
    public static class FightMenu
    {
        public static void ShowMainMenu()
        {
            DisplayHelper.ClearScreen();
            Console.WriteLine("FIGHT MENU");
            Console.WriteLine("1. Singles Wrestling Match");
            Console.WriteLine("2. Back");

            var choice = Console.ReadKey();

            switch (choice.KeyChar)
            {
                case '1':
                    ShowSelectWrestlers();
                    break;
                case '2':
                    View.Menu.MainMenu.ShowMainMenu();
                    break;
                default:
                    View.Menu.MainMenu.ShowMainMenu();
                    break;
            }
        }

        public static void ShowSelectWrestlers()
        {
            SinglesMatch singlesMatch = new SinglesMatch();
            singlesMatch.Wrestler1 = new ActiveWrestler();
            singlesMatch.Wrestler2 = new ActiveWrestler();

            DisplayHelper.ClearScreen();
            Console.WriteLine("SINGLES MATCH");
            Console.WriteLine("Select first wrestler");
            singlesMatch.Wrestler1.Wrestler = InputHelper.SelectWrestlerAll();
            Console.WriteLine("Select second wrestler");
            singlesMatch.Wrestler2.Wrestler = InputHelper.SelectWrestlerAll();

            singlesMatch.Wrestler1.HumanControlled = true;
            StatusHelper.SetStartingStatus(singlesMatch.Wrestler1);
            StatusHelper.SetStartingStatus(singlesMatch.Wrestler2);

            Match.Match
        }
    }
}
