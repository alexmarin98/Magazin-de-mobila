using System;
using System.Collections.Generic;

namespace MagazinDeMobila.COR
{
    public class Importator : Owner
    {

        private Dictionary<String, double> ProductPrice { get; set; }

        public Importator()
        {
            this.ProductPrice = new Dictionary<String, Double>();
            AddProductPrice();
        }


        public override double GetProductPrise(string productName)
        {
            if (ProductPrice.ContainsKey(productName))
                return ProductPrice[productName];
            else return -1;
        }

        private void AddProductPrice()
        {
            ProductPrice.Add("bed", 230.0);
            ProductPrice.Add("door", 316.0);
        }

    }
}
