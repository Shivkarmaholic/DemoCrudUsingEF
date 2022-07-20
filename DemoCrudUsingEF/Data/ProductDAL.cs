using DemoCrudUsingEF.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoCrudUsingEF.Data
{
    public class ProductDAL
    {
        ApplicationDbContext db;
        public ProductDAL()
        {
            
        }
        public List<Product> GetAllProducts()
        {

            return db.products.ToList();
        }
        public IEnumerable<Product> GetAllProducts1()
        {

            return db.products.ToList();
        }

        public Product GetProductById(int id)
        {
            Product p = db.products.Where(x => x.ID == id).FirstOrDefault();
            return p;
        }

        public int AddProduct(Product p)
        {
            db.products.Add(p);
            int result=db.SaveChanges();
            return result;
        }
        public int UpdateProduct(Product p)
        {
            int result = 0;
            Product prod = db.products.Where(x => x.ID == p.ID).FirstOrDefault();
            if (prod != null)
            {
                prod.Name=p.Name;
                prod.Price = p.Price;
                result = db.SaveChanges();
            }
            return result;

        }
        public int DeleteProduct(int id)
        {
            int result = 0;
            Product prod = db.products.Where(x => x.ID == id).FirstOrDefault();
            if (prod != null)
            {
                db.products.Remove(prod);
                result = db.SaveChanges();
            }
            return result;
        }

    }
}
