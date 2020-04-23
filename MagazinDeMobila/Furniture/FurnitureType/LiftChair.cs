using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class LiftChair : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public LiftChair()
        {
            FurnitureType = EFurnitureType.ELiftChair;
        }
        public LiftChair(int id, double price, EFurnitureComplexity furnitureComplexity, EMaterialMixType materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}