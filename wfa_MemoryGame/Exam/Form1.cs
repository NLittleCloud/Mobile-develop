
using Exam.Classes;
using System.Numerics;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {

        public int level = 1;
        public int number = 4;
        public int order = 1;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private DateTime startTmUp;
        Player player;
        int score_win = 0;
        int score_lose = 0;

        public Form1()
        {
            InitializeComponent();
            CellController.cells = new System.Collections.Generic.List<Cell>();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Start();
            startTmUp = DateTime.Now;

            player = new Player(0);

            FillColors();
            cmb_level.SelectedIndexChanged += Cmb_level_SelectedIndexChanged;

            if (level == 1)
            {
                table_panel.RowCount = 3;
                table_panel.ColumnCount = 3;
                number = 4;
            }

            Init();
        }

        private void Cmb_level_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmb_level.SelectedIndex == 0)
            {
                table_panel.RowCount = 3;
                table_panel.ColumnCount = 3;
                number = 4;
                score_lose = -5;
                score_win = 8;
                Init();
            }
            else if (cmb_level.SelectedIndex == 1)
            {
                table_panel.RowCount = 4;
                table_panel.ColumnCount = 4;
                number = 6;
                score_lose = -3;
                score_win = 15;
                Init();
            }
            else
            {
                table_panel.RowCount = 5;
                table_panel.ColumnCount = 5;
                number = 8;
                score_lose = -1;
                score_win = 30;
                Init();
            }
        }

        private void FillColors()
        {
            cmb_level.Items.Insert(0, "Начальный");
            cmb_level.Items.Insert(1, "Средний");
            cmb_level.Items.Insert(2, "Продвинутый");
        }

        public void Init()
        {
            CellController.cells.Clear();
            table_panel.Controls.Clear();
            CellController.InitCell(table_panel);
            Style();
            CellController.RangeNumber(number);
            startTmUp = DateTime.Now;
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            System.TimeSpan x;
            x = DateTime.Now.Subtract(startTmUp);
            l_time.Text = x.ToString(@"mm\:ss");
        }

        public void Style()
        {
            table_panel.ColumnStyles.Clear();
            table_panel.RowStyles.Clear();
            for (int i = 0; i < table_panel.ColumnCount; i++)
            {
                table_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / table_panel.ColumnCount));
            }
            for (int i = 0; i < table_panel.RowCount; i++)
            {
                table_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / table_panel.RowCount));
            }
        }

        public void Click_buttons()
        {
            for (int i = 0; i < CellController.cells.Count; i++)
            {
                CellController.cells[i].GetButton().Click += Button_Click;

            }
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            int n = 0;

            if (sender is Button btn)
            {
                for (int i = 0; i < CellController.cells.Count; i++)
                {

                    if (CellController.cells[i].GetButton() == btn)
                    {
                        n = i;
                        break;
                    }
                }
            }

            if (CellController.cells[n].number == order)
            {

                if (order == number)
                {
                    MessageBox.Show("You win");
                    order = 1;
                    player.ChangeScore(l_score, score_win);
                    Init();
                }
                else order++;
            }
            else
            {
                MessageBox.Show("You lose");
                player.ChangeScore(l_score, score_lose);
                order = 1;
                Init();
            }

        }

        private void btn_Turn_Click(object sender, EventArgs e)
        {
            CellController.Turnover();
            Click_buttons();
        }
    }
}