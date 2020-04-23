using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class Bed : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public Bed()
        {
            FurnitureType = EFurnitureType.EBed;
        }
        public Bed(int id, double price, EFurnitureComplexity furnitureComplexity, EMaterialMixType materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}