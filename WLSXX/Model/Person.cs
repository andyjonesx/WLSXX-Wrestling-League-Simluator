using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using WLSXX.Model.Enumerations;

namespace WLSXX.Model
{
    public class Person
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public GenderEnum Gender { get; set; }
       
    }

     
}
