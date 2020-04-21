using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class Bench : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public Bench()
        {
            FurnitureType = EFurnitureType.EBench;
        }
        public Bench(int id, double price, EFurnitureComplexity furnitureComplexity, MaterialMixBuilder materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}