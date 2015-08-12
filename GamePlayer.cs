using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pentago
{
    class GamePlayer
    {
        public Guid Id { get; private set; }
        static public Dictionary<Guid, GamePlayer> Items = new Dictionary<Guid, GamePlayer>();

        private Guid _GameId;
        public Game Game
        {
            get { return Game.Items[_GameId]; }
            private set { _GameId = value.Id; }
        }

        private Guid _PlayerId;
        public Player Player
        {
            get { return Player.Items[_PlayerId]; }
            private set { _PlayerId = value.Id; }
        }

        public GamePlayer(Game game, Player player)
        {
            Id = Guid.NewGuid();
            Items.Add(Id, this);
            Game = game;
            Player = player;
        }
    }
}
