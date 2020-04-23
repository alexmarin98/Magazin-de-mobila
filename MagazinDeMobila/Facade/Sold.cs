using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Facade
{
    class Sold
    {
        public double CurrentSold { get; set; }
        public Sold(double currentSold)
        {
           // CurrentSold += currentSold;
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
        //public double getSold()
        //{
        //    return CurrentSold;
        //}
    }
}
