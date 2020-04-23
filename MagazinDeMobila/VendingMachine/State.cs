using MagazinDeMobila.Furniture.FurnitureFactory;

namespace MagazinDeMobila.VendingMachine
{
    public abstract class State
    {
        public FurnitureSeller furnitureSeller { get; set; }
        public static VendingMachine Machine { get; set; }

        public abstract bool InsertMoney(double value);
        public abstract bool RedrawMoney(double value);
        public abstract bool BuyProduct(int id);
        public abstract bool Dispense();

    }
}
