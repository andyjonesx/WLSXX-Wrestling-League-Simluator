using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model;

namespace WLSXX.Helpers
{
    public static class CalculationHelper
    {
        public static int CalculateUpperChanceOfMoveHappening(ActiveWrestler wrestler, Move move)
        {
            //todo apply damage
            int baseUpperChance = 1;

            if (wrestler.Status.Stunned)
            {
                //adjust for stun    
            }

        }

        public static int CalculateUpperChanceOfMoveSuccess(ActiveWrestler wrestler, Move move)
        {
            //todo flesh all this out
            int baseUpperChance = 1;

            if (wrestler.Status.Stunned)
            {
                //adjust for stun    
            }

            baseUpperChance += wrestler.Status.Stamina;
            baseUpperChance += CalculateAttributeAdjustment(wrestler, move);

            return baseUpperChance;
        }

        public static int CalculateUpperChanceOfMoveDefend(ActiveWrestler wreslter, Move move)
        {
            //todo flesh this out
            int baseUpperChance = 1;

            return baseUpperChance;
        }

        public static int CalculateSelfDamage(ActiveWrestler wrestler, Move move)
        {
            //todo apply damage
            return 0;
        }

        public static int CalculateDamage(ActiveWrestler attackingWrestler, ActiveWrestler defendingWrestler, Move move)
        {
            //todo apply damage
            return 10;
        }

        private static int CalculateAttributeAdjustment(ActiveWrestler wrestler, Move move)
        {
            int attributeAdjustment = 0;

            if (wrestler.Wrestler.Attributes.Aerial < move.RecommendedAttributes.Aerial)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.Aerial - move.RecommendedAttributes.Aerial;
            }
            if (wrestler.Wrestler.Attributes.Agility < move.RecommendedAttributes.Agility)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.Agility - move.RecommendedAttributes.Agility;
            }
            if (wrestler.Wrestler.Attributes.Brawling < move.RecommendedAttributes.Brawling)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.Brawling - move.RecommendedAttributes.Brawling;
            }
            if (wrestler.Wrestler.Attributes.Cheating < move.RecommendedAttributes.Cheating)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.Cheating - move.RecommendedAttributes.Cheating;
            }
            if (wrestler.Wrestler.Attributes.Conditioning < move.RecommendedAttributes.Conditioning)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.Conditioning - move.RecommendedAttributes.Conditioning;
            }
            if (wrestler.Wrestler.Attributes.Intelligence < move.RecommendedAttributes.Intelligence)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.Intelligence - move.RecommendedAttributes.Intelligence;
            }
            if (wrestler.Wrestler.Attributes.MatWrestling < move.RecommendedAttributes.MatWrestling)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.MatWrestling - move.RecommendedAttributes.MatWrestling;
            }
            if (wrestler.Wrestler.Attributes.Quickness < move.RecommendedAttributes.Quickness)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.Quickness - move.RecommendedAttributes.Quickness;
            }
            if (wrestler.Wrestler.Attributes.Aerial < move.RecommendedAttributes.Aerial)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.Aerial - move.RecommendedAttributes.Aerial;
            }
            if (wrestler.Wrestler.Attributes.Strength < move.RecommendedAttributes.Strength)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.Strength - move.RecommendedAttributes.Strength;
            }
            if (wrestler.Wrestler.Attributes.Teamwork < move.RecommendedAttributes.Teamwork)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.Teamwork - move.RecommendedAttributes.Teamwork;
            }
            if (wrestler.Wrestler.Attributes.Technical < move.RecommendedAttributes.Technical)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.Technical - move.RecommendedAttributes.Technical;
            }
            if (wrestler.Wrestler.Attributes.Toughness < move.RecommendedAttributes.Toughness)
            {
                attributeAdjustment += wrestler.Wrestler.Attributes.Toughness - move.RecommendedAttributes.Toughness;
            }

            return attributeAdjustment;
        }
    }
}
