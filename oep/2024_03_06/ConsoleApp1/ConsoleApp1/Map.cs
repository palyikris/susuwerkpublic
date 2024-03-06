using System.Collections.Generic;

namespace ConsoleApp1
{
    public struct Item
    {
        public int Key;
        public string Data;
    }

    public struct Item2 { 
        public bool Bool;
        public int Value; 
    }

    internal class Map
    {
        private List<Item> seq = new();

        //public Map(List<Item> item) {
        //    this.seq = item;
        //}

        private Item2 LogSearch(int key)
        {
            bool I = false;
            int ah = 1;
            int fh = seq.Count;
            int ind = (ah + fh) / 2;


            while (!I && ah < fh) 
            {

                if (seq[ind].Key > key)
                {
                    fh = ind - 1;
                }
                else if (seq[ind].Key == key)
                {
                    I = true;
                }
                else if (seq[ind].Key < key)
                {
                    ah = ind + 1;
                }

            }
            if (!I)
            {
                ind = ah;
            }

            Item2 result = new Item2();
            result.Bool = I;
            result.Value = ind;
            return result;
        }

        public void SetEmpty()
        {
            seq.Clear();
        }

        public int Count()
        {
            return seq.Count;
        }

        public void Insert(Item item)
        {
            Item2 LSResult = new Item2();
            LSResult = LogSearch(item.Key);

            if (LSResult.Bool)
            {
                throw new Exception("Error during Insertion!");
            }

            seq.Insert(LSResult.Value, item);
        }

        public void Remove(int key)
        {
            Item2 LSResult = new();
            LSResult = LogSearch(key);
            if (!LSResult.Bool)
            {
                throw new Exception("Error during Removal!");
            }

            int ind = LSResult.Value;
            seq.RemoveAt(ind);
        }

        public bool In(int key)
        {
            Item2 LSResult = new();
            LSResult = LogSearch(key);

            return LSResult.Bool;
        }





    }

}
