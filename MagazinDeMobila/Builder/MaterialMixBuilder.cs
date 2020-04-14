using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Builder
{
    class MaterialMixBuilder : IMaterialBuilder
    {
        public MaterialMix materialMix;

        public MaterialMixBuilder()
        {
            materialMix = new MaterialMix();
        }

        public void SetMaterialMixType(EMaterialMixType type)
        {
            materialMix.type = type;
        }

        public void SetPrice(double price)
        {
            materialMix.setPrice(price);
        }

        public void SetAmount(double amount)
        {
            materialMix.amount = amount;
        }

        public MaterialMix GetMaterialMix()
        {
            return materialMix;
        }

        public double GetPrice(EMaterialMixType materialType)
        {
            return materialMix.price;
        }
    }
}
