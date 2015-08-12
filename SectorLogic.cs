using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace pentago
{
    public class SectorLogic
    {
        public static readonly int StartTop = 20;
        public static readonly int StartLeft = StartTop + GameField.MenuWidth;
        public static readonly int Gap = 199;
        public static readonly int Side = 189;
        public static readonly int SectorWidth = 3;
        private int BackgroundIndex;

        private Guid _GameId;
        public Game Game
        {
            get { return Game.Items[_GameId]; }
            set { _GameId = value.Id; }
        }

        public Guid Id { get; private set; }
        public Point Coord { get; private set; }

        static public Dictionary<Guid, SectorLogic> Items = new Dictionary<Guid, SectorLogic>();

        public SectorLogic(Game game, Point p)
        {
            Id = Guid.NewGuid();
            Coord = p;
            Game = game;
            //Size = new Size(Side, Side);
            //SetImage("sector_up.gif");
           // BackgroundImageLayout = ImageLayout.Zoom;
           // DrawSector();
            BackgroundIndex = 0;

            Items.Add(Id, this);
        }

        //public void DrawSector()
        //{
        //    int LocX = StartTop + (Coord.X - 1) * Gap;
        //    int LocY = StartLeft + (Coord.Y - 1) * Gap;
        //    Location = new Point(LocY, LocX);
        //}

        public static Point[,] BallMatrix
        {
            get
            {
                var ball = new Point[SectorWidth, SectorWidth];
                for (int i = 0; i < SectorWidth; i++)
                    for (int j = 0; j < SectorWidth; j++)
                        ball[i, j] = new Point(i + 1, j + 1);
                return ball;
            }
        }

        public List<BallPoint> BallPoints
        {
            get
            {
                var res = new List<BallPoint>();
                foreach (var ballpoint in BallPoint.Items.Values)
                    if (ballpoint.SectorLogic == this)
                        res.Add(ballpoint);
                return res;
            }
        }

        public static SectorLogic GetByCoord(Point p)
        {
            foreach (var sector in Items.Values)
                if (sector.Coord == p)
                    return sector;
            return null;
        }

        public static SectorLogic GetById(Guid id)
        {
            foreach (var sector in Items.Values)
                if (sector.Id == id)
                    return sector;
            return null;
        }

        public int TurnLeft()
        {
            foreach (BallPoint ball in this.BallPoints)
            {
                ball.Coord = new Point(SectorWidth - ball.Coord.Y + 1, ball.Coord.X);
                ball.DrawBallPoint();
            }
            BackgroundIndex = BackgroundIndex == 0 ? 3 : BackgroundIndex - 1;
 
            return BackgroundIndex;
        }

        public int TurnRight()
        {
            foreach (BallPoint ball in this.BallPoints)
            {
                ball.Coord = new Point(ball.Coord.Y, SectorWidth - ball.Coord.X + 1);
                ball.DrawBallPoint();
            }
            BackgroundIndex = BackgroundIndex == 3 ? 0 : BackgroundIndex + 1;

            return BackgroundIndex;
        }

        //private void RotateBackground()
        //{
        //    string imgFileName ="";

        //    switch (BackgroundIndex)
        //    {
        //        case 0:
        //            imgFileName = "sector_up.gif";
        //            break;
        //        case 1:
        //            imgFileName = "sector_right.gif";
        //            break;
        //        case 2:
        //            imgFileName = "sector_down.gif";
        //            break;
        //        case 3:
        //            imgFileName = "sector_left.gif";
        //            break;
        //    }
        //    SetImage(imgFileName);
        //}

        //private void SetImage(string imgFileName)
        //{
        //    string basePath = AppDomain.CurrentDomain.BaseDirectory;
        //    string s = Path.Combine(basePath, "img", imgFileName);
        //    BackgroundImage = Image.FromFile(s);
        //}
    }
}
