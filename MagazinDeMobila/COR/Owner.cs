using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.COR
{
    public abstract class Owner
    {
        protected Owner succesor;

        public abstract double GetProductPrise(String productName);

        public void setSuccesor(Owner succesor)
        {
            this.succesor = succesor;
        }

    }
}
