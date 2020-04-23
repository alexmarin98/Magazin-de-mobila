using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class TelevisionSet : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public TelevisionSet()
        {
            FurnitureType = EFurnitureType.ETelevisionSet;
        }
        public TelevisionSet(int id, double price, EFurnitureComplexity furnitureComplexity, EMaterialMixType materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}