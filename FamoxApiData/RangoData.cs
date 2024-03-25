using FamoxApiEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiData
{
    public static class RangoData
    {
        public static List<Rango> ListaRangos()
        {
            var db = new FamoxApiContext();
            return db.Rangos.OrderBy(x => x.Id).ToList();
        }
        public static Rango ObtenerRango(int IdRango)
        {
            var db = new FamoxApiContext();
            return db.Rangos.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdRango);
        }
        public static void CrearRango(Rango rango)
        {
            using (var context = new FamoxApiContext())
            {
                context.Rangos.Add(rango);
                context.SaveChanges();
                context.SaveChanges();
            }
        }
        public static void ModificarRango(Rango rango)
        {
            using (var context = new FamoxApiContext())
            {
                var rangoEditado = context.Rangos.Where(x => x.Id.Equals(rango.Id)).Single();
                rangoEditado.Rango_ = rango.Rango_;
                context.Entry(rangoEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarRango(int IdRango)
        {
            using (var context = new FamoxApiContext())
            {
                var rango = context.Rangos.Where(x => x.Id.Equals(IdRango)).Single();

                context.Remove(rango);
                context.SaveChanges();
            }
        }
    }
}
