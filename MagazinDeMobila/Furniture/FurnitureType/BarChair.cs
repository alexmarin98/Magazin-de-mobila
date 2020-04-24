using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class BarChair : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public BarChair()
        {
            FurnitureType = EFurnitureType.EBarChair;
        }
        public BarChair(int id, double price, string name, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price,name, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}