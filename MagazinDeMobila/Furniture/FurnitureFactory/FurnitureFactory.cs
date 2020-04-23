using MagazinDeMobila.Builder;
using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureFactory
{
    public abstract class FurnitureFactory
    {
        protected static int LastId = 0;
        public abstract Furniture1 GetFurniture(double price, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType);
    }
}