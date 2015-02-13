using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using WLSXX.Model.Enumerations;

namespace WLSXX.Model
{
    public class SinglesMatch
    {
        public ActiveWrestler Wrestler1 { get; set; }
        public ActiveWrestler Wrestler2 { get; set; }
        public Guid PromotionId { get; set; }
        public bool MatchOver { get; set; }
        public List<MatchRound> Rounds { get; set; }
        public int CurrentRoundNumber { get; set; }
        public MatchRound CurrentRound { get; set; }

    }

     
}
