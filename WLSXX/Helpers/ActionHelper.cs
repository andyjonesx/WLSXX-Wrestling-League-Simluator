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
                return DecideAction(currentWrestler, opponent, promotionId);
            }

            return null;
        }

        private static List<Move> GetPossibleActions(ActiveWrestler currentWrestler, ActiveWrestler opponent, Guid promotionId)
        {
            var possibleMoves = MoveManager.GetMovesByPosition(currentWrestler.Status.Position, opponent.Status.Position, promotionId);

            return possibleMoves;
        }

        public static MatchRound CalculateActionEffects(MatchRound currentRound, ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            Move successfulMove = null;
            ActiveWrestler attackingWrestler = null;
            ActiveWrestler defendingWrestler = null;

            if (currentRound.SuccessfulWrestler == 1)
            {
                successfulMove = currentRound.Wrestler1Move;
                attackingWrestler = wrestler1;
                defendingWrestler = wrestler2;
            }
            else if (currentRound.SuccessfulWrestler == 2)
            {
                successfulMove = currentRound.Wrestler2Move;
                attackingWrestler = wrestler2;
                defendingWrestler = wrestler1;
            }

            if (CheckMoveSuccess(attackingWrestler, defendingWrestler, successfulMove))
            {
                if (successfulMove.CanStun)
                {
                    defendingWrestler.Status.Stunned = CheckApplyStun(attackingWrestler, defendingWrestler, successfulMove);
                }

                if (successfulMove.CanSubmit)
                {
                    currentRound.SubmissionAttempt = CheckApplySubmission(attackingWrestler, defendingWrestler, successfulMove);

                    if (currentRound.SubmissionAttempt)
                    {
                        currentRound.SubmissionSuccessful = ApplySubmission(attackingWrestler, defendingWrestler, successfulMove);
                    }
                }

                if (successfulMove.CanPin)
                {
                    currentRound.PinAttempt = CheckApplyPin(attackingWrestler, defendingWrestler, successfulMove);

                    if (currentRound.SubmissionAttempt)
                    {
                        currentRound.PinSuccessful = ApplyPin(attackingWrestler, defendingWrestler, successfulMove);
                    }
                }
            }

            return currentRound;
        }

        public static int DecideSuccessfulMove(MatchRound currentRound, ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            //todo weigh up statistics of each wrester, and risk of the move, and return which wrestler performed their move
            return 1;
        }

        private static bool CheckMoveSuccess(ActiveWrestler attackingWrestler, ActiveWrestler defendingWrestler, Move move)
        {
            //todo check if move worked
            return true;
        }

        private static void ApplyDamage(ref ActiveWrestler attackingWrestler, ref ActiveWrestler defendingWrestler, Move move)
        {
            //todo apply damage
        }

        private static bool CheckApplyStun(ActiveWrestler attackingWrestler, ActiveWrestler defendingWrestler, Move move)
        {
            //todo check apply stun
        }

        private static bool ApplyStun(ActiveWrestler attackingWrestler, ActiveWrestler defendingWrestler, Move move)
        {
            //todo apply stun
        }

        private static bool CheckApplySubmission(ActiveWrestler attackingWrestler, ActiveWrestler defendingWrestler, Move move)
        {
            //todo apply submission
        }

        private static bool ApplySubmission(ActiveWrestler attackingWrestler, ActiveWrestler defendingWrestler, Move move)
        {
            //todo apply submission
        }

        private static bool CheckApplyPin(ActiveWrestler attackingWrestler, ActiveWrestler defendingWrestler, Move move)
        {
            //todo apply pin
        }

        private static bool ApplyPin(ActiveWrestler attackingWrestler, ActiveWrestler defendingWrestler, Move move)
        {
            //todo apply pin
        }
    }
}
