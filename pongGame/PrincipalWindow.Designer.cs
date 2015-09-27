namespace pongGame
{
    partial class PrincipalWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalWindow));
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnHighscores = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cpyr = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Image = global::pongGame.Properties.Resources.backgroundPong;
            this.btnStartGame.Location = new System.Drawing.Point(67, 122);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(222, 47);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnHighscores
            // 
            this.btnHighscores.ForeColor = System.Drawing.Color.White;
            this.btnHighscores.Image = global::pongGame.Properties.Resources.backgroundPong;
            this.btnHighscores.Location = new System.Drawing.Point(67, 175);
            this.btnHighscores.Name = "btnHighscores";
            this.btnHighscores.Size = new System.Drawing.Size(222, 48);
            this.btnHighscores.TabIndex = 1;
            this.btnHighscores.Text = "Highscores";
            this.btnHighscores.UseVisualStyleBackColor = true;
            this.btnHighscores.Click += new System.EventHandler(this.btnHighscores_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::pongGame.Properties.Resources.backgroundPong;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbout.Location = new System.Drawing.Point(127, 229);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 37);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "PONG";
            // 
            // cpyr
            // 
            this.cpyr.AutoSize = true;
            this.cpyr.BackColor = System.Drawing.Color.Transparent;
            this.cpyr.Cursor = System.Windows.Forms.Cursors.No;
            this.cpyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.cpyr.Location = new System.Drawing.Point(271, 63);
            this.cpyr.Name = "cpyr";
            this.cpyr.Size = new System.Drawing.Size(34, 29);
            this.cpyr.TabIndex = 4;
            this.cpyr.Text = "©";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // PrincipalWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::pongGame.Properties.Resources.backgroundMenu1;
            this.ClientSize = new System.Drawing.Size(367, 292);
            this.Controls.Add(this.cpyr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHighscores);
            this.Controls.Add(this.btnStartGame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalWindow";
            this.Text = "MENU PONG";
            this.Load += new System.EventHandler(this.PrincipalWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnHighscores;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cpyr;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}