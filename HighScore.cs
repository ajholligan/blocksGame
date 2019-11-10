using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class HighScore : Form
    {
        int score;
        int gameMode;
        public bool playAgain = false;

        /*
         * constructor for high score form.
         */
        public HighScore(int score, int gameMode)
        {
            InitializeComponent();
            NameBox.Hide();
            nameLbl.Hide();
            enterScoreBtn.Hide();
            
            NameNotifLbl.Hide();
            this.score = score;
            scoreLbl.Text = "SCORE: " + score;
            this.gameMode = gameMode;

            
        }

        // lable click event handler
        private void label2_Click(object sender, EventArgs e)
        {

        }

        // lable click event handler
        private void label3_Click(object sender, EventArgs e)
        {

        }

        // high score yes button click event handler
        private void yesScoreBtn_Click(object sender, EventArgs e)
        {
            // changes which lables and buttons shows on the form for the correct option
            if (addHighScoreLbl.Text == "Add high score?")
            {
                yesScoreBtn.Hide();
                noScoreBtn.Hide();
                addHighScoreLbl.Hide();

                enterScoreBtn.Show();
                NameBox.Show();
                nameLbl.Show();
            }
            else
            {
                //closes the window if play again 
                playAgain = true;
                Close();
            }
            
        }


        //event handler foe no adding high score 
        private void noScoreBtn_Click(object sender, EventArgs e)
        {
            if (addHighScoreLbl.Text == "Add high score?")
            {
                addHighScoreLbl.Text = "Would you like to play again?";
            }
            else
            {
                Close();
            }
            
        }

        //Enter button to add your name to the high score event handler
        private void enterScoreBtn_Click(object sender, EventArgs e)
        {
            //checks length is at least 3 characters
            if(NameBox.Text.Length > 2)
            {
                string input = NameBox.Text;
                Console.WriteLine(input);
                //sets up string to write to file
                string line = input + "," + score + "\n";
                NameBox.Hide();
                nameLbl.Hide();
                enterScoreBtn.Hide();
                //writes to file
                writeToFile(line);
                // reads and sorts score board from file
                readFromFile();
                NameNotifLbl.Text = "Leaderboard updated";
                NameNotifLbl.Show();
            }
            else
            {
                NameNotifLbl.Text = "Name must be at least 3 characters";
                NameNotifLbl.Show();
            }
        }

        //writes the line with name and score to file
        void writeToFile(string line)
        {
            // checks if its a time trial score or a classc score
            if(gameMode == 0)
            {
                //appends to the bottom of the file 
                System.IO.File.AppendAllText(@"LeaderBoard.txt", line);
            }
            else if(gameMode == 1)
            {
                System.IO.File.AppendAllText(@"LeaderBoardTime.txt", line);
            }

            
          
        }

        //Reads the value feom file and sorts the values into score order
        void readFromFile()
        {
            string[] lines;
            // checks which file to read from
            if(gameMode == 0)
            {
                // reads all lines
                lines = System.IO.File.ReadAllLines(@"LeaderBoard.txt");
            }
            else
            {
                // reads all lines
                lines = System.IO.File.ReadAllLines(@"LeaderBoardTime.txt");
            }
            //creats an array to put the sorted list in
            Scores[] leaderBoard = new Scores[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                //parses the string
                string[] parts = lines[i].Split(',');
                Scores scoreObj = new Scores(parts[0], Convert.ToInt32(parts[1]));
                leaderBoard[i] = scoreObj;
            }
            // bubble sort algorithm
            for (int write = 0; write < leaderBoard.Length; write++)
            {
                for (int sort = 0; sort < leaderBoard.Length-1; sort++)
                {
                    if (leaderBoard[sort].Score > leaderBoard[sort + 1].Score)
                    {
                        //sorts in decending order
                        Scores temp = leaderBoard[sort + 1];
                        leaderBoard[sort + 1] = leaderBoard[sort];
                        leaderBoard[sort] = temp;
                    }
                }
            }
            for (int i = 0; i < leaderBoard.Length ; i++)
            {
                Console.WriteLine(leaderBoard[i].Name + leaderBoard[i].Score);
            }
            // creats the list view in the form
            addToList(leaderBoard);

        }

        //event handler for highscore load
        private void HighScore_Load(object sender, EventArgs e)
        {

        }

        //event handler for list view
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // creats the list view for the high score table
        void addToList(Scores[] leaderBoard)
        {
            leaderBoardList.View = View.Details;

            
            int counter = 1;

            //loops through the 10 highest scores and adds them to the list
            for (int i = leaderBoard.Length-1; i > leaderBoard.Length - 11; i--)
            {
                if (i< 0)
                    continue;
                string listName = Convert.ToString(counter);
                ListViewItem temp = new ListViewItem(listName, 0);
                temp.SubItems.Add(leaderBoard[i].Name);
                temp.SubItems.Add(Convert.ToString(leaderBoard[i].Score));
                leaderBoardList.Items.AddRange(new ListViewItem[] { temp });
                counter++;
            }
           
        }

       
        // goes back to the menu and closes the high score button
        private void menuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        //event handler
        private void leaderBoardList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


    // This class has score objects
    public class Scores
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Scores()
        {

        }

        // constructor sets up fields if passed in
        public Scores(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
