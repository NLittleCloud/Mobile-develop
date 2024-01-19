using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exam.Classes
{
    public class Cell
    {
        public int number = -1;
        Button btn;
        public bool isUsed = false;

        public Cell(int number, TableLayoutPanel panel, int colums, int rows)
        {
            this.number = number;
            btn = new Button();
            btn.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            btn.BackColor = Color.Plum;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            isUsed = false;
            panel.Controls.Add(btn, colums, rows);
        }

        public void SetNumber(int num)
        {
            this.number = num;
            isUsed = true;
            btn.BackColor = Color.MediumPurple;
            btn.Text = "" + num;
        }

        public void Turnover()
        {
            btn.BackColor = Color.Plum;
            btn.Text = "";
        }


        public Button GetButton()
        {
            return btn;
        }
    }
}
