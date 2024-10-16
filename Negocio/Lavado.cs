using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Lavado
    {

        public static List<Datos.traerLavado> traerLavado()
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.traerLavado.ToList();
            }
        }

        public static List<Datos.tarifa_lavado> busqTarLav(string tip_lav, byte tip_cat)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.tarifa_lavado.Where(t => t.tipo_lavado == tip_lav && t.id_Categoria== tip_cat).ToList();
            }
        }

        public static string traerTipLav(short id_tarLav)
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.tarifa_lavado.Where(t => t.id_TarifaL == id_tarLav).Select(t => t.tipo_lavado).First();
            }
        }

        public static string agregar(string tip_lav, decimal precio,byte tip_cat)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.tarifa_lavado tarifaLav = new Datos.tarifa_lavado
                            {
                                tipo_lavado = tip_lav,
                                precio = precio,
                                id_Categoria = tip_cat
                            };
                            db.tarifa_lavado.Add(tarifaLav);
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Tarifa registrada correctamente";
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            return "Error " + ex;
                        }

                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public static string actualizar(short id_tarifa, decimal precio)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.tarifa_lavado tarifaLav = (from q in db.tarifa_lavado
                                                       where
                               q.id_TarifaL == id_tarifa
                                                       select q).First();
                            tarifaLav.precio = precio;
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Tarifa actualizada correctamente";
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            return "Error " + ex;
                        }

                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public static string eliminar(short id_tarifa)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.tarifa_lavado tarifaLav = (from q in db.tarifa_lavado
                                                       where
                               q.id_TarifaL == id_tarifa
                                                       select q).First();
                            db.tarifa_lavado.Remove(tarifaLav);
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Tarifa eliminada correctamente";
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            return "Error " + ex;
                        }

                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

    }
}
