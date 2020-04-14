using MagazinDeMobila.Builder;

namespace MagazinDeMobila
{
    class Program
    {
        static void Main(string[] args)
        {
            MaterialSeller seller = new MaterialSeller(new MaterialMixBuilder(), EMaterialMixType.EGlass);

            MaterialMix material = seller.GetResult();

            System.Console.WriteLine(material.getPrice());
        }
    }
}