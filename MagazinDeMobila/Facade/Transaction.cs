using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Facade
{
    class Transaction
    {
        public SingletonSold soldOperation { get; set; }
        public ProductOperation productOperation { get; set; }

        public Transaction()
        {
            soldOperation = SingletonSold.getInstance();
            productOperation =new ProductOperation();
        }
        public void soldProduct(String id,double sum)
        {
            productOperation.removeProduct(id);
            soldOperation.addMoney(sum);
        }
        public double getSoldMoney()
        {
            return soldOperation.getSold();
        }
        public void addProduct(String id,double sum)
        {
            productOperation.addProduct(id, sum);
            soldOperation.removeMoney(sum);
        }
        public void printProductList()
        {
            for(VMProduct p: productOperation.getProductsList())
            {
                Console.WriteLine(p.getName());
            }
        }
    }
}
