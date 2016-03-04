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
        int buttonClick = 0;
        int gameOver = 0;
        int gameTurns = 0;
        
        public MainWindow()
        {
            InitializeComponent();

            gameButton.IsEnabled = false;
            gameButton1.IsEnabled = false;
            gameButton2.IsEnabled = false;
            gameButton3.IsEnabled = false;
            gameButton4.IsEnabled = false;
            gameButton5.IsEnabled = false;
            gameButton6.IsEnabled = false;
            gameButton7.IsEnabled = false;
            gameButton8.IsEnabled = false;




        }

        private void buttonStartGame_Click(object sender, RoutedEventArgs e)
        {
            gameButton.IsEnabled = true;
            gameButton1.IsEnabled = true;
            gameButton2.IsEnabled = true;
            gameButton3.IsEnabled = true;
            gameButton4.IsEnabled = true;
            gameButton5.IsEnabled = true;
            gameButton6.IsEnabled = true;
            gameButton7.IsEnabled = true;
            gameButton8.IsEnabled = true;

            gameButton.Content = "";
            gameButton1.Content = "";
            gameButton2.Content = "";
            gameButton3.Content = "";
            gameButton4.Content = "";
            gameButton5.Content = "";
            gameButton6.Content = "";
            gameButton7.Content = "";
            gameButton8.Content = "";
            string playerX = textBoxPlayerX.Text;
            string playerO = textBoxPlayerO.Text;
        }

        private void XO(Button gB)
        {
            if (gB.Content == "")
            {
                if (playerTurn == 0)
                {
                    gB.Content = "X";
                    playerTurn = 1;
                }
                else
                {
                    gB.Content = "O";
                    playerTurn -= 1;
                }                
            }
            gameTurns++;
        }

        private void GameWon()
        {
            if ((gameButton.Content == gameButton1.Content && gameButton1.Content == gameButton2.Content)
                || (gameButton3.Content == gameButton4.Content && gameButton4.Content == gameButton5.Content)
                || (gameButton6.Content == gameButton7.Content && gameButton7.Content == gameButton8.Content)
                || (gameButton.Content == gameButton3.Content && gameButton3.Content == gameButton6.Content)
                || (gameButton1.Content == gameButton4.Content && gameButton7.Content == gameButton4.Content)
                || (gameButton2.Content == gameButton5.Content && gameButton5.Content == gameButton8.Content)
                || (gameButton.Content == gameButton4.Content && gameButton4.Content == gameButton8.Content)
                || (gameButton2.Content == gameButton4.Content && gameButton4.Content == gameButton6.Content))
            {

            }
        }

        private void gameButton_Click(object sender, RoutedEventArgs e)
        {
            XO(gameButton);
        }

        private void gameButton1_Click(object sender, RoutedEventArgs e)
        {
            XO(gameButton1);
        }

        private void gameButton2_Click(object sender, RoutedEventArgs e)
        {
            XO(gameButton2);
        }

        private void gameButton3_Click(object sender, RoutedEventArgs e)
        {
            XO(gameButton3);
        }

        private void gameButton4_Click(object sender, RoutedEventArgs e)
        {
            XO(gameButton4);
        }

        private void gameButton5_Click(object sender, RoutedEventArgs e)
        {
            XO(gameButton5);
        }

        private void gameButton6_Click(object sender, RoutedEventArgs e)
        {
            XO(gameButton6);
        }

        private void gameButton7_Click(object sender, RoutedEventArgs e)
        {
            XO(gameButton7);
        }

        private void gameButton8_Click(object sender, RoutedEventArgs e)
        {
            XO(gameButton8);
        }
    }
}
//Layout Window
//DONE

//Buttons cant be clicked before game starts
//DONE

//TextBlocks display x or o

//On click display whos turn

//calc winner

//Detecty no winner

//track whos turn

//aftereach click check for win

// do not disable buttons to stop them from changing
//DONE

//on start dont change names