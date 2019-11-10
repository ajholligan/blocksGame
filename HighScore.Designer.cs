namespace Assignment_1
{
    partial class HighScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScore));
            this.scoreLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addHighScoreLbl = new System.Windows.Forms.Label();
            this.yesScoreBtn = new System.Windows.Forms.Button();
            this.noScoreBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.enterScoreBtn = new System.Windows.Forms.Button();
            this.NameNotifLbl = new System.Windows.Forms.Label();
            this.leaderboardTitle = new System.Windows.Forms.Label();
            this.leaderBoardList = new System.Windows.Forms.ListView();
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(203, 97);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(381, 75);
            this.scoreLbl.TabIndex = 0;
            this.scoreLbl.Text = "Score: 12345";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = "GAME OVER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addHighScoreLbl
            // 
            this.addHighScoreLbl.AutoSize = true;
            this.addHighScoreLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHighScoreLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addHighScoreLbl.Location = new System.Drawing.Point(187, 267);
            this.addHighScoreLbl.Name = "addHighScoreLbl";
            this.addHighScoreLbl.Size = new System.Drawing.Size(278, 44);
            this.addHighScoreLbl.TabIndex = 2;
            this.addHighScoreLbl.Text = "Add high score?";
            this.addHighScoreLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // yesScoreBtn
            // 
            this.yesScoreBtn.BackColor = System.Drawing.Color.White;
            this.yesScoreBtn.Location = new System.Drawing.Point(195, 371);
            this.yesScoreBtn.Name = "yesScoreBtn";
            this.yesScoreBtn.Size = new System.Drawing.Size(134, 71);
            this.yesScoreBtn.TabIndex = 3;
            this.yesScoreBtn.Text = "YES";
            this.yesScoreBtn.UseVisualStyleBackColor = false;
            this.yesScoreBtn.Click += new System.EventHandler(this.yesScoreBtn_Click);
            // 
            // noScoreBtn
            // 
            this.noScoreBtn.BackColor = System.Drawing.Color.White;
            this.noScoreBtn.Location = new System.Drawing.Point(439, 371);
            this.noScoreBtn.Name = "noScoreBtn";
            this.noScoreBtn.Size = new System.Drawing.Size(134, 71);
            this.noScoreBtn.TabIndex = 4;
            this.noScoreBtn.Text = "NO";
            this.noScoreBtn.UseVisualStyleBackColor = false;
            this.noScoreBtn.Click += new System.EventHandler(this.noScoreBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(73, 327);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(160, 61);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "Name:";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(257, 327);
            this.NameBox.MaxLength = 50;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(316, 61);
            this.NameBox.TabIndex = 6;
            // 
            // enterScoreBtn
            // 
            this.enterScoreBtn.BackColor = System.Drawing.Color.White;
            this.enterScoreBtn.Location = new System.Drawing.Point(579, 327);
            this.enterScoreBtn.Name = "enterScoreBtn";
            this.enterScoreBtn.Size = new System.Drawing.Size(97, 61);
            this.enterScoreBtn.TabIndex = 7;
            this.enterScoreBtn.Text = "Enter";
            this.enterScoreBtn.UseVisualStyleBackColor = false;
            this.enterScoreBtn.Click += new System.EventHandler(this.enterScoreBtn_Click);
            // 
            // NameNotifLbl
            // 
            this.NameNotifLbl.AutoSize = true;
            this.NameNotifLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameNotifLbl.Location = new System.Drawing.Point(259, 412);
            this.NameNotifLbl.Name = "NameNotifLbl";
            this.NameNotifLbl.Size = new System.Drawing.Size(380, 30);
            this.NameNotifLbl.TabIndex = 8;
            this.NameNotifLbl.Text = "Name must be at least 3 characters";
            // 
            // leaderboardTitle
            // 
            this.leaderboardTitle.AutoSize = true;
            this.leaderboardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.leaderboardTitle.Font = new System.Drawing.Font("Franklin Gothic Book", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leaderboardTitle.Location = new System.Drawing.Point(742, 55);
            this.leaderboardTitle.Name = "leaderboardTitle";
            this.leaderboardTitle.Size = new System.Drawing.Size(350, 75);
            this.leaderboardTitle.TabIndex = 10;
            this.leaderboardTitle.Text = "leaderboard";
            // 
            // leaderBoardList
            // 
            this.leaderBoardList.AutoArrange = false;
            this.leaderBoardList.BackColor = System.Drawing.Color.White;
            this.leaderBoardList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Position,
            this.Name,
            this.PlayerScore});
            this.leaderBoardList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.leaderBoardList.GridLines = true;
            this.leaderBoardList.Location = new System.Drawing.Point(755, 161);
            this.leaderBoardList.Name = "leaderBoardList";
            this.leaderBoardList.Size = new System.Drawing.Size(344, 372);
            this.leaderBoardList.TabIndex = 11;
            this.leaderBoardList.UseCompatibleStateImageBehavior = false;
            this.leaderBoardList.SelectedIndexChanged += new System.EventHandler(this.leaderBoardList_SelectedIndexChanged);
            // 
            // Position
            // 
            this.Position.Text = "position";
            this.Position.Width = 100;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 100;
            // 
            // PlayerScore
            // 
            this.PlayerScore.Text = "Score";
            this.PlayerScore.Width = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(725, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 601);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // menuBtn
            // 
            this.menuBtn.Location = new System.Drawing.Point(71, 601);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(144, 72);
            this.menuBtn.TabIndex = 12;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(1161, 696);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.leaderBoardList);
            this.Controls.Add(this.leaderboardTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameNotifLbl);
            this.Controls.Add(this.enterScoreBtn);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.noScoreBtn);
            this.Controls.Add(this.yesScoreBtn);
            this.Controls.Add(this.addHighScoreLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Text = "HighScore";
            this.Load += new System.EventHandler(this.HighScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label addHighScoreLbl;
        private System.Windows.Forms.Button yesScoreBtn;
        private System.Windows.Forms.Button noScoreBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button enterScoreBtn;
        private System.Windows.Forms.Label NameNotifLbl;
        private System.Windows.Forms.Label leaderboardTitle;
        private System.Windows.Forms.ListView leaderBoardList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader PlayerScore;
    }
}