
namespace Proyecto_final_endless_scroller
{
    partial class Endless_Scroller
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelScore = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MysteryBox = new System.Windows.Forms.PictureBox();
            this.Crouch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.T_rex = new System.Windows.Forms.PictureBox();
            this.PowerTimer = new System.Windows.Forms.Timer(this.components);
            this.LabelPower = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MysteryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crouch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_rex)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Consolas", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(23, 26);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(135, 33);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Score: 0";
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 20;
            this.MainTimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // MysteryBox
            // 
            this.MysteryBox.Image = global::Proyecto_final_endless_scroller.Properties.Resources.Mystery_Box__2_;
            this.MysteryBox.Location = new System.Drawing.Point(496, 133);
            this.MysteryBox.Name = "MysteryBox";
            this.MysteryBox.Size = new System.Drawing.Size(108, 99);
            this.MysteryBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MysteryBox.TabIndex = 7;
            this.MysteryBox.TabStop = false;
            this.MysteryBox.Tag = "Box";
            // 
            // Crouch
            // 
            this.Crouch.BackColor = System.Drawing.Color.Transparent;
            this.Crouch.Image = global::Proyecto_final_endless_scroller.Properties.Resources.crouch;
            this.Crouch.Location = new System.Drawing.Point(47, 367);
            this.Crouch.Name = "Crouch";
            this.Crouch.Size = new System.Drawing.Size(84, 52);
            this.Crouch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Crouch.TabIndex = 6;
            this.Crouch.TabStop = false;
            this.Crouch.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Proyecto_final_endless_scroller.Properties.Resources.Float_obstacle;
            this.pictureBox1.Location = new System.Drawing.Point(733, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Obstacle";
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Black;
            this.Ground.Location = new System.Drawing.Point(2, 419);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1257, 35);
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Proyecto_final_endless_scroller.Properties.Resources.obstacle_2;
            this.pictureBox3.Location = new System.Drawing.Point(496, 346);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Obstacle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Proyecto_final_endless_scroller.Properties.Resources.obstacle_1;
            this.pictureBox2.Location = new System.Drawing.Point(306, 335);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Obstacle";
            // 
            // T_rex
            // 
            this.T_rex.BackColor = System.Drawing.Color.Transparent;
            this.T_rex.Image = global::Proyecto_final_endless_scroller.Properties.Resources.running;
            this.T_rex.Location = new System.Drawing.Point(47, 335);
            this.T_rex.Name = "T_rex";
            this.T_rex.Size = new System.Drawing.Size(84, 84);
            this.T_rex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.T_rex.TabIndex = 1;
            this.T_rex.TabStop = false;
            // 
            // PowerTimer
            // 
            this.PowerTimer.Interval = 3000;
            this.PowerTimer.Tick += new System.EventHandler(this.PowerTimer_Tick);
            // 
            // LabelPower
            // 
            this.LabelPower.AutoSize = true;
            this.LabelPower.Font = new System.Drawing.Font("Consolas", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPower.Location = new System.Drawing.Point(486, 78);
            this.LabelPower.Name = "LabelPower";
            this.LabelPower.Size = new System.Drawing.Size(359, 40);
            this.LabelPower.TabIndex = 8;
            this.LabelPower.Text = "Invencibilidad OwO";
            this.LabelPower.Visible = false;
            // 
            // Endless_Scroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 455);
            this.Controls.Add(this.LabelPower);
            this.Controls.Add(this.MysteryBox);
            this.Controls.Add(this.Crouch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.T_rex);
            this.MaximizeBox = false;
            this.Name = "Endless_Scroller";
            this.Text = "Endless Scroller Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.MysteryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crouch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_rex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox T_rex;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Crouch;
        private System.Windows.Forms.PictureBox MysteryBox;
        private System.Windows.Forms.Timer PowerTimer;
        private System.Windows.Forms.Label LabelPower;
    }
}

