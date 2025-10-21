using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //private readonly AppDbContext _db;
    public class ProductEFCoreService
    {
        //private readonly AppDbContext db;
        //public ProductEFCoreService()
        //{
        //    db = new AppDbContext();
        //}
        public void Read()
        {
            AppDbContext1 db = new AppDbContext1();
            var lst = db.Products.ToList();
            for(int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i].ProductId);
                Console.WriteLine(lst[i].ProductName);

            }
        }
        public void Create()
        {
            AppDbContext1 db = new AppDbContext1();
            var item = new Tbl_Product()
            {
                ProductName = "Orange",
                Price = 800,
                DeleteFlag = false
            };
            db.Products.Add(item);
            int result = db.SaveChanges();
            string message = result > 0 ? "Successfully saved" : "Saving Failed";
            Console.WriteLine(message);
        }
        public void Update()
        {
            AppDbContext1 db = new AppDbContext1();
            var item = db.Products.Where(x => x.ProductId > 7).ToList();
            //var item = db.Products.Where(x => x.ProductId > 7).FirstOrDefault();

            //if (item is null)
            //{
            //    return;
            //}
            //item.ProductName = "Lemon";
            //item.Price = 500;
            //int result = db.SaveChanges();
            //string message = result > 0 ? "Successfully updated" : "Updating Failed";
            //Console.WriteLine(message);
            for (int i = 0; i < item.Count; i++)
            {
                Console.WriteLine(item[i].ProductId);
                Console.WriteLine(item[i].ProductName);

            }
        }
        public void Delete()
        {
            AppDbContext1 db = new AppDbContext1();
            var item = db.Products.FirstOrDefault(x => x.ProductId == 4);
            item.DeleteFlag = true;
            int result = db.SaveChanges();
            string message = result > 0 ? "Successfully Deleted" : "Deleting Failed";
            Console.WriteLine(message);
        }
    }
}
