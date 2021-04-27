using System;

using System.Collections.Generic;

using System.Threading.Tasks;

namespace GamesIMightPlay.Data
{
    public class GamesIMightPlayService
    {
        private static readonly List<GamesIMightPlayItem> Users;

        static GamesIMightPlayService()
        {
            Users = new List<GamesIMightPlayItem> {

                new GamesIMightPlayItem
                {
                    User = "randomString",
                    Games = new List<Game> {
                        new Game {
                            gameId = "123456"
                        },
                        new Game {
                            gameId = "234567",
                            WillPlay = DateTime.Now},
                        new Game {
                            gameId = "23456789",
                            WillPlay = DateTime.Today
                        }
                    }
                },

                new GamesIMightPlayItem
                {
                    User = "anotherRandomString",
                    Games = new List<Game> {
                        new Game {
                            gameId = "123457"
                        },
                        new Game {
                            gameId = "234560",
                            WillPlay = DateTime.Now},
                        new Game {
                            gameId = "23456700",
                            WillPlay = DateTime.Today
                        }
                    }
                }
            };
        }

        public Task<List<GamesIMightPlayItem>> GetGIMPAsync()
        {
            return Task.FromResult(Users);
        }
    }
}