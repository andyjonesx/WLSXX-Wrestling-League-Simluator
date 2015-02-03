using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using WLSXX.Model.Enumerations;

namespace WLSXX.Model
{
    public class ActiveWrestler
    {
        public Wrestler Wrestler { get; set; }
        public Status Status { get; set; }
        public bool HumanControlled { get; set; }
    }
}
