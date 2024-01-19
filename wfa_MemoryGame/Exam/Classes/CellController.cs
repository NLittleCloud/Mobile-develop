using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam.Classes
{
    public class CellController
    {
        public static List<Cell> cells;

        public static void InitCell(TableLayoutPanel table_panel)
        {
            for (int i = 0; i < table_panel.RowCount; i++)
            {
                for (int j = 0; j < table_panel.ColumnCount; j++)
                {
                    Cell cell = new Cell(0, table_panel, j, i);
                    cells.Add(cell);
                }
            }
        }

        public static void RangeNumber(int number)
        {
            Random rnd = new Random();

            for (int i = 0; i < number; i++)
            {
                int n = rnd.Next(0, cells.Count);

                while (cells[n].isUsed == true)
                {
                    n = rnd.Next(0, cells.Count);
                }

                if(cells[n].isUsed == false)
                    cells[n].SetNumber(i+1);
            }
        }

        public static void Turnover()
        {
            for(int i = 0; i < cells.Count; i++)
            {
                cells[i].Turnover();
            }
        }
    }
}
