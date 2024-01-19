using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using System.Windows.Threading;
using Wpf_game.Classes;
using static System.Net.Mime.MediaTypeNames;

namespace Wpf_game
{
    /// <summary>
    /// Логика взаимодействия для Lvl3.xaml
    /// </summary>
    
    public partial class Lvl3 : Page
    {
        bool goright = false;
        bool goleft = false;
        int speed = 8;

        Player player;

        DispatcherTimer timer = new DispatcherTimer();
        private Lvl2 _lvl2;

        public Lvl3(Lvl2 lvl2)
        {
            InitializeComponent();
            _lvl2 = lvl2;

            mycanvas.Focus();
            this.KeyDown += new KeyEventHandler(KeyIsDown);
            this.KeyUp += new KeyEventHandler(KeyIsUp);

            Init();
            timer.Tick += gameEngine;
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Start();
        }

        public void Init()
        {
            PlatformController.platforms = new System.Collections.Generic.List<Platform>();
            PlatformController.AddPlatform(mycanvas, 500, 170);
            PlatformController.startPlatformY = 450;
            PlatformController.score = 0;
            PlatformController.GenerateStartPlatforms(mycanvas);;
            Canvas.SetTop(person, 270);
            Canvas.SetLeft(person, 175);
            player = new Player(person);

            Canvas.SetZIndex(person, 150);
        }

        private void gameEngine(object? sender, EventArgs e)
        {
            
            if(Canvas.GetTop(person) >= Canvas.GetTop(PlatformController.platforms[0].image) + 200)
            {
                PlatformController.platforms.Clear();
                mycanvas.Children.Clear();
                timer.Stop();
                NavigationService.Navigate(new Lvl3_GG(this));
                mycanvas.Children.Add(person);
                mycanvas.Children.Add(l_score);

                goright = false; goleft = false;
                Init();
                timer.Start();
            }else{
                player.physics.Jump(mycanvas);
                PlatformController.ClearPlatforms();
                PlatformController.DrawPlatforms();
                FollowPlayer();

                l_score.Content = "Score: " + PlatformController.score;

                if (PlatformController.score == 1000)
                {
                    timer.Stop();
                    NavigationService.Navigate(_lvl2);
                }
            }

            if (goright == true && (Canvas.GetLeft(person) + (person.Width + 20) < 450))
            {
                Canvas.SetLeft(person, Canvas.GetLeft(person) + speed);
            }
            if (goleft == true && Canvas.GetLeft(person) > 5)
            {
                Canvas.SetLeft(person, Canvas.GetLeft(person) - speed);
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D)
            {
                if(goleft == true) person.Source = new BitmapImage(new Uri(@"/Images/person_left.png", UriKind.Relative));
                else person.Source = new BitmapImage(new Uri(@"/Images/person.png", UriKind.Relative));
                goright = false;
            }
            if (e.Key == Key.A)
            {
                if(goright == true) person.Source = new BitmapImage(new Uri(@"/Images/person_right.png", UriKind.Relative));
                else person.Source = new BitmapImage(new Uri(@"/Images/person.png", UriKind.Relative));
                goleft = false;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.D)
            {
                person.Source = new BitmapImage(new Uri(@"/Images/person_right.png", UriKind.Relative));
                goright = true;
            }
            if(e.Key == Key.A)
            {
                person.Source = new BitmapImage(new Uri(@"/Images/person_left.png", UriKind.Relative));
                goleft = true;
            }
            if (goright == true && goleft == true)
            {
                person.Source = new BitmapImage(new Uri(@"/Images/person.png", UriKind.Relative));
            }
        }

        public void FollowPlayer()
        {
            int offset = 600 - (int)Canvas.GetTop(person);
            Canvas.SetTop(person, Canvas.GetTop(person) + offset);
            for (int i = 0; i < PlatformController.platforms.Count(); i++)
            {
                PlatformController.platforms[i].TransformPlatform(offset);
            }
        }
    }
}