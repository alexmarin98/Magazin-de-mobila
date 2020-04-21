using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class BarChair : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public BarChair()
        {
            FurnitureType = EFurnitureType.EBarChair;
        }
        public BarChair(int id, double price, EFurnitureComplexity furnitureComplexity, MaterialMixBuilder materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}