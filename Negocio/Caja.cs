using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Caja
    {
        public static List<Datos.cajaIngresos_Result> ListarResIngre(DateTime fecIni, DateTime fecFin)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.cajaIngresos(fecIni, fecFin).ToList();
            }
        }

        public static List<Datos.cajaEgresos_Result> ListarResEgre(DateTime fecIni, DateTime fecFin)
        {
            using (Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return db.cajaEgresos(fecIni, fecFin).ToList();
            }
        }

        public static decimal saldoAnt(DateTime fecha)
        {
            using(Datos.carwashEntities db = new Datos.carwashEntities())
            {
                return (decimal)db.saldoAnt(fecha).FirstOrDefault();
            }
        }
    }
}
