using MagazinDeMobila.Furniture.FurnitureFactory;

namespace MagazinDeMobila.COR
{
    public class Seller : Owner
    {

        FurnitureSeller StoreProduct { get; set; }


        public Seller(FurnitureSeller storeProduct)
        {
            this.StoreProduct = storeProduct;
        }


        public override double GetProductPrise(string productName)
        {
            double price = StoreProduct.ExistProduct(productName);

            if (price != -1)
            {
                return price;
            }
            if (this.succesor != null)
                return succesor.GetProductPrise(productName);
            return -1;
        }

    }
}