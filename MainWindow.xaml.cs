using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int playerTurn = 0;
        int gameOver = 0;
        int gameTurns = 0;
        string playerX;
        string playerO;
        int endGame = 0;
        int xWins = 0;
        int yWins = 0;



        public MainWindow()
        {
            InitializeComponent();

            //Disable Buttons
            gameButton.IsEnabled = false;
            gameButton1.IsEnabled = false;
            gameButton2.IsEnabled = false;
            gameButton3.IsEnabled = false;
            gameButton4.IsEnabled = false;
            gameButton5.IsEnabled = false;
            gameButton6.IsEnabled = false;
            gameButton7.IsEnabled = false;
            gameButton8.IsEnabled = false;

            textBlockPlayerTurn.Text = "";
        }

        //Start button
        private void buttonStartGame_Click(object sender, RoutedEventArgs e)
        {
            //Enable Buttons
            gameButton.IsEnabled = true;
            gameButton1.IsEnabled = true;
            gameButton2.IsEnabled = true;
            gameButton3.IsEnabled = true;
            gameButton4.IsEnabled = true;
            gameButton5.IsEnabled = true;
            gameButton6.IsEnabled = true;
            gameButton7.IsEnabled = true;
            gameButton8.IsEnabled = true;

            //Set Button text to blank
            gameButton.Content = "";
            gameButton1.Content = "";
            gameButton2.Content = "";
            gameButton3.Content = "";
            gameButton4.Content = "";
            gameButton5.Content = "";
            gameButton6.Content = "";
            gameButton7.Content = "";
            gameButton8.Content = "";

            //Set Background button color to white
            gameButton.Background = Brushes.White;
            gameButton1.Background = Brushes.White;
            gameButton2.Background = Brushes.White;
            gameButton3.Background = Brushes.White;
            gameButton4.Background = Brushes.White;
            gameButton5.Background = Brushes.White;
            gameButton6.Background = Brushes.White;
            gameButton7.Background = Brushes.White;
            gameButton8.Background = Brushes.White;

            //Store player names
            playerX = textBoxPlayerX.Text;
            playerO = textBoxPlayerO.Text;

            //Set vars to begining values
            playerTurn = 0;
            gameOver = 0;
            gameTurns = 0;
            endGame = 0;

            //Wins impact who goes first
            if (yWins <= xWins)
            {
                playerTurn = 1;
            }
            //Name Easter Egg
            if (playerO == "Mark")
            {
                playerTurn = 1;
            }
            else if (playerX == "Mark")
            {
                playerTurn = 0;
            }

            PlayerTurnText();
        }

        //Methods
        private void XO(Button gB)
        {
            
            //Check to see if there is already a value for the button
                if ((string)(gB.Content) == "")
                {

            // Set X and O respectivly
                    if (playerTurn == 0)
                    {
                        gB.Content = "X";
                        playerTurn += 1;
                    }
                    else
                    {
                        gB.Content = "O";
                        playerTurn -= 1;
                    }

            //End game after 9 turns
                    if (gameTurns == 8)
                    {
                        textBlockPlayerTurn.Text = "Game Over No Winner";
                        endGame = 1;
                    }
                }

            //Add one to gameTurns
                gameTurns++;
            }        

        private void CheckAll()
        {

            //Check all the possible win combos
            GameWon(gameButton, gameButton1, gameButton2);
            GameWon(gameButton3, gameButton4, gameButton5);
            GameWon(gameButton6, gameButton7, gameButton8);
            GameWon(gameButton, gameButton3, gameButton6);
            GameWon(gameButton1, gameButton4, gameButton7);
            GameWon(gameButton2, gameButton5, gameButton8);
            GameWon(gameButton, gameButton4, gameButton8);
            GameWon(gameButton2, gameButton4, gameButton6);

            //display correct win message
            if ((gameOver != 0) && (playerTurn != 0) && (gameOver == 1))
            {
                textBlockPlayerTurn.Text = playerX + " Won The Game";
                xWins++;
            }
            else if ((gameOver != 0) && (playerTurn == 0) && (gameOver == 1))
            {
                textBlockPlayerTurn.Text = playerO + " Won The Game";
                yWins++;
            }
            else if ((gameOver != 0) && (playerTurn != 0) && (gameOver >= 1))
            {
                textBlockPlayerTurn.Text = playerX + " Won The Game In " + Convert.ToString(gameOver) + " Ways";
                xWins++;
            }
            else if ((gameOver != 0) && (playerTurn == 0) && (gameOver >= 1))
            {
                textBlockPlayerTurn.Text = playerO + " Won The Game In " + Convert.ToString(gameOver) + " Ways";
                yWins++;
            }
        }

        private void GameWon(Button btn, Button btn2, Button btn3)
        {

            //Check for 3 valid X or O values in a row
            if (((string)(btn.Content) != "") && (btn.Content == btn2.Content) && (btn2.Content == btn3.Content))
            {

            //If valid win turn them to blue
                btn.Background = Brushes.Cyan;
                btn2.Background = Brushes.Cyan;
                btn3.Background = Brushes.Cyan;

            //Add one to gameOver
                gameOver++;
            }
        }

        private void PlayerTurnText()
        {

            //If game isn't over
           

            //State Correct players turn
                if (playerTurn == 0)
                {
                    textBlockPlayerTurn.Text = playerX + "'s Turn";
                }
                else
                {
                    textBlockPlayerTurn.Text = playerO + "'s Turn";
                }
            }



//All the game buttons
        private void gameButton_Click(object sender, RoutedEventArgs e)
        {
            if (gameOver == 0 && endGame == 0)
            {
                XO(gameButton);
                CheckAll();
                PlayerTurnText();
            }
        }

        private void gameButton1_Click(object sender, RoutedEventArgs e)
        {
            if (gameOver == 0 && endGame == 0)
            {
                XO(gameButton1);
                CheckAll();
                PlayerTurnText();
            }
        }

        private void gameButton2_Click(object sender, RoutedEventArgs e)
        {
            if (gameOver == 0 && endGame == 0)
            {
                XO(gameButton2);
                CheckAll();
                PlayerTurnText();
            }
        }

        private void gameButton3_Click(object sender, RoutedEventArgs e)
        {
            if (gameOver == 0 && endGame == 0)
            {
                XO(gameButton3);
                CheckAll();
                PlayerTurnText();
            }
        }

        private void gameButton4_Click(object sender, RoutedEventArgs e)
        {
            if (gameOver == 0 && endGame == 0)
            {
                XO(gameButton4);
                CheckAll();
                PlayerTurnText();
            }
        }

        private void gameButton5_Click(object sender, RoutedEventArgs e)
        {
            if (gameOver == 0 && endGame == 0)
            {
                XO(gameButton5);
                CheckAll();
                PlayerTurnText();
            }
        }

        private void gameButton6_Click(object sender, RoutedEventArgs e)
        {
            if (gameOver == 0 && endGame == 0)
            {
                XO(gameButton6);
                CheckAll();
                PlayerTurnText();
            }
        }

        private void gameButton7_Click(object sender, RoutedEventArgs e)
        {
            if (gameOver == 0 && endGame == 0)
            {
                XO(gameButton7);
                CheckAll();
                PlayerTurnText();
            }
        }

        private void gameButton8_Click(object sender, RoutedEventArgs e)
        {
            if (gameOver == 0 && endGame == 0)
            {
                XO(gameButton8);
                CheckAll();
                PlayerTurnText();
            }
        }
    }
}