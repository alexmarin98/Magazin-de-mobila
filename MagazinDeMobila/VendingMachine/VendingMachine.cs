using System;
using MagazinDeMobila.Furniture.FurnitureFactory;

namespace MagazinDeMobila.VendingMachine
{
    public class VendingMachine
    {
        private int Capacity { get; set; }
        public double MoneyAmount { get; set; }
        public FurnitureSeller FurnitureSeller { get; set; }
        private State MachineState { get; set; }
        public HasMoneyState HasMoneyState {get;set;}
        public HasNoMoneyState HasNoMoneyState { get; set; }
        public SoldOutState SoldOutState { get; set; }
        public SoldProductState SoldProductState { get; set; }

        public VendingMachine(FurnitureSeller furnitureSeller)
        {
            FurnitureSeller = furnitureSeller;
            Capacity = furnitureSeller.OrderedFurniture.Count;
            HasMoneyState = new HasMoneyState();
            HasNoMoneyState = new HasNoMoneyState();
            SoldOutState = new SoldOutState();
            SoldProductState = new SoldProductState();
            
        }
        
        public void UpdateState(EClientOption clientOption, double value,int productId)
        {
            switch (clientOption)
            {
                case EClientOption.InsertMoney:
                    {
                        InsertMoney(value);
                        break;
                    }
                case EClientOption.RetractMoney:
                    {
                        RedrawMoney(value);
                        break;
                    }
                case EClientOption.BuyProduct:
                    {
                        BuyProduct(productId);
                        break;
                    }
                case EClientOption.InspectStock:
                    {
                        InspectStok();
                        break;
                    }
                case EClientOption.Exit:
                    {
                        break;
                    }
            }
        }

        private bool InsertMoney(double value)
        {
            return MachineState.InsertMoney(value);
        }
        private bool RedrawMoney(double value)
        {
            return MachineState.RedrawMoney(value);
        }
        private void InspectStok()
        {
            FurnitureSeller.ShowAvaibleProduct();
        }
        private bool BuyProduct(int productId)
        {
            MachineState.BuyProduct(productId);
            return MachineState.Dispense();
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
        public int SellProduct()
        {
            return Capacity--;
        }
    }
}
