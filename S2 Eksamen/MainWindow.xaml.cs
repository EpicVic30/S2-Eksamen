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
using System.Windows.Threading;

namespace S2_Eksamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int gravity = 8;
        double score;
        Rect FlappyRect;
        bool gameover = false;

        public MainWindow()
        {
            
            startGame();
        }

        private void Canvas_KeyisDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Space)
            {
                player.RenderTransform = new RotateTransform(-20, player.Width / 2, player.Height / 2);
                gravity = -8;
            }
            if (e.Key == Key.R && gameover == true)
            {
                
                startGame();
            }
        }

        private void startGame()
        {
            int temp = 200;
            score = 0;
            Canvas.SetTop(player, 100);
            gameover = false; 
           
            foreach (var x in grid.Children.OfType<Image>())
            {
                
                if (x is Image && (string)x.Tag == "obs1")
                {
                    Canvas.SetLeft(x, 500);
                }
                
                if (x is Image && (string)x.Tag == "obs2")
                {
                    Canvas.SetLeft(x, 800);
                }
                
                if (x is Image && (string)x.Tag == "obs3")
                {
                    Canvas.SetLeft(x, 1000);
                }
                
                if (x is Image && (string)x.Tag == "clouds")
                {
                    Canvas.SetLeft(x, (300 + temp));
                    temp = 800;
                }
            }
        }


    }
}
