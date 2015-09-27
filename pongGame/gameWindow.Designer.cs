namespace pongGame
{
    partial class gameWindow
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
            this.playerOne = new System.Windows.Forms.PictureBox();
            this.playerTwo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // playerOne
            // 
            this.playerOne.Image = global::pongGame.Properties.Resources.player;
            this.playerOne.Location = new System.Drawing.Point(40, 132);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(10, 70);
            this.playerOne.TabIndex = 0;
            this.playerOne.TabStop = false;
            this.playerOne.Click += new System.EventHandler(this.playerOne_Click);
            // 
            // playerTwo
            // 
            this.playerTwo.Image = global::pongGame.Properties.Resources.player;
            this.playerTwo.Location = new System.Drawing.Point(734, 132);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(10, 70);
            this.playerTwo.TabIndex = 1;
            this.playerTwo.TabStop = false;
            // 
            // gameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.playerOne);
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "gameWindow";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.gameWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerOne;
        private System.Windows.Forms.PictureBox playerTwo;
    }
}