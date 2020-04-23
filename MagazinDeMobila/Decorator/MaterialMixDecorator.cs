using MagazinDeMobila.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Decorator
{
    abstract class MaterialMixDecorator : IMaterialAccesory
    {
        protected IMaterialAccesory DecoratedMaterial { get; set; }
        public EMaterialMixType Type { get; set; }
        public EAccesoryType AccesoryType { get; set; }
        public string Color { get; set; }
        //  public double Amount { get; set; }
        public double Price { get; set; }

        public MaterialMixDecorator(IMaterialAccesory materialAccesory)
        {
            DecoratedMaterial = new MaterialMix();
            DecoratedMaterial.Type = materialAccesory.Type;
            DecoratedMaterial.AccesoryType = materialAccesory.AccesoryType;
            DecoratedMaterial.Color = materialAccesory.Color;
            DecoratedMaterial.Price = materialAccesory.Price;
        }

        public void Assemble(string color)
        {
            Color = color;
            Type = DecoratedMaterial.Type;
            Price = DecoratedMaterial.Price;
            AccesoryType = DecoratedMaterial.AccesoryType;
        }

        public abstract void SetPrice();

    }
}

