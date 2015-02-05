using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model;
using WLSXX.Helpers;

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
            Move wrestler1Move = null;
            Move wrestler2Move = null;

            if (singlesMatch.Wrestler1.HumanControlled)
            {
                wrestler1Move = ActionHelper.DecideAction(singlesMatch.Wrestler1, singlesMatch.Wrestler2, singlesMatch.PromotionId);
            }
            if (singlesMatch.Wrestler1.HumanControlled)
            {
                wrestler2Move = ActionHelper.DecideAction(singlesMatch.Wrestler1, singlesMatch.Wrestler2, singlesMatch.PromotionId);
            }

        }

        public static void ShowActions(ActiveWrestler currentWrestler, ActiveWrestler opponent)
        {

        }
    }
}
