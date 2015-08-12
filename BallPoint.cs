using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace pentago
{
    public class BallPoint : Control
    {
        private Guid _SectorId;
        private static readonly int Radius = 35;
        private static readonly int Gap = 63;
        private static readonly int Edge = 14;

        public enum BallColor { red, green, blue, cyan, magenta, yellow, black, white, brown };
        public bool IsColored;
        public Point Coord { get; set; }
        public Guid Id { get; private set; }
        public BallColor PointColor;

        static public Dictionary<Guid, BallPoint> Items = new Dictionary<Guid, BallPoint>();

        public Point OpenCoord 
        {
            get 
            { 
                return new Point((Sector.Coord.X - 1) * 3 + Coord.X, (Sector.Coord.Y - 1) * 3 + Coord.Y); 
            }
        }

        public Sector Sector
        {
            get { return Sector.Items[_SectorId]; }
            set { _SectorId = value.Id; }
        }

        public Player Player
        {
            get
            {
                foreach (var player in Player.Items.Values)
                    if (player.PlayerColor == this.PointColor)
                        return player;
                return null;
            }
        }

        public static BallPoint GetByCoord(Point p)
        {
            foreach (var ball in Items.Values)
                if (ball.Coord == p)
                    return ball;
            return null;
        }

        public static BallPoint GetByOpenCoord(Point p)
        {
            foreach (var ball in Items.Values)
                if (ball.OpenCoord == p)
                    return ball;
            return null;
        }

        public static BallPoint GetById(Guid id)
        {
            foreach (var ball in Items.Values)
                if (ball.Id == id)
                    return ball;
            return null;
        }

        public BallPoint(Sector sec, Point p) : this(sec, p, BallColor.white, false) { }

        public BallPoint(Sector sec, Point p, BallColor ballcolor, bool isColored)
        {
            Sector = sec;
            IsColored = isColored;
            Coord = p;
            PointColor = ballcolor;
            Id = Guid.NewGuid();
            Size = new Size(Radius, Radius);
            BackColor = Color.FromArgb(247, 235, 200);
            DrawBallPoint();
            BackgroundImageLayout = ImageLayout.Zoom;
            BallPoint b = this;
            Items.Add(Id, b);
        }

        public void DrawBallPoint()
        {
            int LocX = (Coord.X - 1) * Gap + Edge;
            int LocY = (Coord.Y - 1) * Gap + Edge;
            Location = new Point(LocY, LocX);

            string imgFileName = "";

            switch (PointColor)
            {
                case BallColor.red:
                    imgFileName = "ball_red.gif";
                    break;
                case BallColor.green:
                    imgFileName = "ball_green.gif";
                    break;
                case BallColor.blue:
                    imgFileName = "ball_blue.gif";
                    break;
                case BallColor.cyan:
                    imgFileName = "ball_cyan.gif";
                    break;
                case BallColor.magenta:
                    imgFileName = "ball_magenta.gif";
                    break;
                case BallColor.yellow:
                    imgFileName = "ball_yellow.gif";
                    break;
                case BallColor.black:
                    imgFileName = "ball_black.gif";
                    break;
                case BallColor.brown:
                    imgFileName = "ball_brown.gif";
                    break;
                default: //white 
                    imgFileName = "ball_white.gif";
                    break;
            }
            SetImage(imgFileName);

        }

        public void SetImage(string imgFileName)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string s = Path.Combine(basePath, "img", imgFileName);
            BackgroundImage = Image.FromFile(s);
        }

    }
}
