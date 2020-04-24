using MagazinDeMobila.Builder;
using MagazinDeMobila.Decorator;
using MagazinDeMobila.Furniture.FurnitureType;

namespace MagazinDeMobila.Furniture.FurnitureFactory
{
    public class BiliardTableFactory : FurnitureFactory
    {
        public override Furniture1 GetFurniture(double price,string name, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType)
            => new BiliardTable(LastId++, price, name, furnitureComplexity, materialMixBuilder, EFurnitureType.EBarChair);
    }
}