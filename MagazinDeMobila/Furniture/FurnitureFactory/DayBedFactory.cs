using MagazinDeMobila.Builder;
using MagazinDeMobila.Furniture.FurnitureType;

namespace MagazinDeMobila.Furniture.FurnitureFactory
{
    public class DayBedFactory : FurnitureFactory
    {
        public override Furniture GetFurniture(double price, EFurnitureComplexity furnitureComplexity, MaterialMixBuilder materialMixBuilder, EFurnitureType furnitureType) 
            => new DayBed(LastId++, price, furnitureComplexity, materialMixBuilder, EFurnitureType.EBarChair);
    }
}