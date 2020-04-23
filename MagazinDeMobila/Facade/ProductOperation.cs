using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinDeMobila.Facade
{
    class ProductOperation
    {
        public List<VMProduct> productList { get; set; }
        public void addProduct(String prodId,double sum)
        {
            int id = 0;
            foreach(VMProduct p in productList)
            {
                if (p.getName() == prodId)
                {
                    p.addProduct();
                    return;
                }
                id = int.Parse(p.getId());
            }
            id++;
            productList.Add(new VMProduct(id, prodId));
        }
        public void removeProduct(String id)
        {
            foreach(VMProduct p in productList)
            {
                if(p.getName()==id)
                {
                    p.removeProduct();
                    return;
                }
            }
        }
        public List<VMProduct> getProductsList()
        {
            return productList;
        }
    }
}
