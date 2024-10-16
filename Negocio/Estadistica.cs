using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Estadistica
    {
        public static List<Datos.categoriasMasSolicitadas_Result> categoriasMasSolicitadas()
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.categoriasMasSolicitadas().ToList();
            }
        }

        public static List<Datos.topVehiculosServicios_Result> topVehiculosServicios()
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.topVehiculosServicios().ToList();
            }
        }

        public static List<Datos.ventasGrafica_Result> ventasGraficas(DateTime fecIni,DateTime fecFin)
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.ventasGrafica(fecIni,fecFin).ToList();
            }
        }

        public static List<ObjectParameter> datosInterfazPrincipal()
        {
            List<ObjectParameter> datos = new List<ObjectParameter>();
            datos.Add(new ObjectParameter("xCantDeud", typeof(int)));
            datos.Add(new ObjectParameter("xCantServ", typeof(int)));
            datos.Add(new ObjectParameter("xGastos", typeof(float)));
            datos.Add(new ObjectParameter("xDeudas", typeof(float)));
            datos.Add(new ObjectParameter("xVentas", typeof(float)));
            datos.Add(new ObjectParameter("xCaja", typeof(float)));
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                db.datosInterfazPrincipal(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
                return datos;
            }
        }
    }
}
