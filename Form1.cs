#define My_Debug

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette_Reloaded
{

    public partial class Form1 : Form
    {
#if My_Debug
        int _cursX = 0;
        int _cursY = 0;
#endif

        RouletteTable table;
        SpinnerGif gif;
        Chips1 chip1;
        Chips5 chip5;
        Chips10 chip10;
        Chips25 chip25;
        Chips100 chip100;

        public Form1()
        {
            InitializeComponent();

            table = new RouletteTable() { Left = 220, Top = 0 };
            gif = new SpinnerGif() { Left = 0, Top = 0 };
            chip1 = new Chips1() { Left = 270, Top = 280 };
            chip5 = new Chips5() { Left = 360, Top = 280 };
            chip10 = new Chips10() { Left = 450, Top = 280 };
            chip25 = new Chips25() { Left = 540, Top = 280 };
            chip100 = new Chips100() { Left = 630, Top = 280 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void GameHeartBeat_Tick(object sender, EventArgs e)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;

            table.DrawImage(dc);
            gif.DrawImage(dc);
            chip1.DrawImage(dc);
            chip5.DrawImage(dc);
            chip10.DrawImage(dc);
            chip25.DrawImage(dc);
            chip100.DrawImage(dc);

#if My_Debug
            TextFormatFlags flag = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font _fontt = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "X = " + _cursX.ToString() + ":" + "Y=" + _cursY.ToString(),
                _fontt, new Rectangle(0, 250, 120, 20), SystemColors.ControlText, flag);
#endif

            base.OnPaint(e);

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            _cursX = e.X;
            _cursY = e.Y;

            this.Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //+4 top -4 bot
            int r3top = 146;
            int r3bot = 202;
            int r2top = 0;
            int r2bot = 0;
            int r1top = 0;
            int r1bot = 0;

            //-4 +4
            int colleft1 = 280; int colright1 = 308;

            int colleft2 = 319; int colright2 = 0;

            int colleft3 = 354; int colright3 = 0;

            int colleft4 = 393; int colright4 = 0;

            int colleft5 = 431;  int colright5 = 0;

            int colleft6 = 467;  int colright6 = 0;

            int colleft7 = 506;  int colright7 = 0;

            int colleft8 = 543; int colright8 = 0;

            int colleft9 = 579; int colright9 = 0;

            int colleft10 = 616; int colright10 = 0;

            int colleft11 = 653; int colright11 = 0;

            int colleft12 = 691; int colright12 = 0;

            if (e.X > colleft1 && e.X < colright1 && e.Y > r1top && e.Y < r1bot)
            {
                // 3 region
                Console.WriteLine("3");
            }else if (e.X > colleft1 && e.X < colright1 && e.Y > r2top && e.Y < r2bot)
            {
                //2 region
                Console.WriteLine("2");
            } else if (e.X > colleft1 && e.X < colright1 && e.Y > r3top && e.Y < r3bot)
            {
                //1 region
                Console.WriteLine("1");
            }else if (e.X > colleft2 && e.X < colright2 && e.Y > r1top && e.Y < r1bot)
            {
                //6 region
                Console.WriteLine("6");
            }
            else if (e.X > colleft2 && e.X < colright2 && e.Y > r2top && e.Y < r2bot)
            {
                //5 region
                Console.WriteLine("5");
            }
            else if (e.X > colleft2 && e.X < colright2 && e.Y > r3top && e.Y < r3bot)
            {
                //4 region
                Console.WriteLine("4");
            }


        }
        }
}
