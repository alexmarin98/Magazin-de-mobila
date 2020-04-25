using System;
using System.Collections.Generic;

namespace MagazinDeMobila.COR
{
    public class Local : Owner
    {

        private Dictionary<String, double> ProductPrice { get; set; }

        public Local()
        {
            this.ProductPrice = new Dictionary<String, Double>();
            AddProductPrice();
        }


        public override double GetProductPrise(string productName)
        {
            if (ProductPrice.ContainsKey(productName))
                return ProductPrice[productName];
            if (this.succesor != null)
                return succesor.GetProductPrise(productName);
            return -1;
        }

        private void AddProductPrice()
        {
            ProductPrice.Add("desk", 230.0);
            ProductPrice.Add("window", 316.0);
        }

    }
}
