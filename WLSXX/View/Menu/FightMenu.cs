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
        private static Promotion _promotion;

        public static void SelectPromotion()
        {
            _promotion = null;

            var promotion = InputHelper.SelectPromotionAll();

            if (promotion == null)
            {
                MainMenu.ShowMainMenu();
            }
            else
            {
                _promotion = promotion;
                ShowMainMenu();
            }

        }

        public static void ShowMainMenu()
        {
            DisplayHelper.ClearScreen();
            Console.WriteLine("Match Type");
            Console.WriteLine("1. Singles Wrestling Match");
            Console.WriteLine("2. Back");

            var choice = Console.ReadKey();

            switch (choice.KeyChar)
            {
                case '1':
                    ShowSelectWrestlers();
                    break;
                case '2':
                    SelectPromotion();
                    break;
                default:
                    SelectPromotion();
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
            singlesMatch.Wrestler1.Wrestler = InputHelper.SelectWrestlerAll(_promotion.ID);
            Console.WriteLine("Select second wrestler");
            singlesMatch.Wrestler2.Wrestler = InputHelper.SelectWrestlerAll(_promotion.ID);

            singlesMatch.Wrestler1.HumanControlled = true;
            StatusHelper.SetStartingStatus(singlesMatch.Wrestler1);
            StatusHelper.SetStartingStatus(singlesMatch.Wrestler2);

            Match.Match.StartSinglesMatch(singlesMatch);
        }
    }
}
