using MagazinDeMobila.Builder;
using MagazinDeMobila.Decorator;

namespace MagazinDeMobila
{
    class Program
    {
        static void Main(string[] args)
        {
            //Builder
            MaterialSeller seller = new MaterialSeller(new MaterialMixBuilder(), EMaterialMixType.EGlass);

            MaterialMix material = seller.GetResult();
            material.Type = EMaterialMixType.EIron;


            //Convert builder result to IMaterialAccesory
            IMaterialAccesory materialAccesory = material;

            //Decorator
            IMaterialAccesory basic = new MaterialMix();
            basic.Assemble("black");
            IMaterialAccesory handle = new HandleDecorator(materialAccesory);
            handle.Assemble("red");
            IMaterialAccesory ex = new ExtendableDecorator(handle);
            ex.Assemble("black");

            System.Console.WriteLine(material.Price);
            System.Console.WriteLine(basic.Price);
            System.Console.WriteLine(ex.Price);
            System.Console.WriteLine(handle.Price);
        }
    }
}