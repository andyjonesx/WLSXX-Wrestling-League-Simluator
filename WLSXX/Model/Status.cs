using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using WLSXX.Model.Enumerations;

namespace WLSXX.Model
{
    public class Status
    {
        public StatusElement Damage { get; set; }
        public StatusElement Stamina { get; set; }
        public StatusElement Morale { get; set; }
        public LocationEnum Position { get; set; }
        public bool Stunned { get; set; }
        public bool Cut { get; set; }
    }

     
}
