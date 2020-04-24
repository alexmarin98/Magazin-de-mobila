using MagazinDeMobila.Builder;
using MagazinDeMobila.COR;
using MagazinDeMobila.Decorator;
using MagazinDeMobila.Furniture;
using MagazinDeMobila.Furniture.FurnitureFactory;
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
                catch (Exception e)
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
                case "chair":
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
            var p1 = furnitureSeller.OrderFurniture(3001, "chair", EFurnitureComplexity.Easy, new MaterialMix(), EFurnitureType.EBench);
            var p2 = furnitureSeller.OrderFurniture(3000,"barChair", EFurnitureComplexity.Easy, new MaterialMix(), EFurnitureType.EBench);
            var p3 = furnitureSeller.OrderFurniture(3000,"sofaBed", EFurnitureComplexity.Easy, new MaterialMix(), EFurnitureType.EBench);



            int option = -1;
            while (option != 0)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Decorate");
                Console.WriteLine("3. Buy");

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


                        Console.WriteLine("1. Extendable");
                        Console.WriteLine("2. Handle");
                        Console.WriteLine("3. Height adjusted");
                        Console.WriteLine("4. Upholstered");

                        int op = 0;
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
                            catch (Exception e)
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

                        Console.WriteLine("What color do you want?");
                        string color = Console.ReadLine();
                        materialAccesory.Assemble(color);



                        do
                        {
                            Console.WriteLine("Introduce the name of the product:");
                            name = Console.ReadLine();
                            furnitureType = GetFurnitureType(name);
                        } while (furnitureType == EFurnitureType.ENone);


                        furnitureSeller.OrderFurniture(materialAccesory.Price, name, EFurnitureComplexity.Easy, new MaterialMix(), furnitureType);
                        break;

                    case 3:
                        Seller my_seller = new Seller(furnitureSeller);
                        RequestPrice request = new RequestPrice(my_seller);
                        Console.WriteLine("What product do you want?");
                        string product = Console.ReadLine();
                        double price = request.GetProductPrice(product);
                        if (price == -1)
                            Console.Write("This product doesn't exist.");
                        else
                            Console.WriteLine(price);
                        break;

                    default:
                        break;
                }
            }




            //MaterialSeller seller = new MaterialSeller(new MaterialMixBuilder(), EMaterialMixType.EGlass);
            //MaterialMix material = seller.GetResult();
            ////material.Type = EMaterialMixType.EIron;

            ////Convert builder result to IMaterialAccesory
            //IMaterialAccesory materialAccesory = material;

            ////Decorator
            //IMaterialAccesory basic = new MaterialMix();
            //basic.Assemble("black");
            //IMaterialAccesory handle = new HandleDecorator(materialAccesory);
            //handle.Assemble("red");
            //IMaterialAccesory ex = new ExtendableDecorator(handle);
            //ex.Assemble("black");
            //Console.WriteLine(basic.Price);
            //Console.WriteLine(ex.Price+ex.Color+ex.AccesoryType);
            //Console.WriteLine(handle.Price);


            

            //furnitureSeller.ShowAvaibleProduct();

            //Seller my_seller = new Seller(furnitureSeller);
            //RequestPrice request = new RequestPrice(my_seller);
            //double price = request.GetProductPrice("door34");
            //Console.WriteLine(price);

        }
    }
}