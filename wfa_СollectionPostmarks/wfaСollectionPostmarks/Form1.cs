using System;
using wfaСollectionPostmarks.Classes;

namespace wfaСollectionPostmarks
{
    public partial class Form1 : Form
    {
        public int width = 360;
        public int height = 390;
        public int nrows = 3;
        public int ncols = 2;
        public int colorindex = 0;
        public int design = 0;
        public int padding = 15;
        Page page;

        public Form1()
        {
            InitializeComponent();
            page = new Page(width, height, nrows, ncols, padding, colorindex, design);
            pb_PagePreview.Image = page.GetBitmap();

            FillColors();
            FillDesign();
            tabControl.SelectedIndex = 2;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            cb_Color.SelectedIndexChanged += Cb_Color_SelectedIndexChanged;
            cb_Design.SelectedIndexChanged += Cb_Color_SelectedIndexChanged;

            tb_Width.KeyPress += Tb_Number_KeyPress;
            tb_Height.KeyPress += Tb_Number_KeyPress;
            tb_Rows.KeyPress += Tb_Number_KeyPress;
            tb_Columns.KeyPress += Tb_Number_KeyPress;
            tb_Padding.KeyPress += Tb_Number_KeyPress;

            tb_Width.TextChanged += Tb_Number_TextChanged;
            tb_Height.TextChanged += Tb_Number_TextChanged;
            tb_Rows.TextChanged += Tb_Number_TextChanged;
            tb_Columns.TextChanged += Tb_Number_TextChanged;
            tb_Padding.TextChanged += Tb_Number_TextChanged;

            pb_Page.MouseClick += Pb_Page_MouseClick;
            PageController.pages = new System.Collections.Generic.List<Page>();
        }

        private void Pb_Page_MouseClick(object? sender, MouseEventArgs e)
        {
            for (int i = 0; i < PageController.pages[lb_str.SelectedIndex].rectangles.Count; i++)
            {
                int x = PageController.pages[lb_str.SelectedIndex].rectangles[i].Location.X;
                int y = PageController.pages[lb_str.SelectedIndex].rectangles[i].Location.Y;
                int w = PageController.pages[lb_str.SelectedIndex].rectangles[i].Width;
                int h = PageController.pages[lb_str.SelectedIndex].rectangles[i].Height;

                if (e.Location.X >= x && e.Location.X <= x + w)
                {
                    if (e.Location.Y >= y && e.Location.Y <= y + h)
                    {
                        PageController.pages[lb_str.SelectedIndex].AddPostmarks(PageController.pages[lb_str.SelectedIndex].rectangles[i]);
                        pb_Page.Image = PageController.pages[lb_str.SelectedIndex].GetBitmap();
                    }
                }
            }
        }

        private void Cb_Color_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is ComboBox combo)
            {
                if (combo.Name == "cb_Color") page.SetColor(cb_Color.SelectedIndex);
                else page.SetDesign(cb_Design.SelectedIndex);
            }
            pb_PagePreview.Image = page.GetBitmap();
        }

        private void FillColors()
        {
            cb_Color.Items.Insert(0, "Нет");
            cb_Color.Items.Insert(1, "Золотые волны");
            cb_Color.Items.Insert(2, "Розовый дым");
            cb_Color.Items.Insert(3, "Голубая краска");
            cb_Color.Items.Insert(4, "Лаванда");
            cb_Color.Items.Insert(5, "Салатовый"); //Honeydew
            cb_Color.SelectedIndex = 0;
        }

        private void FillDesign()
        {
            cb_Design.Items.Insert(0, "Нет");
            cb_Design.Items.Insert(1, "Штрих-ткань");
            cb_Design.Items.Insert(2, "Вертикальный штрих");
            cb_Design.Items.Insert(3, "Горизонтальный штрих");
            cb_Design.Items.Insert(4, "Диагональный штрих");
            cb_Design.Items.Insert(5, "Штрих-плед");
            cb_Design.SelectedIndex = 0;
        }

        private void Tb_Number_TextChanged(object? sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Name == "tb_Width" && textBox.Text != "")
                {
                    width = Convert.ToInt32(tb_Width.Text);
                    page.SetWidth(width);
                    pb_PagePreview.Image = page.GetBitmap();
                    pb_PagePreview.Width = page.GetBitmap().Width;

                }
                else if (textBox.Name == "tb_Height" && textBox.Text != "")
                {
                    if (Convert.ToInt32(tb_Height.Text) <= 900)
                    {
                        if (tb_Rows.Text == "" || (Convert.ToInt32(tb_Rows.Text) > Convert.ToDouble(tb_Height.Text) / 100 + 0.4))
                        {
                            nrows = 1;
                            page.SetRows(nrows);
                            pb_PagePreview.Image = page.GetBitmap();
                            tb_Rows.Text = "1";
                        }
                        height = Convert.ToInt32(tb_Height.Text);
                        page.SetHeight(height);
                        pb_PagePreview.Image = page.GetBitmap();
                        pb_PagePreview.Height = page.GetBitmap().Height;
                    }

                }
                else if (textBox.Name == "tb_Rows" && textBox.Text != "")
                {
                    if (tb_Height.Text == "" || (Convert.ToInt32(tb_Rows.Text) <= Convert.ToDouble(tb_Height.Text) / 100 + 0.4))
                    {
                        nrows = Convert.ToInt32(tb_Rows.Text);
                        page.SetRows(nrows);
                        pb_PagePreview.Image = page.GetBitmap();
                    }
                }
                else if (textBox.Name == "tb_Columns" && textBox.Text != "")
                {
                    if (tb_Width.Text == "" || (Convert.ToInt32(tb_Columns.Text) <= Convert.ToDouble(tb_Width.Text) / 100 + 0.4))
                    {
                        ncols = Convert.ToInt32(tb_Columns.Text);
                        page.SetColumns(ncols);
                        pb_PagePreview.Image = page.GetBitmap();
                    }

                }
                else if (textBox.Name == "tb_Padding" && textBox.Text != "")
                {
                    padding = Convert.ToInt32(tb_Padding.Text);
                    page.SetPadding(padding);
                    pb_PagePreview.Image = page.GetBitmap();
                }
            }
        }

        private void Tb_Number_KeyPress(object? sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void TabControl_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0) isIndex0();
        }

        private void isIndex0()
        {
            PageController.FillListBox(lb_str);
            if (lb_str.Items.Count != 0) lb_str.SetSelected(0, true);
            lb_str.SelectedIndexChanged += Lb_str_SelectedIndexChanged;
        }

        private void Lb_str_SelectedIndexChanged(object? sender, EventArgs e)
        {

            pb_Page.Image = PageController.pages[lb_str.SelectedIndex].GetBitmap();
            pb_Page.Size = new Size(PageController.pages[lb_str.SelectedIndex].GetBitmap().Width, PageController.pages[lb_str.SelectedIndex].GetBitmap().Height);
        }

        private void btn_CreatePage_Click(object sender, EventArgs e)
        {
            PageController.AddPage(page);
            page = new Page(width, height, nrows, ncols, padding, colorindex, design);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (lb_str.Items.Count > 0)
            {
                PageController.pages[lb_str.SelectedIndex].Draw();
                pb_Page.Image = PageController.pages[lb_str.SelectedIndex].GetBitmap();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lb_str.Items.Count > 0)
            {
                PageController.pages.RemoveAt(lb_str.SelectedIndex);
                pb_Page.Image = null;
                isIndex0();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (lb_str.Items.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Рисунок.bmp | *.bmp";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = (Bitmap)PageController.pages[lb_str.SelectedIndex].GetBitmap();
                    bmp.Save(sfd.FileName);
                }
            }
        }

        private void btn_SaveF_Click(object sender, EventArgs e)
        {
            if (lb_str.Items.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*\"";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string saveall = "";
                        string savelinepage = "";

                        for (int i = 0; i < PageController.pages.Count; i++)
                        {
                            savelinepage = PageController.pages[i].Width.ToString() + '|';
                            savelinepage += PageController.pages[i].Height.ToString() + '|';
                            savelinepage += PageController.pages[i].NRows.ToString() + '|';
                            savelinepage += PageController.pages[i].NColumns.ToString() + '|';
                            savelinepage += PageController.pages[i].Padding.ToString() + '|';
                            savelinepage += PageController.pages[i].ColorIndex.ToString() + '|';
                            savelinepage += PageController.pages[i].Design.ToString() + '|';

                            FileInfo info = new FileInfo(sfd.FileName);
                            PageController.pages[i].Save(info.DirectoryName + "\\" + i + ".bmp");

                            savelinepage += info.DirectoryName + "\\" + i + ".bmp" + "\n";
                            saveall += savelinepage;
                        }

                        File.WriteAllText(sfd.FileName, saveall);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить файл", "Ошибка");
                    }
                }
            }
        }

        private void btn_OpenF_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*\"";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(ofd.FileName))
                    {
                        string[] readLine = File.ReadAllLines(ofd.FileName);
                        foreach (string line in readLine)
                        {
                            Page pagen = new Page(10, 10, 1, 1, 15, 0, 0);
                            string[] parameters = line.Split('|');
                            int i = 0;
                            foreach (string parameter in parameters)
                            {
                                int n = 0;
                                if (i < 7) n = Convert.ToInt32(parameter);
                                switch (i)
                                {
                                    case 0:
                                        pagen.SetWidth(n);
                                        break;
                                    case 1:
                                        pagen.SetHeight(n);
                                        break;
                                    case 2:
                                        pagen.SetRows(n);
                                        break;
                                    case 3:
                                        pagen.SetColumns(n);
                                        break;
                                    case 4:
                                        pagen.SetPadding(n);
                                        break;
                                    case 5:
                                        pagen.SetColor(n);
                                        break;
                                    case 6:
                                        pagen.SetDesign(n);
                                        break;
                                    case 7:
                                        Bitmap m = new Bitmap(parameter);
                                        pagen.SetBitmap(m);
                                        break;

                                }
                                i++;
                            }

                            if (i == 8) PageController.pages.Add(pagen);
                            else MessageBox.Show("Недостаточно параметров\nПотеря данных(", "Ошибка");
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл", "Ошибка");
                }
            }
            isIndex0();
        }
    }
}