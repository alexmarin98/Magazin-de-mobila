using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.COR
{
    public class RequestPrice
    {
        private Seller Seller;
        private Local Local;
        private Importator Importator;

        public RequestPrice(Seller seller)
        {
            this.Seller = seller;
            this.Local = new Local();
            this.Importator = new Importator();

            seller.setSuccesor(Local);
            Local.setSuccesor(Importator);
        }

        public double GetProductPrice(string productName)
        {
            return Seller.GetProductPrise(productName);

        }
    }
}
