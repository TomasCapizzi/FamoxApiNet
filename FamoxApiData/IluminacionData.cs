using FamoxApiEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiData
{
    public static class IluminacionData
    {
        public static List<Iluminacion> ListaIluminaciones()
        {
            var db = new FamoxApiContext();
            return db.Iluminaciones.OrderBy(x => x.Id).ToList();
        }
        public static Iluminacion ObtenerIluminacion(int IdIluminacion)
        {
            var db = new FamoxApiContext();
            return db.Iluminaciones.OrderBy(x => x.Id).ToList().Find(a => a.Id == IdIluminacion);
        }
        public static void CrearIluminacion(Iluminacion iluminacion)
        {
            using (var context = new FamoxApiContext())
            {
                context.Iluminaciones.Add(iluminacion);
                context.SaveChanges();
                context.SaveChanges();
            }
        }
        public static void ModificarIluminacion(Iluminacion iluminacion)
        {
            using (var context = new FamoxApiContext())
            {
                var iluminacionEditado = context.Iluminaciones.Where(x => x.Id.Equals(iluminacion.Id)).Single();
                iluminacionEditado.Iluminacion_ = iluminacion.Iluminacion_;
                context.Entry(iluminacionEditado).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void EliminarIluminacion(int IdIluminacion)
        {
            using (var context = new FamoxApiContext())
            {
                var iluminacion = context.Iluminaciones.Where(x => x.Id.Equals(IdIluminacion)).Single();

                context.Remove(iluminacion);
                context.SaveChanges();
            }
        }
    }
}
