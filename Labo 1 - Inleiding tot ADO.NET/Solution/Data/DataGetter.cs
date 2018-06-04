using Globals;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Data
{
    public class DataGetter : IDataGetter
    {
        // Local fields
        private const string LOCAL_SERVER = "localhost";
        private const string LOCAL_DATABASE = "labohighscores";
        private const string LOCAL_USER = "root";
        private const string LOCAL_PASSWORD = "root";

        // Remote fields
        private const string REMOTE_SERVER = "10.129.28.180";
        private const string REMOTE_DATABASE = "r0579578_C#ProgrammingTechniques_Labo1";
        private const string REMOTE_USER = "r0579578_Dwight";
        private const string REMOTE_PASSWORD = "C#isEenZeerLeukVak";

        // Query
        private const string SELECT_ALL_FROM = "SELECT * FROM ";

        private MySqlConnection conn;

        public DataGetter()
        {            
            // Local
            conn = new MySqlConnection($"SERVER={LOCAL_SERVER};DATABASE={LOCAL_DATABASE};UID={LOCAL_USER};PASSWORD={LOCAL_PASSWORD};");

            // Remote
            conn = new MySqlConnection($"SERVER={REMOTE_SERVER};DATABASE={REMOTE_DATABASE};UID={REMOTE_USER};PASSWORD={REMOTE_PASSWORD};");
        }

        public Tuple<List<Player>,List<Game>,List<Score>> ReadDatabase()
        {
            DataSet ds = new DataSet();

            conn.Open();

            // Players
            new MySqlDataAdapter(SELECT_ALL_FROM + "players", conn).Fill(ds,"players");
            var players = ds.Tables[0].AsEnumerable().Select(dataRow => new Player(dataRow.Field<int>("id"), dataRow.Field<string>("name"), dataRow.Field<string>("nickname"))).ToList();
            ds = new DataSet();

            // Games
            new MySqlDataAdapter(SELECT_ALL_FROM + "games", conn).Fill(ds, "games");
            var games = ds.Tables[0].AsEnumerable().Select(dataRow => new Game(dataRow.Field<int>("id"), dataRow.Field<string>("name"))).ToList();
            ds = new DataSet();

            // Scores
            new MySqlDataAdapter(SELECT_ALL_FROM + "scores", conn).Fill(ds, "scores");
            var scores = ds.Tables[0].AsEnumerable().Select(dataRow => new Score(dataRow.Field<int>("id"), dataRow.Field<int>("playerId"), dataRow.Field<int>("gameId"), dataRow.Field<int>("points"))).ToList();
            
            conn.Close();

            return new Tuple<List<Player>, List<Game>, List<Score>>(players, games, scores);
        }
    }
}
