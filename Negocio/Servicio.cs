using Datos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Servicio
    {
        public static List<Datos.busqServicio_Result> listarServicios(
            string placa,
            byte id_cat,
            DateTime fecIni,
            DateTime fecFin,
            string trab,
            byte opc,
            byte opcDscto,
            bool estPago 
        )
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.busqServicio(placa,id_cat,fecIni,fecFin,trab,opc,opcDscto,estPago).ToList();
            }
        }
        

        public static string agregar(short id_trab,int id_veh, short? id_tarif,decimal precLav,decimal precAdic,decimal dscto, 
            bool estPago,DateTime? fecha_pago,TimeSpan hora_salida)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.servicio servicio = new Datos.servicio
                            {
                                id_Trabajador = id_trab,
                                id_Vehiculo = id_veh,
                                id_TarifaL = id_tarif,
                                precioLav = precLav,
                                preciosAdic = precAdic,
                                estado_pago = estPago,
                                descuento = dscto,
                                fecha_pedido = DateTime.Now,
                                fecha_pago = fecha_pago,
                                hora_salida = hora_salida
                            };
                            db.servicio.Add(servicio);
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Servicio registrado correctamente";
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

        public static string actualizar(int id_Serv,short id_trab, int id_veh, short? id_tarif,decimal precLav,
            decimal precAdic,decimal dscto,TimeSpan hora_salida,bool estado_servicio)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.servicio servicio = (from q in db.servicio
                                                              where
                                      q.id_Servicio == id_Serv
                                                              select q).First();

                            servicio.id_Trabajador = id_trab;
                            servicio.id_Vehiculo = id_veh;
                            servicio.id_TarifaL = id_tarif;
                            servicio.precioLav = precLav;
                            servicio.preciosAdic = precAdic;
                            servicio.descuento = dscto;
                            servicio.hora_salida = hora_salida;
                            servicio.estado_servicio = estado_servicio;
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Servicio actualizado correctamente";
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            return "Error " + ex.Message;
                        }

                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public static string eliminar(int id_Serv)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.servicio servicio = (from q in db.servicio
                                                       where
                               q.id_Servicio == id_Serv
                                                       select q).First();
                            db.servicio.Remove(servicio);
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Servicio eliminado correctamente";
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            return "Error " + ex.Message;
                        }

                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public static void actEstado(int id_serv, bool est_pago,DateTime? fec_pago)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            Datos.servicio servicio = (from q in db.servicio
                                                           where
                                                           q.id_Servicio == id_serv
                                                           select q).First();
                            servicio.fecha_pago = fec_pago;
                            servicio.estado_pago = est_pago;
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

        public static bool seleccionarEstado(int id_serv)
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.servicio.Where(s => s.id_Servicio == id_serv).Select(s => s.estado_pago).FirstOrDefault();
            }
        }

        public static short seleccionarTrab(int id_serv)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.servicio.Where(te => te.id_Servicio == id_serv).Select(t => t.id_Trabajador).FirstOrDefault();
            }
        }

        public static short? seleccionarIdTarLav(int id_serv)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.servicio.Where(te => te.id_Servicio == id_serv).Select(t => t.id_TarifaL).FirstOrDefault();
            }
        }

        public static decimal tomarDscto(int id_serv)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.servicio.Where(te => te.id_Servicio == id_serv).Select(t => t.descuento).First();
            }
        }

        public static int traerUltIdServ()
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.servicio.OrderByDescending(s => s.id_Servicio).Select(s => s.id_Servicio).First();
            }
        }

        public static bool estado_servicio(int id_serv)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.servicio.Where(te => te.id_Servicio == id_serv).Select(t => t.estado_servicio).First();
            }
        }
    }
}
