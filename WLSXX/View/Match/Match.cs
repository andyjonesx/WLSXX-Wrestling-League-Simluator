using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model;

namespace WLSXX.View.Match
{
    public static class Match
    {
        public static void StartSinglesMatch(SinglesMatch singlesMatch)
        {
            singlesMatch.Wrestler1.Status.Position = Model.Enumerations.LocationEnum.Standing;
            singlesMatch.Wrestler2.Status.Position = Model.Enumerations.LocationEnum.Standing;

            do
            {
                TakeTurn(singlesMatch);
            } while (!singlesMatch.MatchOver);


        }

        public static void TakeTurn(SinglesMatch singlesMatch)
        {
            if (singlesMatch.Wrestler1.HumanControlled)
            {
                ShowActions(singlesMatch.Wrestler1, singlesMatch.Wrestler2);
            }
        }

        public static void ShowActions(ActiveWrestler currentWrestler, ActiveWrestler opponent)
        {
            
        }
    }
}
