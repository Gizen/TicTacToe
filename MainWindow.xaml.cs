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

            string playerX = textBoxPlayerX.Text;
            string playerO = textBoxPlayerO.Text;


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

        }

        private void XO()
        {
            if (playerTurn == 0)
            {
                gameButton.Content = "X";
                playerTurn += 1;
            }
            else
            {
                gameButton.Content = "O";
                playerTurn -= 1;
            }



        }

        private void gameButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void gameButton1_Click(object sender, RoutedEventArgs e)
        {

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

// do not disable buttons

//on start dont change names