using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class TelevisionSet : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public TelevisionSet()
        {
            FurnitureType = EFurnitureType.ETelevisionSet;
        }
        public TelevisionSet(int id, double price, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}