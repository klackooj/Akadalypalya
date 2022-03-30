using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Akadalypalya.Persistence
{
    public class AkadalypalyaTable
    {

        private Point me = new Point(9/2,0);
        public Point Me { get { return me; } set { me = value; } }

        private int hp = 3;

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        private int time = 0;

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        private int point;

        public int Point
        {
            get { return point; }
            set { point = value; }
        }

        private List<List<Point>> walls;

        public List<List<Point>> Walls
        {
            get { return walls; }
            set { walls = value; }
        }




    }
}
