using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Builder
{
    class MaterialMix
    {
        public EMaterialMixType type;
        public double amount;
        public double price;

        public MaterialMix()
        {

        }

        public EMaterialMixType getMaterialMixType()
        {
            return this.type;
        }

        public void setMaterialMixType(EMaterialMixType type)
        {
            this.type = type;
        }

        public double getAmount()
        {
            return this.amount;
        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }
    }
}
