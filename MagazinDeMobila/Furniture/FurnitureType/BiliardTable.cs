using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class BiliardTable : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public BiliardTable()
        {
            FurnitureType = EFurnitureType.EBiliardTable;
        }
        public BiliardTable(int id, double price, EFurnitureComplexity furnitureComplexity, EMaterialMixType materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}