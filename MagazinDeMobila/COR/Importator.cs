﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.COR
{
    public class Importator : Owner
    {

        private Dictionary<String, double> ProductPrice { get; set; }

        public Importator()
        {
            this.ProductPrice = new Dictionary<String, Double>();
            addProductPrice();
        }


        public override double GetProductPrise(string productName)
        {
            if (ProductPrice.ContainsKey(productName))
                return ProductPrice[productName];
            else return -1;
        }

        private void addProductPrice()
        {
            ProductPrice.Add("bed", 230.0);
            ProductPrice.Add("door", 316.0);
        }

    }
}
