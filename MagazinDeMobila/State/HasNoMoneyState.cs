using MagazinDeMobila.Flyweight;
using System;

namespace MagazinDeMobila.VendingMachine
{
    public class HasNoMoneyState : State
    {
        public override bool BuyProduct(int id,EMoneyType moneyType)
        {
            Console.WriteLine("Your account is empty");
            return false;
        }


        public override bool InsertMoney(double value, EMoneyType moneyType)
        {
            Machine.Cashier.CashIn(value, moneyType);
            Console.WriteLine($"You just added {value} to your account");
            Machine.SetMachineState(new SoldProductState());
            return true;
        }

        public override bool RedrawMoney(double value, EMoneyType moneyType)
        {
            Console.WriteLine("You don't have money to redraw! Your account is empty");
            return false;
        }
    }
}
