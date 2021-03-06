﻿using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Furniture.FurnitureType
{
    public class SofaBed : Furniture1
    {
        public override EFurnitureType FurnitureType { get; set; }
        public SofaBed()
        {
            FurnitureType = EFurnitureType.ESofaBed;
        }
        public SofaBed(int id, double price, string name, EFurnitureComplexity furnitureComplexity, IMaterialAccesory materialMixBuilder, EFurnitureType furnitureType) :
            base(id, price, name, furnitureComplexity, materialMixBuilder)
        {
            FurnitureType = furnitureType;
        }
    }
}