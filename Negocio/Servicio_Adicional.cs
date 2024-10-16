using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Servicio_Adicional
    {

        public static List<Datos.servicio_adicional> traerServAdic(int id_serv)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.servicio_adicional.Where(sa => sa.id_Servicio.Equals(id_serv)).ToList();
            }
        }

        public static void elimId_SA(int id_serv)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            var servicios_adicionales = db.servicio_adicional.Where(sa => sa.id_Servicio.Equals(id_serv)).ToList();
                            foreach(var sa in servicios_adicionales)
                            {
                                db.servicio_adicional.Remove(sa);
                            }
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            throw ex;
                        }

                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public static string agregar(int id_Serv, short id_TA, decimal precAct)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.servicio_adicional servicio_Adicional = new Datos.servicio_adicional
                            {
                                id_Servicio = id_Serv,
                                id_TA = id_TA,
                                precioAct = precAct
                            };
                            db.servicio_adicional.Add(servicio_Adicional);
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Servicio Adicional registrado correctamente";
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            return "Error: " + ex.Message;
                        }

                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public static string actualizar(int id_SA,int id_Serv, short id_TA, decimal precAct)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.servicio_adicional servicio_Adicional = (from q in db.servicio_adicional
                                                       where
                               q.id_SA == id_SA
                                                       select q).First();

                            servicio_Adicional.id_Servicio = id_Serv;
                            servicio_Adicional.id_TA = id_TA;
                            servicio_Adicional.precioAct = precAct;

                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Servicio Adicional actualizado correctamente";
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

        public static string eliminar(int id_SA)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.servicio_adicional servicio_Adicional = (from q in db.servicio_adicional
                                                       where
                               q.id_Servicio == id_SA
                                                       select q).First();
                            db.servicio_adicional.Remove(servicio_Adicional);
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Servicio Adicional eliminado correctamente";
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
