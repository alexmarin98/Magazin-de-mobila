using System;

namespace MagazinDeMobila.VendingMachine
{
    public class HasNoMoneyState : State
    {
        public override bool BuyProduct(int id)
        {
            Console.WriteLine("Your account is empty");
            return false;
        }

        public override bool Dispense()
        {
            Console.WriteLine("Your account is empty");
            return false;
        }

        public override bool InsertMoney(double value)
        {
            Machine.MoneyAmount += value;
            Console.WriteLine($"You just added {value}");
            Machine.SetMachineState(new HasMoneyState());
            return true;
        }

        public override bool RedrawMoney(double value)
        {
            Console.WriteLine("You don't have money to redraw!!!");
            return false;
        }
    }
}
