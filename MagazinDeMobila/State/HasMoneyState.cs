using MagazinDeMobila.Flyweight;
using System;

namespace MagazinDeMobila.VendingMachine
{
    public class HasMoneyState : State
    {
        public override bool BuyProduct(int id,EMoneyType moneyType)
        {
            Console.WriteLine("Choose Buy Product menu and then pick a product from our offer");
            Machine.SetMachineState(new SoldProductState());
            return true;
        }


        public override bool InsertMoney(double value, EMoneyType moneyType)
        {
            Machine.Cashier.CashIn(value, moneyType);
            Console.WriteLine($"You just added {value} to your account");
            Machine.SeeMoneyAmmount();
            Machine.SetMachineState(new SoldProductState());
            return true;
        }

        public override bool RedrawMoney(double value, EMoneyType moneyType)
        {
            if (value > Machine.Cashier.GetTotalCache())
            {
                Console.WriteLine("You can't redraw this sum");
                return false;
            }
            else
            {
                Machine.Cashier.CashOut(value, moneyType);
                Console.WriteLine($"You just redrawn {value} from your account");
                Machine.SeeMoneyAmmount();
                if (Machine.MoneyAmount <= 0)
                {
                    Machine.SetMachineState(new HasNoMoneyState());
                }
                else
                {
                    Machine.SetMachineState(new SoldProductState());
                }
                return true;
            }
        }
    }
}
