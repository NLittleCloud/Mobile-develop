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
using System.Windows.Media.Animation;

namespace Wpf_game
{
    /// <summary>
    /// Логика взаимодействия для Lvl1.xaml
    /// </summary>
    public partial class Lvl1 : Page
    {
        bool isNext = false;

        public Lvl1()
        {
            InitializeComponent();
        }

        private void a_rightClick(object sender, MouseEventArgs e)
        {
            //do something here
            if (!isNext)
            {
                isNext = true;
                Storyboard storyboard = new Storyboard();
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 1,
                    To = 0,
                    Duration = new Duration(TimeSpan.FromMilliseconds(600)),
                    AutoReverse = true,
                    RepeatBehavior = new RepeatBehavior(2.0)

                };
                DoubleAnimation animation2 = new DoubleAnimation()
                {
                    BeginTime = TimeSpan.FromSeconds(1.8),
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromMilliseconds(600))
                };
                DoubleAnimation animation3 = new DoubleAnimation()
                {
                    BeginTime = TimeSpan.FromSeconds(2.9),
                    From = 1,
                    To = 0,
                    Duration = new Duration(TimeSpan.FromMilliseconds(600))
                };
                animation3.Completed += anim_Completed;

                Storyboard.SetTarget(animation, img2);
                Storyboard.SetTargetProperty(animation, new PropertyPath(Image.OpacityProperty));
                Storyboard.SetTarget(animation2, img2);
                Storyboard.SetTargetProperty(animation2, new PropertyPath(Image.OpacityProperty));
                Storyboard.SetTarget(animation3, img2);
                Storyboard.SetTargetProperty(animation3, new PropertyPath(Image.OpacityProperty));
                storyboard.Children.Add(animation);
                storyboard.Children.Add(animation2);
                storyboard.Children.Add(animation3);
                storyboard.Begin();
            }

        }

        void anim_Completed(object? sender, EventArgs e)
        {
            isNext = true;
            person1.Opacity = 0;
            person2.Opacity = 1;

            DoubleAnimation Left = new DoubleAnimation()
            {
                From = Canvas.GetLeft(person2),
                To = 100,
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };

            DoubleAnimation Top = new DoubleAnimation()
            {
                From = Canvas.GetTop(person2),
                To = 275,
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };

            Top.Completed += anim2_Completed;
            person2.BeginAnimation(Canvas.LeftProperty, Left);
            person2.BeginAnimation(Canvas.TopProperty, Top);
        }

        void anim2_Completed(object? sender, EventArgs e)
        {
                NavigationService.Navigate(new Lvl2());
        }
    }
}
