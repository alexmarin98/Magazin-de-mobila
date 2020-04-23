using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class Bench : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public Bench()
        {
            FurnitureType = EFurnitureType.EBench;
        }
        public Bench(int id, double price, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}