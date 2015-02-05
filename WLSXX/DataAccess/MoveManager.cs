using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model;
using WLSXX.Model.Enumerations;

namespace WLSXX.DataAccess
{
    public static class MoveManager
    {
        public static Move GetMoveByID(Guid moveId, Guid promotionId)
        {
            var promotion = DataManager.Data.Promotions.Where(p => p.ID == promotionId).SingleOrDefault();
            if (promotion != null)
            {
                return promotion.Moves.Where(w => w.ID == moveId).SingleOrDefault();    
            }
            else
            {
                return null;
            }
            
        }

        public static List<Move> GetMovesByPosition(LocationEnum currentLocation, LocationEnum opponentLocation, Guid promotionId)
        {
            var moves = GetMoves(promotionId).Where(m => m.WrestlerLocation == currentLocation && m.OpponentLocation == opponentLocation && m.AssignOnly == false).ToList();

            return moves;
        }

        public static bool UpdateMove(Move move, Guid promotionId)
        {
            if (RemoveMove(move.ID, promotionId))
            {
                return AddMove(move, promotionId);    
            }
            else
            {
                return false;
            }
        }

        public static bool AddMove(Move move, Guid promotionId)
        {
            if (move.ID == null || move.ID == Guid.Empty)
            {
                move.ID = Guid.NewGuid();
            }

            var moves = GetMoves(promotionId);
            moves.Add(move);
            UpdateMoveList(moves, promotionId);
            return true;
        }

        public static bool RemoveMove(Move move, Guid promotionId)
        {
            var moves = GetMoves(promotionId);
            moves.Remove(moves.Where(x => x.ID == move.ID).SingleOrDefault());

            UpdateMoveList(moves, promotionId);

            return true;
        }

        public static bool RemoveMove(Guid moveId, Guid promotionId)
        {
            var move = GetMoveByID(moveId, promotionId);
            return RemoveMove(move, promotionId);
        }

        public static List<Move> GetMoves(Guid promotionId)
        {
            var promotion = DataManager.Data.Promotions.Where(p => p.ID == promotionId).SingleOrDefault();
            return promotion.Moves;
        }

        private static bool UpdateMoveList(List<Move> moves, Guid promotionId)
        {
            var promotion = DataManager.Data.Promotions.Where(p => p.ID == promotionId).SingleOrDefault();
            promotion.Moves = moves;

            DataManager.UpdateData();

            return true;
        }
    }
}
