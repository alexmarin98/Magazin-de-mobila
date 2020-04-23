using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class Couch : Furniture
    {
        public override EFurnitureType FurnitureType { get; set; }
        public Couch()
        {
            FurnitureType = EFurnitureType.ECouch;
        }
        public Couch(int id, double price, EFurnitureComplexity furnitureComplexity, EMaterialMixType materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}