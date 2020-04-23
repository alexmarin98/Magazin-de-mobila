using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class Chair : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public Chair()
        {
            FurnitureType = EFurnitureType.EChair;
        }
        public Chair(int id, double price, EFurnitureComplexity furnitureComplexity, EMaterialMixType materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}