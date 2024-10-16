using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Vehiculo
    {
        public static List<Datos.categoria> traerCategorias()
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.categoria.ToList();
            }
        }

        public static List<Datos.buscarVehiculo_Result> buscarVehiculo(string placa,string cate)
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.buscarVehiculo(placa, cate).ToList();
            }
        }

        public static byte SeleccionarCat(string placa)
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.vehiculo.Where(v => v.placa == placa).Select(c => c.id_Categoria).FirstOrDefault();
            }
        }

        public static byte tomarIdCat(string nomCate)
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.categoria.Where(v => v.descripcion == nomCate).Select(v => v.id_Categoria).FirstOrDefault();
            }
        }

        public static bool evitarDup(string placa)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                var veh = db.vehiculo.Where(v => v.placa == placa).ToList();
                return veh.Any();
            }
        }

        public static string agregar(byte id_cate,string placa)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.vehiculo vehiculo = new Datos.vehiculo
                            {
                                id_Categoria = id_cate,
                                placa = placa
                            };
                            db.vehiculo.Add(vehiculo);
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Vehiculo registrado correctamente";
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

        public static string actualizar(int id_veh,byte id_Cate,string placa)
        {
            try
            {
                using (Datos.carwashEntities db = new Datos.carwashEntities())
                {
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {

                            Datos.vehiculo vehiculo = (from q in db.vehiculo
                                                       where
                               q.id_Vehiculo == id_veh
                                                       select q).First();
                            vehiculo.id_Categoria = id_Cate;
                            vehiculo.placa = placa;
                            db.SaveChanges();
                            dbContextTransaction.Commit();
                            return "Vehiculo actualizado correctamente";
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
