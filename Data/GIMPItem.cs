using System;

using System.Collections.Generic;

namespace GamesIMightPlay.Data
{
    public class GIMPItem
    {
        public string User {get; set; }
        public List<Game> Games {get; set; }

        public GIMPItem()
        {
            Games = new List<Game>();
        }
    }

    public class Game
    {
        public string gameId {get; set; }
        public DateTime WillPlay {get; set; }
        public DateTime LastPlayed {get; set; }
    }
}