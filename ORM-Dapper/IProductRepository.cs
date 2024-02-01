using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    internal interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        void InsertProduct(string name, double price, int categoryID, int onSale, int stockLevel);
    }
}
