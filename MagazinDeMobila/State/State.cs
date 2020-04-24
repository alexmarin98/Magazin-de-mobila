using MagazinDeMobila.Flyweight;
using MagazinDeMobila.Furniture.FurnitureFactory;

namespace MagazinDeMobila.VendingMachine
{
    public abstract class State
    {
        // public FurnitureSeller FurnitureSeller { get; set; }
        public static VendingMachine1 Machine { get; set; }

        public abstract bool InsertMoney(double value, EMoneyType moneyType);
        public abstract bool RedrawMoney(double value, EMoneyType moneyType);
        public abstract bool BuyProduct(int id, EMoneyType moneyType);
    }
}
