using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Wpf_game.Classes
{
    public class PlatformController
    {
        public static List<Platform> platforms;
        public static int score;
        public static int startPlatformY = 700;

        public static void AddPlatform(Canvas canvas, double top, double left)
        {
            Platform platform = new Platform(top, left);
            platforms.Add(platform);
            canvas.Children.Add(platform.image);
        }

        public static void DrawPlatforms()
        {
            for(int i = 0; i < platforms.Count(); i++)
            {
                Canvas.SetLeft(platforms[i].image, platforms[i].left);
                Canvas.SetTop(platforms[i].image, platforms[i].top);
            }
        }

        public static void GenerateRandomPlatform(Canvas canvas)
        {
            Random r = new Random();
            int left = r.Next(30, 270);
            int top = r.Next(-10, 15);
            AddPlatform(canvas, 200 - top, left);


            //int k = r.Next(1, 3);
            //for (int i = 0; i < k; i++)
            //{
            //if(k != 1 && i == 1)
            //{
            //    if ((left + 130/2) - 270 / 2 < 0) left = r.Next(135, 270);
            //    else left = r.Next(0, 135);
            //    top = r.Next(-10, 20);
            //}
            //else{
            //    left = r.Next(30, 270);
            //    top = r.Next(-10, 20);
            ////}
            //AddPlatform(canvas, 200 - top, left);
            //}
        }

        public static void ClearPlatforms()
        {
            for(int i = 0; i < platforms.Count; i++)
            {
                if (Canvas.GetTop(platforms[i].image) >= 1200)
                {
                    platforms.RemoveAt(i);
                }
            }
        }

        public static void GenerateStartPlatforms(Canvas canvas)
        {
            Random r = new Random();

            for(int i = 0; i < 10; i++)
            {
                int x = r.Next(30, 270);
                int y = r.Next(60, 70);
                startPlatformY -= y;
                AddPlatform(canvas, startPlatformY, x);
            }
        }


    }
}
