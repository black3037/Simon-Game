using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Simon
{
    public partial class Simon : Form
    {

        // Initialize Starting Round
        int roundNumber = 0;
        int level = 0;

        // Initial states of player and ai
        static List<int> aiState = new List<int>();
        List<int> playerState = new List<int>();
        bool aiPlaying = false;
        Random rnd = new Random();

        

        public Simon()
        {
            InitializeComponent();
        }

        private void Simon_Load(object sender, EventArgs e)
        {

        }

        void play()
        {
            int delayTimer = 250;

            // Start ai round
            aiPlaying= true;

            // Iterate through aiStates to light up the appropriate pattern to user
            foreach(int color in aiState)
            {
                switch(color)
                {
                    case 0:
                        new Thread(beep1).Start();

                        Red.BackColor = Color.White;
                        Thread.Sleep(delayTimer);
                        Red.BackColor = Color.Salmon;
                        break;
                    case 1:
                        new Thread(beep2).Start();
                        Blue.BackColor = Color.White;
                        Thread.Sleep(delayTimer);
                        Blue.BackColor = Color.SkyBlue;
                        break;
                    case 2:
                        new Thread(beep3).Start();
                        Green.BackColor = Color.White;
                        Thread.Sleep(delayTimer);
                        Green.BackColor = Color.SpringGreen;
                        break;
                    case 3:
                        new Thread(beep4).Start();
                        Yellow.BackColor = Color.White;
                        Thread.Sleep(delayTimer);
                        Yellow.BackColor = Color.Moccasin;
                        break;
                }
                Thread.Sleep(delayTimer);
            }

            // End ai round
            aiPlaying = false;

        }

        /// <summary>
        /// These functions send sound to the user once a button is pressed or the ai is playing
        /// </summary>
        void beep1()
        {
            Console.Beep(250, 250);
        }

        void beep2()
        {
            Console.Beep(375, 250);
        }

        void beep3()
        {
            Console.Beep(425, 250);
        }

        void beep4()
        {
            Console.Beep(620, 250);
        }


        // Set up colored button functions
        private void Red_Click(object sender, EventArgs e)
        {
            new Thread(beep1).Start();
            playerPlaying(0);

        }

        private void Blue_Click(object sender, EventArgs e)
        {
            new Thread(beep2).Start();
            playerPlaying(1);
        }

        private void Green_Click(object sender, EventArgs e)
        {
            new Thread(beep3).Start();
            playerPlaying(2);
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            new Thread(beep4).Start();
            playerPlaying(3);
        }
        

        // Player's turn function
        void playerPlaying(int color)
        {
            // Don't append data if ai is currently playing and user pushes a button
            if (aiPlaying == true)
            {
                return;
            }
            // Collect color pattern from the user
            playerState.Add(color);

            // Check to make sure players pattern and ai's patter are same length
            if (playerState.Count() == aiState.Count())
            {
                // Check players pattern against ai's pattern and advance/start over round.
                if (playerState.SequenceEqual(aiState) == true)
                {
                    DialogResult result = MessageBox.Show("Round Passed! Play Next Round?", "Simon", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Thread.Sleep(200);
                        Start.PerformClick();
                    }
                    else if (result == DialogResult.No)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                    
                }
                else
                {
                    DialogResult result = MessageBox.Show("Round Failed! Play Again?", "Simon", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        roundNumber = 0;
                        Thread.Sleep(200);
                        Start.PerformClick();
                    }
                    else if (result == DialogResult.No)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }

            }
        }

        // Game start button
        private void Start_Click(object sender, EventArgs e)
        {
            // Clear all lists for the start of each round
            aiState.Clear();
            playerState.Clear();

            // Generate new ai states for the round
            for (int i = 0; i < roundNumber + 1; i++)
            {
                aiState.Add(rnd.Next(0, 4));
            }
            
            // Start round and incremement round number
            new Thread(play).Start();
            roundNumber++;
            RoundNumberSet.Text = roundNumber.ToString();
        }
    }
}
