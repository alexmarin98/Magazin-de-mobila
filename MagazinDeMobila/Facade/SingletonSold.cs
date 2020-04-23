using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Facade
{
    class SingletonSold
    {
        public static SingletonSold Instance { get; set; } = null;

        public Sold Sold { get; set; }

        public static SingletonSold getInstance()
        {
            if (Instance == null)
                Instance = new SingletonSold();
            return Instance;
        }
        public void addMoney(double sum)
        {
            Sold.AddMoney(sum);
        }
        public void removeMoney(double sum)
        {
            Sold.RemoveMoney(sum);
        }
        public double GetSold()
        {
            return Sold.CurrentSold;
        }

    }

}
