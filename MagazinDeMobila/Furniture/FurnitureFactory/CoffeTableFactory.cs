﻿using MagazinDeMobila.Decorator;
using MagazinDeMobila.Furniture.FurnitureType;

namespace MagazinDeMobila.Furniture.FurnitureFactory
{
    public class CoffeTableFactory : FurnitureFactory
    {
        public override Furniture1 GetFurniture(double price, string name, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType)
            => new CoffeTable(LastId++, price, name, furnitureComplexity, materialMixBuilder, EFurnitureType.EBarChair);
    }
}