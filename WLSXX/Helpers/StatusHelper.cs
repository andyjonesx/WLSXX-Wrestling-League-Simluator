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
            activeWrestler.Status.Damage = new StatusElement
            {
                Current = 100,
                Max = 100,
                Min = 0
            };

            activeWrestler.Status.Morale = new StatusElement
            {
                Current = 100,
                Max = 100,
                Min = 0
            };

            activeWrestler.Status.Stamina = new StatusElement
            {
                Current = 100,
                Max = 100,
                Min = 0
            };
        }
    }
}
