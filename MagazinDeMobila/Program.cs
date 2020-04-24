using MagazinDeMobila.Builder;
using MagazinDeMobila.Decorator;
using MagazinDeMobila.Flyweight;
using MagazinDeMobila.Furniture;
using MagazinDeMobila.Furniture.FurnitureFactory;
using MagazinDeMobila.VendingMachine;
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
            Console.WriteLine(ex.Price + ex.Color + ex.AccesoryType);
            Console.WriteLine(handle.Price);

            var furitureSeller = new FurnitureSeller();
            var p1 = furitureSeller.OrderFurniture(3000, EFurnitureComplexity.Easy, basic, EFurnitureType.EBench);
             p1 = furitureSeller.OrderFurniture(3000, EFurnitureComplexity.Easy, basic, EFurnitureType.EBench);
            p1 = furitureSeller.OrderFurniture(3000, EFurnitureComplexity.Easy, basic, EFurnitureType.EBench);
            p1 = furitureSeller.OrderFurniture(3000, EFurnitureComplexity.Easy, basic, EFurnitureType.EBench);
             p1 = furitureSeller.OrderFurniture(3000, EFurnitureComplexity.Easy, basic, EFurnitureType.EBench);

            // furitureSeller.ShowAvaibleProduct();
            ClientMenu(furitureSeller);


        }
        public static void ClientMenu(FurnitureSeller furnitureSeller)
        {
            var vendingMachine = new VendingMachine1(furnitureSeller,new Cashier());
            State.Machine = vendingMachine;
            Console.WriteLine("1.InsertMoney");
            Console.WriteLine("2.RedrawMoney");
            Console.WriteLine("3.Buy Product");
            Console.WriteLine("4.Inspect Stock");
            Console.WriteLine("4.See your money ammount");
            Console.WriteLine("6.Exit Store");
            var choice = -1;
            while (!choice.Equals(6))
            {
                try
                {
                    Console.WriteLine("Insert your option...");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                var value = 0;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How much do you want to add to your account!");
                        value = Convert.ToInt32(Console.ReadLine());
                        vendingMachine.UpdateState(EClientOption.InsertMoney, value, int.MaxValue,EMoneyType.Card);
                        break;
                    case 2:
                        Console.WriteLine("How much do you want to redraw?");
                        value = Convert.ToInt32(Console.ReadLine());
                        vendingMachine.UpdateState(EClientOption.RetractMoney, value, int.MaxValue, EMoneyType.Card);
                        break;
                    case 3:
                        Console.WriteLine("Choose your product Id");
                        value = Convert.ToInt32(Console.ReadLine());
                        vendingMachine.UpdateState(EClientOption.BuyProduct,value,value, EMoneyType.Card);
                        break;
                    case 4:
                        vendingMachine.UpdateState(EClientOption.InspectStock,value,value, EMoneyType.Card);
                        break;
                    case 5:
                        vendingMachine.UpdateState(EClientOption.SeeMoneyAmmount, value, value, EMoneyType.Card);
                        break;
                    case 6:
                        break;
                }
            }
        }
    }
}
