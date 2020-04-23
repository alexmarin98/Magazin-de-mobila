using MagazinDeMobila.Builder;
using MagazinDeMobila.Furniture;
using MagazinDeMobila.Furniture.FurnitureFactory;
namespace MagazinDeMobila
{
    class Program
    {
        static void Main(string[] args)
        {

            //MaterialMix material = seller.GetResult();
            //material.Type = EMaterialMixType.EIron;

 //Convert builder result to IMaterialAccesory
            IMaterialAccesory materialAccesory = material;

            //Decorator
            IMaterialAccesory basic = new MaterialMix();
            basic.Assemble("black");
            IMaterialAccesory handle = new HandleDecorator(materialAccesory);
            handle.Assemble("red");
            IMaterialAccesory ex = new ExtendableDecorator(handle);
            ex.Assemble("black")            System.Console.WriteLine(basic.Price);
            System.Console.WriteLine(ex.Price);
            System.Console.WriteLine(handle.Price);

            var furitureSeller = new FurnitureSeller();
            var p1 = furitureSeller.OrderFurniture(3000,EFurnitureComplexity.Easy, EMaterialMixType.EIron, EFurnitureType.EBench);
            furitureSeller.ShowAvaibleProduct();

        }
    }
}