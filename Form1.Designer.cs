namespace gameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stableButton = new System.Windows.Forms.Button();
            this.oscylatorButton = new System.Windows.Forms.Button();
            this.gliderButton = new System.Windows.Forms.Button();
            this.gliderGunButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.resetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridButton = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 650);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // stableButton
            // 
            this.stableButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.stableButton.Location = new System.Drawing.Point(961, 28);
            this.stableButton.Name = "stableButton";
            this.stableButton.Size = new System.Drawing.Size(176, 30);
            this.stableButton.TabIndex = 1;
            this.stableButton.Text = "stabilne";
            this.stableButton.UseVisualStyleBackColor = false;
            this.stableButton.Click += new System.EventHandler(this.stableButton_Click);
            // 
            // oscylatorButton
            // 
            this.oscylatorButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.oscylatorButton.Location = new System.Drawing.Point(961, 64);
            this.oscylatorButton.Name = "oscylatorButton";
            this.oscylatorButton.Size = new System.Drawing.Size(176, 30);
            this.oscylatorButton.TabIndex = 2;
            this.oscylatorButton.Text = "oscylator";
            this.oscylatorButton.UseVisualStyleBackColor = false;
            this.oscylatorButton.Click += new System.EventHandler(this.oscylatorButton_Click);
            // 
            // gliderButton
            // 
            this.gliderButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gliderButton.Location = new System.Drawing.Point(961, 100);
            this.gliderButton.Name = "gliderButton";
            this.gliderButton.Size = new System.Drawing.Size(176, 30);
            this.gliderButton.TabIndex = 3;
            this.gliderButton.Text = "glider";
            this.gliderButton.UseVisualStyleBackColor = false;
            this.gliderButton.Click += new System.EventHandler(this.gliderButton_Click);
            // 
            // gliderGunButton
            // 
            this.gliderGunButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gliderGunButton.Location = new System.Drawing.Point(961, 136);
            this.gliderGunButton.Name = "gliderGunButton";
            this.gliderGunButton.Size = new System.Drawing.Size(176, 30);
            this.gliderGunButton.TabIndex = 4;
            this.gliderGunButton.Text = "glider gun";
            this.gliderGunButton.UseVisualStyleBackColor = false;
            this.gliderGunButton.Click += new System.EventHandler(this.gliderGunButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.randomButton.Location = new System.Drawing.Point(961, 172);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(176, 30);
            this.randomButton.TabIndex = 5;
            this.randomButton.Text = "random";
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Firebrick;
            this.stopButton.Location = new System.Drawing.Point(961, 290);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(176, 30);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 92);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(187, 69);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Gold;
            this.resetButton.Location = new System.Drawing.Point(961, 326);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(176, 30);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LimeGreen;
            this.startButton.Location = new System.Drawing.Point(961, 254);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(176, 30);
            this.startButton.TabIndex = 18;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "speed";
            // 
            // gridButton
            // 
            this.gridButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gridButton.Location = new System.Drawing.Point(961, 362);
            this.gridButton.Name = "gridButton";
            this.gridButton.Size = new System.Drawing.Size(176, 30);
            this.gridButton.TabIndex = 20;
            this.gridButton.Text = "grid";
            this.gridButton.UseVisualStyleBackColor = false;
            this.gridButton.Click += new System.EventHandler(this.gridButton_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 33);
            this.trackBar2.Maximum = 40;
            this.trackBar2.Minimum = 5;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(188, 69);
            this.trackBar2.TabIndex = 21;
            this.trackBar2.Value = 10;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "size";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(944, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 211);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(944, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 171);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.trackBar2);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Location = new System.Drawing.Point(944, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 239);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "w";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 26);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 26);
            this.textBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1178, 694);
            this.Controls.Add(this.gridButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.gliderGunButton);
            this.Controls.Add(this.gliderButton);
            this.Controls.Add(this.oscylatorButton);
            this.Controls.Add(this.stableButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button stableButton;
        private System.Windows.Forms.Button oscylatorButton;
        private System.Windows.Forms.Button gliderButton;
        private System.Windows.Forms.Button gliderGunButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gridButton;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

