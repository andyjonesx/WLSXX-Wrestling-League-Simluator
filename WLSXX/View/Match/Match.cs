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

            //finalise the match
        }

        public static void TakeTurn(SinglesMatch singlesMatch)
        {
            singlesMatch.CurrentRound = new MatchRound();
            singlesMatch.CurrentRound.RoundNumber = singlesMatch.CurrentRoundNumber + 1;

            if (singlesMatch.Wrestler1.HumanControlled)
            {
                singlesMatch.CurrentRound.Wrestler1Move = ActionHelper.DecideAction(singlesMatch.Wrestler1, singlesMatch.Wrestler2, singlesMatch.PromotionId);
            }

            if (singlesMatch.Wrestler1.HumanControlled)
            {
                singlesMatch.CurrentRound.Wrestler2Move = ActionHelper.DecideAction(singlesMatch.Wrestler1, singlesMatch.Wrestler2, singlesMatch.PromotionId);
            }

            singlesMatch.CurrentRound.SuccessfulWrestler = ActionHelper.DecideSuccessfulMove(singlesMatch.CurrentRound, singlesMatch.Wrestler1, singlesMatch.Wrestler2);

            singlesMatch.CurrentRound = ActionHelper.CalculateActionEffects(singlesMatch.CurrentRound, singlesMatch.Wrestler1, singlesMatch.Wrestler2);

            singlesMatch.Rounds.Add(new MatchRound
            {
                Damage = singlesMatch.CurrentRound.Damage,
                PinAttempt = singlesMatch.CurrentRound.PinAttempt,
                PinSuccessful = singlesMatch.CurrentRound.PinSuccessful,
                RoundNumber = singlesMatch.CurrentRound.RoundNumber,
                SelfDamage = singlesMatch.CurrentRound.SelfDamage,
                SubmissionAttempt = singlesMatch.CurrentRound.SubmissionAttempt,
                SubmissionSuccessful = singlesMatch.CurrentRound.SubmissionSuccessful,
                SuccessfulWrestler = singlesMatch.CurrentRound.SuccessfulWrestler,
                Wrestler1Move = singlesMatch.CurrentRound.Wrestler1Move,
                Wrestler2Move = singlesMatch.CurrentRound.Wrestler2Move
            });

            if (singlesMatch.CurrentRound.PinSuccessful || singlesMatch.CurrentRound.SubmissionSuccessful)
            {
                singlesMatch.MatchOver = true;
            }

            singlesMatch.CurrentRound = null;
        }

    }
}
