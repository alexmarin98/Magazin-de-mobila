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
        public Chesterfield(int id, double price, string name, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, name, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}