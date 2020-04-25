using MagazinDeMobila.Facade;
using MagazinDeMobila.Flyweight;
using MagazinDeMobila.Furniture.FurnitureFactory;
using System;

namespace MagazinDeMobila.VendingMachine
{
    public class VendingMachine1
    {
        private int Capacity { get; set; }
        public double MoneyAmount { get; set; }
        public FurnitureSeller FurnitureSeller { get; set; }
        public Cashier Cashier { get; set; }
        public Transaction Transaction { get; set; }
        private State MachineState { get; set; }
        public HasMoneyState HasMoneyState {get;set;}
        public HasNoMoneyState HasNoMoneyState { get; set; }
        public SoldOutState SoldOutState { get; set; }
        public SoldProductState SoldProductState { get; set; }

        public VendingMachine1(FurnitureSeller furnitureSeller,Cashier cashier)
        {
            FurnitureSeller = furnitureSeller;
            Cashier = cashier;
            Capacity = furnitureSeller.OrderedFurniture.Count;
            SetMachineState(new HasNoMoneyState());
            HasMoneyState = new HasMoneyState();
            HasNoMoneyState = new HasNoMoneyState();
            SoldOutState = new SoldOutState();
            SoldProductState = new SoldProductState();
            Transaction = new Transaction();
            
        }
        
        public void UpdateState(EClientOption clientOption, double value,int productId,EMoneyType moneyType)
        {
            switch (clientOption)
            {
                case EClientOption.InsertMoney:
                    {
                        InsertMoney(value,moneyType);
                        break;
                    }
                case EClientOption.RetractMoney:
                    {
                        RedrawMoney(value,moneyType);
                        break;
                    }
                case EClientOption.BuyProduct:
                    {
                        BuyProduct(productId,moneyType);
                        break;
                    }
                case EClientOption.InspectStock:
                    {
                        InspectStok();
                        break;
                    }
                case EClientOption.SeeMoneyAmmount:
                    {
                        SeeMoneyAmmount();
                        break;
                    }
                case EClientOption.Exit:
                    {
                        break;
                    }
            }
        }

        private bool InsertMoney(double value,EMoneyType moneyType)
        {
            return MachineState.InsertMoney(value,moneyType);
        }
        private bool RedrawMoney(double value,EMoneyType moneyType)
        {
            return MachineState.RedrawMoney(value,moneyType);
        }
        private void InspectStok()
        {
            FurnitureSeller.ShowAvaibleProduct();
        }
        private bool BuyProduct(int productId,EMoneyType moneyType)
        {
            return MachineState.BuyProduct(productId,moneyType);
        }

        public void SetMachineState(State state)
        {
            MachineState = state;
        }
        public bool IsEmpty()
        {
            if (Capacity == 0)
                return true;
            return false;
        }
        public void SeeMoneyAmmount()
        {
            Console.WriteLine($"Your current sold is {Cashier.GetTotalCache()}");
        }
    }
}
