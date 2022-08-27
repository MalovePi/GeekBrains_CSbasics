namespace geekBrains_CSbasics_HomeWork_07_GameDoubler
{
    partial class Main
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
            System.Windows.Forms.Button buttonPlus;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDoublerGame = new System.Windows.Forms.Label();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonOndo = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.labelScope = new System.Windows.Forms.Label();
            this.groupBoxGetNumber = new System.Windows.Forms.GroupBox();
            this.labelGameNumber = new System.Windows.Forms.Label();
            this.groupBoxPlayerNumber = new System.Windows.Forms.GroupBox();
            this.labelPlayerNumber = new System.Windows.Forms.Label();
            buttonPlus = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBoxScore.SuspendLayout();
            this.groupBoxGetNumber.SuspendLayout();
            this.groupBoxPlayerNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = System.Drawing.Color.White;
            buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            buttonPlus.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            buttonPlus.Location = new System.Drawing.Point(215, 189);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new System.Drawing.Size(115, 80);
            buttonPlus.TabIndex = 3;
            buttonPlus.Text = "+1";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newGameToolStripMenuItem.Image")));
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.labelDoublerGame);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 84);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelDoublerGame
            // 
            this.labelDoublerGame.AutoSize = true;
            this.labelDoublerGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDoublerGame.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoublerGame.Location = new System.Drawing.Point(94, 0);
            this.labelDoublerGame.Name = "labelDoublerGame";
            this.labelDoublerGame.Size = new System.Drawing.Size(231, 84);
            this.labelDoublerGame.TabIndex = 1;
            this.labelDoublerGame.Text = "Doubler Game";
            this.labelDoublerGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMultiply.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMultiply.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.Location = new System.Drawing.Point(215, 275);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(115, 80);
            this.buttonMultiply.TabIndex = 2;
            this.buttonMultiply.Text = "x2";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonOndo
            // 
            this.buttonOndo.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOndo.Location = new System.Drawing.Point(215, 151);
            this.buttonOndo.Name = "buttonOndo";
            this.buttonOndo.Size = new System.Drawing.Size(115, 33);
            this.buttonOndo.TabIndex = 4;
            this.buttonOndo.Text = "undo";
            this.buttonOndo.UseVisualStyleBackColor = true;
            this.buttonOndo.Click += new System.EventHandler(this.buttonOndo_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(215, 112);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(115, 33);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel2.Controls.Add(this.groupBoxScore);
            this.flowLayoutPanel2.Controls.Add(this.groupBoxGetNumber);
            this.flowLayoutPanel2.Controls.Add(this.groupBoxPlayerNumber);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 112);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(203, 243);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.labelScope);
            this.groupBoxScore.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxScore.Location = new System.Drawing.Point(3, 3);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Size = new System.Drawing.Size(130, 51);
            this.groupBoxScore.TabIndex = 2;
            this.groupBoxScore.TabStop = false;
            this.groupBoxScore.Text = "Score";
            // 
            // labelScope
            // 
            this.labelScope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.labelScope.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelScope.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScope.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelScope.Location = new System.Drawing.Point(80, 12);
            this.labelScope.Name = "labelScope";
            this.labelScope.Size = new System.Drawing.Size(44, 36);
            this.labelScope.TabIndex = 2;
            this.labelScope.Text = "0";
            this.labelScope.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBoxGetNumber
            // 
            this.groupBoxGetNumber.Controls.Add(this.labelGameNumber);
            this.groupBoxGetNumber.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGetNumber.Location = new System.Drawing.Point(3, 60);
            this.groupBoxGetNumber.Name = "groupBoxGetNumber";
            this.groupBoxGetNumber.Size = new System.Drawing.Size(184, 82);
            this.groupBoxGetNumber.TabIndex = 1;
            this.groupBoxGetNumber.TabStop = false;
            this.groupBoxGetNumber.Text = "Get a number";
            // 
            // labelGameNumber
            // 
            this.labelGameNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.labelGameNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelGameNumber.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGameNumber.Location = new System.Drawing.Point(90, 16);
            this.labelGameNumber.Name = "labelGameNumber";
            this.labelGameNumber.Size = new System.Drawing.Size(75, 60);
            this.labelGameNumber.TabIndex = 1;
            this.labelGameNumber.Text = "0";
            this.labelGameNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBoxPlayerNumber
            // 
            this.groupBoxPlayerNumber.Controls.Add(this.labelPlayerNumber);
            this.groupBoxPlayerNumber.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPlayerNumber.Location = new System.Drawing.Point(3, 148);
            this.groupBoxPlayerNumber.Name = "groupBoxPlayerNumber";
            this.groupBoxPlayerNumber.Size = new System.Drawing.Size(184, 82);
            this.groupBoxPlayerNumber.TabIndex = 0;
            this.groupBoxPlayerNumber.TabStop = false;
            this.groupBoxPlayerNumber.Text = "Doubler";
            // 
            // labelPlayerNumber
            // 
            this.labelPlayerNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.labelPlayerNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelPlayerNumber.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayerNumber.Location = new System.Drawing.Point(90, 16);
            this.labelPlayerNumber.Name = "labelPlayerNumber";
            this.labelPlayerNumber.Size = new System.Drawing.Size(75, 60);
            this.labelPlayerNumber.TabIndex = 0;
            this.labelPlayerNumber.Text = "0";
            this.labelPlayerNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonOndo);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(buttonPlus);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameDoubler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBoxScore.ResumeLayout(false);
            this.groupBoxGetNumber.ResumeLayout(false);
            this.groupBoxPlayerNumber.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDoublerGame;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonOndo;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxPlayerNumber;
        private System.Windows.Forms.Label labelPlayerNumber;
        private System.Windows.Forms.GroupBox groupBoxGetNumber;
        private System.Windows.Forms.Label labelGameNumber;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.Label labelScope;
    }
}

