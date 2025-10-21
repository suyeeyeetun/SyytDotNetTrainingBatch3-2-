using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class AppDbContext1:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "Batch3MiniPOS",
                UserID = "sa",
                Password = "sasa@123",
                TrustServerCertificate = true
            };
            optionsBuilder.UseSqlServer(sqlConnectionStringBuilder.ConnectionString);
        }
        public DbSet<Tbl_Product> Products { get; set; }

    }
    [Table("Product")]
    public class Tbl_Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public bool DeleteFlag { get; set; }

    }
}
