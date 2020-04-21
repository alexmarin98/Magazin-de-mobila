using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureFactory
{
    public abstract class FurnitureFactory
    {
        protected static int LastId = 0;
        public abstract Furniture GetFurniture(double price, EFurnitureComplexity furnitureComplexity, MaterialMixBuilder materialMixBuilder, EFurnitureType furnitureType);
    }
}