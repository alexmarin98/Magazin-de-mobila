using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Builder
{
    interface IMaterialBuilder
    {
        double GetPrice(EMaterialMixType materialType);

        void SetPrice(double price);

        void SetAmount(double amount);

        void SetMaterialMixType(EMaterialMixType type);

        MaterialMix GetMaterialMix();
    }
}
