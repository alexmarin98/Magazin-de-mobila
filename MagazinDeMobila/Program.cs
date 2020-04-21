using MagazinDeMobila.Builder;

namespace MagazinDeMobila
{
    class Program
    {
        static void Main(string[] args)
        {
            MaterialSeller seller = new MaterialSeller(new MaterialMixBuilder(), EMaterialMixType.EGlass);

            MaterialMix material = seller.GetResult();
            material.Type = EMaterialMixType.EIron;

            System.Console.WriteLine(material.Price);
        }
    }
}