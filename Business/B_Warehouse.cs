using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Warehouse
    {
        public static List<WarehouseEntity> WherehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }        

        public static void CreateWherehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }

        public static WarehouseEntity WarehouseById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList().LastOrDefault(w => w.WarehouseId == id);
            }
        }

        public static void UpdateWherehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }

        public static void DeleteWarehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Remove(oWarehouse);
                db.SaveChanges();
            }
        }
    }
}
