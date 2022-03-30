using Akadalypalya.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Akadalypalya
{
    public partial class Akadalypalya : Form
    {
        private Timer timer;
        private Button[,] buttonGrid;
        private AkadalypalyaModel model;
        private bool cango;
        public Akadalypalya()
        {
            InitializeComponent();
        }

        private void Akadalypalya_Load(object sender, EventArgs e)
        {
            model = new AkadalypalyaModel();
            //model.GameAdvanced += new EventHandler(Model_Advanced);
            model.GameOver += new EventHandler(Model_GameOver);

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(Timer_Tick);

            GenerateTable();

            model.NewGame();
            SetupTable();
            GetMoveButtons();
            cango = true;
            timer.Start();
        }

        private void GetMoveButtons()
        {
            Button up = new Button();
            up.Location = new Point(470, 150);
            up.Size = new Size(100, 50);
            up.Text = "UP";
            up.BackColor = Color.Gray;
            up.FlatStyle = FlatStyle.Standard;
            up.MouseClick += new MouseEventHandler(Up_Move);


            Button down = new Button();
            down.Location = new Point(470, 300);
            down.Size = new Size(100, 50);
            down.Text = "DOWN";
            down.BackColor = Color.Gray;
            down.FlatStyle = FlatStyle.Standard;
            down.MouseClick += new MouseEventHandler(Down_Move);

            Controls.Add(up);
            Controls.Add(down);
        }
        //Y oszlop
        //X sor
        private void Down_Move(object sender, MouseEventArgs e)
        {
            if (model.Me.X != 7 && timer.Enabled)
            model.Me = new Point(model.Me.X + 1, model.Me.Y);
        }

        private void Up_Move(object sender, MouseEventArgs e)
        {
            if (model.Me.X != 0 && timer.Enabled)
            model.Me = new Point(model.Me.X - 1, model.Me.Y);
        }

        private void SetupTable()
        {
            buttonGrid[model.PosX, model.PosY].BackColor = Color.Red;
        }

        private void GenerateTable()
        {
            buttonGrid = new Button[9, 9];
            for (Int32 i = 0; i < 9; i++)
                for (Int32 j = 0; j < 9; j++)
                {
                    buttonGrid[i, j] = new Button();
                    buttonGrid[i, j].Location = new Point(5 + 50 * j, 35 + 50 * i); 
                    buttonGrid[i, j].Size = new Size(50, 50); 
                    buttonGrid[i, j].Enabled = false; 
                    buttonGrid[i, j].TabIndex = 100 + i * 9 + j; 
                    buttonGrid[i, j].FlatStyle = FlatStyle.Flat;
                    buttonGrid[i, j].BackColor = Color.White;
                    //buttonGrid[i, j].Text = i + " " + j;

                    Controls.Add(buttonGrid[i, j]);

                }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            model.AdvanceTime(timer.Interval);
            eletLabel.Text = "HP: " + model.HP;
            pointLabel.Text = "Point: " + model.Point;
            Model_Advanced();
        }

        private void Model_GameOver(object sender, EventArgs e)
        {
            timer.Stop();
            cango = false;
            MessageBox.Show("Vége a játéknak! " + Environment.NewLine + "Összesen " + model.Point + " pontot gyűjtöttél!", "Akadálypálya játék", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //private void Model_Advanced(object sender, EventArgs e)
        //{
        //    //timerLabel.Text = "Time: " + model.Time;
        //    ClearTable();
        //    DrawWalls();
        //    SetupTable();
        //}

        private void Model_Advanced()
        {
            //timerLabel.Text = "Time: " + model.Time;
            ClearTable();
            DrawWalls();
            SetupTable();
        }

        private void ClearTable()
        {
            for (Int32 i = 0; i < 9; i++)
                for (Int32 j = 0; j < 9; j++)
                {
                    buttonGrid[i,j].BackColor = Color.White;
                }
        }

        private void DrawWalls()
        {
            foreach (List<Point> wall in model.Walls)
            {
                foreach (Point p in wall)
                {
                    buttonGrid[p.X, p.Y].BackColor = Color.DarkGray;
                }
            }
        }

        private void newGameMenu_Click(object sender, EventArgs e)
        {
            model.NewGame();
            timer.Start();
            cango = true;
        }

        private void pauseMenu_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void continueMenu_Click(object sender, EventArgs e)
        {
            if (cango)
                timer.Start();
        }
    }
}
