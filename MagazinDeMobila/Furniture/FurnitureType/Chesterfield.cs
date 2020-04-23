using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class Chesterfield : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public Chesterfield()
        {
            FurnitureType = EFurnitureType.EChesterField;
        }
        public Chesterfield(int id, double price, EFurnitureComplexity furnitureComplexity, EMaterialMixType materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}