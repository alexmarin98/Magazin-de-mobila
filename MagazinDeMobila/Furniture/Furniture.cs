using MagazinDeMobila.Builder;

namespace MagazinDeMobila.Furniture
{
    public abstract class Furniture
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public EFurnitureComplexity FurnitureComplexity { get; set; }
        public MaterialMixBuilder MaterialMixBuilder { get; set; }
        public abstract EFurnitureType FurnitureType { get; set; }
        public Furniture()
        {
                
        }
        public Furniture(int id, double price, EFurnitureComplexity furnitureComplexity, MaterialMixBuilder materialMixBuilder)
        {
            Id = id;
            Price = price;
            FurnitureComplexity = furnitureComplexity;
            MaterialMixBuilder = materialMixBuilder;
        }
        public override string ToString()
        {
            return ("Id:" + Id + "Price:" + Price +
                    "   Type:" + FurnitureType +
                    "   Complexity:" + FurnitureComplexity +
                    "   Material:" + MaterialMixBuilder +
                    "   Type:" + FurnitureType);
        }
    }
}