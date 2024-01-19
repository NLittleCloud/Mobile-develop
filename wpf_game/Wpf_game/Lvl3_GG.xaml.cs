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

namespace Wpf_game
{
    /// <summary>
    /// Логика взаимодействия для Lvl3_GG.xaml
    /// </summary>
    public partial class Lvl3_GG : Page
    {
        private Lvl3 _lvl3;
        public Lvl3_GG(Lvl3 lvl3)
        {
            _lvl3 = lvl3;
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(_lvl3);
        }
    }
}
