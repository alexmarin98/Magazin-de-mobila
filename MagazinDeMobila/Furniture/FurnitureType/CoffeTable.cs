using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class CoffeTable : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public CoffeTable()
        {
            FurnitureType = EFurnitureType.ECoffeTable;
        }
        public CoffeTable(int id, double price, EFurnitureComplexity furnitureComplexity, MaterialMixBuilder materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}