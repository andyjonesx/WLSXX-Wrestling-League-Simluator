using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.View;
using WLSXX.Helpers;

namespace WLSXX.View.Menu
{
    public static class MainMenu
    {
        public static void ShowMainMenu()
        {
            DisplayHelper.ClearScreen();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("1. Manage Wrestlers");
            Console.WriteLine("2. Fight"); 
            Console.WriteLine("3. Exit");

            var choice = Console.ReadKey();

            switch (choice.KeyChar)
            {
                case '1':
                    View.Menu.WrestlerMenu.SelectPromotion();
                    break;
                case '2':
                    View.Menu.FightMenu.SelectPromotion();
                    break;
                case '3':
                    ShowExitMenu();
                    break;
                default:
                    ShowMainMenu();
                    break;
            }
        }

        public static void ShowExitMenu()
        {
            DisplayHelper.ClearScreen();
            Console.WriteLine("Thanks for playing!");
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
