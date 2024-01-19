using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    public class Player
    {
        public int score = 0;
        public System.TimeSpan x;
        public System.TimeSpan x2;
        public System.TimeSpan x3;

        public Player(int score)
        {
            this.score = score;
        }

        public void ChangeScore(Label label, int sc)
        {
            score += sc;
            label.Text = "Счет: " + score;
        }


    }
}
