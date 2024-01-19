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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_game
{
    /// <summary>
    /// Логика взаимодействия для Lvl2.xaml
    /// </summary>
    public partial class Lvl2 : Page
    {
        public Lvl2()
        {
            InitializeComponent();
        }
        private void manigame_Clicked(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(new Lvl3(this));

            door1.Opacity = 0;
            door2.Opacity = 1;

            panel1.Opacity = 1;
            panel2.Opacity = 0;
        }

    }
}
