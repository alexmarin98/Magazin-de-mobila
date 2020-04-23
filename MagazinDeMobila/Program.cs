using MagazinDeMobila.Builder;
using MagazinDeMobila.Furniture;
using MagazinDeMobila.Furniture.FurnitureFactory;

namespace MagazinDeMobila
{
    class Program
    {
        static void Main(string[] args)
        {
            //MaterialSeller seller = new MaterialSeller(new MaterialMixBuilder(), EMaterialMixType.EGlass);

            //MaterialMix material = seller.GetResult();
            //material.Type = EMaterialMixType.EIron;

            //System.Console.WriteLine(material.Price);
            var furitureSeller = new FurnitureSeller();
            var p1 = furitureSeller.OrderFurniture(3000,EFurnitureComplexity.Easy, EMaterialMixType.EIron, EFurnitureType.EBench);
            furitureSeller.ShowAvaibleProduct();
        }
    }
}