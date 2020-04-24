using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class BiliardTable : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public BiliardTable()
        {
            FurnitureType = EFurnitureType.EBiliardTable;
        }
        public BiliardTable(int id, double price, string name, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, name, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}