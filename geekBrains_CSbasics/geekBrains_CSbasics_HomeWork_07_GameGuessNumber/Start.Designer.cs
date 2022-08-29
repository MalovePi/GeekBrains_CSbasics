namespace geekBrains_CSbasics_HomeWork_07_GameGuessNumber
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNameGame = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonQuitGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNameGame
            // 
            this.labelNameGame.AutoSize = true;
            this.labelNameGame.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameGame.Location = new System.Drawing.Point(20, 158);
            this.labelNameGame.Name = "labelNameGame";
            this.labelNameGame.Size = new System.Drawing.Size(303, 32);
            this.labelNameGame.TabIndex = 1;
            this.labelNameGame.Text = "Guess Number game";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.buttonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartGame.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStartGame.Location = new System.Drawing.Point(97, 220);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(131, 33);
            this.buttonStartGame.TabIndex = 2;
            this.buttonStartGame.Text = "START GAME";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInfo.Location = new System.Drawing.Point(97, 259);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(131, 33);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "INFO";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonQuitGame
            // 
            this.buttonQuitGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.buttonQuitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitGame.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuitGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonQuitGame.Location = new System.Drawing.Point(97, 298);
            this.buttonQuitGame.Name = "buttonQuitGame";
            this.buttonQuitGame.Size = new System.Drawing.Size(131, 33);
            this.buttonQuitGame.TabIndex = 4;
            this.buttonQuitGame.Text = "QUIT GAME";
            this.buttonQuitGame.UseVisualStyleBackColor = true;
            this.buttonQuitGame.Click += new System.EventHandler(this.buttonQuitGame_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.buttonQuitGame);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelNameGame);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameGuessNumber";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNameGame;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonQuitGame;
    }
}

