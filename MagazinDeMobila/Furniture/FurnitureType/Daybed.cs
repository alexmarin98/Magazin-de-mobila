using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class DayBed : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public DayBed()
        {
            FurnitureType = EFurnitureType.EDayBed;
        }
        public DayBed(int id, double price, EFurnitureComplexity furnitureComplexity, MaterialMixBuilder materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}