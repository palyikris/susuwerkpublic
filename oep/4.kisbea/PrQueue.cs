using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF4
{

    public struct Element
    {
        public int pr;
        public string data;
    }
    internal class PrQueue
    {
        private List<Element> elements = new List<Element>();


        public void SetEmpty()
        {
            elements.Clear();
        }

        public bool isEmpty()
        {
            return elements.Count == 0;
        }

        public void Add(Element e)
        {
            elements.Add(e);
        }

        private (int, int) MaxSelect()
        {
            if (elements.Count == 0)
            {
                throw new Exception("Hiba!");
            }

            int maxind = 0;
            int maxert = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].pr > maxert)
                {
                    maxind = i;
                    maxert = elements[i].pr;
                }
            }

            return (maxert, maxind);
        }

        public Element GetMax()
        {
            if(elements.Count == 0)
            {
                throw new Exception("Error!");
            }

            (int _, int maxind) = MaxSelect();

            return elements[maxind];
            
        }

        private void pop_back()
        {
            if (elements.Count == 0)
            {
                throw new Exception("Hiba!");
            }

            (int _, int maxind) = MaxSelect();

            elements.RemoveAt(maxind);
        }
        public Element RemMax()
        {
            if (elements.Count == 0)
            {
                throw new Exception("Error!");
            }

            (int _, int maxind) = MaxSelect();
            

            Element e = elements[maxind];

            elements[maxind] = elements[elements.Count];

            pop_back();

            return e;
        }
    }
}
