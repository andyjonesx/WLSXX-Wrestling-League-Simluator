using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model;

namespace WLSXX.Helpers
{
    public static class DisplayHelper
    {
        public static void ClearScreen()
        {
            Console.Clear();
        }

        public static void DisplayWrestlerAttributes(Attributes attributes)
        {
            Console.WriteLine("ATTRIBUTES");
            Console.WriteLine("Agility: " + attributes.Agility);
            Console.WriteLine("Intelligence: " + attributes.Intelligence);
            Console.WriteLine("Strength: " + attributes.Strength);
            Console.WriteLine("Toughness: " + attributes.Toughness);
            Console.WriteLine("Conditioning: " + attributes.Conditioning);
            Console.WriteLine("Brawling: " + attributes.Brawling);
            Console.WriteLine("Technical: " + attributes.Technical);
            Console.WriteLine("Cheating: " + attributes.Cheating);
            Console.WriteLine("Mat Wrestling: " + attributes.MatWrestling);
            Console.WriteLine("Aerial: " + attributes.Aerial);
            Console.WriteLine("Quickness: " + attributes.Quickness);
            Console.WriteLine("Teamwork: " + attributes.Teamwork);
            Console.WriteLine("Face: " + attributes.Face);
            Console.WriteLine("Heel: " + attributes.Heel);
        }

        public static void ShowSinglesMatchHealth(SinglesMatch singlesMatch)
        {
            Console.Write(singlesMatch.Wrestler1.Wrestler.Nickname + ": ");

            Console.Write(singlesMatch.Wrestler2.Wrestler.Nickname + ": ");
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            for (int i = 0; i < Console.WindowWidth; i++)
                Console.Write(" ");
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static void ClearLastConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(0, currentLineCursor - 1);
        }
    }
}
