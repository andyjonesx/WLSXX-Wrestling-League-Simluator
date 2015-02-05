using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model;

namespace WLSXX.DataAccess
{
    public static class PromotionManager
    {
        public static Promotion Get(Guid promotionId)
        {
            return DataManager.Data.Promotions.Where(p => p.ID == promotionId).SingleOrDefault();
        }

        public static bool Update(Promotion promotion)
        {
            if (Remove(promotion.ID))
            {
                return Add(promotion);    
            }
            else
            {
                return false;
            }
            
        }

        public static bool Add(Promotion promotion)
        {
            if (promotion.ID == null || promotion.ID == Guid.Empty)
            {
                promotion.ID = Guid.NewGuid();
            }

            var promotions = GetList();
            promotions.Add(promotion);
            UpdateDataList(promotions);
            return true;
        }

        public static bool Remove(Promotion promotion)
        {
            var promotions = GetList();
            promotions.Remove(promotions.Where(x => x.ID == promotion.ID).SingleOrDefault());

            UpdateDataList(promotions);

            return true;
        }

        public static bool Remove(Guid promotionId)
        {
            var promotion = Get(promotionId);
            return Remove(promotion);
        }

        public static List<Promotion> GetList()
        {
            return DataManager.Data.Promotions;
        }

        private static bool UpdateDataList(List<Promotion> promotions)
        {
            DataManager.Data.Promotions = promotions;
            DataManager.UpdateData();
            return true;
        }
    }
}
