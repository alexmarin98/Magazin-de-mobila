using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Decorator
{
    public interface IMaterialAccesory
    {
        EMaterialMixType Type { get; set; }
        EAccesoryType AccesoryType { get; set; }
        string Color { get; set; }
        double Price { get; set; }

        void Assemble(string color);
        void SetPrice();

    }
}
