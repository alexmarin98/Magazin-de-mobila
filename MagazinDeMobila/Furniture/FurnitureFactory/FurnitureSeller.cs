using MagazinDeMobila.Builder;
using System;
using System.Collections.Generic;

namespace MagazinDeMobila.Furniture.FurnitureFactory
{
    public class FurnitureSeller
    {
        public Dictionary<int, Furniture> StoredFurniture { get; set; }
        public Dictionary<int, Furniture> OrderedFurniture { get; set; }

        public FurnitureSeller()
        {
            StoredFurniture = new Dictionary<int, Furniture>();
            OrderedFurniture = new Dictionary<int, Furniture>();
        }
        public int OrderFurniture(double price, EFurnitureComplexity furnitureComplexity, EMaterialMixType materialMixBuilder, EFurnitureType furnitureType)
        {
            Furniture furniture;
            FurnitureFactory furnitureFactory;
            switch (furnitureType)
            {
                case EFurnitureType.EBarChair:
                    {
                        furnitureFactory = new BarChairFactory();
                        break;
                    }
                case EFurnitureType.EBed:
                    {
                        furnitureFactory = new BedFactory();
                        break;
                    }
                case EFurnitureType.EBench:
                    {
                        furnitureFactory = new BenchFactory();
                        break;
                    }
                case EFurnitureType.EBiliardTable:
                    {
                        furnitureFactory = new BiliardTableFactory();
                        break;
                    }
                case EFurnitureType.EChair:
                    {
                        furnitureFactory = new ChairFactory();
                        break;
                    }
                case EFurnitureType.EChesterField:
                    {
                        furnitureFactory = new ChesterFieldFactory();
                        break;
                    }
                case EFurnitureType.ECoffeTable:
                    {
                        furnitureFactory = new CoffeTableFactory();
                        break;
                    }
                case EFurnitureType.ECouch:
                    {
                        furnitureFactory = new Couchfactory();
                        break;
                    }
                case EFurnitureType.EDayBed:
                    {
                        furnitureFactory = new DayBedFactory();
                        break;
                    }
                case EFurnitureType.EDiningTable:
                    {
                        furnitureFactory = new DiningTableFactory();
                        break;
                    }
                case EFurnitureType.ELiftChair:
                    {
                        furnitureFactory = new LiftChairFactory();
                        break;
                    }
                case EFurnitureType.ESofaBed:
                    {
                        furnitureFactory = new SofaBedFactory();
                        break;
                    }
                case EFurnitureType.ETelevisionSet:
                    {
                        furnitureFactory = new TelevisionSetFactory();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Unknown furniture type!");
                        return 0;
                    }
            }
            furniture = furnitureFactory.GetFurniture(price, furnitureComplexity, materialMixBuilder, furnitureType);
            OrderedFurniture.Add(furniture.Id, furniture);
            return furniture.Id;
        }

        public void SellFurniture(int furnitureId)
        {
            if (OrderedFurniture.ContainsKey(furnitureId))
            {
                OrderedFurniture.Remove(furnitureId);
            }
            else
            {
                Console.WriteLine("This product is not avaible in store right now");
            }
        }

        public void ShowAvaibleProduct()
        {
            foreach(var product in OrderedFurniture)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}