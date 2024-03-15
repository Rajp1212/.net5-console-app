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
        private char[,] _grid = new char[3, 3];
        private bool _isX = true;

        public MainWindow()
        {
            InitializeComponent();
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    _grid[i, j] = '-';
                }
            }
            _isX = true;

            string imagePath = "/Images/default.png";
            img00.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            img01.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            img02.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            img10.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            img11.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            img12.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            img20.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            img21.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            img22.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            MessageBox.Show("Player X Go!", "Start!");
        }
        private void img_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string location = (sender as Image).Tag.ToString();
            if(ProcessClick(location)==true)
            {
                if (CheckWin())
                {
                    string player = _isX ? "X" : "O";
                    MessageBox.Show($"Player {player} wins!", "We have a winner!");
                    InitializeBoard();
                    
                }
                else
                {
                    _isX = !_isX;
                }
            }
            else
            {
                MessageBox.Show("Spot already taken.  Try again.", "Nope!");
            }
        }

        private bool ProcessClick(string location)
        {
            string[] coord = location.Split(':');
            int row = int.Parse(coord[0]);
            int col = int.Parse(coord[1]);

            //Space is free
            if(_grid[row,col]=='-')
            {
                //Player X is playing
                if(_isX==true)
                {
                    _grid[row, col] = 'X';
                }
                //Player O is playing
                else
                {
                    _grid[row, col] = 'O';
                }
                UpdateImage(location);
                return true;
            }
            //space is not free
            else
            {
                return false;
            }

        }

        private void UpdateImage(string location)
        {
            string imagePath = "";
            if(_isX==true)
            {
                imagePath = "/Images/X.png";
            }
            else
            {
                imagePath = "/Images/O.png";
            }

            switch(location)
            {
                case "0:0": img00.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative)); break;
                case "0:1": img01.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative)); break;
                case "0:2": img02.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative)); break;
                case "1:0": img10.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative)); break;
                case "1:1": img11.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative)); break;
                case "1:2": img12.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative)); break;
                case "2:0": img20.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative)); break;
                case "2:1": img21.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative)); break;
                case "2:2": img22.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative)); break;

            }
        }

        private bool CheckWin()
        {
            char val = _isX ? 'X' : 'O';
            //CHECK ROWS
            if (_grid[0, 0] == val && _grid[0, 1] == val && _grid[0, 2] == val)
                return true;
            else if (_grid[1, 0] == val && _grid[1, 1] == val && _grid[1, 2] == val)
                return true;
            else if (_grid[2, 0] == val && _grid[2, 1] == val && _grid[2, 2] == val)
                return true;

            //CHECK COLUMNS
            if (_grid[0, 0] == val && _grid[1, 0] == val && _grid[2, 0] == val)
                return true;
            else if (_grid[0, 1] == val && _grid[1, 1] == val && _grid[2, 1] == val)
                return true;
            else if (_grid[0, 2] == val && _grid[1, 2] == val && _grid[2, 2] == val)
                return true;

            //CHECK DIAGONAL LINES
            else if (_grid[0, 0] == val && _grid[1, 1] == val && _grid[2, 2] == val)
                return true;
            else if (_grid[0, 2] == val && _grid[1, 1] == val && _grid[2, 0] == val)
                return true;

            if(AnySpacesLeft()==false)
            {
                MessageBox.Show("Game board full. No winners.", "No winners");
                InitializeBoard();
            }
            return false;
        }

        private bool AnySpacesLeft()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_grid[i, j] == '-')
                        return true;
                }
            }

            return false;
        }
    }
}
