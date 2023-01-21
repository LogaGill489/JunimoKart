using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunimoKart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables

        //random generator
        Random randGen = new Random();

        //one time boolein used to do a first time setup after each new gameTimer startup
        bool startUpVariable = false;

        //brushes used for the home screen
        Brush grayBrush = new SolidBrush(Color.Gray);
        Brush whiteBrush = new SolidBrush(Color.White);

        //boolein that checks for if the control page is open
        bool controlsPageCheck = false;

        bool firstTimeSetup = true;

        #region Dash Mechanic Variables

        //stopwatch to track total time in a dash
        Stopwatch speedBoost = new Stopwatch();

        //boolein used for easy checks between when a dash is happening vs when one isn't
        bool speedResetStopper = true;

        Brush blueBrush = new SolidBrush(Color.DarkCyan);
        Pen whitePen = new Pen(Color.White);

        int dashBarLength = 100;
        bool dashBarCheck;

        Rectangle dashBarOutline = new Rectangle(28, 20, 104, 20);
        Rectangle dashBar = new Rectangle(30, 23, 100, 14);

        #endregion

        #region Jumping Mechanic Variables
        //variables used for jumping mechanic

        //speed that resets the stopwatch upon startup
        //adjust to change base jump height
        int resetSpeed = 50;

        //speed that jump always is (similar to Earth's gravity of 9.8m/s squared)
        int gravitySpeed = 5;

        //variable that changes the player's Y position to a negative gravity upon a jump
        //counts back to stagnant 0 value to return gravity to typical state
        int counterSpeed;

        //Stopwatchs and booleins to change counterSpeed and keep track of weather a jump has occured
        Stopwatch gravityReset = new Stopwatch();
        Stopwatch heightCap = new Stopwatch();

        bool jumpCheck = false;
        bool singleCheck = false;

        #endregion

        #region Platform Generation & Platform Movement Variables

        //platforms colour
        Brush woodBrush = new SolidBrush(Color.BurlyWood);

        //platform Generation Lists
        List<Rectangle> platforms = new List<Rectangle>();
        List<int> platformHeight = new List<int>();

        //platform Supports Lists
        List<Rectangle> platformSupportSidesL = new List<Rectangle>();
        List<Rectangle> platformSupportSidesR = new List<Rectangle>();

        //Stopwatch that slowly increase platform speed over time
        Stopwatch platformIncrease = new Stopwatch();
        int platformSpeed = 4;

        //integer used to track random generation
        int tempRandom;

        //movement variables
        int x;
        int xPlatformR;
        int xPlatformL;

        #endregion

        #region Coin Generation Variables

        //List to track coins on screen
        List<Rectangle> coins = new List<Rectangle>();

        //coin positioning integers
        int coinsRandom;
        int xCoins;

        //integers to keep track and adjust the player's score
        int scoreChecker;
        int playerScore;

        #endregion

        #region Player & Player Movement Variables

        //player
        Rectangle player = new Rectangle(200, 400, 40, 40);

        //player Y tracking variables
        int prevY2;
        int prevY;

        //booleins for a and d controls
        bool aDown = false;
        bool dDown = false;

        //players a and d speed
        int playerSpeed = 2;

        #endregion

        #endregion
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    jumpCheckCall();
                    break;
                case Keys.Space:
                    jumpCheckCall();
                    break;
                case Keys.Up:
                    jumpCheckCall();
                    break;
                case Keys.S:
                    for (int i = 0; i < platforms.Count; i++)
                    {
                        if (player.IntersectsWith(platforms[i]) && player.Y + player.Height - 5 <= platforms[i].Y)
                        {
                            player.Y += gravitySpeed;
                        }
                    }
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.Left:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Right:
                    dDown= true;
                    break;
                case Keys.ShiftKey:
                    if (!speedBoost.IsRunning && dashBarCheck == false)
                    {
                        speedBoost.Start();
                    }
                    break;
                case Keys.Enter:
                    //checks if the game is currently running
                    //wont run unless the game is not running
                    if (gameTimer.Enabled == false && controlsPageCheck == false)
                    {
                        //starts the game loop
                        gameTimer.Enabled = true;

                        //removes labels that are on the home screen
                        copyrightLabel.Visible = false;
                        controlsLabel.Visible = false;

                        enterLabel.Visible = false;
                        escapeLabel.Visible = false;
                        scoreLabel.Visible = false;

                        //shows the ingame scoreLabel
                        playerScoreLabel.Visible = true;

                        //removes the startup labels
                        enterLabel.Location = new Point(enterLabel.Location.X, 364);
                        escapeLabel.Location = new Point(escapeLabel.Location.X, 364);

                        //removes the image of the junimo kart sign
                        junimoKartSignImage.Visible = false;

                        //removes the image of the junimo in the bottom corner of the screen
                        junimoImage.Visible = false;

                        //sets the firstTimeSetup boolein to false so that the game knows that it is not the first time it's drawn the homescreen
                        firstTimeSetup = false;
                    }
                    break;
                case Keys.Escape:
                    if (gameTimer.Enabled == false && controlsPageCheck == false)
                    {
                        Application.Exit();
                    }
                    break;
                case Keys.C:
                    if (gameTimer.Enabled == false && controlsPageCheck == false)
                    {
                        //removes labels that are on the home screen
                        enterLabel.Visible = false;
                        escapeLabel.Visible = false;
                        scoreLabel.Visible = false;

                        //removes the junimo kart sign
                        junimoKartSignImage.Visible = false;

                        //adds small decoration junimos to the top of the control screen
                        pinkJunimoImage.Visible = true;
                        orangeJunimoImage.Visible = true;
                        blueJunimoImage.Visible = true;

                        //shows the controls labels
                        jumpLabel.Visible = true;
                        leftLabel.Visible = true;
                        rightLabel.Visible = true;
                        dashLabel.Visible = true;

                        //updates the controlLabe text
                        controlsLabel.Text = "Press \"C\" To Return To Homescreen!";

                        //sets the boolein that the if statements use to true so the code knows what screen is on
                        controlsPageCheck = true;
                    }
                    else if (gameTimer.Enabled == false && controlsPageCheck == true)
                    {
                        //removes labels that are on the home screen
                        enterLabel.Visible = true;
                        escapeLabel.Visible = true;

                        //draws the junimo kart sign
                        junimoKartSignImage.Visible = true;

                        //shows the scoreLabel if it is not the first time on the homepage
                        if (firstTimeSetup == false)
                        {
                            scoreLabel.Visible = true;
                        }

                        //removes the decorational junimos on the top of the controls screen
                        pinkJunimoImage.Visible = false;
                        orangeJunimoImage.Visible = false;
                        blueJunimoImage.Visible = false;

                        //removes the controls labels
                        jumpLabel.Visible = false;
                        leftLabel.Visible = false;
                        rightLabel.Visible = false;
                        dashLabel.Visible = false;

                        //updates the controlsLabel text
                        controlsLabel.Text = "Press \"C\" For Controls!";

                        //sets the boolein that the if statements use to false so the code knows what screen is on
                        controlsPageCheck = false;
                    }
                    break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    jumpCheckEndCall();
                    break;
                case Keys.Space:
                    jumpCheckEndCall();
                    break;
                case Keys.Up:
                    jumpCheckEndCall();
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.Left:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Right:
                    dDown = false;
                    break;
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //runs once upon gameTimer startup then never again
            if (startUpVariable == false)
            {
                //for loop to setup inital platforms before generation
                for (int i = 0; i < 11; i++)
                {
                    platforms.Add(new Rectangle(i * 100 + 2, 448, 100, 4));
                    platformHeight.Add((platforms[i].Y + 2) / 50);

                    platformSupportSidesL.Add(new Rectangle(i * 100 + 12, 448, 4, this.Height));
                    platformSupportSidesR.Add(new Rectangle(i * 100 + 92, 448, 4, this.Height));
                }
                //starts the stopwatch that slowly increases the platform speed
                platformIncrease.Start();

                //stops the if statement from happening again
                startUpVariable = true;
            }

            //track player's previous y position
            prevY2 = prevY;
            prevY = player.Y;

            //move player
            if (aDown == true && player.X > 0)
            {
                player.X -= playerSpeed;
            }
            if (dDown == true && player.X < this.Width - 44)
            {
                player.X += playerSpeed;
            }

            #region Testing Labels

            //displays values for testing purposes
            /*
            playerX.Text = $"{player.X}";
            playerY.Text = $"{player.Y}";
            playerSpeedLabel.Text = $"{counterSpeed}";
            jumpCheckLabel.Text = $"{jumpCheck}";
            gfLabel.Text = $"{gravityReset.ElapsedMilliseconds}";
            singleCheckValue.Text = $"{singleCheck}";
            platSupportLabel.Text = $"{platformSpeed}";

            platformHeightLabel.Text = "";
            for (int i = 0; i < platforms.Count; i++)
            {
                platformHeightLabel.Text += $"{platformHeight[i]} ";
            }
            */

            #endregion

            #region Player's Score Checks and Increases

            //remoevs coins if player intersects with them
            for (int i = 0; i < coins.Count; i++)
            {
                if (player.IntersectsWith(coins[i]))
                {
                    coins.RemoveAt(i);
                    playerScore += 5;
                }
            }

            //increases score in intervals based upon the platform gen
            if (scoreChecker >= 2)
            {
                playerScore++;
                scoreChecker = 0;
            }

            //updates the score label in the top right corner
            playerScoreLabel.Text = $"{playerScore}";

            #endregion

            #region Jumping Mechanic and Line Intersection

            //checks for any platforms intersections with the player's hitbox and if the player is above the platform, applies gravity if condition isn't met
            for (int i = 0; i < platforms.Count; i++)
            {
                if (player.IntersectsWith(platforms[i]) && player.Y + player.Height - 5 <= platforms[i].Y)
                {
                    //upon any player intersection with the top of a platform, stops gravity and breaks out of for loop
                    singleCheck = true;
                    break;
                }
            }

            //if statement to force gravity to continue if a jump has occured and the movement is still negative
            //Makes for a slightly smoother animation and smoother controls when moving under and through platforms
            if (gravityReset.IsRunning && prevY2 > prevY || heightCap.IsRunning && prevY2 > prevY)
            {
                singleCheck = false;
            }

            //if statement that generates gravity
            //only works if a player is not touching a line or if they touch a line while moving in a negative y direction
            if (singleCheck == false)
            {
                //gravity on player that is adjusted through the counterSpeed variable every time a successful jump is made
                player.Y += gravitySpeed + counterSpeed;
            }

            //resets singleCheck variable for next tick
            singleCheck = false;


            //stops jump height if jump key is held down for longer than half a second
            if (heightCap.ElapsedMilliseconds >= 500)
            {
                jumpCheck = false;

                gravityReset.Start();
                heightCap.Reset();
            }

            //Checks if counterSpeed variables has changed from it's resting state, indicating that a jump has occured
            if (counterSpeed < 0)
            {
                //checks if the player has released the jump key or if the maximum jump height has been reached
                if (jumpCheck == false)
                {
                    //counterSpeed variable, which always starts at -double the gravity, begins to count down back to 0 or its resting place
                    //this is done using a timer on an adjustable resetable delay
                    counterSpeed += Convert.ToInt16(gravityReset.ElapsedMilliseconds) / resetSpeed;
                    if (gravityReset.ElapsedMilliseconds > resetSpeed)
                    {
                        gravityReset.Restart();
                    }
                }
            }
            //resets the timers used upon a return to normal gravity
            else
            {
                gravityReset.Reset();
                heightCap.Reset();
            }

            #endregion

            #region Platform Speed Increases & Dash Mechanic

            //increases the platform speed after each 15 second interval
            if (platformIncrease.ElapsedMilliseconds > 15000)
            {
                platformSpeed++;
                platformIncrease.Restart();
            }

            //moves the player's x forward if they are still on screen and they are dashing
            if (speedBoost.IsRunning && player.X < this.Width - 54)
            {
                player.X += 10;
            }

            //stops dashing after the alloted time
            if (speedBoost.ElapsedMilliseconds >= 150)
            {
                dashBarCheck = true;
                speedBoost.Reset();
            }

            //draws the dash bar and counts it down
            if (dashBarCheck == true)
            {
                dashBarLength--;
                dashBar = new Rectangle(dashBar.X, dashBar.Y, dashBarLength, dashBar.Height);
            }

            //resets the dash bar when it is at 0
            if (dashBarLength <= 0)
            {
                //sets the bar to false
                dashBarCheck = false;

                //resets the length
                dashBarLength = 100;

                //resets the dashBar position
                dashBar = new Rectangle(dashBar.X, dashBar.Y, 100, dashBar.Height);
            }

            #endregion

            #region Platform Gen & Movement

            //checks for platforms being fully off screen, then generates a new section
            if (platforms[0].X <= -100)
            {
                newPlatformGeneration();
            }

            //for loop that moves variables
            //display will only take into account the x values that come out of this for loop
            for (int i = 0; i < platforms.Count; i++)
            {
                //calulations for new platforms
                x = platforms[i].X - platformSpeed;
                xPlatformL = x + 10;
                xPlatformR = x + 85;

                //redraws platforms slightly over
                platforms[i] = new Rectangle(x, platforms[i].Y, 100, 4);

                //redraws platform supports
                platformSupportSidesL[i] = new Rectangle(xPlatformL, platformSupportSidesL[i].Y, 4, this.Height - platformSupportSidesL[i].Y);
                platformSupportSidesR[i] = new Rectangle(xPlatformR, platformSupportSidesR[i].Y, 4, this.Height - platformSupportSidesR[i].Y);
            }

            //redraws coins movement
            for (int i = 0; i < coins.Count; i++)
            {
                //calualtion for coins x value
                xCoins = coins[i].X - platformSpeed;

                //redraws coins
                coins[i] = new Rectangle(xCoins, coins[i].Y, 30, 30);
            }

            #endregion

            //checks for player falling off screen, and runs end game code if true
            if (player.Y > this.Height - 10)
            {
                gameOver();
            }

            //redraws screen
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //draws each platform that the player can interact with
            for (int i = 0; i < platforms.Count; i++)
            {
                e.Graphics.FillRectangle(woodBrush, platforms[i]);
            }
            for (int i = 0; i < platformSupportSidesL.Count; i++)
            {
                e.Graphics.FillRectangle(woodBrush, platformSupportSidesL[i]);
                e.Graphics.FillRectangle(woodBrush, platformSupportSidesR[i]);
            }
            for (int i = 0; i < coins.Count; i++)
            {
                e.Graphics.DrawImage(Properties.Resources.JunimoKartCoin1, coins[i]);
            }

            //draws the dash reset bar if the cooldown is true
            if (dashBarCheck == true && gameTimer.Enabled == true)
            {
                e.Graphics.FillRectangle(woodBrush, dashBarOutline);
                e.Graphics.FillRectangle(blueBrush, dashBar);
            }

            //draws the dash animation lines
            if (speedBoost.IsRunning)
            {
                e.Graphics.DrawLine(whitePen, player.X + 20, player.Y + 15, player.X - 10, player.Y + 15);
                e.Graphics.DrawLine(whitePen, player.X + 17, player.Y + 25, player.X - 13, player.Y + 25);

                e.Graphics.DrawLine(whitePen, player.X + 10, player.Y + 20, player.X - 20, player.Y + 20);
            }

            //draws player
            //e.Graphics.FillRectangle(whiteBrush, player);
            if (counterSpeed == 0)
            {
                e.Graphics.DrawImage(Properties.Resources.JunimoCart, player);
            }
            else
            {
                e.Graphics.DrawImage(Properties.Resources.JunimoCartFlying, player);
            }

            //draws home screen
            if (gameTimer.Enabled == false)
            {
                //draws the background square
                e.Graphics.FillRectangle(whiteBrush, 50, 50, 900, 500);
                e.Graphics.FillRectangle(grayBrush, 60, 60, 880, 480);
            }
        }

        #region Input Call Functions

        public void jumpCheckCall()
        {
            //runs a for loop through the length of the platform amounts each button press
            for (int i = 0; i < platforms.Count; i++)
            {
                //starts a jump function if the player is touching a platform on the top side
                if (player.IntersectsWith(platforms[i]) && player.Y + player.Height - 5 <= platforms[i].Y)
                {
                    //gives counterSpeed variable a value of -10 which is essential for manipulating the gravity of the player
                    counterSpeed = -10;

                    //variables to determine when to start decelerating into a fall
                    jumpCheck = true;
                    heightCap.Start();

                    //does something
                    gravityReset.Reset();

                    //slight adjustment on the player to force them out of the platform and into the air
                    player.Y -= gravitySpeed;

                    break;
                }
            }
        }
        public void jumpCheckEndCall()
        {
            if (jumpCheck == true)
            {
                jumpCheck = false;
                gravityReset.Start();
                heightCap.Stop();
            }
        }

        #endregion

        #region Section Generation Code

        public void newPlatformGeneration()
        {
            tempRandom = randGen.Next(1, 101);
            //60% chance of spawning a platform at teh same Y level as previous section if the previous section is not in the void
            if (tempRandom <= 40 && platforms[10].Y < 600)
            {
                //adds a new platform at the same Y level as previous section
                platforms.Add(new Rectangle(platforms[10].X + 100, platforms[10].Y, 100, 4));
                platformHeight.Add((platforms[11].Y + 2) / 50);

                //adds support beams on either side of the platform
                platformSupportSidesL.Add(new Rectangle(platforms[11].X + 110, platforms[11].Y, 4, this.Height - platforms[11].Y));
                platformSupportSidesR.Add(new Rectangle(platforms[11].X + 185, platforms[11].Y, 4, this.Height - platforms[11].Y));

                //try for a coin generation
                coinGeneration();
            }
            //if previous section is not in the void, run this
            else if (platformHeight[10] < 12) //12
            {
                platformGenChance();
            }
            //if section 10 is in the void, check if section 9 is too, and if so, run this
            else if (platformHeight[9] < 12)
            {
                platformGenChance();
            }
            //generate a new platform no matter what if no platform has generated with 2 sections
            else
            {
                platformGeneration1();
            }

            //remove offscreen platforms and other list variables affecting the structure to run loop without breaks
            platforms.RemoveAt(0);
            platformHeight.RemoveAt(0);

            //removal of left and right supports
            platformSupportSidesL.RemoveAt(0);
            platformSupportSidesR.RemoveAt(0);

            if (coins.Count > 0)
            {
                if (coins[0].X <= -50)
                {
                    coins.RemoveAt(0);
                }
            }

            scoreChecker++;
        }
        public void platformGenChance()
        {
            tempRandom = randGen.Next(1, 101);
            //55% chance of a platform generating
            if (tempRandom >= 55)
            {
                platformGeneration1();
            }
            //45% chance of no platform generating
            else
            {
                //generate platform in the floor
                platforms.Add(new Rectangle(platforms[10].X + 100, 700, 100, 4));
                platformHeight.Add((platforms[11].Y + 2) / 50);

                //add supports into the support lists to stop breakage
                platformSupportSidesL.Add(new Rectangle(platforms[11].X + 110, 700, 4, this.Height - platforms[11].Y));
                platformSupportSidesR.Add(new Rectangle(platforms[11].X + 185, 700, 4, this.Height - platforms[11].Y));
            }
        }
        public void platformGeneration1()
        {
            //random generation within 3 and 9 platform gap
            switch (platformHeight[10])
            {
                //adjusts how a platform can generate based upon the location of the previous platform
                case 9:
                    tempRandom = randGen.Next(7, 10);
                    break;
                case 8:
                    tempRandom = randGen.Next(6, 10);
                    break;
                case 7:
                    tempRandom = randGen.Next(5, 10);
                    break;
                case 4:
                    tempRandom = randGen.Next(3, 8);
                    break;
                case 3:
                    tempRandom = randGen.Next(3, 7);
                    break;

                    //case that only occurs if a platform is generated in the void
                case 14:
                    //check for a double gap, if not, then set the gap to the previous available height
                    if (platformHeight[9] < 12)
                    {
                        switch (platformHeight[9])
                        {
                            //adjusts how a platform can generate based upon the location of the previous platform
                            case 9:
                                tempRandom = randGen.Next(7, 10);
                                break;
                            case 8:
                                tempRandom = randGen.Next(6, 10);
                                break;
                            case 7:
                                tempRandom = randGen.Next(5, 10);
                                break;
                            case 4:
                                tempRandom = randGen.Next(3, 8);
                                break;
                            case 3:
                                tempRandom = randGen.Next(3, 7);
                                break;
                            //standard generation if no special criteria is met
                            default:
                                tempRandom = randGen.Next(platformHeight[9] - 2, platformHeight[9] + 3);
                                break;
                        }
                    }
                    //sets the height to that of section 8's platform if there is a gap of two
                    else if (platformHeight[8] < 12) 
                    {
                        switch (platformHeight[8])
                        {
                            //adjusts how a platform can generate based upon the location of the previous platform
                            case 9:
                                tempRandom = randGen.Next(7, 10);
                                break;
                            case 8:
                                tempRandom = randGen.Next(6, 10);
                                break;
                            case 7:
                                tempRandom = randGen.Next(5, 10);
                                break;
                            case 4:
                                tempRandom = randGen.Next(3, 8);
                                break;
                            case 3:
                                tempRandom = randGen.Next(3, 7);
                                break;
                            //standard generation if no special criteria is met
                            default:
                                tempRandom = randGen.Next(platformHeight[8] - 2, platformHeight[8] + 3);
                                break;
                        }

                        //tempRandom = platformHeight[8];
                    }
                    break;
                    //standard generation if no special criteria is met
                default:
                    tempRandom = randGen.Next(platformHeight[10] - 2, platformHeight[10] + 3);
                    break;
            }
            //generates new platforms with the newly generated height
            platforms.Add(new Rectangle(platforms[10].X + 100, tempRandom * 50 - 2, 100, 4));
            platformHeight.Add(tempRandom);

            //adds supports on either side
            platformSupportSidesL.Add(new Rectangle(platforms[11].X + 110, tempRandom * 50 - 2, 4, this.Height - platforms[11].Y));
            platformSupportSidesR.Add(new Rectangle(platforms[11].X + 185, tempRandom * 50 - 2, 4, this.Height - platforms[11].Y));

            //try for a coin generation
            coinGeneration();
        }
        public void coinGeneration()
        {
            tempRandom = randGen.Next(1, 101);

            if (tempRandom <= 11)
            {
                coinsRandom = randGen.Next(platformHeight[11] - 3, platformHeight[11] - 1);

                coins.Add(new Rectangle(platforms[11].X + 35, coinsRandom * 50 - 2, 30, 30));
            }
        }
        
        #endregion

        public void gameOver()
        {
            //stops the game loop
            gameTimer.Stop();

            //displays the junimo kart sign
            junimoKartSignImage.Visible = true;

            //displays the yellow junimo in the corner of the screen
            junimoImage.Visible = true;

            //draws all labels used in the home screen
            copyrightLabel.Visible = true;
            controlsLabel.Visible = true;

            enterLabel.Visible = true;
            escapeLabel.Visible = true;
            scoreLabel.Visible = true;

            //hides the ingame score label
            playerScoreLabel.Visible = false;

            //resets players position
            player.X = 200;
            player.Y = 400;

            //clears every platform list
            platforms.Clear();
            platformHeight.Clear();
            platformSupportSidesL.Clear();
            platformSupportSidesR.Clear();

            //clears the coins list
            coins.Clear();

            //resets startup variable so that it can run again upon a new game startup
            startUpVariable = false;

            //resets platform speed
            platformSpeed = 4;

            //displays and resets score
            scoreLabel.Text = $"Your Final Score Is {playerScore} Points!";
            playerScore = 0;
            scoreChecker = 0;

            //resets Dash mechanic
            dashBarCheck = false;

            //resets the dash bar length
            dashBarLength = 100;

            //resets the dashBar position
            dashBar = new Rectangle(dashBar.X, dashBar.Y, 100, dashBar.Height);

            //resets x movement variables
            x = 0;
            xPlatformL = 0;
            xPlatformR = 0;
            xCoins = 0;

            //resets random variables
            coinsRandom = 0;
            tempRandom = 0;

            //resets the stopwatches
            speedBoost.Reset();
            platformIncrease.Reset();

            //I don't have to reset any jump variables because they will reset themselves after a jump
            //You can never fall into the void mid jump so it is unnecessary
        }

    }
}
