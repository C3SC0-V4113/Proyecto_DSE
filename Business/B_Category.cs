using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }

        public static CategoryEntity CategoryById(string id)
        {
            using(var db=new InventaryContext())
            {
                return db.Categories.ToList().LastOrDefault(c => c.CategoryId == id);
            }
        }

        public static void CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext()) 
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity oCategory)
        {
            using(var db = new InventaryContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }

        public static void DeleteCategory(CategoryEntity oCategory)
        {
            using(var db=new InventaryContext())
            {
                db.Categories.Remove(oCategory);
                db.SaveChanges();
            }
        }
    }
}
