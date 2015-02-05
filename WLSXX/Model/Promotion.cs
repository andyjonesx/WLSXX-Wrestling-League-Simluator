using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLSXX.Model
{
    public class Promotion
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public List<Wrestler> Wrestlers { get; set; }
        public List<Move> Moves { get; set; }
    }
}
