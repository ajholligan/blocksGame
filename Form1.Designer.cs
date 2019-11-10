namespace Assignment_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.multiLbl = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeTrialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLbl = new System.Windows.Forms.Label();
            this.menuBack = new System.Windows.Forms.PictureBox();
            this.HomeTLbl = new System.Windows.Forms.Label();
            this.ClassicBtn = new System.Windows.Forms.Button();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.TimeBtn = new System.Windows.Forms.Button();
            this.plus2Lbl = new System.Windows.Forms.Label();
            this.CountdownLbl = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.PictureBox();
            this.boardHomeBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.multiplayerBtn = new System.Windows.Forms.Button();
            this.P2ScoreLbl = new System.Windows.Forms.Label();
            this.P1ScoreLbl = new System.Windows.Forms.Label();
            this.turnLbl = new System.Windows.Forms.Label();
            this.multiplayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // multiLbl
            // 
            this.multiLbl.AutoSize = true;
            this.multiLbl.BackColor = System.Drawing.Color.White;
            this.multiLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiLbl.Location = new System.Drawing.Point(844, 329);
            this.multiLbl.Name = "multiLbl";
            this.multiLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.multiLbl.Size = new System.Drawing.Size(313, 44);
            this.multiLbl.TabIndex = 2;
            this.multiLbl.Text = "X3 MULTIPLIER!!!";
            this.multiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.multiLbl.Click += new System.EventHandler(this.multiLbl_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.White;
            this.scoreLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(886, 455);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(203, 50);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "SCORE: 0";
            this.scoreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(121)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(800, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 787);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameModeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameModeToolStripMenuItem
            // 
            this.gameModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeTrialToolStripMenuItem,
            this.classicToolStripMenuItem,
            this.multiplayerToolStripMenuItem});
            this.gameModeToolStripMenuItem.Name = "gameModeToolStripMenuItem";
            this.gameModeToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.gameModeToolStripMenuItem.Text = "Game Mode";
            // 
            // timeTrialToolStripMenuItem
            // 
            this.timeTrialToolStripMenuItem.Name = "timeTrialToolStripMenuItem";
            this.timeTrialToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.timeTrialToolStripMenuItem.Text = "Time Trial";
            this.timeTrialToolStripMenuItem.Click += new System.EventHandler(this.timeTrialToolStripMenuItem_Click);
            // 
            // classicToolStripMenuItem
            // 
            this.classicToolStripMenuItem.Name = "classicToolStripMenuItem";
            this.classicToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.classicToolStripMenuItem.Text = "Classic";
            this.classicToolStripMenuItem.Click += new System.EventHandler(this.classicToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.White;
            this.timeLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(849, 188);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(215, 61);
            this.timeLbl.TabIndex = 6;
            this.timeLbl.Text = "TIME: 60";
            this.timeLbl.Click += new System.EventHandler(this.timeLbl_Click);
            // 
            // menuBack
            // 
            this.menuBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(121)))));
            this.menuBack.Location = new System.Drawing.Point(3, 31);
            this.menuBack.Name = "menuBack";
            this.menuBack.Size = new System.Drawing.Size(1179, 743);
            this.menuBack.TabIndex = 7;
            this.menuBack.TabStop = false;
            this.menuBack.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // HomeTLbl
            // 
            this.HomeTLbl.AutoSize = true;
            this.HomeTLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(121)))));
            this.HomeTLbl.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTLbl.Location = new System.Drawing.Point(311, 64);
            this.HomeTLbl.Name = "HomeTLbl";
            this.HomeTLbl.Size = new System.Drawing.Size(515, 83);
            this.HomeTLbl.TabIndex = 8;
            this.HomeTLbl.Text = "TILE MATCH";
            // 
            // ClassicBtn
            // 
            this.ClassicBtn.BackColor = System.Drawing.Color.White;
            this.ClassicBtn.Location = new System.Drawing.Point(307, 188);
            this.ClassicBtn.Name = "ClassicBtn";
            this.ClassicBtn.Size = new System.Drawing.Size(243, 111);
            this.ClassicBtn.TabIndex = 9;
            this.ClassicBtn.Text = "Classic";
            this.ClassicBtn.UseVisualStyleBackColor = false;
            this.ClassicBtn.Click += new System.EventHandler(this.ClassicBtn_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.White;
            this.HelpBtn.Location = new System.Drawing.Point(307, 353);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(243, 111);
            this.HelpBtn.TabIndex = 10;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = false;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(459, 510);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(243, 111);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // TimeBtn
            // 
            this.TimeBtn.BackColor = System.Drawing.Color.White;
            this.TimeBtn.Location = new System.Drawing.Point(609, 188);
            this.TimeBtn.Name = "TimeBtn";
            this.TimeBtn.Size = new System.Drawing.Size(243, 111);
            this.TimeBtn.TabIndex = 12;
            this.TimeBtn.Text = "Time Trial";
            this.TimeBtn.UseVisualStyleBackColor = false;
            this.TimeBtn.Click += new System.EventHandler(this.TimeBtn_Click);
            // 
            // plus2Lbl
            // 
            this.plus2Lbl.AutoSize = true;
            this.plus2Lbl.BackColor = System.Drawing.Color.White;
            this.plus2Lbl.Font = new System.Drawing.Font("Franklin Gothic Book", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus2Lbl.Location = new System.Drawing.Point(1070, 188);
            this.plus2Lbl.Name = "plus2Lbl";
            this.plus2Lbl.Size = new System.Drawing.Size(85, 61);
            this.plus2Lbl.TabIndex = 13;
            this.plus2Lbl.Text = "+2";
            // 
            // CountdownLbl
            // 
            this.CountdownLbl.AutoSize = true;
            this.CountdownLbl.BackColor = System.Drawing.Color.White;
            this.CountdownLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLbl.Location = new System.Drawing.Point(330, 329);
            this.CountdownLbl.Margin = new System.Windows.Forms.Padding(0);
            this.CountdownLbl.MaximumSize = new System.Drawing.Size(160, 140);
            this.CountdownLbl.MinimumSize = new System.Drawing.Size(140, 140);
            this.CountdownLbl.Name = "CountdownLbl";
            this.CountdownLbl.Size = new System.Drawing.Size(140, 140);
            this.CountdownLbl.TabIndex = 14;
            this.CountdownLbl.Text = "3";
            this.CountdownLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountdownLbl.Click += new System.EventHandler(this.CountdownLbl_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.White;
            this.gamePanel.Location = new System.Drawing.Point(832, 630);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(326, 129);
            this.gamePanel.TabIndex = 15;
            this.gamePanel.TabStop = false;
            // 
            // boardHomeBtn
            // 
            this.boardHomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boardHomeBtn.BackgroundImage")));
            this.boardHomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boardHomeBtn.Location = new System.Drawing.Point(863, 653);
            this.boardHomeBtn.Name = "boardHomeBtn";
            this.boardHomeBtn.Size = new System.Drawing.Size(80, 80);
            this.boardHomeBtn.TabIndex = 16;
            this.boardHomeBtn.UseVisualStyleBackColor = true;
            this.boardHomeBtn.Click += new System.EventHandler(this.boardHomeBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(832, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 415);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // multiplayerBtn
            // 
            this.multiplayerBtn.BackColor = System.Drawing.Color.White;
            this.multiplayerBtn.Location = new System.Drawing.Point(609, 354);
            this.multiplayerBtn.Name = "multiplayerBtn";
            this.multiplayerBtn.Size = new System.Drawing.Size(243, 111);
            this.multiplayerBtn.TabIndex = 18;
            this.multiplayerBtn.Text = "Multiplayer";
            this.multiplayerBtn.UseVisualStyleBackColor = false;
            this.multiplayerBtn.Click += new System.EventHandler(this.multiplayerBtn_Click);
            // 
            // P2ScoreLbl
            // 
            this.P2ScoreLbl.AutoSize = true;
            this.P2ScoreLbl.BackColor = System.Drawing.Color.White;
            this.P2ScoreLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2ScoreLbl.Location = new System.Drawing.Point(843, 478);
            this.P2ScoreLbl.Name = "P2ScoreLbl";
            this.P2ScoreLbl.Size = new System.Drawing.Size(247, 47);
            this.P2ScoreLbl.TabIndex = 19;
            this.P2ScoreLbl.Text = "P2 SCORE: 0";
            // 
            // P1ScoreLbl
            // 
            this.P1ScoreLbl.AutoSize = true;
            this.P1ScoreLbl.BackColor = System.Drawing.Color.White;
            this.P1ScoreLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1ScoreLbl.Location = new System.Drawing.Point(843, 414);
            this.P1ScoreLbl.Name = "P1ScoreLbl";
            this.P1ScoreLbl.Size = new System.Drawing.Size(247, 47);
            this.P1ScoreLbl.TabIndex = 20;
            this.P1ScoreLbl.Text = "P1 SCORE: 0";
            this.P1ScoreLbl.Click += new System.EventHandler(this.P1ScoreLbl_Click);
            // 
            // turnLbl
            // 
            this.turnLbl.AutoSize = true;
            this.turnLbl.BackColor = System.Drawing.Color.White;
            this.turnLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLbl.Location = new System.Drawing.Point(843, 301);
            this.turnLbl.Name = "turnLbl";
            this.turnLbl.Size = new System.Drawing.Size(268, 44);
            this.turnLbl.TabIndex = 21;
            this.turnLbl.Text = "Player 1\'s turn";
            // 
            // multiplayerToolStripMenuItem
            // 
            this.multiplayerToolStripMenuItem.Name = "multiplayerToolStripMenuItem";
            this.multiplayerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.multiplayerToolStripMenuItem.Text = "Multiplayer";
            this.multiplayerToolStripMenuItem.Click += new System.EventHandler(this.multiplayerToolStripMenuItem_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.White;
            this.TitleLbl.Font = new System.Drawing.Font("OCR A Extended", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(832, 64);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(312, 50);
            this.TitleLbl.TabIndex = 22;
            this.TitleLbl.Text = "TILE MATCH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1182, 771);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.turnLbl);
            this.Controls.Add(this.P1ScoreLbl);
            this.Controls.Add(this.P2ScoreLbl);
            this.Controls.Add(this.multiplayerBtn);
            this.Controls.Add(this.CountdownLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.TimeBtn);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.ClassicBtn);
            this.Controls.Add(this.HomeTLbl);
            this.Controls.Add(this.menuBack);
            this.Controls.Add(this.plus2Lbl);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.multiLbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.boardHomeBtn);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label multiLbl;
        private System.Windows.Forms.Label scoreLabel;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeTrialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.PictureBox menuBack;
        private System.Windows.Forms.Label HomeTLbl;
        private System.Windows.Forms.Button ClassicBtn;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button TimeBtn;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Label plus2Lbl;
        private System.Windows.Forms.Label CountdownLbl;
        private System.Windows.Forms.PictureBox gamePanel;
        private System.Windows.Forms.Button boardHomeBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button multiplayerBtn;
        private System.Windows.Forms.Label P2ScoreLbl;
        private System.Windows.Forms.Label P1ScoreLbl;
        private System.Windows.Forms.Label turnLbl;
        private System.Windows.Forms.ToolStripMenuItem multiplayerToolStripMenuItem;
        private System.Windows.Forms.Label TitleLbl;
    }
}

