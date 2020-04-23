using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class Chesterfield : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public Chesterfield()
        {
            FurnitureType = EFurnitureType.EChesterField;
        }
        public Chesterfield(int id, double price, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}