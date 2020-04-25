using System;

namespace MagazinDeMobila.Facade
{
    public class Transaction
    {
        public SingletonSold SoldOperation { get; set; }

        public Transaction()
        {
            SoldOperation = SingletonSold.getInstance();
        }
        public void SoldProduct(double sum)
        {
            SoldOperation.AddMoney(sum);
        }
        public void GetSoldMoney()
        {
            Console.WriteLine($"You have { SoldOperation.GetSold()} in your account");
        }
        public void RedrawMoney(double sum)
        {
            SoldOperation.RemoveMoney(sum);
        }
    }
}
