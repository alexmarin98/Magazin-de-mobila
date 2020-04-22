using MagazinDeMobila.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Decorator
{
    interface IMaterialAccesory
    {
        EMaterialMixType Type { get; set; }
        EAccesoryType AccesoryType { get; set; }
        string Color { get; set; }
        double Price { get; set; }

        void Assemble(string color);
        void SetPrice();

    }
}
