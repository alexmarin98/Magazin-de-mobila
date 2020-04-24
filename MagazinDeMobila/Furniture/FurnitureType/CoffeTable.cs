using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class CoffeTable : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public CoffeTable()
        {
            FurnitureType = EFurnitureType.ECoffeTable;
        }
        public CoffeTable(int id, double price, string name, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, name, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}