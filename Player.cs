using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pentago
{
    public class Player
    {
        public Guid Id { get; private set; }
        public int ActiveIndex;
        public string Name;
        public BallPoint.BallColor PlayerColor;
        public static Dictionary<Guid, Player> Items = new Dictionary<Guid, Player>();

        public int VertLine;
        public int HorizLine;
        public int DiagLeftLine;
        public int DiagRightLine;
        public int MaxVLine;
        public int MaxHLine;
        public int MaxDLLine;
        public int MaxDRLine;
        public int Score;

        public Player(Game game,string name, BallPoint.BallColor color)
        {
            Id = Guid.NewGuid();
            Name = name;
            PlayerColor = color;
            HorizLine = 0;
            MaxHLine = 0;
            VertLine = 0;
            MaxVLine = 0;
            DiagLeftLine = 0;
            MaxDLLine = 0;
            DiagRightLine = 0;
            MaxDRLine = 0;
            Items.Add(Id, this);
        }

        public int MaxLine
        {
            get
            {
                int i = MaxVLine;
                if (MaxHLine > i)
                    i = MaxHLine;
                if (MaxDLLine > i)
                    i = MaxDLLine;
                if (MaxDRLine > i)
                    i = MaxDRLine;
                return i;
            }
        }

        public List<Game> Games
        {
            get
            {
                var res = new List<Game>();
                foreach (var gameplayer in GamePlayer.Items.Values)
                    if (gameplayer.Player == this)
                        res.Add(gameplayer.Game);
                return res;
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public static Player GetByName(string name)
        {
            foreach (var player in Items.Values)
                if (player.Name == name)
                    return player;
            return null;
        }
        public static Player GetByActiveIndex(int act)
        {
            foreach (var player in Items.Values)
                if (player.ActiveIndex == act)
                    return player;
            return null;
        }
        public static Player GetByColor(BallPoint.BallColor color)
        {
            foreach (var player in Items.Values)
                if (player.PlayerColor == color)
                    return player;
            return null;
        }
    }
}
