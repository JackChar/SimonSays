namespace SimonSays
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameOver = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.mainScreenButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.Font = new System.Drawing.Font("Trajan Pro", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.ForeColor = System.Drawing.SystemColors.Window;
            this.gameOver.Location = new System.Drawing.Point(85, 87);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(234, 44);
            this.gameOver.TabIndex = 0;
            this.gameOver.Text = "Game Over";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Trajan Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.highScoreLabel.Location = new System.Drawing.Point(110, 175);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(187, 26);
            this.highScoreLabel.TabIndex = 1;
            this.highScoreLabel.Text = "Yor score was ";
            // 
            // mainScreenButton
            // 
            this.mainScreenButton.Font = new System.Drawing.Font("Trajan Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenButton.Location = new System.Drawing.Point(146, 274);
            this.mainScreenButton.Name = "mainScreenButton";
            this.mainScreenButton.Size = new System.Drawing.Size(107, 23);
            this.mainScreenButton.TabIndex = 2;
            this.mainScreenButton.Text = "Main Screen";
            this.mainScreenButton.UseVisualStyleBackColor = true;
            this.mainScreenButton.Click += new System.EventHandler(this.mainScreenButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Trajan Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.scoreLabel.Location = new System.Drawing.Point(192, 214);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 26);
            this.scoreLabel.TabIndex = 3;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.mainScreenButton);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.gameOver);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Button mainScreenButton;
        private System.Windows.Forms.Label scoreLabel;
    }
}
