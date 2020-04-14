using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MagazinDeMobila.Builder
{
    class MaterialSeller
    {
        private IMaterialBuilder builder;
        private static Double EWOOD_PRICE = 12.5;
        private static Double EGLASS_PRICE = 27.7;
        private static Double EIRON_PRICE = 18.5;

        public MaterialSeller(IMaterialBuilder builder, EMaterialMixType materialMixType)
        {
            this.builder = builder;
            Construct(materialMixType);
        }

        public void Construct(EMaterialMixType materialMixType)
        {
            switch (materialMixType)
            {
                case EMaterialMixType.EWood:
                    builder.SetPrice(EWOOD_PRICE);
                    break;
                case EMaterialMixType.EIron:
                    builder.SetPrice(EIRON_PRICE);
                    break;
                case EMaterialMixType.EGlass:
                    builder.SetPrice(EGLASS_PRICE);
                    break;
            }
            builder.SetMaterialMixType(materialMixType);
            builder.SetAmount(100);
        }

        public MaterialMix GetResult()
        {
            MaterialMix materialMix = builder.GetMaterialMix();

            return materialMix;
        }
    }
}
