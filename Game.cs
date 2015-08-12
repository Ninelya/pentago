using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace pentago
{
    public class Game
    {
        public int PlayerCount;
        public Guid Id { get; private set; }
        private static int FieldSize = GameField.SectorCount * Sector.SectorWidth;
        public int ActivePlayer;

        static public Dictionary<Guid, Game> Items = new Dictionary<Guid, Game>();

        public Game(GameField field)
        {
            Id = Guid.NewGuid();
            PlayerCount = field.Start.PlayerCount;
            ActivePlayer = 1;

            Items.Add(Id, this);
        }

        public List<GameField> Fields
        {
            get
            {
                var res = new List<GameField>();
                foreach (var field in GameField.Items.Values)
                    if (field.Game == this)
                        res.Add(field);
                return res;
            }
        }

        public List<StartForm> Starts
        {
            get
            {
                var res = new List<StartForm>();
                foreach (var start in StartForm.Items.Values)
                    if (start.Game == this)
                        res.Add(start);
                return res;
            }
        }

        public static Point[,] SectorMatrix
        {
            get
            {
                var sec = new Point[GameField.SectorCount, GameField.SectorCount];
                for (int i = 0; i < GameField.SectorCount; i++)
                    for (int j = 0; j < GameField.SectorCount; j++)
                        sec[i, j] = new Point(i + 1, j + 1);
                return sec;
            }
        }

        public List<Player> Players
        {
            get
            {
                var res = new List<Player>();
                foreach (var gameplayer in GamePlayer.Items.Values)
                    if (gameplayer.Game == this)
                        res.Add(gameplayer.Player);
                return res;
            }
        }

        public List<Player> Winners(int score)
        {
            var res = new List<Player>();
            foreach (var player in Players)
                if (player.MaxLine == score)
                    res.Add(player);
            return res;
        }

        public List<Sector> Sectors
        {
            get
            {
                var res = new List<Sector>();
                foreach (var sector in Sector.Items.Values)
                    if (sector.Game == this)
                        res.Add(sector);
                return res;
            }
        }

        public bool AddPlayer(Player player)
        {
            bool isNotConnected = true;

            foreach (Player p in this.Players)
                if (p == player)
                    isNotConnected = false;

            if (isNotConnected)
                new GamePlayer(this, player);

            return isNotConnected;
        }

        public void CreatePlayers(StartForm start)
        {
            switch (PlayerCount)
            {
                case 8:
                    CreatePlayer(start.Player8Name, start.Player8Color, PlayerCount);
                    goto case 7;
                case 7:
                    CreatePlayer(start.Player7Name, start.Player7Color, PlayerCount);
                    goto case 6;
                case 6:
                    CreatePlayer(start.Player6Name, start.Player6Color, PlayerCount);
                    goto case 5;
                case 5:
                    CreatePlayer(start.Player5Name, start.Player5Color, PlayerCount);
                    goto case 4;
                case 4:
                    CreatePlayer(start.Player4Name, start.Player4Color, PlayerCount);
                    goto case 3;
                case 3:
                    CreatePlayer(start.Player3Name, start.Player3Color, PlayerCount);
                    goto default;
                default:
                    CreatePlayer(start.Player2Name, start.Player2Color, PlayerCount);
                    CreatePlayer(start.Player1Name, start.Player1Color, PlayerCount-1);

                    Player player = new Player(this, "WhiteBalls", BallPoint.BallColor.white);
                    //AddPlayer(player);
                    break;
            }
        }

        private void CreatePlayer(string name, BallPoint.BallColor color, int count)
        {
            Player player = new Player(this, name, color);
            AddPlayer(player);
            player.ActiveIndex = count;
        }

        public static bool CheckForWhiteBalls()
        {
            bool IsGameOver;
            int i = 0;
            foreach (var ball in BallPoint.Items.Values)
                if (ball.PointColor == BallPoint.BallColor.white)
                    i++;
            IsGameOver = i == 0 ? true : false;
            return IsGameOver;
        }

        public int CheckForScore()
        {
            SetZeroScore();

            BallPoint currball;
            BallPoint prevball;

            //горизонталь
            for (int i = 1; i <= FieldSize; i++)
            {
                for (int j = 1; j <= FieldSize; j++)
                {
                    currball = BallPoint.GetByOpenCoord(new Point(i, j));
                    Point p = j == 1 ? new Point(i, j) : new Point(i, j - 1);
                    prevball = BallPoint.GetByOpenCoord(p);
                    CheckLine(currball, prevball, "h"); //собственно проверка
                }
                SetZeroLines("h");
            }

            //вертикаль
            for (int j = 1; j <= FieldSize; j++)
            {
                for (int i = 1; i <= FieldSize; i++)
                {
                    currball = BallPoint.GetByOpenCoord(new Point(i, j));
                    Point p = i == 1 ? new Point(i, j) : new Point(i - 1, j);
                    prevball = BallPoint.GetByOpenCoord(p);
                    CheckLine(currball, prevball, "v"); //собственно проверка
                }
                SetZeroLines("v");
            }

            //главная диагональ
            int a;
            int b;
            for (int k = 2; k < 2 * FieldSize - 1; k++)
            {
                if (k <= FieldSize)
                {
                    a = FieldSize;
                    b = k;
                }
                else
                {
                    a = 2 * FieldSize - k;
                    b = FieldSize;
                }
                while ((a >= 1) && (b >= 1))
                {
                    currball = BallPoint.GetByOpenCoord(new Point(a, b));
                    Point p = (a == FieldSize || b == FieldSize) ? new Point(a, b) : new Point(a + 1, b + 1);
                    prevball = BallPoint.GetByOpenCoord(p);
                    CheckLine(currball, prevball, "dl"); //собственно проверка
                    a--;
                    b--;
                }
                SetZeroLines("dl");
            }

            //вторичная диагональ
            for (int k = 2; k < 2 * FieldSize - 1; k++)
            {
                if (k <= FieldSize)
                {
                    a = 1;
                    b = k;
                }
                else
                {
                    a = k - FieldSize + 1;
                    b = FieldSize;
                }
                while ((a <= FieldSize) && (b >= 1))
                {
                    currball = BallPoint.GetByOpenCoord(new Point(a, b));
                    Point p = (a == 1 || b == FieldSize) ? new Point(a, b) : new Point(a - 1, b + 1);
                    prevball = BallPoint.GetByOpenCoord(p);
                    CheckLine(currball, prevball, "dr"); //собственно проверка
                    a++;
                    b--;
                }
                SetZeroLines("dr");
            }

            int f = 0;
            foreach (var player in this.Players)
                if (player.MaxLine > f)
                    f = player.MaxLine;

            return f;
        }

        private void CheckLine(BallPoint ball, BallPoint prevball, string dimention)
        {
            Player player = Player.GetByColor(prevball.PointColor);
            if (ball.PointColor == prevball.PointColor)
            {
                if (prevball.PointColor != BallPoint.BallColor.white) //оба одинаковые цветные
                    IncLine(player, dimention);
            } //оба белые игнорируем
            else //ball.PointColor != currPlayer.PlayerColor
            {
                if (ball.PointColor == BallPoint.BallColor.white) //текущий белый, предыдущий цветной
                {
                    SetLineToZero(player, dimention);
                    player = Player.GetByName("WhiteBalls");
                }
                else //ball.PointColor != BallPoint.BallColor.white //оба разные и текущий цветной
                {
                    if (player.Name != "WhiteBalls") //оба цветные
                        SetLineToZero(player, dimention);
                    player = ball.Player;
                    IncLine(player, dimention);
                }
            }
            return; //player;
        }

        private void SetZeroLines(string dimention)
        {
            foreach (var player in this.Players)
            {
                switch (dimention)
                {
                    case "h":
                        player.HorizLine = 0;
                        break;
                    case "v":
                        player.VertLine = 0;
                        break;
                    case "dl":
                        player.DiagLeftLine = 0;
                        break;
                    case "dr":
                        player.DiagRightLine = 0;
                        break;
                }
            }
        }

        private void SetZeroScore()
        {
            foreach (var player in this.Players)
            {
                player.MaxHLine = 0;
                player.MaxVLine = 0;
                player.MaxDLLine = 0;
                player.MaxDRLine = 0;
                player.Score = 0;
            }
        }

        private void IncLine(Player player, string dimention)
        {
            switch (dimention)
            {
                case "h":
                    player.HorizLine++;
                    if (player.MaxHLine < player.HorizLine)
                        player.MaxHLine = player.HorizLine;
                    break;
                case "v":
                    player.VertLine++;
                    if (player.MaxVLine < player.VertLine)
                        player.MaxVLine = player.VertLine;
                    break;
                case "dl":
                    player.DiagLeftLine++;
                    if (player.MaxDLLine < player.DiagLeftLine)
                        player.MaxDLLine = player.DiagLeftLine;
                    break;
                case "dr":
                    player.DiagRightLine++;
                    if (player.MaxDRLine < player.DiagRightLine)
                        player.MaxDRLine = player.DiagRightLine;
                    break;
            }
        }

        private void SetLineToZero(Player player, string dimention)
        {
            switch (dimention)
            {
                case "h":
                    player.HorizLine = 0;
                    break;
                case "v":
                    player.VertLine = 0;
                    break;
                case "dl":
                    player.DiagLeftLine = 0;
                    break;
                case "dr":
                    player.DiagRightLine = 0;
                    break;
            }
        }

    }
}
