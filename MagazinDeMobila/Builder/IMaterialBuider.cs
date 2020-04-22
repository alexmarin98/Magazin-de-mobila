namespace MagazinDeMobila.Builder
{
    public interface IMaterialBuilder
    {
        double GetPrice(EMaterialMixType materialType);

        void SetPrice(double price);

        void SetColor(string color);

        void SetAccesoryType(EAccesoryType accesoryType);

        void SetMaterialMixType(EMaterialMixType type);

        MaterialMix GetMaterialMix();
    }
}
