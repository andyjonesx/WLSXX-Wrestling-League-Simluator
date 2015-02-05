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
        public static Move DecideAction(ActiveWrestler currentWrestler, ActiveWrestler opponent, Guid promotionId)
        {
            var actions = GetPossibleActions(currentWrestler, opponent, promotionId);

            var options = new Dictionary<int, Move>();

            int i = 1;
            foreach (var move in actions)
            {
                options.Add(i, move);
                i++;
            }

            foreach (var option in options)
            {
                Console.WriteLine(option.Key.ToString() + ". " + option.Value.Name);
            }

            var choice = Console.ReadKey();

            int intChoice = -1;

            if (int.TryParse(choice.KeyChar.ToString(), out intChoice))
            {
                if (intChoice == 0)
                {
                    return null;
                }
                else
                {  
                    return options[intChoice];
                }
            }
            else
            {
                DecideAction(currentWrestler, opponent, promotionId);
            }

            return null;
        }

        private static List<Move> GetPossibleActions(ActiveWrestler currentWrestler, ActiveWrestler opponent, Guid promotionId)
        {
            var possibleMoves = MoveManager.GetMovesByPosition(currentWrestler.Status.Position, opponent.Status.Position, promotionId);

            return possibleMoves;
            
        }


    }
}
