using System.Collections.Generic;
using System;

namespace Globals
{
    public class Player : IComparable
    {
        private List<Score> scores;
        private int averageTopScore = 0;

        public string NameWithAvarage => ToString() + " (" + averageTopScore + ")";
        public int Id { get; }
        public string Name { get; }
        public string NickName { get; }
        public List<Score> Scores {
            get {
                scores.Sort();
                return scores;
            }
        }
        
        public Player(int _Id, string _Name, string _NickName)
        {
            Id = _Id;
            Name = _Name;
            NickName = _NickName;
            scores = new List<Score>();
        }

        public void AddScoreForGame(Score s) => scores.Add(s);

        public List<Score> ScoresOfGamesSorted(Game g)
        {
            // Filter scores
            List<Score> returnable = new List<Score>();

            foreach (Score score in scores) if (score.GameId == g.Id) returnable.Add(score);

            if (returnable.Count == 0) return null;

            // Reverse sort them
            returnable.Sort();
            returnable.Reverse();

            return returnable;
        }

        public Score MaxScoreForGame(Game g)
        {
            List<Score> scoresOfGamesSorted = ScoresOfGamesSorted(g);
            if (scoresOfGamesSorted == null) return null;
            return scoresOfGamesSorted[0];
        }

        public int GetAverageTopScores(List<Game> games)
        {
            int total = 0;
            int noGames = 0;

            // Get number of Games and highscore total
            foreach (Game g in games)
            {
                Score s = MaxScoreForGame(g);
                if (s == null) continue;
                total += s.Points;
                noGames++;
            }

            averageTopScore = total / noGames;
            return averageTopScore;
        }

        public int CompareTo(object obj) => (NickName).CompareTo((obj as Player).NickName);

        public override string ToString() => NickName;
    }
}
