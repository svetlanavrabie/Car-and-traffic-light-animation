namespace SimulateurSignalisation
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.car = new System.Windows.Forms.PictureBox();
            this.greenstop = new System.Windows.Forms.PictureBox();
            this.yellowstop = new System.Windows.Forms.PictureBox();
            this.redstop = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenstop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowstop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redstop)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(411, 52);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 32);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(411, 148);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 32);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // car
            // 
            this.car.Image = global::SimulateurSignalisation.Properties.Resources.cars;
            this.car.Location = new System.Drawing.Point(162, 427);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(175, 137);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 5;
            this.car.TabStop = false;
            // 
            // greenstop
            // 
            this.greenstop.Image = global::SimulateurSignalisation.Properties.Resources.vert;
            this.greenstop.Location = new System.Drawing.Point(166, 41);
            this.greenstop.Name = "greenstop";
            this.greenstop.Size = new System.Drawing.Size(171, 356);
            this.greenstop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greenstop.TabIndex = 2;
            this.greenstop.TabStop = false;
            // 
            // yellowstop
            // 
            this.yellowstop.Image = global::SimulateurSignalisation.Properties.Resources.jeune;
            this.yellowstop.Location = new System.Drawing.Point(166, 41);
            this.yellowstop.Name = "yellowstop";
            this.yellowstop.Size = new System.Drawing.Size(176, 352);
            this.yellowstop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.yellowstop.TabIndex = 1;
            this.yellowstop.TabStop = false;
            // 
            // redstop
            // 
            this.redstop.Image = global::SimulateurSignalisation.Properties.Resources.rouge;
            this.redstop.Location = new System.Drawing.Point(162, 41);
            this.redstop.Name = "redstop";
            this.redstop.Size = new System.Drawing.Size(180, 356);
            this.redstop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redstop.TabIndex = 0;
            this.redstop.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 587);
            this.Controls.Add(this.car);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.greenstop);
            this.Controls.Add(this.yellowstop);
            this.Controls.Add(this.redstop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenstop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowstop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redstop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redstop;
        private System.Windows.Forms.PictureBox yellowstop;
        private System.Windows.Forms.PictureBox greenstop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Timer timer2;
    }
}

