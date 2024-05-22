using GroceryStoreClassLibrary.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreClassLibrary
{
    public class ProductCountingClass
    {
        GSEntities storeEntities = new GSEntities();

        public double ProductPriceCounting()
        {
                double sum = 0;
                var list = new List<double?>();
                list = storeEntities.ComposeOfCheck.Select(k => k.fullPrice).ToList();
                foreach (double summ in list)
                {
                    sum += summ;
                }
                return sum;
        }

        public double? ProductDiscountCounting(int? price, double? discount)
        {
 
            var disc = price * discount;
            var pr = price - disc;
           
            return pr;
        }

        public double? ProductNoDiscountCounting()
        {
            double? priceNoDisc = 0;
            var list = new List<int?>();
            var list2 = new List<int?>();
            list = storeEntities.ComposeOfCheck.Select(k =>k.price).ToList();
            list2 = storeEntities.ComposeOfCheck.Select(k =>k.count).ToList();
            for(int i = 0; i < list.Count; i++)
            {
                priceNoDisc += list[i] * list2[i];
            }
            
            return priceNoDisc;
        }
    }
}
