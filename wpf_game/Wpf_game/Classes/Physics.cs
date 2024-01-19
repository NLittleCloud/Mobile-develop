using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Wpf_game.Classes
{
    public class Physics
    {
        double gravity;
        double a;
        Image image;

        public Physics(Image image)
        {
            this.image = image;
            gravity = 0.0;
            a = 1.6;
        }

        public void Jump(Canvas canvas)
        {
            if(Canvas.GetTop(image) < 900)
            {
                Canvas.SetTop(image, Canvas.GetTop(image) + gravity);
                gravity += a;
                Collide(canvas);
            }
        }

        public void Collide(Canvas canvas)
        {
            for(int i = 0; i < PlatformController.platforms.Count(); i++)
            {
                if ((Canvas.GetLeft(image) + image.Width / 2 >= Canvas.GetLeft(PlatformController.platforms[i].image)) && (Canvas.GetLeft(image) + image.Width / 2 <= Canvas.GetLeft(PlatformController.platforms[i].image) + PlatformController.platforms[i].image.Width))
                //Середина игрока в диапазоне от начала и до конца платформы
                {
                    if ((Canvas.GetTop(image) + image.Height >= Canvas.GetTop(PlatformController.platforms[i].image)) && (Canvas.GetTop(image) + image.Height <= Canvas.GetTop(PlatformController.platforms[i].image) + PlatformController.platforms[i].image.Height))
                    //По высоте нижняя точка игрока находиться в пределах платформы
                    {
                        if (gravity > 0)
                        {
                            AddForce();
                            if (!PlatformController.platforms[i].isTouchedByPlayer)
                            {
                                PlatformController.score += 20;
                                PlatformController.platforms[i].isTouchedByPlayer = true;
                                PlatformController.GenerateRandomPlatform(canvas);
                            }
                        }
                    }

                }
            }

        }
        
        public void AddForce()
        {
            gravity = -20.0;
        }
    }
}
