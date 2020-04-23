using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class DayBed : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public DayBed()
        {
            FurnitureType = EFurnitureType.EDayBed;
        }
        public DayBed(int id, double price, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}