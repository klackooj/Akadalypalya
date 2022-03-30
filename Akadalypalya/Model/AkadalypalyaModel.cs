using Akadalypalya.Persistence;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Akadalypalya.Model
{
    public class AkadalypalyaModel
    {
        private AkadalypalyaTable table;
        private Random random;
        public int PosX { get { return table.Me.X; } }
        public int PosY { get { return table.Me.Y; } }
        public Point Me { get { return table.Me; } set { table.Me = value; } }
        public int HP { get { return table.HP; } }
        public int Point { get { return table.Point; } }

        public int Time { get { return table.Time; } }
        public List<List<Point>> Walls { get { return table.Walls; } }

        //public event EventHandler GameAdvanced;
        public event EventHandler GameOver;

        public AkadalypalyaModel()
        {
            table = new AkadalypalyaTable();
            table.Walls = new List<List<Point>>();
            random = new Random();
        }
        public void NewGame()
        {

            table.Me = new Point(9/2,0);
            table.HP = 3;
            table.Time = 0;
            table.Point = 0;
            table.Walls.Clear();
            GetWall();
            //OnGameAdvanced();
        }

        private void GetWall()
        {
            if (Time % 5000 == 0)
            {
                int s = random.Next(1, 6);
                int h = random.Next(0, 9 - s);
                List<Point> points = new List<Point>();
                for (int i = 0; i < s; i++)
                {
                    points.Add(new Point(h + i, 8));
                }
                table.Walls.Add(points);
                

            }
        }

        public void AdvanceTime(int interval)
        {
            table.Time += interval;
            if (table.Time % 1000 != 0) return;
            if (!IsGameOver())
            {
                MoveWall();
                GetWall();
                //OnGameAdvanced();
            }
            else
            {
                OnGameOver();
            }
        }
        
        private void MoveWall()
        {
            if (table.Walls[0][0].Y == 0)
            {
                table.Walls.RemoveAt(0);
                table.Point += 1;
            }

            List<List<Point>> points = new List<List<Point>>();
            foreach (List<Point> lista in table.Walls)
            {
                List<Point> tmp = new List<Point>();
                foreach (Point p in lista)
                {
                    tmp.Add(new Point(p.X, p.Y - 1));
                }
                points.Add(tmp);
            }
            table.Walls = points;
        }

        private void OnGameOver()
        {
            GameOver?.Invoke(this, EventArgs.Empty);
        }

        //private void OnGameAdvanced()
        //{
        //    GameAdvanced?.Invoke(this, EventArgs.Empty);
        //}

        private bool IsGameOver()
        {
            bool isGameOver = false;
            foreach (List<Point> lista in table.Walls)
            {
                foreach (Point p in lista)
                {
                    isGameOver |= table.Me.Equals(p);
                }
            }
            if (isGameOver)
                table.HP -= 1;

            return isGameOver && table.HP <= 0;
        }
    }
}
