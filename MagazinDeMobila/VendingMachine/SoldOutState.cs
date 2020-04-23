using System;

namespace MagazinDeMobila.VendingMachine
{
    public class SoldOutState : State
    {
        public override bool BuyProduct(int id)
        {
            Console.WriteLine("We don't have products in store at this time...Sorry for the incovenience!!");
            return false;
        }

        public override bool Dispense()
        {
            Console.WriteLine("We don't have products in store at this time...Sorry for the incovenience!!");
            return false;
        }

        public override bool InsertMoney(double value)
        {
            Console.WriteLine("We don't have products in store at this time...Sorry for the incovenience!!");
            return false;
        }

        public override bool RedrawMoney(double value)
        {
            Console.WriteLine("We don't have products in store at this time...Sorry for the incovenience!!");
            return false;
        }
    }
}
