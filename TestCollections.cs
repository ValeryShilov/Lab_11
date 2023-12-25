using Lab_10_lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    public class TestCollections
    {
        private int count = 0;
        public LinkedList<Goods> listGoods = new();
        public LinkedList<string> listStrings = new();
        public Dictionary<Goods, Product> dictGP = new();
        public Dictionary<string, Product> dictSP = new();

        public int Count { get { return count; } }

        public TestCollections(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var product = new Product();
                product.RandomInit();
                while (listGoods.Contains(product.BaseGoods))
                {
                    product.RandomInit();
                }
                
                listStrings.AddLast(product.ToString());
                listGoods.AddLast(product.BaseGoods);
                
                dictSP.Add(product.ToString(), product);
                dictGP.Add(product.BaseGoods, product);
                this.count++;
            }
        }

        public bool Add(Product product)
        {
            if (listGoods.Contains(product.BaseGoods))
                return false;

            listGoods.AddLast(product.BaseGoods);
            listStrings.AddLast(product.ToString());
            dictGP.Add(product.BaseGoods, product);
            dictSP.Add(product.ToString(), product);
            this.count++;
            return true;
        }

        public bool RemoveElem(Product product)
        {
            if (!listGoods.Contains(product.BaseGoods))
                return false;

            listGoods.Remove(product.BaseGoods);
            listStrings.Remove(product.ToString());
            dictGP.Remove(product.BaseGoods);
            dictSP.Remove(product.ToString());
            this.count++;
            return true;
        }
    }
}
