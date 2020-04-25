using System;

namespace MagazinDeMobila.COR
{
    public abstract class Owner
    {
        protected Owner succesor;

        public abstract double GetProductPrise(String productName);

        public void SetSuccesor(Owner succesor)
        {
            this.succesor = succesor;
        }
    }
}
