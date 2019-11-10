using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace Assignment_1
{
    public partial class Form1 : Form
    {
        // initialise new 2d array of buttons
        Button[,] btn = new Button[10 , 10];
        int score, scoreP1, scoreP2, turn;
        bool ticking, done = false;
        //variable for the amount of seconds left 
        int timeCounter = 60;
        private static System.Timers.Timer aTimer;
     
        Label timerLbl = new Label();
        
        int gameMode = -1;
        int multiplier = 1;
        int tempTime, prevTime;

        string rules = "Rules\n\nClassic:\nAim: To score as many points as possible before there are no more possible moves.\n\nRules: You can click on any group of three or more coloured squares. These squares will then disappear, and the board drop down and to the left if there is an empty column.If you click a set of 5 or more coloured squares your multiplier will increase until you reach 8 times multiplier or select a group of squares less than 5. Once there are no more available moves the game will end.\n\nTime Trial: \nAim: To score as many points as possible in 60 seconds.\n\nRules: You can click on any group of three or more coloured squares. These squares will then disappear, and the board will drop down. New randomly coloured squares will then drop down to fill the gap. If you click a set of 5 or more coloured squares your multiplier will increase until you reach 8 times multiplier or select a group of squares less than 5. Once the timer runs out the game will end.\n\nMultiplayer:\nAim: To score more points than your opponent before there are no more possible moves.\n\nRules: The game will randomly decide who goes first and the two players will take alternate turns. You can click on any group of three or more coloured squares. These squares will then disappear, and the board drop down and to the left if there is an empty column.The game will end when there are no more possible moves.The winner is the player with the highest score.";

        // constructor for form 1
        public Form1()
        {
            
            InitializeComponent();
            initBoard();
            
        }

//----------------------------------------CREATING THE BOARD------------------------------------------\\
        
         // initialises the board by adding the array of buttons
        void initBoard()
        {
            Random r = new Random();

            // nested for loop that initialises an array of buttons
            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y < btn.GetLength(1); y++)
                {
                    // creates new button object
                    btn[x, y] = new Button();
                    // sets dimentions and position of buttons
                    btn[x, y].SetBounds(60 * x, (60 * y)+25, 60, 60);
                    btn[x, y].FlatStyle = FlatStyle.Flat;
                    btn[x,y].FlatAppearance.BorderColor = Color.FromArgb(17,47,65);
                    // generates a random number between 0 and 3
                    int colorNum = r.Next(4);
                    if (colorNum == 0)
                    {
                        // changes colour of button to red
                        btn[x, y].BackColor = Color.Red;
                    }
                    else if (colorNum == 1)
                    {
                        // changes colour of button to blue
                        btn[x, y].BackColor = Color.Blue;
                    }
                    else if (colorNum == 2)
                    {
                        // changes colour of button to green
                        btn[x, y].BackColor = Color.Green;
                    }
                    else if (colorNum == 3)
                    {
                        // changes colour of button to yellow
                        btn[x, y].BackColor = Color.Yellow;
                    }



                    //creates button click event handler
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);
                    // adds buttons to gui
                    Controls.Add(btn[x, y]);
                    multiLbl.Hide();
                    timeLbl.Hide();
                    scoreLabel.Hide();
                    plus2Lbl.Hide();
                    turnLbl.Hide();
                    CountdownLbl.Hide();
                    boardHomeBtn.Hide();
                    TitleLbl.Hide();
                    P1ScoreLbl.Hide();
                    P2ScoreLbl.Hide();

                }
            }
        }

        //initialises classic game
        void classicInit()
        {
            // checks if a timer is running
            if (ticking)
            {
                aTimer.Stop();
                ticking = false;
            }
            // sets up correct score game and multiplier values
            score = 0;
            gameMode = 0;
            multiplier = 1;
            multiLbl.Hide();
            done = false;
            //randomises button colors
            reshuffle();
            // sets up menu
            timeLbl.Hide();
            scoreLabel.Show();
            CountdownLbl.Hide();
            P1ScoreLbl.Hide();
            P2ScoreLbl.Hide();
            scoreLabel.Text = "Score: " + score;
        }

        //initialises time trial game 
        void timeTrialInit()
        {
            // sets up initial timer 
            tempTime = 3;
            // sets up inital values
            score = 0;
            gameMode = 1;
            multiplier = 1;
            //sets up menu
            multiLbl.Invoke(new Action(() => multiLbl.Hide()));
            done = false;
            reshuffle();
            tempTime = 3;
            CountdownLbl.Invoke(new Action(() => CountdownLbl.Show()));
            P1ScoreLbl.Invoke(new Action(() => P1ScoreLbl.Hide()));
            P2ScoreLbl.Invoke(new Action(() => P2ScoreLbl.Hide()));
            
            Console.WriteLine(tempTime);

            // starts the timer
            timeCounter = 60;
            if (ticking)
            {
                aTimer.Stop();
            }

            ticking = true;
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += timer_Tick;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            timeLbl.Invoke(new Action(() => timeLbl.Show()));
            scoreLabel.Invoke(new Action(() => scoreLabel.Show()));
            
            scoreLabel.Text = "Score: " + score;
        }

        // initialises multi player game mode
        void multiplayerInit()
        {
            //stops the timer if one is running
            if (ticking)
            {
                aTimer.Stop();
                ticking = false;
            }
            //picks random player to start
            Random r = new Random();
            int turn = r.Next(2);
            scoreP1 = 0;
            scoreP2 = 0;
            // sets up lables
            P1ScoreLbl.Text = "P1 SCORE: " + scoreP1;
            P2ScoreLbl.Text = "P2 SCORE: " + scoreP2;
            // works out whos turn it is
            if(turn%2==1)
            {
                turnLbl.Text = "Player 1's turn";
            }
            else
            {
                turnLbl.Text = "Player 2's turn";
            }
            // sets up menu
            gameMode = 2;
            multiLbl.Hide();
            scoreLabel.Hide();
            CountdownLbl.Hide();
            done = false;
            reshuffle();
            timeLbl.Hide();
            P1ScoreLbl.Show();
            P2ScoreLbl.Show();
            turnLbl.Show();
            
        }

        // randomises button colours
        void reshuffle()
        {
            Random r = new Random();
            // nested for loops that iterates through every square
            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y < btn.GetLength(1); y++)
                {
                    int colorNum = r.Next(4);
                    if (colorNum == 0)
                    {
                        // changes colour of button to red
                        btn[x, y].BackColor = Color.FromArgb(8,148,161);
                    }
                    else if (colorNum == 1)
                    {
                        // changes colour of button to blue
                        btn[x, y].BackColor = Color.FromArgb(71,171,108);
                    }
                    else if (colorNum == 2)
                    {
                        // changes colour of button to green
                        btn[x, y].BackColor = Color.FromArgb(242,177,52);
                    }
                    else if (colorNum == 3)
                    {
                        // changes colour of button to yellow
                        btn[x, y].BackColor = Color.FromArgb(237,85,59);
                    }
                }
            }
        }
        

        //-------------------------------------MAIN GAMEPLAY FUNCTIONS----------------------------------

        /*
         * function runs if user clicks a button in the classic menu option. 
         */
        void btnClickClassic(object sender, EventArgs e)
        {
            if (!done)
            {

                // checks if user clicked a non empty square
                if (((Button)sender).BackColor != Color.FromArgb(17,47,65))
                {
                    // creates a temporary copy of button clicked
                    Button copy = ((Button)sender);
                    // calls method that gets coordinates of square
                    int[] pos = findPos(sender);
                    int counter = 0;
                    //calls method that returns amount of surrounding squares that are the same colour
                    counter = legalMove(pos[0], pos[1], (Button)sender, counter);
                    if (counter >= 2)
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"thud.wav");
                        player.Play();
                        // changes clicked colour to background colour
                        ((Button)sender).BackColor = Color.FromArgb(17,47,65);
                        findGroup(pos[0], pos[1], copy);
                        moveThroughBoard();
                        checkEmptyCol();
                        // gets score and then displays it in a label
                        score = score + calculateScore(counter + 1);
                        scoreLabel.Text = "Score: " + score;
                        if (!checkRemainingMoves())
                        {
                            // checks to play again
                            bool playAgain = gameOver();
                            if (!playAgain)
                            {
                                showMenu();
                                done = true;
                            }
                        }
                        scoreLabel.Show();
                    }
                    else
                    {
                        if (score == 0)
                        {
                            scoreLabel.Hide();
                        }
                        // changes the squares back to original colour if counter is less than 3
                        colorBack((Button)sender);
                    }

                }
            }


        }

        // clicking on multi player button
        void btnClickMultiplayer(object sender, EventArgs e)
        {
            if (!done)
            {
                
                
                
                // checks if user clicked a non empty square
                if (((Button)sender).BackColor != Color.FromArgb(17,47,65))
                {
                    // creates a temporary copy of button clicked
                    Button copy = ((Button)sender);
                    // calls method that gets coordinates of square
                    int[] pos = findPos(sender);
                    int counter = 0;
                    //calls method that returns amount of surrounding squares that are the same colour
                    counter = legalMove(pos[0], pos[1], (Button)sender, counter);
                    if (counter >= 2)
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"thud.wav");
                        player.Play();
                        // changes clicked colour to background colour
                        ((Button)sender).BackColor = Color.FromArgb(17,47,65);
                        findGroup(pos[0], pos[1], copy);
                        moveThroughBoard();
                        checkEmptyCol();
                        
                        if (turn%2 == 0)
                        {
                            // gets score and then displays it in a label
                            scoreP1 = scoreP1 + counter + 1;
                            P1ScoreLbl.Text = "P1 SCORE: " + scoreP1;
                        }
                        else
                        {
                            // gets score and then displays it in a label
                            scoreP2 = scoreP2 + counter + 1;
                            P2ScoreLbl.Text = "P2 SCORE: " + scoreP2;
                        }
                        
                        // checks if there are any remaining moves
                        if (!checkRemainingMoves())
                        {
                            //checks who won
                            string winner;
                            if(scoreP1 > scoreP2)
                            {
                                winner = "Player 1";
                            }
                            else
                            {
                                winner = "Player 2";
                            }
                            
                            System.Windows.Forms.MessageBox.Show("GAME OVER\n"+ winner +" Won\nPlayer 1 scored: " + Convert.ToString(scoreP1) + "\nPlayer 2 scored: " + Convert.ToString(scoreP2));
                            showMenu();
                            done = true;
                        }
                        

                        //checks whos turn it is
                        if (turn % 2 == 1)
                        {
                            turnLbl.Text = "Player 1's turn";
                        }
                        else
                        {
                            turnLbl.Text = "Player 2's turn";
                        }
                        turn++;

                    }
                    else
                    {
                        if (score == 0)
                        {
                            scoreLabel.Hide();
                        }
                        // changes the squares back to original colour if counter is less than 3
                        colorBack((Button)sender);
                    }
                }
            }
        }

        //button click on time trial
        void btnClickTimeTrial(object sender, EventArgs e)
        {
            if (timeCounter > 0)
            {
                // checks if user clicked a non empty square
                if (((Button)sender).BackColor != Color.FromArgb(17,47,65)&& tempTime<0)
                {
                    // creates a temporary copy of button clicked
                    Button copy = ((Button)sender);
                    // calls method that gets coordinates of square
                    int[] pos = findPos(sender);
                    int counter = 0;
                    //calls method that returns amount of surrounding squares that are the same colour
                    counter = legalMove(pos[0], pos[1], (Button)sender, counter);
                    if (counter >= 2 && timeCounter > 0)
                    {
                        if(timeCounter>10)
                        {
                            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"thud.wav");
                            player.Play();
                        }
                        // changes clicked colour to background colour
                        ((Button)sender).BackColor = Color.FromArgb(17,47,65);
                        findGroup(pos[0], pos[1], copy);
                        moveThroughBoard();
                        fillEmpty();
                        // gets score and then displays it in a label
                        score = score + calculateScore(counter + 1);
                        scoreLabel.Text = "Score: " + score;
                        scoreLabel.Show();
                    }
                    else
                    {
                        if (score == 0)
                        {
                            scoreLabel.Hide();
                        }
                        // changes the squares back to original colour if counter is less than 3
                        colorBack((Button)sender);
                    }

                }
            }
            else
            {
                // chekcs for play again
                bool playAgain = gameOver();
                if (!playAgain)
                {
                    showMenu();
                    done = true;
                }
                else
                {
                    // sets up timer again
                    timeCounter = 60;
                    if (ticking == false)
                    {
                        aTimer.Start();
                        ticking = true;
                    }
                }
            }


        }


        // checks for remaining moves
        bool checkRemainingMoves()
        {
            // traverses the whole array of buttons
            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y < btn.GetLength(1); y++)
                {
                   // checks the back colour
                    int counter = 0;
                    if (btn[x, y].BackColor != Color.FromArgb(17,47,65))
                    {
                        //counts how many it finds
                        counter = legalMove(x, y, btn[x, y], counter);
                        colorBack(btn[x, y]);
                        if (counter > 1)
                        {
                            //if there are remaining moves
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        
        //event handler for a second elapsing
        void timer_Tick(object sender, ElapsedEventArgs e)
        {
            //if time has run out
            if (tempTime <= 0)
            {
                tempTime = -1;
                CountdownLbl.Invoke(new Action(() => CountdownLbl.Hide()));
                timeCounter--;
            }
            else
            {
                //reduces time
                tempTime--;

                CountdownLbl.Invoke(new Action(() => CountdownLbl.Text = Convert.ToString(tempTime)));
            }
            
            if (timeCounter > 0)
            {
                // displays the time lable
                timeLbl.Invoke(new Action(() => timeLbl.Text = "Time: " + Convert.ToString(timeCounter)));
            }
            else
            {
                // displays time up
                timeLbl.Invoke(new Action(() => timeLbl.Text = "Times up!"));
                
            }
            //end game
            if(timeCounter == 0)
            {
              //  System.Windows.Forms.MessageBox.Show("GAME OVER\nyou scored: " + Convert.ToString(score));
                aTimer.Stop();
                timeCounter = -1;
                ticking = false;

                btnClickTimeTrial(btn[1, 1], e);
            }
            //hides label
            if(timeCounter<=prevTime)
            {
                
                plus2Lbl.Invoke(new Action(() => plus2Lbl.Hide()));
            }
            // starts countdown sound
            if (timeCounter == 10)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"timer.wav");
                player.Play();
            }
        }
        
        //Fills empty squares with random colour
        void fillEmpty()
        {
            Random r = new Random();
            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y < btn.GetLength(1); y++)
                {
                    if (btn[x, y].BackColor == Color.FromArgb(17,47,65))
                    {
                        // set colour of button at current position to original colour

                        int colorNum = r.Next(4);
                        if (colorNum == 0)
                        {
                            // changes colour of button to red
                            btn[x, y].BackColor = Color.FromArgb(8, 148, 161);
                        }
                        else if (colorNum == 1)
                        {
                            // changes colour of button to blue
                            btn[x, y].BackColor = Color.FromArgb(71,171,108);
                        }
                        else if (colorNum == 2)
                        {
                            // changes colour of button to green
                            btn[x, y].BackColor = Color.FromArgb(242,177,52);
                        }
                        else if (colorNum == 3)
                        {
                            // changes colour of button to yellow
                            btn[x, y].BackColor = Color.FromArgb(237,85,59);
                        }
                    }
                }
            }
        }
    

        /*
         * calculates score from move from number of squares cleared and returns value
         */
        int calculateScore(int counter)
        {
            if(counter>4 && multiplier!=8)
            {
                multiplier = multiplier + 1;
            }
            else if(counter < 5)
            {
                multiplier = 1;
            }
            if (multiplier == 1)
            {
                multiLbl.Hide();
            }
            else
            {
                multiLbl.Show();
            }

            if(gameMode == 1 && counter>9)
            {
                prevTime = timeCounter;
                timeCounter = timeCounter + 2;
                plus2Lbl.Show();
                
            }

            multiLbl.Text = "x" + multiplier + " Multiplier!!!";
            int score = counter * multiplier;
            return score;
        }

       

        /*
         * works out the position of the clicked square and returns it
         */
        int[] findPos(object sender)
        {
            int[] pos = new int[2];
            // nested for loops that iterates through every square
            for(int x = 0; x<btn.GetLength(0); x++)
            {
                for(int y = 0; y<btn.GetLength(1); y++)
                {
                    //if the button at current position is the same as the clicked button
                    if(btn[x,y] == (Button)sender)
                    {
                        pos[0] = x;
                        pos[1] = y;
                        return pos;
                        
                    }
                }
            }
            pos[0] = -1;
            return pos;
        }

        /*
         * this is called if the user clicks on a group of squares that is less than 3.
         * it changes the colour back to the original colour
         */
        void colorBack(Button button)
        {
            // nested for loops that iterates through every square
            for (int x = 0; x < btn.GetLength(0); x++)
            {
                for (int y = 0; y < btn.GetLength(1); y++)
                {
                    if (btn[x,y].BackColor == Color.White)
                    {
                        // set colour of button at current position to original colour
                        btn[x, y].BackColor = button.BackColor;
                    }
                }
            }
        }

      
        /*
         * this function recursively checks adjacent squares to find squares of the same colour
         * and turns them white while incrementing the counter
         */
        int legalMove(int x, int y, Button original, int counter)
        {
            // if position is out of bounds do nothing
            if (x - 1 < 0)
            {
            
            }
            //if button being checked is the original button do nothing
            else if (btn[x - 1, y] == original)
            {

            }
            //if button being checked is same colour as original
            else if (btn[x - 1, y].BackColor == original.BackColor)
            {
                btn[x - 1, y].BackColor = Color.White;
                counter++;
                //call method for square to the left
                counter = legalMove(x - 1, y, original, counter);
            }
            // if position is out of bounds do nothing
            if (x + 1 >= btn.GetLength(0))
            {

            }
            //if button being checked is the original button do nothing
            else if (btn[x + 1, y] == original)
            {

            }
            //if button being checked is same colour as original
            else if (btn[x + 1, y].BackColor == original.BackColor)
            {
                btn[x + 1, y].BackColor = Color.White;
                counter++;
                // call method for square to the right
                counter = legalMove(x + 1, y, original, counter);
            }
            // if position is out of bounds do nothing
            if (y - 1 < 0)
            {

            }
            //if button being checked is the original button do nothing
            else if (btn[x, y - 1] == original)
            {

            }
            //if button being checked is same colour as original
            else if (btn[x, y - 1].BackColor == original.BackColor)
            {
                btn[x, y - 1].BackColor = Color.White;
                counter++;
                // call method for square above
                counter = legalMove(x, y - 1, original, counter);
            }

            // if position is out of bounds do nothing
            if (y + 1 >= btn.GetLength(1))
            {

            }
            //if button being checked is the original button do nothing
            else if (btn[x, y + 1] == original)
            {

            }
            //if button being checked is same colour as original
            else if (btn[x, y + 1].BackColor == original.BackColor)
            {
                btn[x, y + 1].BackColor = Color.White;
                counter++;
                //call method for square below
                counter = legalMove(x, y + 1, original, counter);
            }


            return counter;
        }

        int findGroup(int x, int y, Button original)
        {
            // if position is out of bounds do nothing
            if (x - 1 < 0)
            {
                
            }
            //if button being checked is the original button do nothing
            else if (btn[x - 1, y] == original)
            {

            }
            //if button being checked is a selected button
            else if (btn[x-1,y].BackColor == Color.White)
            {
                btn[x-1, y].BackColor = Color.FromArgb(17,47,65);
                // call method for square to the left
                findGroup(x - 1, y, original);
            }

            // if position is out of bounds do nothing
            if (x + 1 >= btn.GetLength(0))
            {

            }
            //if button being checked is the original button do nothing
            else if (btn[x + 1, y] == original)
            {

            }
            //if button being checked is a selected button
            else if (btn[x + 1, y].BackColor == Color.White)
            {
                btn[x+1, y].BackColor = Color.FromArgb(17,47,65);
                // call method for square to the right
                findGroup(x + 1, y, original);
            }

            // if position is out of bounds do nothing
            if (y -1 < 0)
            {

            }
            //if button being checked is the original button do nothing
            else if (btn[x, y-1] == original)
            {

            }
            //if button being checked is a selected button
            else if (btn[x, y - 1].BackColor == Color.White)
            {
                btn[x, y-1].BackColor = Color.FromArgb(17,47,65);
                // call method for square above
                findGroup(x , y - 1, original);
            }

            // if position is out of bounds do nothing
            if (y + 1 >= btn.GetLength(1))
            {

            }
            //if button being checked is the original button do nothing
            else if (btn[x, y+1] == original)
            {

            }
            //if button being checked is a selected button
            else if (btn[x, y + 1].BackColor == Color.White)
            {
                btn[x, y+1].BackColor = Color.FromArgb(17,47,65);
                // call method for square below
                findGroup(x, y + 1, original);
            }


            return 0;
        }

        //---------------------------------MOVING TILES--------------------------------------------


        /*
         * this function goes through the board and calls a method to move
         * buttons down
         */
        void moveThroughBoard()
        {
            // nested for loops that iterates through every square 10 times
            for (int i = 0; i < 10; i++)
            {
                for (int x = btn.GetLength(0) - 1; x >= 0; x--)
                {
                    for (int y = btn.GetLength(1) - 2; y >= 0; y--)
                    {
                        checkBelow(x, y);
                    }
                }
            }
        }

        /*
         * this function moves buttons down if they have an empty space
         * below them
         */
        void checkBelow(int x, int y)
        {
            // if button below is empty swap the colours around
            if (btn[x, y + 1].BackColor == Color.FromArgb(17,47,65))
            {
                btn[x, y + 1].BackColor = btn[x, y].BackColor;
                btn[x, y].BackColor = Color.FromArgb(17,47,65);
            }
        }

        /*
         * this function checks for an empty column and calls a method to move buttons left
         */
        void checkEmptyCol()
        {
            int count = 0;
            // nested for loops that iterates through every square in a column 10 times
            for (int i = 0; i < 10; i++)
            {
                for (int x = btn.GetLength(0) - 2; x >= 0; x--)
                {
                    for (int y = btn.GetLength(1) - 1; y >= 0; y--)
                    {
                        // counts how many squares in a column are empty
                        if (btn[x, y].BackColor == Color.FromArgb(17,47,65))
                        {
                            count++;
                        }
                    }
                    // if column is empty call method to move left
                    if (count == 10)
                    {
                        moveCol(x);
                    }
                    count = 0;
                }
            }
        }

        /*
         * function that moves all buttons to right of empty column left
         */
        void moveCol(int x)
        {

            for (int y = btn.GetLength(0) - 1; y >= 0; y--)
            {
                //swaps button with button to the right
                btn[x, y].BackColor = btn[x + 1, y].BackColor;
                btn[x + 1, y].BackColor = Color.FromArgb(17,47,65);
            }

        }

        //----------------------------------MENU FUNCTIONS--------------------------------\\
        //Sets up the new high score form to show the end of the game 
        bool gameOver()
        {
            //makes new high score object
            HighScore highScore = new HighScore(score, gameMode);
            highScore.ShowDialog();
            
            //if play again foe classic mode
            if (highScore.playAgain && gameMode == 0)
            {
                gameMode = 0;
                hideMenu();
                classicInit();
                Console.WriteLine("CLASSIC");

                
            }
            //play again time trial
            else if (highScore.playAgain && gameMode == 1)
            {
                Console.WriteLine("TT");
                timeTrialInit();
                hideMenu();
            }
            return highScore.playAgain;
        }

        //hides the main menu
        void hideMenu()
        {
            ClassicBtn.Hide();
            ExitBtn.Hide();
            HelpBtn.Hide();
            TimeBtn.Hide();
            multiplayerBtn.Hide();
            menuBack.Hide();
            HomeTLbl.Hide();
            boardHomeBtn.Show();
            TitleLbl.Show();
            if(gameMode==2)
            {
                P1ScoreLbl.Show();
                P2ScoreLbl.Show();
                turnLbl.Show();
            }
            
        }

        //shows the main menu
        void showMenu()
        {
            
            ClassicBtn.Invoke(new Action(() => ClassicBtn.Show()));
            ExitBtn.Invoke(new Action(() => ExitBtn.Show()));
            HelpBtn.Invoke(new Action(() => HelpBtn.Show()));
            multiplayerBtn.Invoke(new Action(() => multiplayerBtn.Show()));
            TimeBtn.Invoke(new Action(() => TimeBtn.Show()));
            menuBack.Invoke(new Action(() => menuBack.Show()));
            HomeTLbl.Invoke(new Action(() => HomeTLbl.Show()));
            boardHomeBtn.Invoke(new Action(() => boardHomeBtn.Hide()));
            CountdownLbl.Invoke(new Action(() => CountdownLbl.Hide()));
            TitleLbl.Invoke(new Action(() => TitleLbl.Hide()));
            
            if(gameMode==2)
            {
                P1ScoreLbl.Invoke(new Action(() => P1ScoreLbl.Hide()));
                P2ScoreLbl.Invoke(new Action(() => P2ScoreLbl.Hide()));
                turnLbl.Invoke(new Action(() => turnLbl.Hide()));
                
            }
            
        }



        //----------------------------EVENT HANDLERS----------------------------------\\

        /*
         * event handler that runs when the user clicks a button. It calls a
         * function depending on what game mode has been selected
         */
        void btnEvent_Click(object sender, EventArgs e)
        {

            if (gameMode == 0)
            {
                btnClickClassic(sender, e);
            }
            else if (gameMode == 1)
            {
                btnClickTimeTrial(sender, e);
            }
            else if (gameMode == 2)
            {
                btnClickMultiplayer(sender, e);
            }
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void multiLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }

        //closes program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        // starts classic game
        private void classicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classicInit();
        }

        // starts time trial
        private void timeTrialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideMenu();
            timeTrialInit();
        }

        private void timeLbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //closes program
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //sets up multiplayer
        private void multiplayerBtn_Click(object sender, EventArgs e)
        {
            gameMode = 2;
            hideMenu();
            multiplayerInit();
        }

        //starts multiplayer
        private void multiplayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            multiplayerInit();
        }

        //starts classic mode
        private void ClassicBtn_Click(object sender, EventArgs e)
        {
            gameMode = 0;
            hideMenu();
            classicInit();
        }

        private void P1ScoreLbl_Click(object sender, EventArgs e)
        {

        }

        //starts time trial
        private void TimeBtn_Click(object sender, EventArgs e)
        {
            gameMode = 1;
            hideMenu();
            timeTrialInit();
        }

        

        // goes to home
        private void boardHomeBtn_Click(object sender, EventArgs e)
        {
            if(ticking)
            {
                aTimer.Stop();
                ticking = false;
            }
            showMenu();
        }

        private void CountdownLbl_Click(object sender, EventArgs e)
        {

        }

        // shows menu
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMenu();
        }

        // shows rules
        private void HelpBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(rules);
        }
    }
}





//<div>Icons made by <a href="https://www.flaticon.com/authors/dave-gandy" title="Dave Gandy">Dave Gandy</a> from <a href="https://www.flaticon.com/" 			    title="Flaticon">www.flaticon.com</a> is licensed by <a href="http://creativecommons.org/licenses/by/3.0/" 			    title="Creative Commons BY 3.0" target="_blank">CC 3.0 BY</a></div>