using MagazinDeMobila.Builder;
using MagazinDeMobila.COR;
using MagazinDeMobila.Decorator;
using MagazinDeMobila.Facade;
using MagazinDeMobila.Flyweight;
using MagazinDeMobila.Furniture;
using MagazinDeMobila.Furniture.FurnitureFactory;
using MagazinDeMobila.VendingMachine;
using System;

namespace MagazinDeMobila
{
    class Program
    {
        public static EMaterialMixType GetMaterialType()
        {
            Console.WriteLine("1. Wood");
            Console.WriteLine("2. Glass");
            Console.WriteLine("3. Iron");
            int option = -1;
            while (option != 0)
            {
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option < 1 || option > 3)
                    {
                        option = 0;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Choose a number between 1 and 3!");
                }

                switch (option)
                {
                    case 1:
                        return EMaterialMixType.EWood;
                    case 2:
                        return EMaterialMixType.EGlass;
                    case 3:
                        return EMaterialMixType.EIron;

                    default:
                        Console.WriteLine("Choose a number between 1 and 3!");
                        break;
                }
            }
            return EMaterialMixType.EWood;
        }
        private static EFurnitureType GetFurnitureType(string name)
        {
            switch (name)
            {
                case "Chair":
                    return EFurnitureType.EChair;
                case "Lift chair":
                    return EFurnitureType.ELiftChair;
                case "Bar chair":
                    return EFurnitureType.EBarChair;
                case "Couch":
                    return EFurnitureType.ECouch;
                case "Bench":
                    return EFurnitureType.EBench;
                case "Chesterfield":
                    return EFurnitureType.EChesterField;
                case "Bed":
                    return EFurnitureType.EBed;
                case "Day bed":
                    return EFurnitureType.EDayBed;
                case "Sofa bed":
                    return EFurnitureType.ESofaBed;
                case "Biliard table":
                    return EFurnitureType.EBiliardTable;
                case "Television set":
                    return EFurnitureType.ETelevisionSet;
                case "Dining table":
                    return EFurnitureType.EDiningTable;
            }
            Console.Write("Introduced name is wrong!");
            return EFurnitureType.ENone;
        }

        static void Main(string[] args)
        {

            FurnitureSeller furnitureSeller = new FurnitureSeller();
            var p1 = furnitureSeller.OrderFurniture(250, "Chair", EFurnitureComplexity.Medium, new MaterialMix(), EFurnitureType.EChair);
            var p2 = furnitureSeller.OrderFurniture(200, "Bar chair", EFurnitureComplexity.Medium, new MaterialMix(), EFurnitureType.EBarChair);
            var p3 = furnitureSeller.OrderFurniture(800, "Sofa bed", EFurnitureComplexity.Easy, new MaterialMix(), EFurnitureType.ESofaBed);
            var p4 = furnitureSeller.OrderFurniture(700, "Bed", EFurnitureComplexity.Easy, new MaterialMix(), EFurnitureType.EBed);
            var p5 = furnitureSeller.OrderFurniture(550, "Bench", EFurnitureComplexity.Easy, new MaterialMix(), EFurnitureType.EBench);
            var p6 = furnitureSeller.OrderFurniture(900, "Television set", EFurnitureComplexity.Medium, new MaterialMix(), EFurnitureType.ETelevisionSet);
            var p7 = furnitureSeller.OrderFurniture(1000, "Billiard table", EFurnitureComplexity.Hard, new MaterialMix(), EFurnitureType.EBiliardTable);
            var p8 = furnitureSeller.OrderFurniture(1000, "Coffe table", EFurnitureComplexity.Medium, new MaterialMix(), EFurnitureType.ECoffeTable);
            var vendingMachine = new VendingMachine1(furnitureSeller, new Cashier());
            Transaction transaction = new Transaction();
            State.Machine = vendingMachine;
            int option = -1;
            while (option != 0)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Client");
                Console.WriteLine("2. Seller");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option < 1 || option > 2)
                    {
                        option = 0;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Choose a correct input");
                }
                switch (option)
                {
                    case 1:
                        {
                            ClientMenu(furnitureSeller, vendingMachine);
                            break;
                        }
                    case 2:
                        {
                            SellerMenu(transaction);
                            break;
                        }
                    default: break;
                }
            }

        }

        private static void SellerMenu(Transaction transaction)
        {
            int option = -1;
            while (option != 0)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Redraw Money");
                Console.WriteLine("2. See your money");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    if (option < 1 || option > 2)
                    {
                        option = 0;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Choose a number between 1 and 3!");
                }
                switch (option)
                {
                    case 1:
                        {
                            var sum = 0;
                            Console.WriteLine("What sum do you want to redraw?");
                            try
                            {
                                sum = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Choose a valid number");
                            }
                            transaction.RedrawMoney(sum);
                            break;
                        }
                    case 2:
                        {
                            transaction.GetSoldMoney();
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        private static void ClientMenu(FurnitureSeller furnitureSeller, VendingMachine1 vendingMachine)
        {
            int option = -1;
            while (option != 0)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Decorate");
                Console.WriteLine("3. Check a product");
                Console.WriteLine("4. Buy");
                Console.WriteLine("5. Insert Money");
                Console.WriteLine("6. Redraw Money");
                Console.WriteLine("7. Inspect stock");
                Console.WriteLine("8. See your money ammount");

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                switch (option)
                {
                    case 1:


                        EMaterialMixType materialMixType = GetMaterialType();
                        MaterialSeller createSeller = new MaterialSeller(new MaterialMixBuilder(), materialMixType);
                        MaterialMix createdMaterial = createSeller.GetResult();
                        string name;
                        EFurnitureType furnitureType;
                        do
                        {
                            Console.WriteLine("Chair");
                            Console.WriteLine("Lift chair");
                            Console.WriteLine("Bar chair");
                            Console.WriteLine("Bench");
                            Console.WriteLine("Couch");
                            Console.WriteLine("Chesterfield");
                            Console.WriteLine("Bed");
                            Console.WriteLine("Day bed");
                            Console.WriteLine("Sofa bed");
                            Console.WriteLine("Biliard table");
                            Console.WriteLine("Television set");
                            Console.WriteLine("Coffe table");
                            Console.WriteLine("Dining table");
                            Console.WriteLine();
                            Console.WriteLine("Introduce the name of the product:");
                            name = Console.ReadLine();
                            furnitureType = GetFurnitureType(name);
                        } while (furnitureType == EFurnitureType.ENone);


                        furnitureSeller.OrderFurniture(createdMaterial.Price, name, EFurnitureComplexity.Easy, new MaterialMix(), furnitureType);
                        break;

                    case 2:
                        materialMixType = GetMaterialType();
                        createSeller = new MaterialSeller(new MaterialMixBuilder(), materialMixType);
                        createdMaterial = createSeller.GetResult();
                        IMaterialAccesory materialAccesory = createdMaterial;

                        do
                        {
                            Console.WriteLine("Chair");
                            Console.WriteLine("Lift chair");
                            Console.WriteLine("Bar chair");
                            Console.WriteLine("Bench");
                            Console.WriteLine("Couch");
                            Console.WriteLine("Chesterfield");
                            Console.WriteLine("Bed");
                            Console.WriteLine("Day bed");
                            Console.WriteLine("Sofa bed");
                            Console.WriteLine("Biliard table");
                            Console.WriteLine("Television set");
                            Console.WriteLine("Coffe table");
                            Console.WriteLine("Dining table");
                            Console.WriteLine();
                            Console.WriteLine("Introduce the name of the product:");
                            name = Console.ReadLine();
                            furnitureType = GetFurnitureType(name);
                        } while (furnitureType == EFurnitureType.ENone);

                        Console.WriteLine("1. Extendable");
                        Console.WriteLine("2. Handle");
                        Console.WriteLine("3. Height adjusted");
                        Console.WriteLine("4. Upholstered");

                        var op = 0;
                        do
                        {
                            try
                            {
                                Console.WriteLine("Choose a number.");
                                op = Convert.ToInt32(Console.ReadLine());
                                if (op < 1 || op > 4)
                                {
                                    op = 0;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Choose a number between 1 and 4!");
                            }

                        } while (op == 0);

                        switch (op)
                        {
                            case 1:
                                materialAccesory = new ExtendableDecorator(materialAccesory);
                                break;
                            case 2:
                                materialAccesory = new HandleDecorator(materialAccesory);
                                break;
                            case 3:
                                materialAccesory = new HeightAdjustedDecorator(materialAccesory);
                                break;
                            case 4:
                                materialAccesory = new UpholsteredDecorator(materialAccesory);
                                break;
                        }

                        //Console.WriteLine("What color do you want?");
                        //string color = Console.ReadLine();
                        materialAccesory.Assemble();
                        


                        furnitureSeller.OrderFurniture(materialAccesory.Price, name, EFurnitureComplexity.Hard, new MaterialMix(), furnitureType);
                        break;

                    case 3:
                        Seller my_seller = new Seller(furnitureSeller);
                        RequestPrice request = new RequestPrice(my_seller);
                        Console.WriteLine("Introduce the name of the product you want to check:");
                        string product = Console.ReadLine();
                        double price = request.GetProductPrice(product);
                        if (price == -1)
                            Console.Write("Can't find this product.");
                        else
                            Console.WriteLine("We found your product.It's price is: " + price);
                        break;
                    case 4:
                        Console.WriteLine("Choose your product Id");
                        int value = Convert.ToInt32(Console.ReadLine());
                        vendingMachine.UpdateState(EClientOption.BuyProduct, value, value, EMoneyType.Card);
                        break;
                    case 5:
                        Console.WriteLine("How much do you want to add to your account?");
                        value = Convert.ToInt32(Console.ReadLine());
                        vendingMachine.UpdateState(EClientOption.InsertMoney, value, int.MaxValue, EMoneyType.Card);
                        break;
                    case 6:
                        Console.WriteLine("How much do you want to redraw?");
                        value = Convert.ToInt32(Console.ReadLine());
                        vendingMachine.UpdateState(EClientOption.RetractMoney, value, int.MaxValue, EMoneyType.Card);
                        break;
                    case 7:
                        vendingMachine.UpdateState(EClientOption.InspectStock, double.NaN, int.MaxValue, EMoneyType.Card);
                        break;
                    case 8:
                        vendingMachine.UpdateState(EClientOption.SeeMoneyAmmount, int.MaxValue, int.MaxValue, EMoneyType.Card);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}