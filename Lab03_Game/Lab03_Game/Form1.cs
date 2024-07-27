/*
 * Khushi kheti
 * Course: CMPE 1666 A02
 * Assingment –Lab 3 BallZ
 * Date of submission - 10-04-2024
 * Description -  Lab3 Ballz graphical game, dropping the balls
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using GDIDrawer;
using System.Drawing;
using System.Threading;
using System.IO;


namespace Lab03_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Form Objects declaration
        Score SDialog = new Score();
        Animation ADialog = new Animation();
        HighScore Highscore = new HighScore();
        public enum State
        {
            alive,
            dead
        };
        public struct ballInfo
        {
            public Color Col;
            public State Sat;
            public ballInfo(Color col, State sat)
            {
                this.Col = col;
                this.Sat = sat;
            }

        }

       /// <summary>
       /// Creating the GDI Drawer Window
       /// Random, Color Array Declaration
       /// </summary>

        public SelectDifficulty dialog = null;
        int ChoiceRec = 0;
        Random rand = new Random();
        Color[] col = new Color[] { Color.Green, Color.Orange, Color.Red, Color.Chartreuse, Color.Blue };
        ballInfo[,] Arr = new ballInfo[16, 12];
        CDrawer Canvas = new CDrawer(800,600);
        int UserScore;


        private void UI_Play_btn_Click(object sender, EventArgs e)
        {
            if(dialog == null)
            {
                dialog = new SelectDifficulty();

            }
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                ChoiceRec = dialog.Choice;                          //Passing the Difficukty Level to the Main form for GDI Window Creation
                Randomize();
                Display();
            }
        }
        //********************************************************************************************
        //Method: private void Randomize()
        //Purpose: Intializes the global 2D array with random colours 
        //         According to the selected difficulty
        //Parameters: None 
        //Returns: none
        //*********************************************************************************************
        private void Randomize()
        {
            
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    
                    Arr[i, j] = new ballInfo(col[rand.Next(ChoiceRec)], State.alive);           //Creating the 2D array of Struct Type

                }

            }
        }
        //********************************************************************************************
        //Method: private void Display()
        //Purpose: Displays the Balls on the Screen according to the 2D array values
        //Parameters: None 
        //Returns: none
        //*********************************************************************************************
        private void Display()
        {
            Canvas.Clear();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (Arr[i, j].Sat == State.alive)
                    {
                        Color c = Arr[i, j].Col;
                        Canvas.AddEllipse(i * 50, j * 50, 50, 50, Arr[i, j].Col);
                    }
                }
            }

        }

        //********************************************************************************************
        //Method: private int pick()
        //Purpose: Checks for the Lst Mouse Left click on the balls
        //Parameters: None 
        //Returns: none
        //*********************************************************************************************
        private int pick()
        {
            Point point = new Point();
            int Score = 0;
            int numkilled = 0;

            if (Canvas.GetLastMouseLeftClick(out point))
            {
                int row = point.X / 50;
                int col = point.Y / 50;
                if (Arr[row, col].Sat == State.dead)
                {
                    Console.Beep();
                }
                else
                {
                    CheckBalls(row, col, Arr[row, col].Col);
                    numkilled = FallDown();
                    Score += numkilled * 50;
                    if (numkilled > 1)                          //Calculating the Score
                    {
                        Score += 10;
                    }
                }
            }
            return Score;
        }
        //********************************************************************************************
        //Method: private int pick()
        //Purpose: Checks for the Lst Mouse Left click on the balls
        //Parameters: None 
        //Returns: The Number of balls killed
        //*********************************************************************************************
        //Returns the Number of Balls Killed of the Same Colour when the user clicks on the Ball, and set them to dead
        private int CheckBalls(int row, int col, Color color)
        {


            if (row >= 16 || row < 0)
            {
                return 0;

            }
            if (col >= 12 || col < 0)
            {
                return 0;
            }
            if (Arr[row, col].Sat == State.dead)
            {
                return 0;
            }
            if (Arr[row, col].Col != color)
            {
                return 0;
            }
            int NumKilled = 1;
            Arr[row, col].Sat = State.dead;


            NumKilled += CheckBalls(row, col - 1, color);
            NumKilled += CheckBalls(row, col + 1, color);
            NumKilled += CheckBalls(row - 1, col, color);
            NumKilled += CheckBalls(row + 1, col, color);
            return NumKilled;


        }

        //invoke StepDown() repeatedly until the return value indicates no balls dropped
        private int FallDown()
        {
            int total = 0;
            int ans = StepDown();
            total += ans;
            while (ans != 0)
            {
                ans = StepDown();
                total += ans;
            }
            return total;
        }

        //- “Drop” all the balls in our grid by one level
        private int StepDown()
        {
            int Num_dropped = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (Arr[i, j].Sat == State.dead)
                    {
                        if (j - 1 < Arr.GetLength(0) && j - 1 >= 0)
                        {
                            if (Arr[i, j - 1].Sat == State.alive)
                            {
                                Arr[i, j] = Arr[i, j - 1];
                                Arr[i, j - 1].Sat = State.dead;
                                Num_dropped++;
                            }
                        }

                    }
                }
                
                Display();
                Thread.Sleep(ADialog.FallDelay);
            }
            return Num_dropped;
        }

        //– a worker method that counts balls that are alive
        private int BallsAllive()
        {
            int Count_Alive = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (Arr[i, j].Sat == State.alive)
                    {
                        Count_Alive++;
                    }
                }
            }
            return Count_Alive;
        }

        //Passes the Score Value and the High Sore Value for the File
        private void UI_Timer_Tick(object sender, EventArgs e)
        {
             UserScore  += pick();
            int AliveBalls = BallsAllive();
            if(AliveBalls != 0)
            {
                if (UserScore != 0)
                {
                    SDialog.ScoreVal = UserScore.ToString();

                }
            }
            else
            {
                Canvas.Clear();
                Canvas.AddText("Game Over", 96);
                Highscore.Show();
                if(Highscore.DialogResult == DialogResult.OK)
                {
                    File.WriteAllText("file1.txt", Highscore.UserName+" Score: "+ UserScore+" Difficulty level "+ChoiceRec);
                }
            }
            
        }
        //Opens and Closes form on checkbox
        private void UI_Show_Score_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_Show_Score_Cbx.Checked)
            {
                SDialog.Show();
                
                SDialog.ScoreFormClose = closing_method;
            }
            else
            {
                SDialog.Hide();
            }
        }
        private void closing_method()
        {
            UI_Show_Score_Cbx.Checked = false;
        }
        //Closes and opens the form on CheckBox
        private void UI_Animation_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            if(UI_Animation_Cbx.Checked)
            {
                ADialog.Show();
                ADialog.AnimationDelay = closing_method_delay;
            }
            else
            {
                ADialog.Hide();
            }
        }
        private void closing_method_delay()
        {
           UI_Animation_Cbx.Checked = false;
        }
    }
}
