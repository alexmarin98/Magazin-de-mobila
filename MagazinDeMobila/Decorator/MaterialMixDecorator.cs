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
            this.DecoratedMaterial = new MaterialMix();
            this.DecoratedMaterial.Type = materialAccesory.Type;
            this.DecoratedMaterial.AccesoryType = materialAccesory.AccesoryType;
            this.DecoratedMaterial.Color = materialAccesory.Color;
            this.DecoratedMaterial.Price = materialAccesory.Price;
        }

        public void Assemble(string color)
        {
            this.Color = color;
            this.Type = DecoratedMaterial.Type;
            this.Price = DecoratedMaterial.Price;
            this.AccesoryType = DecoratedMaterial.AccesoryType;
        }

        public abstract void SetPrice();

    }
}

