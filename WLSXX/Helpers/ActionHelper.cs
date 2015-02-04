using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model;
using WLSXX.DataAccess;

namespace WLSXX.Helpers
{
    public static class ActionHelper
    {
        public static Move DecideAvailableActions(ActiveWrestler currentWrestler, ActiveWrestler opponent)
        {
            return GetPossibleActions(currentWrestler, opponent)[0];
        }

        public static List<Move> GetPossibleActions(ActiveWrestler currentWrestler, ActiveWrestler opponent)
        {
            var possibleMoves = MoveManager.GetMovesByPosition(currentWrestler.Status.Position, opponent.Status.Position);

            return possibleMoves;
            
        }


    }
}
