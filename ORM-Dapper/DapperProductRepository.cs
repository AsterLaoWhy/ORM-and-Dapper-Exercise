using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ORM_Dapper
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        public DapperProductRepository(IDbConnection connection)
        {
            //Nikki Minaj Constructor
            _connection = connection;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            var products = _connection.Query<Product>("SELECT * FROM products");

            return products;
        }

        public void InsertProduct(string name, double price, int categoryID, int onSale, int stockLevel)
        {
            _connection.Execute("INSERT INTO PRODUCTS (Name) VALUES (@productName);",
            new { productName = name });
        }
    }
}
