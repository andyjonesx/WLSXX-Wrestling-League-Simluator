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
        public static Wrestler Get(Guid wrestlerId, Guid promotionId)
        {
            var promotion = DataManager.Data.Promotions.Where(p => p.ID == promotionId).SingleOrDefault();
            
            if (promotion != null)
            {
                return promotion.Wrestlers.Where(w => w.ID == wrestlerId).SingleOrDefault();
            }
            else
            {
                return null;
            }
        }

        public static bool Update(Wrestler wrestler, Guid promotionId)
        {
            if (Remove(wrestler.ID, promotionId))
            {
                return Add(wrestler, promotionId);    
            }
            else
            {
                return false;
            }
            
        }

        public static bool Add(Wrestler wrestler, Guid promotionId)
        {
            if (wrestler.ID == null || wrestler.ID == Guid.Empty)
            {
                wrestler.ID = Guid.NewGuid();
            }

            var wrestlers = GetList(promotionId);
            wrestlers.Add(wrestler);
            UpdateDataList(wrestlers, promotionId);
            return true;
        }

        public static bool Remove(Wrestler wrestler, Guid promotionId)
        {
            var wrestlers = GetList(promotionId);
            wrestlers.Remove(wrestlers.Where(x => x.ID == wrestler.ID).SingleOrDefault());

            UpdateDataList(wrestlers, promotionId);

            return true;
        }

        public static bool Remove(Guid wrestlerId, Guid promotionId)
        {
            var wrestler = Get(wrestlerId, promotionId);
            return Remove(wrestler, promotionId);
        }

        public static List<Wrestler> GetList(Guid promotionId)
        {
            var promotion = DataManager.Data.Promotions.Where(p => p.ID == promotionId).SingleOrDefault();

            if (promotion != null)
            {
                return promotion.Wrestlers;    
            }
            else
            {
                return null;
            }
            
        }

        private static bool UpdateDataList(List<Wrestler> wrestlers, Guid promotionId)
        {
            var promotion = DataManager.Data.Promotions.Where(p => p.ID == promotionId).SingleOrDefault();

            if (promotion != null)
            { 
                promotion.Wrestlers = wrestlers;

                DataManager.UpdateData();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
