using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLSXX.Model
{
    public class MatchRound
    {
        public int RoundNumber { get; set; }
        public Move Wrestler1Move { get; set; }
        public Move Wrestler2Move { get; set; }
        public int SuccessfulWrestler { get; set; }
        public int Damage { get; set; }
        public int SelfDamage { get; set; }
        public bool SubmissionAttempt { get; set; }
        public bool SubmissionSuccessful { get; set; }
        public bool PinAttempt { get; set; }
        public bool PinSuccessful { get; set; }
    }
}
