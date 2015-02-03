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

        public static void ShowSinglesMatchHealth(SinglesMatch singlesMatch)
        {
            Console.Write(singlesMatch.Wrestler1.Wrestler.Nickname + ": ");

            Console.Write(singlesMatch.Wrestler2.Wrestler.Nickname + ": ");
        }
    }
}
