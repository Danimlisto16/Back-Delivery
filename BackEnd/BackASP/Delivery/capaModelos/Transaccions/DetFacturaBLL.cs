using capaModelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaModelos.Modelos;
using System.Data.Entity.Migrations;

namespace capaModelos.Transaccions
{
    public class DetFacturaBLL
    {
        public static void Create(DETALLE_FACTURA df)
        {
            using (DeliveryEntidades db = new DeliveryEntidades())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.DETALLE_FACTURA.Add(df);
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("No se ha podido crear el detalle de factura" + ex.Message);
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static DETALLE_FACTURA Get(int? id)
        {
            using (DeliveryEntidades db = new DeliveryEntidades())
            {
                try
                {
                    return db.DETALLE_FACTURA.Find(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No se ha podido retornar el detalle de factura " + ex.Message);
                    throw ex;
                }
            }
        }

        public static void Update(DETALLE_FACTURA df)
        {
            using (DeliveryEntidades db = new DeliveryEntidades())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.DETALLE_FACTURA.Attach(df);
                        db.Entry(df).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("No se ha podido actualizar  la factura " + ex.Message);
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
                        DETALLE_FACTURA df = db.DETALLE_FACTURA.Find(id);
                        db.Entry(df).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("No se ha podido eliminar el detalle de factura " + ex.Message);
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static List<DETALLE_FACTURA> List()
        {
            using (DeliveryEntidades db = new DeliveryEntidades())
            {
                try
                {
                    return db.DETALLE_FACTURA.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No se ha podido retornar la lista de detalles de factura " + ex.Message);
                    throw ex;
                }
            }

        }
    }
}
