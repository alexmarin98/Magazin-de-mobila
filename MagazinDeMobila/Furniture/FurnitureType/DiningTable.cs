using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class DiningTable : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public DiningTable()
        {
            FurnitureType = EFurnitureType.EDiningTable;
        }
        public DiningTable(int id, double price, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}