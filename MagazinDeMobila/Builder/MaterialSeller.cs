using System;

namespace MagazinDeMobila.Builder
{
    class MaterialSeller
    {
        private readonly IMaterialBuilder _builder;
        private static Double EWOOD_PRICE = 12.5;
        private static Double EGLASS_PRICE = 27.7;
        private static Double EIRON_PRICE = 18.5;

        public MaterialSeller(IMaterialBuilder builder, EMaterialMixType materialMixType)
        {
            _builder = builder;
            Construct(materialMixType);
        }

        public void Construct(EMaterialMixType materialMixType)
        {
            switch (materialMixType)
            {
                case EMaterialMixType.EWood:
                    _builder.SetPrice(EWOOD_PRICE);
                    break;
                case EMaterialMixType.EIron:
                    _builder.SetPrice(EIRON_PRICE);
                    break;
                case EMaterialMixType.EGlass:
                    _builder.SetPrice(EGLASS_PRICE);
                    break;
            }
            _builder.SetMaterialMixType(materialMixType);
            _builder.SetColor("none");
            _builder.SetAccesoryType(EAccesoryType.EBasic);
        }

        public MaterialMix GetResult()
        {
            MaterialMix materialMix = _builder.GetMaterialMix();
            return materialMix;
        }
    }
}