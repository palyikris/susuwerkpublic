

namespace HF4
{

    public struct Element
    {
        public int pr;
        public string data;
    }
    internal class PrQueue
    {
        private List<Element> seq = new List<Element>();


        public void SetEmpty()
        {
            seq.Clear();
        }

        public bool isEmpty()
        {
            return seq.Count == 0;
        }

        public void Add(Element e)
        {
            seq.Add(e);
        }

        private (int, int) MaxSelect()
        {
            if (seq.Count == 0)
            {
                throw new Exception("Hiba!");
            }

            int maxind = 0;
            int maxert = 0;

            for (int i = 0; i < seq.Count; i++)
            {
                if (seq[i].pr > maxert)
                {
                    maxind = i;
                    maxert = seq[i].pr;
                }
            }

            return (maxert, maxind);
        }

        public Element GetMax()
        {
            if(seq.Count == 0)
            {
                throw new Exception("Error!");
            }

            (int maxert, int maxind) = MaxSelect();

            return seq[maxind];
            
        }

        private void pop_back()
        {
            if (seq.Count == 0)
            {
                throw new Exception("Hiba!");
            }

            Element max = GetMax();

            seq.Remove(max);
        }
        public Element RemMax()
        {
            if (seq.Count == 0)
            {
                throw new Exception("Error!");
            }

            (int maxert, int maxind) = MaxSelect();
            

            Element e = seq[maxind];

            pop_back();

            return e;
        }
    }
}
