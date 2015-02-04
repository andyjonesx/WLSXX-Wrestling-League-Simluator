using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model;

namespace WLSXX.DataAccess
{
    public static class WrestlerManager
    {
        public static Wrestler GetWrestlerByID(Guid wrestlerId)
        {
            return DataManager.Data.Wrestlers.Where(w => w.ID == wrestlerId).SingleOrDefault();
        }

        public static bool UpdateWrestler(Wrestler wrestler)
        {
            if (RemoveWrestler(wrestler.ID))
            {
                return AddWrestler(wrestler);    
            }
            else
            {
                return false;
            }
            
        }

        public static bool AddWrestler(Wrestler wrestler)
        {
            if (wrestler.ID == null || wrestler.ID == Guid.Empty)
            {
                wrestler.ID = Guid.NewGuid();
            }

            var wrestlers = GetWrestlers();
            wrestlers.Add(wrestler);
            UpdateWresterList(wrestlers);
            return true;
        }

        public static bool RemoveWrestler(Wrestler wrestler)
        {
            var wrestlers = GetWrestlers();
            wrestlers.Remove(wrestlers.Where(x => x.ID == wrestler.ID).SingleOrDefault());

            UpdateWresterList(wrestlers);

            return true;
        }

        public static bool RemoveWrestler(Guid wrestlerId)
        {
            var wrestler = GetWrestlerByID(wrestlerId);
            return RemoveWrestler(wrestler);
        }

        public static List<Wrestler> GetWrestlers()
        {
            return DataManager.Data.Wrestlers;
        }

        private static bool UpdateWresterList(List<Wrestler> wrestlers)
        {
            DataManager.Data.Wrestlers = wrestlers;

            DataManager.UpdateData();

            return true;
        }
    }
}
