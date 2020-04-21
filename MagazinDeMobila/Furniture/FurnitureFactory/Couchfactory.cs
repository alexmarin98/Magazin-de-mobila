using MagazinDeMobila.Builder;
using MagazinDeMobila.Furniture.FurnitureType;

namespace MagazinDeMobila.Furniture.FurnitureFactory
{
    class Couchfactory : FurnitureFactory
    {
        public override Furniture GetFurniture(double price, EFurnitureComplexity furnitureComplexity, MaterialMixBuilder materialMixBuilder, EFurnitureType furnitureType) 
            => new Couch(LastId++, price, furnitureComplexity, materialMixBuilder, EFurnitureType.EBarChair);
    }
}