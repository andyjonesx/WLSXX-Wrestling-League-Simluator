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
        public static Move GetMoveByID(Guid moveId)
        {
            return DataManager.Data.Moves.Where(w => w.ID == moveId).SingleOrDefault();
        }

        public static List<Move> GetMovesByPosition(LocationEnum currentLocation, LocationEnum opponentLocation)
        {
            var moves = GetMoves().Where(m => m.WrestlerLocation == currentLocation && m.OpponentLocation == opponentLocation && m.AssignOnly == false).ToList();

            return moves;
        }

        public static bool MoveWrestler(Move move)
        {
            if (RemoveMove(move.ID))
            {
                return AddMove(move);    
            }
            else
            {
                return false;
            }
        }

        public static bool AddMove(Move move)
        {
            if (move.ID == null || move.ID == Guid.Empty)
            {
                move.ID = Guid.NewGuid();
            }

            var moves = GetMoves();
            moves.Add(move);
            UpdateMoveList(moves);
            return true;
        }

        public static bool RemoveMove(Move move)
        {
            var moves = GetMoves();
            moves.Remove(moves.Where(x => x.ID == move.ID).SingleOrDefault());

            UpdateMoveList(moves);

            return true;
        }

        public static bool RemoveMove(Guid moveId)
        {
            var move = GetMoveByID(moveId);
            return RemoveMove(move);
        }

        public static List<Move> GetMoves()
        {
            return DataManager.Data.Moves;
        }

        private static bool UpdateMoveList(List<Move> moves)
        {
            DataManager.Data.Moves = moves;

            DataManager.UpdateData();

            return true;
        }
    }
}
