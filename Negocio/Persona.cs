using Datos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Persona
    {

        public static string traerNombreApellido(short id_trab)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.traerNombreApellido(id_trab).First();
            }
        }

        public static short traerId(string nombreApellido)
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                short id_Persona = db.persona.Where(p => p.nombres + " " + p.apellido_paterno + " " + p.apellido_materno == nombreApellido)
                    .Select(p => p.id_Persona).FirstOrDefault();
                return db.trabajador.Where(t => t.id_Persona == id_Persona).Select(t => t.id_Trabajador).FirstOrDefault();
            }
        }

        public static List<Datos.persona> listarPersonal()
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.persona.ToList();
            }
        }

        public static string editarPerfil(short id_per,string nom,string ape_pat,string ape_mat
            ,string telef, string correo)
        {
            try
            {
                using(Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using(var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            Datos.persona persona = (from q in db.persona where
                                                     q.id_Persona == id_per
                                                     select q).First();
                            
                            persona.nombres = nom;
                            persona.apellido_materno = ape_mat;
                            persona.apellido_paterno = ape_pat;
                            persona.correo = correo;
                            persona.telefono = telef;
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Perfil Actualizado correctamente";
                        }
                        catch(Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            return "Error " + ex;
                        }

                    }
                }
            }catch(Exception ex) { throw ex; }
        }

        public static short agregar(string nombres, string apePat, string apeMat, string telef, string correo)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.persona persona = new Datos.persona
                            {
                                nombres = nombres,
                                apellido_paterno = apePat,
                                apellido_materno = apeMat,
                                telefono = telef,
                                correo = correo
                            };
                            db.persona.Add(persona);
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return db.persona.OrderByDescending(p => p.id_Persona).Select(p => p.id_Persona).First();
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
    }
}
