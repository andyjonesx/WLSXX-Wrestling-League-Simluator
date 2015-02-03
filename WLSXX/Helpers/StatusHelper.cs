using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model;

namespace WLSXX.Helpers
{
    public static class StatusHelper
    {
        public static void SetStartingStatus(ActiveWrestler activeWrestler)
        {
            activeWrestler.Status = new Status();
            activeWrestler.Status.Damage = 0;
            activeWrestler.Status.Morale = 100;
            activeWrestler.Status.Stamina = 100;
        }
    }
}
