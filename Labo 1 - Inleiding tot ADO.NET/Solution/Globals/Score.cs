using System;

namespace Globals
{
    public class Score : IComparable
    {
        public int Id;
        public int PlayerId;
        public int GameId;
        public int Points;

        public Score(int id, int playerId, int gameId, int points)
        {
            Id = id;
            PlayerId = playerId;
            GameId = gameId;
            Points = points;
        }

        public int CompareTo(object obj) => (Points).CompareTo((obj as Score).Points);

        public override string ToString() => Id + " - " + PlayerId + " - " + GameId + " - " + Points;
    }
}
