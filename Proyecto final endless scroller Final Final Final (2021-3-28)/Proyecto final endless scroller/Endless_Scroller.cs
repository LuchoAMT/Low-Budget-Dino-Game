using System;
using System.Windows.Forms;

namespace Proyecto_final_endless_scroller
{
    public partial class Endless_Scroller : Form
    {
        private bool gameOver;
        private int score;
        private bool stadoPower = false;

        Trex Dino = new Trex();
        Obstaculos obs = new Obstaculos();
        public Endless_Scroller()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            T_rex.Top += Dino.veloSalto - Dino.gravedad;
            labelScore.Text = "Score: " + score;
            Dino.Saltar();
            Dino.Agacharse();
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Box")
                {
                    x.Left -= obs.veloObst;
                    if (x.Left < -1)
                    {
                        x.Left = this.ClientSize.Width + obs.rndm.Next(2000, 5000) + (x.Width * 50);
                    }
                    if (T_rex.Visible & T_rex.Bounds.IntersectsWith(x.Bounds))
                    {
                        stadoPower = true;
                        PowerTimer.Start();
                        LabelPower.Visible = true;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "Obstacle")
                {
                    x.Left -= obs.veloObst;
                    if (x.Left < -10)
                    {
                        x.Left = this.ClientSize.Width + obs.rndm.Next(200, 800) + (x.Width*15);
                        score++;
                    }
                    if (stadoPower)
                    {
                        
                    }
                    else
                    {
                        if ((T_rex.Visible & T_rex.Bounds.IntersectsWith(x.Bounds)) || (Crouch.Visible & Crouch.Bounds.IntersectsWith(x.Bounds)))
                        {
                            MainTimer.Stop();
                            T_rex.Image = Properties.Resources.dead;
                            Crouch.Image = Properties.Resources.dead;
                            labelScore.Text += " Presiona R para reintentar";
                            gameOver = true;
                        }
                    }
                }
            }
            if (T_rex.Top > 143 && !Dino.saltando)
            {
                Dino.gravedad = 12;
                T_rex.Top = Ground.Bottom - Ground.Height - (T_rex.Height - 10);
                Dino.veloSalto = 0;
            }
            if (score >= 5)
            {
                obs.veloObst = 12;
            }
            if (score >= 10)
            {
                obs.veloObst = 15;
            }
            if (score >= 20)
            {
                obs.veloObst = 17;
            }
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && Dino.saltando == false)
            {
                Dino.saltando = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                Dino.agachado = true;
                T_rex.Visible = false;
                Crouch.Visible = true;
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && gameOver == true)
            {
                GameReset();
            }
            if (Dino.saltando)
            {
                Dino.saltando = false;
            }
            if (Dino.agachado && gameOver == false)
            {
                Dino.agachado = false;
                T_rex.Visible = true;
                Crouch.Visible = false;
            }
        }
        private void GameReset()
        {
            Dino.SetStartPos();
            obs.SetStartVel();
            score = 0;
            labelScore.Text = "Score: " + score;
            gameOver = false;
            T_rex.Top = Ground.Top - T_rex.Height; // = 146
            T_rex.Image = Properties.Resources.running;
            Crouch.Image = Properties.Resources.crouch;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Obstacle")
                {
                    int dinoPos = this.ClientSize.Width + obs.rndm.Next(200,800) + (x.Width * 10);
                    x.Left = dinoPos;
                }
                if (x is PictureBox && (string)x.Tag == "Box")
                {
                    int dinoPos = this.ClientSize.Width + obs.rndm.Next(2000, 5000) + (x.Width * 10);
                    x.Left = dinoPos;
                }
            }
            MainTimer.Start();
        }

        private void PowerTimer_Tick(object sender, EventArgs e)
        {
            // intervalo de 3 seg
            stadoPower = false;
            PowerTimer.Stop();
            LabelPower.Visible = false;
        }
    }
}
