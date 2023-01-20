using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQL_Database : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){name = "xbox", price = 500},
             new Product(){name = "pc", price = 1500},
              new Product(){name = "ps4", price = 250},
               new Product(){name = "ps5", price = 500}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading Data from SQL Data Access");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("Im saving Data from a SQL Data Access");
        }
    }
}
