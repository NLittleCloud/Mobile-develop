using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;

namespace Wpf_game.Classes
{
    public class Platform
    {
        public Image image;
        public double top;
        public double left;

        public bool isTouchedByPlayer;

        public Platform(double top, double left)
        {
            image = new Image();
            image.Height = 30;
            image.Width = 130;
            image.Source = new BitmapImage(new Uri(@"/Images/lvl3_board.png", UriKind.Relative));

            this.top = top;
            this.left = left;
            isTouchedByPlayer = false;
        }

        public void TransformPlatform(double top)
        {
            int x = (int)Canvas.GetTop(this.image);
            Canvas.SetTop(this.image, Canvas.GetTop(this.image) + top);
            this.top = Canvas.GetTop(this.image);
        }

    }
}
