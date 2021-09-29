using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject2
{
    class BadBoy:Guy
    {
        public int StartingPosition { get; set; }
        public int RacetrackLength { get; set; }
        public PictureBox MyPictureBox { get; set; }
        public int Location { get; set; }
        public Random Randomizer { get; set; }

        public void TakeStartingPoint()
        {
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }

        public override string WhoAttack()
        {
            return "";
        }
    }
}
