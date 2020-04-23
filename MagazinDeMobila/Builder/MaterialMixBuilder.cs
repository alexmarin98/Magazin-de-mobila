namespace MagazinDeMobila.Builder
{
    public class MaterialMixBuilder : IMaterialBuilder
    {
        public MaterialMix materialMix;

        public MaterialMixBuilder()
        {
            materialMix = new MaterialMix();
        }

        public void SetMaterialMixType(EMaterialMixType type)
        {
            materialMix.Type = type;
        }

        public void SetPrice(double price)
        {
            materialMix.Price=price;
        }

        public void SetColor(string color)
        {
            materialMix.Color = color;
        }

        public void SetAccesoryType(EAccesoryType accesoryType)
        {
            materialMix.AccesoryType = accesoryType;
        }

        public MaterialMix GetMaterialMix()
        {
            return materialMix;
        }

        public double GetPrice(EMaterialMixType materialType)
        {
            return materialMix.Price;
        }
    }
}
