using System;
using System.Collections.Generic;

namespace Globals
{
    public class Game : IComparable
    {
        private List<Score> scores;
        
        public int Id { get; }
        public string Name { get; }
        public List<Score> Scores {
            get {
                scores.Sort();
                return scores;
            }
        }
        public Score AllTimeTopScore {
            get {
                // No scores yet
                if (scores.Count == 0) return null;

                // Get top score
                scores.Sort();
                return scores[scores.Count - 1];
            }
        }
        
        public Game(int _Id, string _Name)
        {
            Id = _Id;
            Name = _Name;
            scores = new List<Score>();
        }

        public void AddScore(Score score) => scores.Add(score);

        public int CompareTo(object obj) => (Name).CompareTo((obj as Game).Name);

        public override string ToString() => Id + " - " + Name;
    }
}
