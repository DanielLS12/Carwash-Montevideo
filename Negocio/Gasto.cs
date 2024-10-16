using Datos;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Gasto
    {

        public static List<Datos.buscarEgreso_Result> buscarEgresos(string personal,string desc,DateTime fecIni,
            DateTime fecFin,byte opc)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.buscarEgreso(personal, desc, fecIni, fecFin,opc).ToList();
            }
        }

        public static short seleccionarTrab(int id_TE)
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.trabajador_egreso.Where(te => te.id_TE== id_TE).Select(t => t.id_Trabajador).FirstOrDefault();
            }
        }

        public static string agregar(short id_Trabajador, string descripcion, decimal costo, DateTime fecha_compra)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.trabajador_egreso egreso = new Datos.trabajador_egreso
                            {
                                id_Trabajador = id_Trabajador,
                                descripcion = descripcion,
                                costo = costo,
                                fecha_compra =  fecha_compra
                            };
                            db.trabajador_egreso.Add(egreso);
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Gasto registrado correctamente";
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

        public static string actualizar(int id_TE, short id_Trabajador, string descripcion, decimal costo, DateTime fecha_compra)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.trabajador_egreso egreso = (from q in db.trabajador_egreso
                                                       where
                               q.id_TE == id_TE
                                                       select q).First();
                            
                            egreso.id_Trabajador = id_Trabajador;
                            egreso.descripcion = descripcion;
                            egreso.costo = costo;
                            egreso.fecha_compra = fecha_compra;
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Gasto actualizado correctamente";
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

        public static string eliminar(int id_TE)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.trabajador_egreso egreso = (from q in db.trabajador_egreso
                            where
                                      q.id_TE == id_TE
                                                              select q).First();
                            db.trabajador_egreso.Remove(egreso);
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Costo eliminado correctamente";
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
