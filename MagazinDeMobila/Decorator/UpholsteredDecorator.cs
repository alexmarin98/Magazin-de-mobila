using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Decorator
{
    class UpholsteredDecorator : MaterialMixDecorator
    {
        public UpholsteredDecorator(IMaterialAccesory myMaterial) : base(myMaterial)
        {
            this.DecoratedMaterial.AccesoryType = Builder.EAccesoryType.EUpholstered;
            SetPrice();
        }
        public override sealed void SetPrice()
        {
            this.DecoratedMaterial.Price += 1100;
        }
    }
}
