using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Drawing;
using wfaСollectionPostmarks.Properties;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace wfaСollectionPostmarks.Classes
{
    public class Page
    {
        public int Width = 0;
        public int Height = 0;
        public int NRows = 0;
        public int NColumns = 0;
        public int Padding = 15;
        public int ColorIndex = 0;
        public int Design = 0;
        Bitmap bitpage;
        public List<Rectangle> rectangles;
        //public int

        public Page(int width, int height, int nrows, int columns, int padding, int colorindex, int design)
        {
            this.Width = width;
            this.Height = height;
            this.NRows = nrows;
            this.ColorIndex = colorindex;
            this.Design = design;
            this.NColumns = columns;
            this.Padding = padding;

            this.bitpage = new Bitmap(width, height);
            rectangles = new System.Collections.Generic.List<Rectangle>();
            Draw();
        }

        public void SetWidth(int width)
        {
            this.Width = width;
            this.bitpage = new Bitmap(bitpage, new Size(this.Width, this.Height));
            Draw();
        }

        public void SetHeight(int height)
        {
            this.Height = height;
            this.bitpage = new Bitmap(bitpage, new Size(this.Width, this.Height));
            Draw();
        }

        public void SetRows(int nrows)
        {
            this.NRows = nrows;
            Draw();
        }

        public void SetColumns(int ncolms)
        {
            this.NColumns = ncolms;
            Draw();
        }

        public void SetColor(int colorindex)
        {
            this.ColorIndex = colorindex;
            Draw();
        }

        public void SetDesign(int design)
        {
            this.Design = design;
            Draw();
        }

        public void SetPadding(int padding)
        {
            this.Padding = padding;
            Draw();
        }

        public void Save(string Filename)
        {
            bitpage.Save(Filename);
        }

        public void SetBitmap(Bitmap bit)
        {
            bitpage = bit;
        }

        public void Draw()
        {
            rectangles.Clear();

            var b = new Bitmap(this.Width, this.Height);
            var g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int x = 0;
            int y = 0;

            SolidBrush Brush = new SolidBrush(Color.PeachPuff);
            if (ColorIndex == 1) Brush = new SolidBrush(Color.AntiqueWhite);
            else if (ColorIndex == 2) Brush = new SolidBrush(Color.RosyBrown);
            else if (ColorIndex == 3) Brush = new SolidBrush(Color.DarkTurquoise);
            else if (ColorIndex == 4) Brush = new SolidBrush(Color.Plum);
            else if (ColorIndex == 5) Brush = new SolidBrush(Color.MediumAquamarine);

            Designer(g);
            if (NRows > 1 && NColumns > 1)
            {
                int xhe = Convert.ToInt32((Height - 2 * Padding) / (NRows + 0.2));
                int ost = (Height - xhe * NRows - 2 * Padding) / (NRows - 1);

                int ywi = Convert.ToInt32((Width - 2 * Padding) / (NColumns + 0.2));
                int osty = (Width - ywi * NColumns - 2 * Padding) / (NColumns - 1);

                for (int i = 0; i < NRows; i++)
                {
                    for (int j = 0; j < NColumns; j++)
                    {
                        Rectangle rect = new Rectangle(x + Padding, y + Padding, ywi, xhe);
                        rectangles.Add(rect);
                        g.FillRectangle(Brush, rect);
                        x += ywi + osty;
                    }
                    x = 0;
                    y += xhe + ost;
                }
            }else
            {
                Rectangle rect = new Rectangle(x + Padding, y + Padding, Width - 2 * Padding, Height - 2 * Padding);
                rectangles.Add(rect);
                g.FillRectangle(Brush, rect);
            }

            bitpage = (Bitmap)b.Clone();
        }

        public void Designer(Graphics g) 
        {
            SolidBrush ColorBrush;
            TextureBrush myTextureBrush;

            switch (ColorIndex)
            {
                case 0:
                    ColorBrush = new SolidBrush(Color.Transparent);
                    g.FillRectangle(ColorBrush, 0, 0, Width, Height);
                    break;
                case 1:
                    Image m = wfaСollectionPostmarks.Properties.Resources.back_1;
                    myTextureBrush = new TextureBrush(m);
                    g.FillRectangle(myTextureBrush, 0,0, Width, Height);
                    break;
                case 2:
                    Image m1 = wfaСollectionPostmarks.Properties.Resources.back_2;
                    myTextureBrush = new TextureBrush(m1);
                    g.FillRectangle(myTextureBrush, 0, 0, Width, Height);
                    break;
                case 3:
                    Image m3 = wfaСollectionPostmarks.Properties.Resources.back_3;
                    myTextureBrush = new TextureBrush(m3);
                    g.FillRectangle(myTextureBrush, 0, 0, Width, Height);
                    break;
                case 4:
                    ColorBrush = new SolidBrush(Color.Lavender);
                    g.FillRectangle(ColorBrush, 0, 0, Width, Height);
                    break;
                case 5:
                    ColorBrush = new SolidBrush(Color.Honeydew);
                    g.FillRectangle(ColorBrush, 0, 0, Width, Height);
                    break;
            }

            HatchBrush myHatchBrush;
            switch (Design)
            {
                case 1:
                    myHatchBrush = new HatchBrush(HatchStyle.Weave, Color.Gray, Color.Transparent);
                    g.FillRectangle(myHatchBrush, 0, 0, Width, Height);
                    break;
                case 2:
                    myHatchBrush = new HatchBrush(HatchStyle.Vertical, Color.Gray, Color.Transparent);
                    g.FillRectangle(myHatchBrush, 0, 0, Width, Height);
                    break;
                case 3:
                    myHatchBrush = new HatchBrush(HatchStyle.Horizontal, Color.Gray, Color.Transparent);
                    g.FillRectangle(myHatchBrush, 0, 0, Width, Height);
                    break;
                case 4:
                    myHatchBrush = new HatchBrush(HatchStyle.ForwardDiagonal, Color.Gray, Color.Transparent);
                    g.FillRectangle(myHatchBrush, 0, 0, Width, Height);
                    break;
                case 5:
                    myHatchBrush = new HatchBrush(HatchStyle.Plaid, Color.Gray, Color.Transparent);
                    g.FillRectangle(myHatchBrush, 0, 0, Width, Height);
                    break;
            }


        }

        public void AddPostmarks(Rectangle rect)
        {
            Image m = wfaСollectionPostmarks.Properties.Resources.back_1;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.PNG)|*.PNG";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл", "Ошибка");
                }
            }
            var b = new Bitmap(bitpage);
            var g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            SolidBrush Brush = new SolidBrush(Color.PeachPuff);
            if (ColorIndex == 1) Brush = new SolidBrush(Color.AntiqueWhite);
            else if (ColorIndex == 2) Brush = new SolidBrush(Color.RosyBrown);
            else if (ColorIndex == 3) Brush = new SolidBrush(Color.DarkTurquoise);
            else if (ColorIndex == 4) Brush = new SolidBrush(Color.Plum);
            else if (ColorIndex == 5) Brush = new SolidBrush(Color.MediumAquamarine);
            g.FillRectangle(Brush, rect);
            g.DrawImage(m, rect);

            bitpage = (Bitmap)b.Clone();
        }
        
        public Image GetBitmap()
        {
            return bitpage;
        }
    }
}