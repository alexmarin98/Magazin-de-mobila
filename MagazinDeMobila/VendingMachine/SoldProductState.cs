using MagazinDeMobila.Furniture;
using System;

namespace MagazinDeMobila.VendingMachine
{
    public class SoldProductState : State
    {
        public override bool BuyProduct(int id)
        {

           // Furniture furniture = new Furniture();
            Furniture1 furniture;
            if (Machine.FurnitureSeller.OrderedFurniture.ContainsKey(id))
            {
                furniture = Machine.FurnitureSeller.OrderedFurniture[id];
                if (Machine.MoneyAmount > furniture.MaterialAccesory.Price)
                {
                    Machine.FurnitureSeller.SellFurniture(id);
                    Machine.MoneyAmount -= furniture.MaterialAccesory.Price;
                }
                else
                {
                    Console.WriteLine("You don't have enough money");
                }
            }
            else
            {
                Console.WriteLine("This product is not avaible in our stock");
            }
            if(Machine.MoneyAmount <= 0)
            {
                Machine.SetMachineState(new HasNoMoneyState());
            }
            if (Machine.IsEmpty())
            {
                Machine.SetMachineState(new SoldOutState());
            }
            return true;
        }

        public override bool Dispense()
        {
            throw new System.NotImplementedException();
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
            if (value > Machine.MoneyAmount)
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
