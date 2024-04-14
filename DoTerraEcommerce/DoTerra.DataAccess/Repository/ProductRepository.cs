using DoTerra.DataAccess.Data;
using DoTerra.DataAccess.Repository.IRepository;
using DoTerra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoTerra.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.ScientificName = obj.ScientificName;
                objFromDb.COD = obj.COD;
                objFromDb.Size = obj.Size;
                objFromDb.Price = obj.Price;
                objFromDb.Size = obj.Size;
                objFromDb.Description = obj.Description;
                objFromDb.Benefits = obj.Benefits;
                objFromDb.AromaticDescription = obj.AromaticDescription;
                objFromDb.Ingredients = obj.Ingredients;
                objFromDb.Uses = obj.Uses;
                objFromDb.HowToUse = obj.HowToUse;
                objFromDb.Precautions = obj.Precautions;
                objFromDb.CategoryId = obj.CategoryId;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
