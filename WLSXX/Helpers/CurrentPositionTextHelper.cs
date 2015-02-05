using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model;
using WLSXX.Model.Enumerations;

namespace WLSXX.Helpers
{
    public static class CurrentPositionTextHelper
    {
        public static string GetDescriptionText(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            switch (wrestler1.Status.Position)
            {
                case LocationEnum.Standing:
                    return GetStanding(wrestler1, wrestler2);

                case LocationEnum.LockedUp:
                    return Get1LockedUp2LockedUp(wrestler1, wrestler2);

                case LocationEnum.Ground:
                    return GetGround(wrestler1, wrestler2);
                    
                case LocationEnum.Corner1:
                    return GetCorner1(wrestler1, wrestler2);

                case LocationEnum.Corner1Climbed:
                    return GetCorner1Climbed(wrestler1, wrestler2);

                case LocationEnum.Corner1Ground:
                    return GetCorner1Ground(wrestler1, wrestler2);

                case LocationEnum.Corner2:
                    return GetCorner2(wrestler1, wrestler2);

                case LocationEnum.Corner2Climbed:
                    return GetCorner2Climbed(wrestler1, wrestler2);

                case LocationEnum.Corner2Ground:
                    return GetCorner2Ground(wrestler1, wrestler2);

                case LocationEnum.OffRopes:
                    return GetOffRopes(wrestler1, wrestler2);

                case LocationEnum.OnRopes:
                    return GetOnRopes(wrestler1, wrestler2);

                case LocationEnum.OutsideRingGround:
                    return GetOutsideRingGround(wrestler1, wrestler2);

                case LocationEnum.OutsideRingStanding:
                    return GetOutsideRingStanding(wrestler1, wrestler2);

                default:
                    return "";
            }
        }


        private static string GetStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            switch (wrestler2.Status.Position)
            {
                case LocationEnum.Standing:
                    return Get1Standing2Standing(wrestler1, wrestler2);
                case LocationEnum.Corner1:
                    return Get1Standing2Corner1(wrestler1, wrestler2);
                case LocationEnum.Corner1Climbed:
                    return Get1Standing2Corner1Climbed(wrestler1, wrestler2);
                case LocationEnum.Corner1Ground:
                    return Get1Standing2Corner1Ground(wrestler1, wrestler2);
                case LocationEnum.Corner2:
                    return Get1Standing2Corner2(wrestler1, wrestler2);
                case LocationEnum.Corner2Climbed:
                    return Get1Standing2Corner2Climbed(wrestler1, wrestler2);
                case LocationEnum.Corner2Ground:
                    return Get1Standing2Corner2Ground(wrestler1, wrestler2);
                case LocationEnum.Ground:
                    return Get1Standing2Ground(wrestler1, wrestler2);
                case LocationEnum.OffRopes:
                    return Get1Standing2OffRopes(wrestler1, wrestler2);
                case LocationEnum.OnRopes:
                    return Get1Standing2OnRopes(wrestler1, wrestler2);
                case LocationEnum.OutsideRingGround:
                    return Get1Standing2OutsideRingGround(wrestler1, wrestler2);
                case LocationEnum.OutsideRingStanding:
                    return Get1Standing2OutsideRingStanding(wrestler1, wrestler2);
                default:
                    return "";
            }
        }

        private static string GetGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            switch (wrestler2.Status.Position)
            {
                case LocationEnum.Standing:
	                return Get1Standing2Ground(wrestler2, wrestler1);
                case LocationEnum.Corner1:
	                return Get1Ground2Corner1(wrestler1, wrestler2);
                case LocationEnum.Corner1Ground:
	                return Get1Ground2Corner1Ground(wrestler1, wrestler2);
                case LocationEnum.Corner1Climbed:
	                return Get1Ground2Corner1Climbed(wrestler1, wrestler2);
                case LocationEnum.Corner2:
	                return Get1Ground2Corner2(wrestler1, wrestler2);
                case LocationEnum.Corner2Climbed:
	                return Get1Ground2Corner2Climbed(wrestler1, wrestler2);
                case LocationEnum.Corner2Ground:
	                return Get1Ground2Corner2Ground(wrestler1, wrestler2);
                case LocationEnum.Ground:
	                return Get1Ground2Ground(wrestler1, wrestler2);
                case LocationEnum.OffRopes:
	                return Get1Ground2OffRopes(wrestler1, wrestler2);
                case LocationEnum.OnRopes:
	                return Get1Ground2OnRopes(wrestler1, wrestler2);
                case LocationEnum.OutsideRingGround:
	                return Get1Ground2OutsideRingGround(wrestler1, wrestler2);
                case LocationEnum.OutsideRingStanding:
	                return Get1Ground2OutsideRingStanding(wrestler1, wrestler2);
                default:
                    return "";
            }
        }

        private static string GetLockedUp(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            return Get1LockedUp2LockedUp(wrestler1, wrestler2);
        }

        private static string GetCorner1(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            switch (wrestler2.Status.Position)
            {
                case LocationEnum.Standing:
	                return Get1Standing2Corner1(wrestler2, wrestler1);
                case LocationEnum.Corner1:
	                return Get1Corner12Corner1(wrestler1, wrestler2);
                case LocationEnum.Corner1Ground:
	                return Get1Corner12Corner1Ground(wrestler1, wrestler2);
                case LocationEnum.Corner1Climbed:
	                return Get1Corner12Corner1Climbed(wrestler1, wrestler2);
                case LocationEnum.Corner2:
	                return Get1Corner12Corner2(wrestler1, wrestler2);
                case LocationEnum.Corner2Climbed:
	                return Get1Corner12Corner2Climbed(wrestler1, wrestler2);
                case LocationEnum.Corner2Ground:
	                return Get1Corner12Corner2Ground(wrestler1, wrestler2);
                case LocationEnum.Ground:
	                return Get1Ground2Corner1(wrestler2, wrestler1);
                case LocationEnum.OffRopes:
	                return Get1Corner12OffRopes(wrestler1, wrestler2);
                case LocationEnum.OnRopes:
	                return Get1Corner12OnRopes(wrestler1, wrestler2);
                case LocationEnum.OutsideRingGround:
	                return Get1Corner12OutsideRingGround(wrestler1, wrestler2);
                case LocationEnum.OutsideRingStanding:
	                return Get1Corner12OutsideRingStanding(wrestler1, wrestler2);
                default:
                    return "";
            }
        }

        private static string GetCorner1Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {

            switch (wrestler2.Status.Position)
            {
                case LocationEnum.Standing:
	                return Get1Standing2Corner1Climbed(wrestler2, wrestler1);
                case LocationEnum.Corner1:
	                return Get1Corner12Corner1Climbed(wrestler2, wrestler1);
                case LocationEnum.Corner1Ground:
                    return Get1Corner1Climbed2Corner1Ground(wrestler1, wrestler2);
                case LocationEnum.Corner1Climbed:
                    return Get1Corner1Climbed2Corner1Climbed(wrestler1, wrestler2);
                case LocationEnum.Corner2:
                    return Get1Corner1Climbed2Corner2(wrestler1, wrestler2);
                case LocationEnum.Corner2Climbed:
                    return Get1Corner1Climbed2Corner2Climbed(wrestler1, wrestler2);
                case LocationEnum.Corner2Ground:
                    return Get1Corner1Climbed2Corner2Ground(wrestler1, wrestler2);
                case LocationEnum.Ground:
	                return Get1Ground2Corner1Climbed(wrestler2, wrestler1);
                case LocationEnum.OffRopes:
                    return Get1Corner1Climbed2OffRopes(wrestler1, wrestler2);
                case LocationEnum.OnRopes:
                    return Get1Corner1Climbed2OnRopes(wrestler1, wrestler2);
                case LocationEnum.OutsideRingGround:
                    return Get1Corner1Climbed2OutsideRingGround(wrestler1, wrestler2);
                case LocationEnum.OutsideRingStanding:
                    return Get1Corner1Climbed2OutsideRingStanding(wrestler1, wrestler2);
                default:
                    return "";
            }
        }

        private static string GetCorner1Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            switch (wrestler2.Status.Position)
            {
                case LocationEnum.Standing:
                    return Get1Standing2Corner1Ground(wrestler2, wrestler1);
                case LocationEnum.Corner1:
                    return Get1Corner12Corner1Ground(wrestler2, wrestler1);
                case LocationEnum.Corner1Ground:
                    return Get1Corner1Ground2Corner1Ground(wrestler1, wrestler2);
                case LocationEnum.Corner1Climbed:
                    return Get1Corner1Climbed2Corner1Ground(wrestler2, wrestler1);
                case LocationEnum.Corner2:
                    return Get1Corner1Ground2Corner2(wrestler1, wrestler2);
                case LocationEnum.Corner2Climbed:
                    return Get1Corner1Ground2Corner2Climbed(wrestler1, wrestler2);
                case LocationEnum.Corner2Ground:
                    return Get1Corner1Ground2Corner2Ground(wrestler1, wrestler2);
                case LocationEnum.Ground:
                    return Get1Ground2Corner1Ground(wrestler2, wrestler1);
                case LocationEnum.OffRopes:
                    return Get1Corner1Ground2OffRopes(wrestler1, wrestler2);
                case LocationEnum.OnRopes:
                    return Get1Corner1Ground2OnRopes(wrestler1, wrestler2);
                case LocationEnum.OutsideRingGround:
                    return Get1Corner1Ground2OutsideRingGround(wrestler1, wrestler2);
                case LocationEnum.OutsideRingStanding:
                    return Get1Corner1Ground2OutsideRingStanding(wrestler1, wrestler2);
                default:
                    return "";
            }
        }

        private static string GetCorner2(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            switch (wrestler2.Status.Position)
            {
                case LocationEnum.Standing:
                    return Get1Standing2Corner2(wrestler2, wrestler1);
                case LocationEnum.Corner1:
                    return Get1Corner12Corner2(wrestler2, wrestler1);
                case LocationEnum.Corner1Ground:
                    return Get1Corner1Ground2Corner2(wrestler2, wrestler1);
                case LocationEnum.Corner1Climbed:
                    return Get1Corner1Climbed2Corner2(wrestler2, wrestler1);
                case LocationEnum.Corner2:
                    return Get1Corner22Corner2(wrestler1, wrestler2);
                case LocationEnum.Corner2Climbed:
                    return Get1Corner22Corner2Climbed(wrestler1, wrestler2);
                case LocationEnum.Corner2Ground:
                    return Get1Corner22Corner2Ground(wrestler1, wrestler2);
                case LocationEnum.Ground:
                    return Get1Ground2Corner2(wrestler2, wrestler1);
                case LocationEnum.OffRopes:
                    return Get1Corner22OffRopes(wrestler1, wrestler2);
                case LocationEnum.OnRopes:
                    return Get1Corner22OnRopes(wrestler1, wrestler2);
                case LocationEnum.OutsideRingGround:
                    return Get1Corner22OutsideRingGround(wrestler1, wrestler2);
                case LocationEnum.OutsideRingStanding:
                    return Get1Corner22OutsideRingStanding(wrestler1, wrestler2);
                default:
                    return "";
            }
        }

        private static string GetCorner2Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            switch (wrestler2.Status.Position)
            {
                case LocationEnum.Standing:
                    return Get1Standing2Corner2Climbed(wrestler2, wrestler1);
                case LocationEnum.Corner1:
                    return Get1Corner12Corner2Climbed(wrestler2, wrestler1);
                case LocationEnum.Corner1Ground:
                    return Get1Corner1Ground2Corner2Climbed(wrestler2, wrestler1);
                case LocationEnum.Corner1Climbed:
                    return Get1Corner1Climbed2Corner2Climbed(wrestler2, wrestler1);
                case LocationEnum.Corner2:
                    return Get1Corner22Corner2Climbed(wrestler2, wrestler1);
                case LocationEnum.Corner2Climbed:
                    return Get1Corner2Climbed2Corner2Climbed(wrestler1, wrestler2);
                case LocationEnum.Corner2Ground:
                    return Get1Corner2Climbed2Corner2Ground(wrestler1, wrestler2);
                case LocationEnum.Ground:
                    return Get1Ground2Corner2Climbed(wrestler2, wrestler1);
                case LocationEnum.OffRopes:
                    return Get1Corner2Climbed2OffRopes(wrestler1, wrestler2);
                case LocationEnum.OnRopes:
                    return Get1Corner2Climbed2OnRopes(wrestler1, wrestler2);
                case LocationEnum.OutsideRingGround:
                    return Get1Corner2Climbed2OutsideRingGround(wrestler1, wrestler2);
                case LocationEnum.OutsideRingStanding:
                    return Get1Corner2Climbed2OutsideRingStanding(wrestler1, wrestler2);
                default:
                    return "";
            }
        }

        private static string GetCorner2Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            switch (wrestler2.Status.Position)
            {
                case LocationEnum.Standing:
                    return Get1Standing2Corner2Ground(wrestler2, wrestler1);
                case LocationEnum.Corner1:
                    return Get1Corner12Corner2Ground(wrestler2, wrestler1);
                case LocationEnum.Corner1Ground:
                    return Get1Corner1Ground2Corner2Ground(wrestler2, wrestler1);
                case LocationEnum.Corner1Climbed:
                    return Get1Corner1Climbed2Corner2Ground(wrestler2, wrestler1);
                case LocationEnum.Corner2:
                    return Get1Corner22Corner2Ground(wrestler2, wrestler1);
                case LocationEnum.Corner2Climbed:
                    return Get1Corner2Climbed2Corner2Ground(wrestler2, wrestler1);
                case LocationEnum.Corner2Ground:
                    return Get1Corner2Ground2Corner2Ground(wrestler1, wrestler2);
                case LocationEnum.Ground:
                    return Get1Ground2Corner2Ground(wrestler2, wrestler1);
                case LocationEnum.OffRopes:
                    return Get1Corner2Ground2OffRopes(wrestler1, wrestler2);
                case LocationEnum.OnRopes:
                    return Get1Corner2Ground2OnRopes(wrestler1, wrestler2);
                case LocationEnum.OutsideRingGround:
                    return Get1Corner2Ground2OutsideRingGround(wrestler1, wrestler2);
                case LocationEnum.OutsideRingStanding:
                    return Get1Corner2Ground2OutsideRingStanding(wrestler1, wrestler2);
                default:
                    return "";
            }
        }

        private static string GetOffRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            switch (wrestler2.Status.Position)
            {
                case LocationEnum.Standing:
                    return Get1Standing2OffRopes(wrestler2, wrestler1);
                case LocationEnum.Corner1:
                    return Get1Corner12OffRopes(wrestler2, wrestler1);
                case LocationEnum.Corner1Ground:
                    return Get1Corner1Ground2OffRopes(wrestler2, wrestler1);
                case LocationEnum.Corner1Climbed:
                    return Get1Corner1Climbed2OffRopes(wrestler2, wrestler1);
                case LocationEnum.Corner2:
                    return Get1Corner22OffRopes(wrestler2, wrestler1);
                case LocationEnum.Corner2Climbed:
                    return Get1Corner2Climbed2OffRopes(wrestler2, wrestler1);
                case LocationEnum.Corner2Ground:
                    return Get1Corner2Ground2OffRopes(wrestler2, wrestler1);
                case LocationEnum.Ground:
                    return Get1Ground2OffRopes(wrestler2, wrestler1);
                case LocationEnum.OffRopes:
                    return Get1OffRopes2OffRopes(wrestler1, wrestler2);
                case LocationEnum.OnRopes:
                    return Get1OffRopes2OnRopes(wrestler1, wrestler2);
                case LocationEnum.OutsideRingGround:
                    return Get1OffRopes2OutsideRingGround(wrestler1, wrestler2);
                case LocationEnum.OutsideRingStanding:
                    return Get1OffRopes2OutsideRingStanding(wrestler1, wrestler2);
                default:
                    return "";
            }
        }

        private static string GetOnRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            switch (wrestler2.Status.Position)
            {
                case LocationEnum.Standing:
                    return Get1Standing2OnRopes(wrestler2, wrestler1);
                case LocationEnum.Corner1:
                    return Get1Corner12OnRopes(wrestler2, wrestler1);
                case LocationEnum.Corner1Ground:
                    return Get1Corner1Ground2OnRopes(wrestler2, wrestler1);
                case LocationEnum.Corner1Climbed:
                    return Get1Corner1Climbed2OnRopes(wrestler2, wrestler1);
                case LocationEnum.Corner2:
                    return Get1Corner22OnRopes(wrestler2, wrestler1);
                case LocationEnum.Corner2Climbed:
                    return Get1Corner2Climbed2OnRopes(wrestler2, wrestler1);
                case LocationEnum.Corner2Ground:
                    return Get1Corner2Ground2OnRopes(wrestler2, wrestler1);
                case LocationEnum.Ground:
                    return Get1Ground2OnRopes(wrestler2, wrestler1);
                case LocationEnum.OffRopes:
                    return Get1OffRopes2OnRopes(wrestler2, wrestler1);
                case LocationEnum.OnRopes:
                    return Get1OnRopes2OnRopes(wrestler1, wrestler2);
                case LocationEnum.OutsideRingGround:
                    return Get1OnRopes2OutsideRingGround(wrestler1, wrestler2);
                case LocationEnum.OutsideRingStanding:
                    return Get1OnRopes2OutsideRingStanding(wrestler1, wrestler2);
                default:
                    return "";
            }
        }

        private static string GetOutsideRingGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            switch (wrestler2.Status.Position)
            {
                case LocationEnum.Standing:
                    return Get1Standing2OutsideRingGround(wrestler2, wrestler1);
                case LocationEnum.Corner1:
                    return Get1Corner12OutsideRingGround(wrestler2, wrestler1);
                case LocationEnum.Corner1Ground:
                    return Get1Corner1Ground2OutsideRingGround(wrestler2, wrestler1);
                case LocationEnum.Corner1Climbed:
                    return Get1Corner1Climbed2OutsideRingGround(wrestler2, wrestler1);
                case LocationEnum.Corner2:
                    return Get1Corner22OutsideRingGround(wrestler2, wrestler1);
                case LocationEnum.Corner2Climbed:
                    return Get1Corner2Climbed2OutsideRingGround(wrestler2, wrestler1);
                case LocationEnum.Corner2Ground:
                    return Get1Corner2Ground2OutsideRingGround(wrestler2, wrestler1);
                case LocationEnum.Ground:
                    return Get1Ground2OutsideRingGround(wrestler2, wrestler1);
                case LocationEnum.OffRopes:
                    return Get1OffRopes2OutsideRingGround(wrestler2, wrestler1);
                case LocationEnum.OnRopes:
                    return Get1OnRopes2OutsideRingGround(wrestler2, wrestler1);
                case LocationEnum.OutsideRingGround:
	                return Get1OutsideRingGround2OutsideRingGround(wrestler1, wrestler2);
                case LocationEnum.OutsideRingStanding:
                    return Get1OutsideRingGround2OutsideRingStanding(wrestler1, wrestler2);
                default:
                    return "";
            }
        }

        private static string GetOutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            switch (wrestler2.Status.Position)
            {
                case LocationEnum.Standing:
                    return Get1Standing2OutsideRingStanding(wrestler2, wrestler1);
                case LocationEnum.Corner1:
                    return Get1Corner12OutsideRingStanding(wrestler2, wrestler1);
                case LocationEnum.Corner1Ground:
                    return Get1Corner1Ground2OutsideRingStanding(wrestler2, wrestler1);
                case LocationEnum.Corner1Climbed:
                    return Get1Corner1Climbed2OutsideRingStanding(wrestler2, wrestler1);
                case LocationEnum.Corner2:
                    return Get1Corner22OutsideRingStanding(wrestler2, wrestler1);
                case LocationEnum.Corner2Climbed:
                    return Get1Corner2Climbed2OutsideRingStanding(wrestler2, wrestler1);
                case LocationEnum.Corner2Ground:
                    return Get1Corner2Ground2OutsideRingStanding(wrestler2, wrestler1);
                case LocationEnum.Ground:
                    return Get1Ground2OutsideRingStanding(wrestler2, wrestler1);
                case LocationEnum.OffRopes:
                    return Get1OffRopes2OutsideRingStanding(wrestler2, wrestler1);
                case LocationEnum.OnRopes:
                    return Get1OnRopes2OutsideRingStanding(wrestler2, wrestler1);
                case LocationEnum.OutsideRingGround:
                    return Get1OutsideRingGround2OutsideRingStanding(wrestler2, wrestler1);
                case LocationEnum.OutsideRingStanding:
	                return Get1OutsideRingStanding2OutsideRingStanding(wrestler1, wrestler2);
                default:
                    return "";
            }
        }


        private static string Get1Standing2Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{1} is on the ground with {0} standing over him.";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Standing2Standing(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} and {1} are in the centre of the ring.";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1LockedUp2LockedUp(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "Both wrestlers are locked up";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Standing2Corner1(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Standing2Corner1Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Standing2Corner1Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Standing2Corner2(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Standing2Corner2Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Standing2Corner2Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Standing2OffRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Standing2OnRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Standing2OutsideRingGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Standing2OutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Ground2Corner1(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Ground2Corner1Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Ground2Corner1Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Ground2Corner2(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Ground2Corner2Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Ground2Corner2Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Ground2Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Ground2OffRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Ground2OnRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Ground2OutsideRingGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Ground2OutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner12Corner1(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner12Corner1Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner12Corner1Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner12Corner2(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner12Corner2Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner12Corner2Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner12OffRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner12OnRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner12OutsideRingGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner12OutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Climbed2Corner1Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Climbed2Corner1Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Climbed2Corner2(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Climbed2Corner2Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Climbed2Corner2Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Climbed2OffRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Climbed2OnRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Climbed2OutsideRingGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Climbed2OutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Ground2Corner1Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Ground2Corner2(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Ground2Corner2Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Ground2Corner2Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Ground2OffRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Ground2OnRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Ground2OutsideRingGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner1Ground2OutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner22Corner2(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner22Corner2Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner22Corner2Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner22OffRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner22OnRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner22OutsideRingGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner22OutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner2Climbed2Corner2Climbed(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner2Climbed2Corner2Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner2Climbed2OffRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner2Climbed2OnRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner2Climbed2OutsideRingGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner2Climbed2OutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner2Ground2Corner2Ground(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner2Ground2OffRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner2Ground2OnRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner2Ground2OutsideRingGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1Corner2Ground2OutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1OffRopes2OffRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1OffRopes2OnRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1OffRopes2OutsideRingGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1OffRopes2OutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1OnRopes2OnRopes(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1OnRopes2OutsideRingGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1OnRopes2OutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1OutsideRingGround2OutsideRingGround(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1OutsideRingGround2OutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

        private static string Get1OutsideRingStanding2OutsideRingStanding(ActiveWrestler wrestler1, ActiveWrestler wrestler2)
        {
            string text = "{0} todo {1}";
            return string.Format(text, wrestler1.Wrestler.Name, wrestler2.Wrestler.Name);
        }

    }
}
