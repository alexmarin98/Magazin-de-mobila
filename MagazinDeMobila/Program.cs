using MagazinDeMobila.Builder;
using MagazinDeMobila.Decorator;
using MagazinDeMobila.Furniture;
using MagazinDeMobila.Furniture.FurnitureFactory;
using System;

namespace MagazinDeMobila
{
    class Program
    {
        static void Main(string[] args)
        {
            MaterialSeller seller = new MaterialSeller(new MaterialMixBuilder(), EMaterialMixType.EGlass);
            MaterialMix material = seller.GetResult();
            //material.Type = EMaterialMixType.EIron;

            //Convert builder result to IMaterialAccesory
            IMaterialAccesory materialAccesory = material;

            //Decorator
            IMaterialAccesory basic = new MaterialMix();
            basic.Assemble("black");
            IMaterialAccesory handle = new HandleDecorator(materialAccesory);
            handle.Assemble("red");
            IMaterialAccesory ex = new ExtendableDecorator(handle);
            ex.Assemble("black");
            Console.WriteLine(basic.Price);
            Console.WriteLine(ex.Price+ex.Color+ex.AccesoryType);
            Console.WriteLine(handle.Price);

            var furitureSeller = new FurnitureSeller();
            var p1 = furitureSeller.OrderFurniture(3000, EFurnitureComplexity.Easy, basic, EFurnitureType.EBench);
            furitureSeller.ShowAvaibleProduct();

        }
    }
}