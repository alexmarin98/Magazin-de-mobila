namespace MagazinDeMobila.Builder
{
    public interface IMaterialBuilder
    {
        double GetPrice(EMaterialMixType materialType);

        void SetPrice(double price);

        void SetAmount(double amount);

        void SetMaterialMixType(EMaterialMixType type);

        MaterialMix GetMaterialMix();
    }
}
