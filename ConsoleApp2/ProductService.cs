using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ProductService
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

            SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);

            connection.Open();

            string query = @"SELECT [ProductId]
                  ,[ProductName]
                  ,[Price]
                  ,[DeleteFlag]
              FROM [dbo].[Product]";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                int rowNo = i + 1;
                decimal price = Convert.ToDecimal(row["Price"]);//row["Price"] is object
                Console.WriteLine(rowNo.ToString() + ". " + row["ProductName"] + " ( " + price.ToString("n0") + " )");
            }
        }
        public void Create()
        {
            string query = @"INSERT INTO [dbo].[Product]
           ([ProductName]
           ,[Price]
           ,[DeleteFlag])
     VALUES
           ('Guava'
           ,1500
           ,0)";

            SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query,connection);
            int result = cmd.ExecuteNonQuery();
            connection.Close();

            string message = result > 0 ? "Saving Successful" : "Saving Failed";
            Console.WriteLine(message);

        }
        public void Update()
        {
            string query = @"UPDATE [dbo].[Product]
   SET [ProductName] = 'Grape'
      ,[Price] = 4000
      ,[DeleteFlag] = 0
 WHERE ProductId = 2";
            SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();
            connection.Close();

            string message = result > 0 ? "Update Successful" : "Update Failed";
            Console.WriteLine(message);
        }
        public void Delete()
        {
            string query = @"DELETE FROM [dbo].[Product]
      WHERE ProductId = 6";
            SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);

            connection.Open();
            SqlCommand cmd = new SqlCommand(query,connection );
            int result = cmd.ExecuteNonQuery();
            connection.Close();

            string message = result > 0 ? "Deleted Successfully" : "Delete Failed";
            Console.WriteLine(message);
        }
    }
}
