using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;


namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
            IDbConnection conn = new MySqlConnection(connString);
            //DEPOS TIME
            DapperDepartmentRepository repo = new DapperDepartmentRepository(conn);
            Console.WriteLine("Hello user, here are the current departments:");
            var depos = repo.GetAllDepartments();
            foreach (var depo in depos)
            {
                Console.WriteLine($"ID: {depo.DepartmentID} Name: {depo.Name}\n");
            }

            //Product Time
            DapperProductRepository prodRepo = new DapperProductRepository(conn);
            Console.WriteLine("Hello user, here are the current departments:");
            var products = prodRepo.GetAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ProductID} Name: {product.Name}\n");
            }
        }
    }
}
