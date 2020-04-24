using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class Chair : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public Chair()
        {
            FurnitureType = EFurnitureType.EChair;
        }
        public Chair(int id, double price, string name, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, name, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}