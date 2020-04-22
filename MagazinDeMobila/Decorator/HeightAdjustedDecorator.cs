using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Decorator
{
    class HeightAdjustedDecorator : MaterialMixDecorator
    {
        public HeightAdjustedDecorator(IMaterialAccesory myMaterial) : base(myMaterial)
        {
            this.DecoratedMaterial.AccesoryType = Builder.EAccesoryType.EHeightAdjusted;
            SetPrice();
        }
        public override sealed void SetPrice()
        {
            this.DecoratedMaterial.Price += 1100;
        }
    }
}
