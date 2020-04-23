using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class LiftChair : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public LiftChair()
        {
            FurnitureType = EFurnitureType.ELiftChair;
        }
        public LiftChair(int id, double price, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}