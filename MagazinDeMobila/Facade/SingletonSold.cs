using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Facade
{
    class SingletonSold
    {
        public static SingletonSold instance { get; set; } = null;

        public Sold sold { get; set; }

        public static SingletonSold getInstance()
        {
            if (instance == null)
                instance = new SingletonSold();
            return instance;
        }
        public void addMoney(double sum)
        {
            sold.addMoney(sum);
        }
        public void removeMoney(double sum)
        {
            sold.getMoney(sum);
        }
        public double getSold()
        {
            return sold.getCurrentSold();
        }

    }

}
