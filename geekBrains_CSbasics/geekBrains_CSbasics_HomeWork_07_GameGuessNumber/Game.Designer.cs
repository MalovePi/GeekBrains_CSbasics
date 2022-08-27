namespace geekBrains_CSbasics_HomeWork_07_GameGuessNumber
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxDetective = new System.Windows.Forms.PictureBox();
            this.labelDetectiveText = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelText1 = new System.Windows.Forms.Label();
            this.textBoxPlayerInput = new System.Windows.Forms.TextBox();
            this.labelNumberAttempts = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetective)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(197)))), ((int)(((byte)(85)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxDetective);
            this.flowLayoutPanel1.Controls.Add(this.labelDetectiveText);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(310, 76);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxDetective
            // 
            this.pictureBoxDetective.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDetective.Image")));
            this.pictureBoxDetective.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxDetective.Name = "pictureBoxDetective";
            this.pictureBoxDetective.Size = new System.Drawing.Size(67, 70);
            this.pictureBoxDetective.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetective.TabIndex = 0;
            this.pictureBoxDetective.TabStop = false;
            // 
            // labelDetectiveText
            // 
            this.labelDetectiveText.AutoSize = true;
            this.labelDetectiveText.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetectiveText.Location = new System.Drawing.Point(78, 15);
            this.labelDetectiveText.Margin = new System.Windows.Forms.Padding(5, 15, 3, 0);
            this.labelDetectiveText.Name = "labelDetectiveText";
            this.labelDetectiveText.Size = new System.Drawing.Size(214, 48);
            this.labelDetectiveText.TabIndex = 1;
            this.labelDetectiveText.Text = "I have a random number \r\nbetween 1 - 100\r\nDare to guess?";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(197)))), ((int)(((byte)(85)))));
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel2.Controls.Add(this.labelText1);
            this.flowLayoutPanel2.Controls.Add(this.textBoxPlayerInput);
            this.flowLayoutPanel2.Controls.Add(this.labelNumberAttempts);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 103);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(310, 116);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // labelText1
            // 
            this.labelText1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelText1.AutoSize = true;
            this.labelText1.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 10F);
            this.labelText1.Location = new System.Drawing.Point(20, 10);
            this.labelText1.Margin = new System.Windows.Forms.Padding(20, 10, 1, 1);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(273, 14);
            this.labelText1.TabIndex = 1;
            this.labelText1.Text = "Enter your guess below and press enter";
            this.labelText1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPlayerInput
            // 
            this.textBoxPlayerInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(93)))));
            this.textBoxPlayerInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flowLayoutPanel2.SetFlowBreak(this.textBoxPlayerInput, true);
            this.textBoxPlayerInput.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPlayerInput.ForeColor = System.Drawing.Color.Black;
            this.textBoxPlayerInput.Location = new System.Drawing.Point(88, 35);
            this.textBoxPlayerInput.Margin = new System.Windows.Forms.Padding(88, 10, 3, 3);
            this.textBoxPlayerInput.MaxLength = 3;
            this.textBoxPlayerInput.Name = "textBoxPlayerInput";
            this.textBoxPlayerInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPlayerInput.Size = new System.Drawing.Size(133, 48);
            this.textBoxPlayerInput.TabIndex = 0;
            this.textBoxPlayerInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPlayerInput.TextChanged += new System.EventHandler(this.textBoxPlayerInput_TextChanged);
            // 
            // labelNumberAttempts
            // 
            this.labelNumberAttempts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNumberAttempts.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 10F);
            this.labelNumberAttempts.Location = new System.Drawing.Point(89, 93);
            this.labelNumberAttempts.Margin = new System.Windows.Forms.Padding(89, 7, 3, 0);
            this.labelNumberAttempts.Name = "labelNumberAttempts";
            this.labelNumberAttempts.Size = new System.Drawing.Size(141, 23);
            this.labelNumberAttempts.TabIndex = 2;
            this.labelNumberAttempts.Text = "Number attempts: 0";
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(93)))));
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonRestart.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(197)))), ((int)(((byte)(85)))));
            this.buttonRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(197)))), ((int)(((byte)(85)))));
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRestart.Location = new System.Drawing.Point(12, 314);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(310, 35);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "RESTART";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.UseWaitCursor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(197)))), ((int)(((byte)(85)))));
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message from a detective";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(7, 26);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(215, 12);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Hello! You\'re ready? Click restart.";
            this.labelStatus.UseWaitCursor = true;
            // 
            // Game
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameGuessNumber";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetective)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxDetective;
        private System.Windows.Forms.Label labelDetectiveText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxPlayerInput;
        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.Label labelNumberAttempts;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelStatus;
    }
}