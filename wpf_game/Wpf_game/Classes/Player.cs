using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_game.Classes;
using System.Windows.Controls;

namespace Wpf_game.Classes
{
    public class Player
    {
        public Physics physics;

        public Player(Image image)
        {
            physics = new Physics(image);
        }


    }
}
