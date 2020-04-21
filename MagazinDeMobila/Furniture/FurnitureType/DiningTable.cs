using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class DiningTable : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public DiningTable()
        {
            FurnitureType = EFurnitureType.EDiningTable;
        }
        public DiningTable(int id, double price, EFurnitureComplexity furnitureComplexity, MaterialMixBuilder materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}