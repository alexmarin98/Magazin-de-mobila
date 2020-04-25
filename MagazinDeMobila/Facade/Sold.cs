using System;

namespace MagazinDeMobila.Facade
{
    public class Sold
    {
        public double CurrentSold { get; set; }
        public Sold()
        {
        }
        public void AddMoney(double sum)
        {
            CurrentSold += sum;
        }
        public void RemoveMoney(double sum)
        {
            if (CurrentSold > sum)
                CurrentSold -= sum;
            else
                Console.WriteLine("We dont have that kind of money in our current sold");
        }
    }
}
