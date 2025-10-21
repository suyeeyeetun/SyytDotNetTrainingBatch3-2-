using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyytDotNetTrainingBatch3_2_.Database.AppDbContextModels;

namespace ConsoleApp2
{
    public class ProductCategoryEFCoreService
    {
        public void Read()
        {
            AppDbContext db = new AppDbContext();
            var lst = db.TblProductCategories.ToList();
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i].ProductCategoryId);
                Console.WriteLine(lst[i].ProductCategoryName);

            }
        }

        public void Create()
        {
            AppDbContext db = new AppDbContext();
            var item = new TblProductCategory()
            {
                ProductCategoryCode = "ELEC",
                ProductCategoryName = "Electronics"
            };
            db.TblProductCategories.Add(item);
            int result = db.SaveChanges();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            Console.WriteLine(message);
        }
        public void Update()
        {
            AppDbContext db = new AppDbContext();
            var item = db.TblProductCategories.Where(x=> x.ProductCategoryId==1).FirstOrDefault();
            if (item is null)
            {
                return;
            }
            item.ProductCategoryName = "Updated Electronics";
            int result = db.SaveChanges();
            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            Console.WriteLine(message);
        }
        public void Delete()
        {
            AppDbContext db = new AppDbContext();
            var item = db.Products.FirstOrDefault(x => x.ProductId == 4);
            if (item is null)
            {
                return;
            }
            item.DeleteFlag = true;
            int result = db.SaveChanges();
            string message = result > 0 ? "Successfully Deleted" : "Deleting Failed";
            Console.WriteLine(message);
        }
    }
}
