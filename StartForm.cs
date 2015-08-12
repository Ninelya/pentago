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
    public partial class StartForm : Form
    {
        public Guid Id{ get; private set; }
        public int PlayerCount;
        public bool IsFinish = true;

        public string Player1Name;
        public string Player2Name;
        public string Player3Name;
        public string Player4Name;
        public string Player5Name;
        public string Player6Name;
        public string Player7Name;
        public string Player8Name;

        public BallPoint.BallColor Player1Color;
        public BallPoint.BallColor Player2Color;
        public BallPoint.BallColor Player3Color;
        public BallPoint.BallColor Player4Color;
        public BallPoint.BallColor Player5Color;
        public BallPoint.BallColor Player6Color;
        public BallPoint.BallColor Player7Color;
        public BallPoint.BallColor Player8Color;

        public int State;
        static public Dictionary<Guid, StartForm> Items = new Dictionary<Guid, StartForm>();

        private Guid _GameId;
        public GameField Field { get; private set; }

        public StartForm(GameField field)
        {
            InitializeComponent();
            Id = Guid.NewGuid();
            Field = field;

            Items.Add(Id, this);
        }

        public Game Game
        {
            get { return Game.Items[_GameId]; }
            set { _GameId = value.Id; }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayerCount = Convert.ToInt16(cbPlayerCount.Text);

            switch (cbSectorCount.Text)
            {
                case "4":
                case "4 (2 х 2)":
                    GameField.SectorCount = 2;
                    break;
                case "9":
                case "9 (3 х 3)":
                    GameField.SectorCount = 3;
                    break;
                case "16":
                case "16 (4 х 4)":
                    GameField.SectorCount = 4;
                    break;
                case "25":
                case "25 (5 х 5)":
                    GameField.SectorCount = 5;
                    break;
            }

            Player1Name = tbName1.Text;
            Player2Name = tbName2.Text;
            Player3Name = tbName3.Text;
            Player4Name = tbName4.Text;
            Player5Name = tbName5.Text;
            Player6Name = tbName6.Text;
            Player7Name = tbName7.Text;
            Player8Name = tbName8.Text;

            Player1Color = BallPoint.BallColor.red;
            Player2Color = BallPoint.BallColor.green;
            Player3Color = BallPoint.BallColor.blue;
            Player4Color = BallPoint.BallColor.cyan;
            Player5Color = BallPoint.BallColor.magenta;
            Player6Color = BallPoint.BallColor.yellow;
            Player7Color = BallPoint.BallColor.black;
            Player8Color = BallPoint.BallColor.brown;

            Game = new Game(Field);
            Field.Game = Game;
            Game.CreatePlayers(this);

            IsFinish = false;
            Close();
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsFinish)
                Application.Exit();
        }

        private void cbPlayerCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPlayerCount.Text)
            {
                case "2":
                    tbName3.Enabled = false;
                    //cbColor3.Enabled = false;
                    tbName4.Enabled = false;
                    //cbColor4.Enabled = false;
                    tbName5.Enabled = false;
                    //cbColor5.Enabled = false;
                    tbName6.Enabled = false;
                   // cbColor6.Enabled = false;
                    tbName7.Enabled = false;
                   // cbColor7.Enabled = false;
                    tbName8.Enabled = false;
                   // cbColor8.Enabled = false;
                    break;
                case "3":
                    tbName3.Enabled = true;
                  //  cbColor3.Enabled = true;
                    tbName4.Enabled = false;
                   // cbColor4.Enabled = false;
                    tbName5.Enabled = false;
                    //cbColor5.Enabled = false;
                    tbName6.Enabled = false;
                   // cbColor6.Enabled = false;
                    tbName7.Enabled = false;
                   // cbColor7.Enabled = false;
                    tbName8.Enabled = false;
                   // cbColor8.Enabled = false;
                    break;
                case "4":
                    tbName3.Enabled = true;
                   // cbColor3.Enabled = true;
                    tbName4.Enabled = true;
                   // cbColor4.Enabled = true;
                    tbName5.Enabled = false;
                   // cbColor5.Enabled = false;
                    tbName6.Enabled = false;
                   // cbColor6.Enabled = false;
                    tbName7.Enabled = false;
                   // cbColor7.Enabled = false;
                    tbName8.Enabled = false;
                   // cbColor8.Enabled = false;
                    break;
                case "5":
                    tbName3.Enabled = true;
                   // cbColor3.Enabled = true;
                    tbName4.Enabled = true;
                   // cbColor4.Enabled = true;
                    tbName5.Enabled = true;
                   // cbColor5.Enabled = true;
                    tbName6.Enabled = false;
                   // cbColor6.Enabled = false;
                    tbName7.Enabled = false;
                    //cbColor7.Enabled = false;
                    tbName8.Enabled = false;
                   // cbColor8.Enabled = false;
                    break;
                case "6":
                    tbName3.Enabled = true;
                    //cbColor3.Enabled = true;
                    tbName4.Enabled = true;
                   // cbColor4.Enabled = true;
                    tbName5.Enabled = true;
                   // cbColor5.Enabled = true;
                    tbName6.Enabled = true;
                   // cbColor6.Enabled = true;
                    tbName7.Enabled = false;
                   // cbColor7.Enabled = false;
                    tbName8.Enabled = false;
                  //  cbColor8.Enabled = false;
                    break;
                case "7":
                    tbName3.Enabled = true;
                   // cbColor3.Enabled = true;
                    tbName4.Enabled = true;
                  //  cbColor4.Enabled = true;
                    tbName5.Enabled = true;
                 //   cbColor5.Enabled = true;
                    tbName6.Enabled = true;
                  //  cbColor6.Enabled = true;
                    tbName7.Enabled = true;
                   // cbColor7.Enabled = true;
                    tbName8.Enabled = false;
                    //cbColor8.Enabled = false;
                    break;
                default:  //8
                    tbName3.Enabled = true;
                 //   cbColor3.Enabled = true;
                    tbName4.Enabled = true;
                 //   cbColor4.Enabled = true;
                    tbName5.Enabled = true;
                   // cbColor5.Enabled = true;
                    tbName6.Enabled = true;
                   // cbColor6.Enabled = true;
                    tbName7.Enabled = true;
                  //  cbColor7.Enabled = true;
                    tbName8.Enabled = true;
                  //  cbColor8.Enabled = true;
                    break;
            }
        }

        //private BallPoint.BallColor SelectColor(ComboBox list)
        //{
        //    switch (list.Text)
        //    {
        //        case "Красный":
        //            return BallPoint.BallColor.red;
        //        case "Зелёный":
        //            return BallPoint.BallColor.green;
        //        case "Синий":
        //            return BallPoint.BallColor.blue;
        //        case "Голубой":
        //            return BallPoint.BallColor.cyan;
        //        case "Розовый":
        //            return BallPoint.BallColor.magenta;
        //        case "Желтый":
        //            return BallPoint.BallColor.yellow;
        //        case "Чёрный":
        //            return BallPoint.BallColor.black;
        //        case "Коричневый":
        //            return BallPoint.BallColor.brown;
        //        default:
        //            return BallPoint.BallColor.white;
        //    }
        //}
    }
}
