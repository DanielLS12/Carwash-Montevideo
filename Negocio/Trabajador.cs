using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Trabajador
    {
        public static List<Datos.traerDatosPerfil_Result> traerDatosPerfil(short id_trab)
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.traerDatosPerfil(id_trab).ToList();
            }
        }
        // Esta función traera a todos los trabajadores que estan contratados hasta la fecha

        public static List<Datos.busqTrab_Result> busqTrabajador(string nomApe,string ocup,string telef,string correo,byte tip_pag,bool estado)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.busqTrab(nomApe,ocup,telef,correo,tip_pag,estado).ToList();
            }
        }

        public static decimal montosPorServicio(short id_trab,DateTime fecIni, DateTime fecFin)
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return (decimal)db.montoServicios(id_trab,fecIni,fecFin).FirstOrDefault();
            }
        }

        public static List<Datos.rol> traerOcup()
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.rol.ToList();
            }
        }

        public static string actDatos(short id_trab ,byte id_rol)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            Datos.trabajador trabajador = (from q in db.trabajador
                                                           where
                                                           q.id_Trabajador == id_trab
                                                           select q).First();
                            trabajador.id_rol = id_rol;
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Personal actualizado correctamente";
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

        public static string agregar(short id_per,byte id_rol)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.trabajador trabajador = new Datos.trabajador
                            {
                                id_Persona = id_per,
                                id_rol = id_rol,
                                estado = true
                            };
                            db.trabajador.Add(trabajador);
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Personal registrado correctamente";
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

        public static bool solicitarEstado(short id_trab)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.trabajador.Where(t => t.id_Trabajador == id_trab).Select(t => t.estado).FirstOrDefault();
            }
        }

        public static string actEstado(short id_trab,bool est)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            Datos.trabajador trabajador = (from q in db.trabajador
                                                     where
                                                     q.id_Trabajador == id_trab
                                                     select q).First();
                            trabajador.estado = est;
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return est ? "Personal recontratado correctamente" : "Personal despedido correctamente"; 
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

        public static string actSueldoComision(short id_trab, decimal sueldo, float comision)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            Datos.trabajador trabajador = (from q in db.trabajador
                                                           where
                                                           q.id_Trabajador == id_trab
                                                           select q).First();
                            trabajador.sueldo = sueldo;
                            trabajador.comision = comision;
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Pago realizado correctamente";
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
    }
}
