using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaModelos.Modelos;

namespace capaModelos.Transaccions
{
    public class ProductosBLL
    {
        public static void Create(PRODUCTO p)
        {
            using (DeliveryEntidades db = new DeliveryEntidades())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.PRODUCTO.Add(p);
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("No se ha podido crear el producto " + ex.Message);
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static PRODUCTO Get(int? id)
        {
            using (DeliveryEntidades db = new DeliveryEntidades())
            {
                try
                {
                    return db.PRODUCTO.Find(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No se ha podido retornar el producto " + ex.Message);
                    throw ex;
                }
            }
        }

        public static void Update(PRODUCTO p)
        {
            using (DeliveryEntidades db = new DeliveryEntidades())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.PRODUCTO.Attach(p);
                        db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("No se ha podido actualizar  el producto " + ex.Message);
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void Delete(int? id)
        {
            using (DeliveryEntidades db = new DeliveryEntidades())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        PRODUCTO p = db.PRODUCTO.Find(id);
                        db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("No se ha podido eliminar el producto " + ex.Message);
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static List<PRODUCTO> List()
        {
            using (DeliveryEntidades db = new DeliveryEntidades())
            {
                try
                {
                    return db.PRODUCTO.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No se ha podido retornar la lista de productos " + ex.Message);
                    throw ex;
                }
            }

        }
    }
}
