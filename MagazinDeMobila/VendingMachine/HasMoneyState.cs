using MagazinDeMobila.Furniture;
using System;

namespace MagazinDeMobila.VendingMachine
{
    public class HasMoneyState : State
    {
        public override bool BuyProduct(int id)
        {
            Console.WriteLine("You can buy your product");
            Machine.SetMachineState(new SoldProductState());
            return true;

        }

        public override bool Dispense()
        {
            Console.WriteLine("Nothing to dispense right now");
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
            if(value > Machine.MoneyAmount)
            {
                Console.WriteLine("You can't redraw this sum");
            }
            else
            {
                Machine.MoneyAmount -= value;
                if (Machine.MoneyAmount <= 0)
                {
                    Machine.SetMachineState(new HasNoMoneyState());
                }
            }
            return true;
        }
    }
}
