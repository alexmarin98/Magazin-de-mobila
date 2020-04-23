using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class Couch : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public Couch()
        {
            FurnitureType = EFurnitureType.ECouch;
        }
        public Couch(int id, double price, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}