using System;
using System.Collections.Generic;
using Globals;

namespace Logic
{
    public class DataProcessing : IDataProcessing
    {
        // Constant
        private const int STRING_LENGTH = 15;

        // Fields
        private Data.IDataGetter data;
        private Tuple<List<Player>, List<Game>, List<Score>> dbData;

        // Constructors
        public DataProcessing()
        {
            // Connection to Data Layer
            data = new Data.DataGetter();
            dbData = data.ReadDatabase();

            // Assign relevant scores
            foreach (var score in dbData.Item3)
            {
                dbData.Item2.Find(x => x.Id == score.GameId).AddScore(score);
                dbData.Item1.Find(x => x.Id == score.PlayerId).AddScoreForGame(score);
            }

            // Sort players
            dbData.Item1.Sort((x, y) => y.GetAverageTopScores(new List<Game>(dbData.Item2)).CompareTo(x.GetAverageTopScores(new List<Game>(dbData.Item2))));
        }

        public List<Player> GetPlayerList() => new List<Player>(dbData.Item1);

        public List<Game> GetGameList() => new List<Game>(dbData.Item2);

        public List<string> GetPlayerScoreList(Player p)
        {
            var returnable = new List<string>();

            foreach (var game in dbData.Item2)
            {
                var score = p.MaxScoreForGame(game);
                if (score == null) continue;
                returnable.Add(game.Name.PadRight(STRING_LENGTH) + "\t" + score.Points + "\t" + game.AllTimeTopScore.Points);
            }

            return returnable;
        }

        public List<string> GetGameScoreList(Game g)
        {
            var returnable = new List<string>();

            foreach (var score in g.Scores) returnable.Add(dbData.Item1.Find(x => x.Id == score.PlayerId).NickName.PadRight(STRING_LENGTH) + "\t" + score.Points);

            return returnable;
        }
    }
}
