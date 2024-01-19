using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaСollectionPostmarks.Classes
{
    public class PageController
    {
        public static List<Page> pages;

        public static void AddPage(Page page)
        {
            pages.Add(page);
        }

        public static void FillListBox(ListBox list)
        {
            list.Items.Clear();
            for(int i = 0; i < pages.Count; i++)
            {
                list.Items.Insert(i, "Страница " + (i+1));
            }
        }
    }
}
    