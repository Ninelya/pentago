using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pentago
{
    public partial class GameField : Form
    {
        public Guid Id { get; private set; }
        public static int SectorCount;
        public const int MenuWidth = 300;
        private static int FieldStep = Sector.Gap;
        private static int FieldLeft = 2 * Sector.StartTop + MenuWidth;  //100 - ширина меню
        private static int FieldTop = 3 * Sector.StartTop;
        static public Dictionary<Guid, GameField> Items = new Dictionary<Guid, GameField>();
        private Guid _GameId;
        public StartForm Start { get; private set; }
        private bool IsBallNotSector;
        private static readonly int WinScore = 5;

        public Game Game
        {
            get { return Game.Items[_GameId]; }
            set { _GameId = value.Id; }
        }

        public GameField()
        {
            InitializeComponent();
            Id = Guid.NewGuid();
            Items.Add(Id, this);

            Start = new StartForm(this);
            Start.ShowDialog();
            
            if (Start.IsFinish)
                return;

            SetNames(Start);
            SetScore();
            ShowPlayers(Start);
            lblActivePlayer.Text = Player.GetByActiveIndex(Game.ActivePlayer) + "!";

            Sector sector;
            foreach (var sec in Game.SectorMatrix)
            {
                sector = new Sector(Game, sec);
                Controls.Add(sector);
                sector.MouseClick += OnSectorMouseClick;
                foreach (var ball in Sector.BallMatrix)
                {
                    BallPoint bp = new BallPoint(sector, ball);
                    bp.Click += OnBallPointClick;
                    sector.Controls.Add(bp);
                }
            }
            IsBallNotSector = true;
            MinimumSize = new Size(SectorCount * FieldStep + FieldLeft, SectorCount * FieldStep + FieldTop);
        }

        private void OnBallPointClick(object sender, EventArgs e)
        {
            BallPoint bp = (BallPoint)sender;
            if (bp.IsColored || !IsBallNotSector)
                return;

            bp.PointColor = Player.GetByActiveIndex(bp.Sector.Game.ActivePlayer).PlayerColor;
            bp.DrawBallPoint();
            bp.IsColored = true;
            string s = bp.OpenCoord.X.ToString() + " " + bp.OpenCoord.Y.ToString();//избыточная переменная
            //MessageBox.Show(s); 
            lblHint.Text = "Поверните сектор";
            IsBallNotSector = false;
        }

        private void OnSectorMouseClick(object sender, MouseEventArgs e)
        {
            if (IsBallNotSector)
                return;

            Sector sv = (Sector)sender;
            int active = sv.Game.ActivePlayer;

            if (e.Button == MouseButtons.Left)
                sv.TurnLeft();

            if (e.Button == MouseButtons.Right)
                sv.TurnRight();

            int result = Game.CheckForScore();
            CangeScore();
            ShowScore();

            if (result >= WinScore)
                SomeoneWins(result);

            if (Game.CheckForWhiteBalls())
                GameOver();

            IsBallNotSector = true;
            sv.Game.ActivePlayer = active == sv.Game.PlayerCount ? 1 : active + 1;
            active = sv.Game.ActivePlayer;
            lblActivePlayer.Text = Player.GetByActiveIndex(active) + "!";
            lblHint.Text = "Выберите шар";

            string s = sv.Game.Players[0].MaxHLine.ToString() + " " + sv.Game.Players[0].MaxVLine.ToString() + " " + sv.Game.Players[0].MaxDLLine.ToString() + " " + sv.Game.Players[0].MaxDRLine.ToString();
            //MessageBox.Show(s);
        }

        private void SomeoneWins(int result)
        {
            string s = "Следующие игроки победили со счетом " + result.ToString() + " очков:";
            List<Player> CurrentWinners = Game.Winners(result);
            foreach (var winner in CurrentWinners)
                s += "\n" + winner.ToString();
            MessageBox.Show(s);
            Application.Exit();
        }

        private void GameOver()
        {
            MessageBox.Show("Конец игры");
            Application.Exit();
        }

        private void ShowScore()
        {
            switch (Game.PlayerCount)
            {
                case 8:
                    lblScore8.Text = Player.GetByActiveIndex(8).Score.ToString();
                    goto case 7;
                case 7:
                    lblScore7.Text = Player.GetByActiveIndex(7).Score.ToString();
                    goto case 6;
                case 6:
                    lblScore6.Text = Player.GetByActiveIndex(6).Score.ToString();
                    goto case 5;
                case 5:
                    lblScore5.Text = Player.GetByActiveIndex(5).Score.ToString();
                    goto case 4;
                case 4:
                    lblScore4.Text = Player.GetByActiveIndex(4).Score.ToString();
                    goto case 3;
                case 3:
                    lblScore3.Text = Player.GetByActiveIndex(3).Score.ToString();
                    goto default;
                default:
                    lblScore2.Text = Player.GetByActiveIndex(2).Score.ToString();
                    lblScore1.Text = Player.GetByActiveIndex(1).Score.ToString();
                    break;
            }
        }

        private void CangeScore()
        {
            switch (Game.PlayerCount)
            {
                case 8:
                    Player.GetByActiveIndex(8).Score = Player.GetByActiveIndex(8).MaxLine;
                    goto case 7;
                case 7:
                    Player.GetByActiveIndex(7).Score = Player.GetByActiveIndex(7).MaxLine;
                    goto case 6;
                case 6:
                    Player.GetByActiveIndex(6).Score = Player.GetByActiveIndex(6).MaxLine;
                    goto case 5;
                case 5:
                    Player.GetByActiveIndex(5).Score = Player.GetByActiveIndex(5).MaxLine;
                    goto case 4;
                case 4:
                    Player.GetByActiveIndex(4).Score = Player.GetByActiveIndex(4).MaxLine;
                    goto case 3;
                case 3:
                    Player.GetByActiveIndex(3).Score = Player.GetByActiveIndex(3).MaxLine;
                    goto default;
                default:
                    Player.GetByActiveIndex(2).Score = Player.GetByActiveIndex(2).MaxLine;
                    Player.GetByActiveIndex(1).Score = Player.GetByActiveIndex(1).MaxLine;
                    break;
            }
        }

        private void SetScore()
        {
            switch (Game.PlayerCount)
            {
                case 8:
                    lblScore8.Text = Player.GetByActiveIndex(8).Score.ToString();
                    goto case 7;
                case 7:
                    lblScore7.Text = Player.GetByActiveIndex(7).Score.ToString();
                    goto case 6;
                case 6:
                    lblScore6.Text = Player.GetByActiveIndex(6).Score.ToString();
                    goto case 5;
                case 5:
                    lblScore5.Text = Player.GetByActiveIndex(5).Score.ToString();
                    goto case 4;
                case 4:
                    lblScore4.Text = Player.GetByActiveIndex(4).Score.ToString();
                    goto case 3;
                case 3:
                    lblScore3.Text = Player.GetByActiveIndex(3).Score.ToString();
                    goto default;
                default:
                    lblScore1.Text = Player.GetByActiveIndex(1).Score.ToString();
                    lblScore2.Text = Player.GetByActiveIndex(2).Score.ToString();
                    break;
            }
        }

        private void SetNames(StartForm start)
        {
            lblName1.Text = start.Player1Name;
            lblName2.Text = start.Player2Name;
            lblName3.Text = start.Player3Name;
            lblName4.Text = start.Player4Name;
            lblName5.Text = start.Player5Name;
            lblName6.Text = start.Player6Name;
            lblName7.Text = start.Player7Name;
            lblName8.Text = start.Player8Name;
        }

        private void ShowPlayers(StartForm start)
        {
            switch (start.PlayerCount)
            {
                case 3:
                    pnlPlayers3.Visible = true;
                    pnlPlayers4.Visible = false;
                    pnlPlayers5.Visible = false;
                    pnlPlayers6.Visible = false;
                    pnlPlayers7.Visible = false;
                    pnlPlayers8.Visible = false;
                    break;
                case 4:
                    pnlPlayers3.Visible = true;
                    pnlPlayers4.Visible = true;
                    pnlPlayers5.Visible = false;
                    pnlPlayers6.Visible = false;
                    pnlPlayers7.Visible = false;
                    pnlPlayers8.Visible = false;
                    break;
                case 5:
                    pnlPlayers3.Visible = true;
                    pnlPlayers4.Visible = true;
                    pnlPlayers5.Visible = true;
                    pnlPlayers6.Visible = false;
                    pnlPlayers7.Visible = false;
                    pnlPlayers8.Visible = false;
                    break;
                case 6:
                    pnlPlayers3.Visible = true;
                    pnlPlayers4.Visible = true;
                    pnlPlayers5.Visible = true;
                    pnlPlayers6.Visible = true;
                    pnlPlayers7.Visible = false;
                    pnlPlayers8.Visible = false;
                    break;
                case 7:
                    pnlPlayers3.Visible = true;
                    pnlPlayers4.Visible = true;
                    pnlPlayers5.Visible = true;
                    pnlPlayers6.Visible = true;
                    pnlPlayers7.Visible = true;
                    pnlPlayers8.Visible = false;
                    break;
                case 8:
                    pnlPlayers3.Visible = true;
                    pnlPlayers4.Visible = true;
                    pnlPlayers5.Visible = true;
                    pnlPlayers6.Visible = true;
                    pnlPlayers7.Visible = true;
                    pnlPlayers8.Visible = true;
                    break;
                default: //2
                    pnlPlayers3.Visible = false;
                    pnlPlayers4.Visible = false;
                    pnlPlayers5.Visible = false;
                    pnlPlayers6.Visible = false;
                    pnlPlayers7.Visible = false;
                    pnlPlayers8.Visible = false;
                    break;
            }
        }

    }
}
