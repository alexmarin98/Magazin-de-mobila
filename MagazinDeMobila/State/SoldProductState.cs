using MagazinDeMobila.Flyweight;
using MagazinDeMobila.Furniture;
using System;

namespace MagazinDeMobila.VendingMachine
{
    public class SoldProductState : State
    {
        public override bool BuyProduct(int id,EMoneyType moneyType)
        {
            Furniture1 furniture;
            if (Machine.FurnitureSeller.OrderedFurniture.ContainsKey(id))
            {
                furniture = Machine.FurnitureSeller.OrderedFurniture[id];
                if (/*Machine.MoneyAmount >= furniture.MaterialAccesory.Price*/Machine.Cashier.GetTotalCache()> furniture.MaterialAccesory.Price)
                {
                    Machine.FurnitureSeller.SellFurniture(id);
                   // Machine.MoneyAmount -= furniture.MaterialAccesory.Price;
                    Machine.Cashier.CashOut(furniture.MaterialAccesory.Price, moneyType);
                    Console.WriteLine("The product will be delivered soon");
                    Machine.SeeMoneyAmmount();
                }
                else
                {
                    Console.WriteLine("You don't have enough money");
                    return false;
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


        public override bool InsertMoney(double value,EMoneyType moneyType)
        {
            Machine.MoneyAmount += value;
            Console.WriteLine($"You just added {value} to your account");
            Machine.SeeMoneyAmmount();
            //Machine.SetMachineState(new HasMoneyState());
            return true;
        }

        public override bool RedrawMoney(double value, EMoneyType moneyType)
        {
            if (value > Machine.MoneyAmount)
            {
                Console.WriteLine("You can't redraw this sum");
            }
            else
            {
                //Machine.MoneyAmount -= value;
                Machine.Cashier.CashOut(value, moneyType);
                Console.WriteLine($"You just redrawn {value} from your account");
                Machine.SeeMoneyAmmount();
                if (Machine.MoneyAmount <= 0)
                {
                    Machine.SetMachineState(new HasNoMoneyState());
                }
            }
            return true;
        }
    }
}