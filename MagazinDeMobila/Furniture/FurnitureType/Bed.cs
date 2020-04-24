using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class Bed : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public Bed()
        {
            FurnitureType = EFurnitureType.EBed;
        }
        public Bed(int id, double price, string name, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, name, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}