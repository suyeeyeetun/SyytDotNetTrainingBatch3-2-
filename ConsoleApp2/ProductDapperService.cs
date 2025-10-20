using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ProductDapperService
    {
        SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "Batch3MiniPOS",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };
        public void Read()
        {
            using(IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                db.Open();
                string query = @"SELECT [ProductId]
                  ,[ProductName]
                  ,[Price]
                  ,[DeleteFlag]
              FROM [dbo].[Product]";
                List<ProductDto> lst = db.Query<ProductDto>(query).ToList();
                for(int i = 0; i < lst.Count; i++)
                {
                    Console.WriteLine(lst[i].ProductId);
                    Console.WriteLine(lst[i].ProductName);
                }


            }
        }
        public void Create()
        {
            
            using(IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                db.Open();
                string query = @"INSERT INTO [dbo].[Product]
           ([ProductName]
           ,[Price]
           ,[DeleteFlag])
     VALUES
           ('Avocado'
           ,1500
           ,0)";
                int result = db.Execute(query);
                string message = result > 0 ? "Successfully saved" : "Saving Failed";
                Console.WriteLine(message);
            }
        }
        public void Update()
        {
            using (IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                db.Open();
                string query = @"UPDATE [dbo].[Product]
   SET [DeleteFlag] = 0
 WHERE ProductId = 1"; ;
                int result = db.Execute(query);
                string message = result > 0 ? "Successfully updated" : "Updating Failed";
                Console.WriteLine(message);
            }
        }
        public void Delete()
        {
            using(IDbConnection db = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                db.Open();
                string query = @"DELETE FROM [dbo].[Product]
      WHERE ProductId = 5";
                int result = db.Execute(query);
                string message = result > 0 ? "Successfully Deleted" : "Deleting Failed";
                Console.WriteLine(message);
            }
        }
        public class ProductDto
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
        }
    }
}
