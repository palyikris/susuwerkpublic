using System.Collections;

namespace elso
{
    public enum Type
    {
        CHECKERED,
        RULED,
        NORMAL
    }
    public class Workbook
    {
        private Type type;
        private List<string> pages;
        private int empty;

        public Workbook(int n, Type type)
        {
            pages = new List<string>();
            for (int i = 0; i < n; i++)
            {
                pages.Add("");
            }
            this.type = type;
            empty = 0;
        }

        public int NumberOfPages()
        {
            return pages.Count;
        }

    }
}
