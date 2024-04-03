using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak07
{
    public class Costumer
    {
        private List<string> shoppingList = new();
        private List<Item> shoppingCart = new();

        public Costumer(List<string> shoppingList) 
        {
            this.shoppingList = shoppingList;
            shoppingCart = new List<Item>();
        }

        public void Buy(Shop s)
        {
            bool l;
            Item? term;
            foreach (string name in shoppingList)
            {
                (l, term) = Search(name, s.food);
                if (l)
                {
                    Take(term, s.food);
                    shoppingList.Remove(name);
                }
            }

            foreach (string name in shoppingList)
            {
                (l, term) = SearchCheap(name, s.electronics);

                if (l)
                {
                    Take(term, s.electronics);
                    shoppingList.Remove(name);
                }
            }
        }

        private (bool, Item?) Search(string name, Department r) 
        {
            foreach(Item item in r.supply)
            {
                if(name == item.getName())
                {
                    return (true, item);
                }
            }
            return (false, null);
        }

        private (bool, Item?) SearchCheap(string name, Department r)
        {
            Item foundItem = null;
            int minPrice;
            bool foundCheap = false;
            foreach(Item item in r.supply)
            {
                if(name == item.getName() && !foundCheap) 
                {
                    foundItem = item;
                    minPrice = item.getPrice();
                    foundCheap = true;
                }
                else if (name == item.getName())
                {
                    if(item.getPrice() > foundItem?.getPrice())
                    {
                        foundItem = item;
                        minPrice = item.getPrice();
                    }
                }
            }
            return (foundCheap, foundItem);
        }

        private void Take(Item? term, Department r)
        {
            r.supply.Remove(term);
            shoppingCart.Add(term);
        }
    }
}
