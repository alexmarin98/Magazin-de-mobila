using MagazinDeMobila.Builder;
using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture
{
    public abstract class Furniture1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public EFurnitureComplexity FurnitureComplexity { get; set; }
        public IMaterialAccesory MaterialAccesory { get; set; }
        public abstract EFurnitureType FurnitureType { get; set; }
        public Furniture1()
        {
                
        }
        public Furniture1(int id,  double price, string name, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialAccesory)
        {
            Id = id;
            Name = name;
            Price = price;
            FurnitureComplexity = furnitureComplexity;
            MaterialAccesory = materialAccesory;
        }
        public override string ToString()
        {
            return ("Id: " + Id +
                    "   Name: "+Name  +
                    "   Price: " + Price +
                    "   Type: " + FurnitureType +
                    "   Complexity: " + FurnitureComplexity +
                    "   Color: " + MaterialAccesory.Color );
        }
    }
}