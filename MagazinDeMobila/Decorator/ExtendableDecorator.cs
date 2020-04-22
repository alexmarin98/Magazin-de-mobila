using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Decorator
{
    class ExtendableDecorator : MaterialMixDecorator
    {
        public ExtendableDecorator(IMaterialAccesory myMaterial) : base(myMaterial)
        {
            this.DecoratedMaterial.AccesoryType = Builder.EAccesoryType.EExtendable;
            SetPrice();
        }
        public override sealed void SetPrice()
        {
            this.DecoratedMaterial.Price += 1100;
        }
    }
}
