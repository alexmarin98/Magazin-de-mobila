using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class SofaBed : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public SofaBed()
        {
            FurnitureType = EFurnitureType.ESofaBed;
        }
        public SofaBed(int id, double price, EFurnitureComplexity furnitureComplexity, MaterialMixBuilder materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}