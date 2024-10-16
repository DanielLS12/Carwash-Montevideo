using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class Login
    {
        public static List<Datos.iniciarSesion_Result> verificar(string user, string pass)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.iniciarSesion(user, pass).ToList();
            }
        }

        public static List<Datos.comprobarClave_Result> comprobarClave(short id_user,string pass)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.comprobarClave(id_user, pass).ToList();
            }
        }

        public static string actUser(short id_user,string user)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            Datos.usuario_login usuario = (from q in db.usuario_login
                                                     where
                                                     q.id_UL == id_user
                                                     select q).First();
                            usuario.usuario = user;

                            
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Cuenta Actualizada correctamente";
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

        public static string actAcc(short id_user,string user, string password)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            db.actAcc(id_user, user, password);
                            dbContextTransaction.Commit();
                            return "Cuenta Actualizada correctamente";
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
